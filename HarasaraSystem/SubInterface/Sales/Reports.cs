using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Sales
{
    public partial class Reports : UserControl
    {
        private static Reports _instance;

        public static Reports Instance
        {
            get
            {
                if (_instance == null)

                    _instance = new Reports();
                return _instance;

            }
        }

        public Reports()
        {
            InitializeComponent();
            CrystalReportSal sal = new CrystalReportSal();
            crystalReportViewer1.ReportSource = sal;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
