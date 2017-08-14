using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using System.ServiceModel;
using DevExpress.ExpressApp.Security.ClientServer.Wcf;
using DevExpress.ExpressApp.Security.ClientServer;

namespace CIPortal.Win {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
#if EASYTEST
            DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register();
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
			if(Tracing.GetFileLocationFromSettings() == DevExpress.Persistent.Base.FileLocation.CurrentUserApplicationDataFolder) {
                Tracing.LocalUserAppDataPath = Application.LocalUserAppDataPath;
            }
			Tracing.Initialize();
            CIPortalWindowsFormsApplication winApplication = new CIPortalWindowsFormsApplication();
            // Refer to the https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112680.aspx help article for more details on how to provide a custom splash form.
            //winApplication.SplashScreen = new DevExpress.ExpressApp.Win.Utils.DXSplashScreen("YourSplashImage.png");
			SecurityAdapterHelper.Enable();
			try {
				string connectionString = "net.tcp://127.0.0.1:1451/DataServer";
				WcfSecuredDataServerClient clientDataServer = new WcfSecuredDataServerClient(WcfDataServerHelper.CreateNetTcpBinding(),
					new EndpointAddress(connectionString));
				ServerSecurityClient securityClient = new ServerSecurityClient(clientDataServer, new ClientInfoFactory());
				securityClient.SupportNavigationPermissionsForTypes = false;
			    securityClient.IsSupportChangePassword = true;
				winApplication.Security = securityClient;
				winApplication.CreateCustomObjectSpaceProvider += 
					delegate(object sender, CreateCustomObjectSpaceProviderEventArgs e) {
						e.ObjectSpaceProvider = new DataServerObjectSpaceProvider(clientDataServer, securityClient);
					};
                winApplication.Setup();
				winApplication.Start();
				clientDataServer.Close();
            }
            catch(Exception e) {
                winApplication.HandleException(e);
            }
        }
    }
}
