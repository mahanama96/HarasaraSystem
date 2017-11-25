using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarasaraSystem.SubInterface.Inventory
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            CrystalReportInv inv = new CrystalReportInv();
            crystalReportViewer1.ReportSource = inv;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
