namespace CIPortal.Module.Mobile {
    partial class CIPortalMobileModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            // 
            // CIPortalMobileModule
            // 
            this.RequiredModuleTypes.Add(typeof(CIPortal.Module.CIPortalModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Mobile.SystemModule.SystemMobileModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.CloneObject.Mobile.CloneObjectMobileModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Mobile.ConditionalAppearance.ConditionalAppearanceMobileModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.FileAttachments.Mobile.FileAttachmentsMobileModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Maps.Mobile.MapsMobileModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.ReportsV2.Mobile.ReportsMobileModuleV2));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Mobile.Validation.ValidationMobileModule));
        }

        #endregion
    }
}