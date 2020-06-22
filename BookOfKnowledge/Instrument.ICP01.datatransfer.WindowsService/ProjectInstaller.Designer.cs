namespace Instrument.ICP01.datatransfer.WindowsService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ICP01serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            this.ICPserviceInstaller1 = new System.ServiceProcess.ServiceInstaller();
            // 
            // ICP01serviceProcessInstaller1
            // 
            this.ICP01serviceProcessInstaller1.Password = null;
            this.ICP01serviceProcessInstaller1.Username = null;
            // 
            // ICPserviceInstaller1
            // 
            this.ICPserviceInstaller1.ServiceName = "Service1";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ICP01serviceProcessInstaller1,
            this.ICPserviceInstaller1});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller ICP01serviceProcessInstaller1;
        private System.ServiceProcess.ServiceInstaller ICPserviceInstaller1;
    }
}