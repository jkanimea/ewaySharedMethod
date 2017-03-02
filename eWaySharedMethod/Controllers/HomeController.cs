using eWAY.Rapid;
using eWAY.Rapid.Enums;
using eWAY.Rapid.Models;
using eWAY.Rapid.Internals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Internal = eWAY.Rapid.Internals.Models;


namespace eWaySharedMethod.Controllers
{
    public class HomeController : Controller
    {
        string apiKey = "60CF3Cm6bBz1yK6UfTzli4qkCiRm/KcrTQ7YIDOBcPYjcX6xzZmF8bLbG7jmGrhS2tTuHr"; //"60CF3Ce97nRS1Z1Wp5m9kMmzHHEh8Rkuj31QCtVxjPWGYA9FymyqsK0Enm1P6mHJf0THbR";
        string password = "QFR5S4em";
        string rapidEndpoint = "Sandbox";

         public ActionResult Index()
        {
            return View();  
        }

        public ActionResult TokenNoPayment()
        {
            IRapidClient ewayClient = RapidClientFactory.NewRapidClient(apiKey, password, rapidEndpoint);

            Customer customer = new Customer()
             {
                 Title = "Ms.",
                 FirstName = "Jane",
                 LastName = "Smith",
                 Address = new Address()
                 {
                     Country = "nz"
                 },
                 CompanyName = "SKIDS HO[DisableForTesting]",
                 Url = "http://localhost:53738",
                 RedirectURL = "http://localhost:53738/Home/Ewayresponse"

             };

           CreateCustomerResponse Customerresponse = ewayClient.Create(PaymentMethod.ResponsiveShared, customer);

          if (Customerresponse.Errors != null)
            {
                foreach (string errorCode in Customerresponse.Errors)
                {
                    Console.WriteLine("Error Message: " + RapidClientFactory.UserDisplayMessage(errorCode, "EN"));
                }
            }

          return Redirect(Customerresponse.SharedPaymentUrl);
        }


        public ActionResult TokenWithPayment()
        {
            IRapidClient ewayClient = RapidClientFactory.NewRapidClient(apiKey, password, rapidEndpoint);

            Customer customer = new Customer()
            {
                Title = "Ms.",
                FirstName = "Jane",
                LastName = "Smith",
                Address = new Address()
                {
                    Country = "nz"
                },
                CompanyName = "SKIDS HO[DisableForTesting]",
                Url = "http://localhost:53738",
                RedirectURL = "http://localhost:53738/Home/Ewayresponse"

            };


            Transaction transaction = new Transaction()
            {
                Customer = customer,
                PaymentDetails = new PaymentDetails()
                 {
                     TotalAmount = 10000,
                     InvoiceDescription = "Parent subscription",
                     InvoiceNumber = "4536",

                 },
                RedirectURL = "http://localhost:53738/Home/Ewayresponse",
                TransactionType = TransactionTypes.Purchase,
                SaveCustomer = true,
            }; 

               CreateTransactionResponse transactionresponse = ewayClient.Create(PaymentMethod.ResponsiveShared, transaction);

               if (transactionresponse.Errors != null)
                 {
                foreach (string errorCode in transactionresponse.Errors)
                 {
                    Console.WriteLine("Error Message: " + RapidClientFactory.UserDisplayMessage(errorCode, "EN"));
                    }
                  }

               return Redirect(transactionresponse.SharedPaymentUrl);
        }



        private object CreateRapidApiClient()
        {
            throw new NotImplementedException();
        }

        public ActionResult Ewayresponse(String AccessCode)
        {
            IRapidClient ewayClient = RapidClientFactory.NewRapidClient(apiKey, password, rapidEndpoint);

            QueryTransactionResponse response = ewayClient.QueryTransaction(AccessCode);
            string tokenid = response.Transaction.Customer.TokenCustomerID;

            //save the tokenid and response for the view
            ViewBag.token = tokenid;
            ViewBag.response = response;


            if ((bool)response.TransactionStatus.Status)
            {
                Console.WriteLine("Payment successful! ID: " + response.TransactionStatus.TransactionID);
                //Get organisation name to save in CssPaymentSetup 
                QueryCustomerResponse customerresponse = ewayClient.QueryCustomer(long.Parse(tokenid));

                string[] orgN = customerresponse.Customers.Select(c => c.CompanyName).ToArray();
                string orgname = orgN[0];

                int orgid;
                using (AimyEntities db = new AimyEntities())
                {
                    int[] orgids = db.Orgs.Where(o => o.Name == orgname).Select(o => o.Id).ToArray();
                    orgid = orgids[0];
                }
                //Get the credit card details to save in CssPaymentSetup
                string[] cd = customerresponse.Customers.Select(cc => cc.CardDetails).Select(d => d.Number).ToArray();
                string creditcard = cd[0];

                using (AimyEntities db = new AimyEntities())
                {
                    CssPaymentSetup savetoken = new CssPaymentSetup();
                    savetoken.CustomerId = tokenid;
                    savetoken.IsActive = true;
                    savetoken.MaskedCardNumber = creditcard;
                    savetoken.OrgId = orgid;
                    savetoken.CreatedOn = DateTime.Today;
                    //CreatedBy is the userid that can be retrieve from session current user -- for now we assign 3694                                             
                    savetoken.CreatedBy = 3694;

                    db.CssPaymentSetups.Add(savetoken);
                    db.SaveChanges();

                };
                
            }
            else if (tokenid == null)
            {
                string[] errorCodes = response.TransactionStatus.ProcessingDetails.ResponseMessage.Split(new[] { ", " }, StringSplitOptions.None);

                foreach (string errorCode in errorCodes)
                {
                    Console.WriteLine("Response Message: "
                      + RapidClientFactory.UserDisplayMessage(errorCode, "EN"));
                }
            }
                
            return View();
        }

