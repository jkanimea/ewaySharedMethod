using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TestEwayService
{
    public partial class Scheduler : ServiceBase
    {
        private Timer timer1 = null;

        public Scheduler()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            timer1 = new Timer();
            this.timer1.Interval = 30000; //every 30 sec
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Tick);
            timer1.Enabled = true;
            Library.WriteErrorLog("Test window service started");

            //using (AimyEntities db = new AimyEntities())
            //{
            //    CssPaymentSetup savetoken = new CssPaymentSetup();
            //    savetoken.CustomerId = tokenid;
            //    savetoken.IsActive = true;
            //    savetoken.MaskedCardNumber = creditcard;
            //    savetoken.OrgId = orgid;
            //    savetoken.CreatedOn = DateTime.Today;
            //    //CreatedBy is the userid that can be retrieve from session current user -- for now we assign 3694                                             
            //    savetoken.CreatedBy = 3694;

            //    db.CssPaymentSetups.Add(savetoken);
            //    db.SaveChanges();

            //};


        }

        private void timer1_Tick(object sender, ElapsedEventArgs e)
        {
            Library.WriteErrorLog("Timer ticked and some job has been done successful");
            throw new NotImplementedException();
        }

        protected override void OnStop()

        {
            timer1.Enabled = false;
            Library.WriteErrorLog("Test window service stopped");
        }
    }
}
