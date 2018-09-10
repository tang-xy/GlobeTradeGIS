namespace GlobeTradeGIS
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.windowsUIButtonPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.axLicenseControl = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.timer_UI_in = new System.Windows.Forms.Timer(this.components);
            this.timer_UI_out = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsUIButtonPanel
            // 
            this.windowsUIButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("min", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons"))), -1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, 0),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("exit", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons1"))), -1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, 1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("graph", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons2"))), -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, false, true, null, null, 2, true, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("country", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons3"))), -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, false, true, null, null, 3, true, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("world", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons4"))), -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, false, true, null, null, 4, true, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("home", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons5"))), -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, false, true, null, null, 6, true, false)});
            this.windowsUIButtonPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.Black;
            this.windowsUIButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(1454, 80);
            this.windowsUIButtonPanel.TabIndex = 6;
            this.windowsUIButtonPanel.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            this.windowsUIButtonPanel.ButtonChecked += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClicked);
            // 
            // axLicenseControl
            // 
            this.axLicenseControl.Enabled = true;
            this.axLicenseControl.Location = new System.Drawing.Point(0, 0);
            this.axLicenseControl.Name = "axLicenseControl";
            this.axLicenseControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl.OcxState")));
            this.axLicenseControl.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl.TabIndex = 7;
            // 
            // axMapControl
            // 
            this.axMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl.Location = new System.Drawing.Point(0, 0);
            this.axMapControl.Margin = new System.Windows.Forms.Padding(0);
            this.axMapControl.Name = "axMapControl";
            this.axMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl.OcxState")));
            this.axMapControl.Size = new System.Drawing.Size(1454, 586);
            this.axMapControl.TabIndex = 8;
            this.axMapControl.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
            // 
            // timer_UI_in
            // 
            this.timer_UI_in.Tick += new System.EventHandler(this.timer_UI_in_Tick);
            // 
            // timer_UI_out
            // 
            this.timer_UI_out.Tick += new System.EventHandler(this.timer_UI_out_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1454, 586);
            this.Controls.Add(this.windowsUIButtonPanel);
            this.Controls.Add(this.axMapControl);
            this.Controls.Add(this.axLicenseControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl;
        private System.Windows.Forms.Timer timer_UI_in;
        private System.Windows.Forms.Timer timer_UI_out;
    }
}