        public CreateCustomerResponse Updatetokendetails(string tokenid)
        {

            IRapidClient ewayClient = RapidClientFactory.NewRapidClient(apiKey, password, rapidEndpoint);

            Customer customer = new Customer()
            {
                Title = "Mr.",
                FirstName = "Tom",
                LastName = "Jones",
                Address = new Address()
                {
                    Country = "au"
                },
                CardDetails = new CardDetails()
                {
                    Name = "Tom Jones",
                    Number = "4444333322221111",
                    ExpiryMonth = "12",
                    ExpiryYear = "25",
                    CVN = "123"
                },
                TokenCustomerID = tokenid,
                
            };

            CreateCustomerResponse response = ewayClient.UpdateCustomer(PaymentMethod.Direct, customer);
            ViewBag.response = response;
            QueryCustomerResponse customerresponse = ewayClient.QueryCustomer(long.Parse(tokenid));
            return response;
        }

        public ActionResult UseToken(string token)
        {
         
            IRapidClient ewayClient = RapidClientFactory.NewRapidClient(apiKey, password, rapidEndpoint);



            //1. Charging the customer with token ... note refer to https://eway.io/api-v3/#token-payments
            // tokenpayment method is not used in rapid sdk Api 
            Transaction transaction = new Transaction()
            {
                Customer = new Customer()
                {
                    TokenCustomerID = token,

                },

                PaymentDetails = new PaymentDetails()
                {
                    TotalAmount = 10000,
                    InvoiceNumber = "14632"
                },
                RedirectURL = "http://localhost:53738/Home/Ewayresponse",
                            
                TransactionType = TransactionTypes.Recurring
            };


            CreateTransactionResponse response = ewayClient.Create(PaymentMethod.Direct, transaction);



            if (response.Errors != null)
            {
                foreach (string errorCode in response.Errors)
                {
                    Console.WriteLine("Error Message: " + RapidClientFactory.UserDisplayMessage(errorCode, "EN"));
                }
            }

            ViewBag.token = token;
            ViewBag.response = response;
            //ViewBag.totalamount = 
                
               int totalamount =  response.Transaction.PaymentDetails.TotalAmount / 100;
               ViewBag.totalamount = totalamount;
            return View();
        }

        public CreateTransactionResponse UseTokenRet(string token)
        {

            IRapidClient ewayClient = RapidClientFactory.NewRapidClient(apiKey, password, rapidEndpoint);



            //1. Charging the customer with token ... note refer to https://eway.io/api-v3/#token-payments
            // tokenpayment method is not used in rapid sdk Api 
            Transaction transaction = new Transaction()
            {
                Customer = new Customer()
                {
                    TokenCustomerID = token,

                },

                PaymentDetails = new PaymentDetails()
                {
                    TotalAmount = 10000
                },
                RedirectURL = "http://localhost:53738/Home/Ewayresponse",

                TransactionType = TransactionTypes.Recurring
            };


            CreateTransactionResponse response = ewayClient.Create(PaymentMethod.Direct, transaction);



            if (response.Errors != null)
            {
                foreach (string errorCode in response.Errors)
                {
                    Console.WriteLine("Error Message: " + RapidClientFactory.UserDisplayMessage(errorCode, "EN"));
                }
            }

            ViewBag.token = token;
            ViewBag.response = response;

            return response;
        }


        public ActionResult Scenario(int number)
        {

            ViewBag.number = number;

            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Subscription(string id)
        {
            int ID = Int32.Parse(id);
            var token = "";
            //Check if token exist otherwise send details to Shared Payment Gateway
            using (AimyEntities db = new AimyEntities()) {
                var checktokenexist = (from sub in db.CssSubscriptions
                                       join org in db.Orgs on sub.OrgId equals org.Id
                                       join pay in db.CssPaymentSetups on org.Id equals pay.OrgId
                                       where sub.Id == ID
                                       select new
                                       {
                                        token = pay.CustomerId,
                                        orgid = org.Id
                                       }
                                       ).FirstOrDefault();
                //check if token exits               
                if (checktokenexist.token != "")
                {
                   // token = checktokenexist.token;
                    token = "910287958561"; //only because this hasn't been save to db .. 
                    CreateTransactionResponse response = UseTokenRet(token);
                    ViewBag.response = response ; 
                }
                else //send to sharepayment gateway
                {
                   
                }
            }
            return View();
        }

    }
}