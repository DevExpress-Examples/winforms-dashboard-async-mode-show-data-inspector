using System;
using System.Windows.Forms;

namespace DataInspectorOnInitializeExample
{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            dashboardViewer1.Initialized += dashboardViewer1_Initialized;
        }
        async void dashboardViewer1_Initialized(object sender, EventArgs e) {
            await dashboardViewer1.ShowDataInspectorAsync("gridDashboardItem1");
        }
    }
}
