using DevExpress.DashboardCommon;

namespace DashboradWinForm
{
    public partial class DesignerForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DesignerForm1()
        {
            InitializeComponent();
            dashboardDesigner.DataSourceWizard.SqlWizardSettings.EnableCustomSql = true;
            dashboardDesigner.CreateRibbon();
            dashboardDesigner.LoadDashboard(@"Dashboards\dashboard1.xml");
            
        }
    }
}
