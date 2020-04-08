using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Tally_AR_Service
{
    public partial class Service1 : ServiceBase
    {
        private readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Service1()
        {
            InitializeComponent();
        }

        public void onDebug()
        {
            log.Debug("Debugging started");
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {
            log.Info("Execution Started");
        }

        protected override void OnStop()
        {
            log.Info("Execution Stopped");
        }   
    }
}
