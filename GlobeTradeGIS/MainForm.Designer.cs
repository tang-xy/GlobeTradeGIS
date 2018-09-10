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
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.timer_UI_in = new System.Windows.Forms.Timer(this.components);
            this.timer_UI_out = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowsUIButtonPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel1.Buttons"))), -1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, 1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel1.Buttons1"))), -1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, 0)});
            this.windowsUIButtonPanel1.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(0, -80);
            this.windowsUIButtonPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(1454, 80);
            this.windowsUIButtonPanel1.TabIndex = 6;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            this.windowsUIButtonPanel1.ButtonChecked += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClicked);
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(0, 0);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 7;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Margin = new System.Windows.Forms.Padding(0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(1454, 586);
            this.axMapControl1.TabIndex = 8;
            this.axMapControl1.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl1_OnMouseMove);
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
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.axLicenseControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.Timer timer_UI_in;
        private System.Windows.Forms.Timer timer_UI_out;
    }
}