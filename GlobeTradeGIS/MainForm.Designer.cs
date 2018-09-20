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
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.commercial_service_exportTableAdapter1 = new GlobeTradeGIS.GlobeTradeDataSetTableAdapters.commercial_service_exportTableAdapter();
            this.commercial_service_exportTableAdapter2 = new GlobeTradeGIS.GlobeTradeDataSetTableAdapters.commercial_service_exportTableAdapter();
            this.progressPanel = new DevExpress.XtraWaitForm.ProgressPanel();
            this.globeTradeDataSet1 = new GlobeTradeGIS.GlobeTradeDataSet();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.label_eventexpressdet = new System.Windows.Forms.Label();
            this.label_Eventexpress = new System.Windows.Forms.Label();
            this.label_rangedet = new System.Windows.Forms.Label();
            this.label_Range = new System.Windows.Forms.Label();
            this.label_namedet = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globeTradeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowsUIButtonPanel
            // 
            this.windowsUIButtonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.windowsUIButtonPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons"), ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons1"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons2"))), ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons3"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons4")))),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons5"), ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons6"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons7"))), ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons8"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons9")))),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons10"), ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons11"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons12"))), ((DevExpress.XtraBars.Docking2010.ImageLocation)(resources.GetObject("windowsUIButtonPanel.Buttons13"))), ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons14"))), resources.GetString("windowsUIButtonPanel.Buttons15"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons16"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons17"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons18"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons19"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons20"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons21"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons22"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons23"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons24"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons25"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons26"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons27")))),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons28"), ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons29"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons30"))), ((DevExpress.XtraBars.Docking2010.ImageLocation)(resources.GetObject("windowsUIButtonPanel.Buttons31"))), ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons32"))), resources.GetString("windowsUIButtonPanel.Buttons33"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons34"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons35"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons36"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons37"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons38"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons39"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons40"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons41"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons42"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons43"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons44"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons45")))),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons46"), ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons47"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons48"))), ((DevExpress.XtraBars.Docking2010.ImageLocation)(resources.GetObject("windowsUIButtonPanel.Buttons49"))), ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons50"))), resources.GetString("windowsUIButtonPanel.Buttons51"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons52"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons53"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons54"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons55"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons56"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons57"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons58"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons59"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons60"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons61"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons62"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons63")))),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons64"), ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons65"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons66"))), ((DevExpress.XtraBars.Docking2010.ImageLocation)(resources.GetObject("windowsUIButtonPanel.Buttons67"))), ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons68"))), resources.GetString("windowsUIButtonPanel.Buttons69"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons70"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons71"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons72"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons73"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons74"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons75"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons76"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons77"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons78"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons79"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons80"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons81")))),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(resources.GetString("windowsUIButtonPanel.Buttons82"), ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel.Buttons83"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons84"))), ((DevExpress.XtraBars.Docking2010.ImageLocation)(resources.GetObject("windowsUIButtonPanel.Buttons85"))), ((DevExpress.XtraBars.Docking2010.ButtonStyle)(resources.GetObject("windowsUIButtonPanel.Buttons86"))), resources.GetString("windowsUIButtonPanel.Buttons87"), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons88"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons89"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons90"))), ((DevExpress.Utils.SuperToolTip)(resources.GetObject("windowsUIButtonPanel.Buttons91"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons92"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons93"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons94"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons95"))), ((object)(resources.GetObject("windowsUIButtonPanel.Buttons96"))), ((int)(resources.GetObject("windowsUIButtonPanel.Buttons97"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons98"))), ((bool)(resources.GetObject("windowsUIButtonPanel.Buttons99"))))});
            this.windowsUIButtonPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.windowsUIButtonPanel.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.windowsUIButtonPanel, "windowsUIButtonPanel");
            this.windowsUIButtonPanel.Name = "windowsUIButtonPanel";
            this.windowsUIButtonPanel.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClick);
            this.windowsUIButtonPanel.ButtonChecked += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonClicked);
            // 
            // axLicenseControl
            // 
            resources.ApplyResources(this.axLicenseControl, "axLicenseControl");
            this.axLicenseControl.Name = "axLicenseControl";
            this.axLicenseControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl.OcxState")));
            // 
            // axMapControl
            // 
            resources.ApplyResources(this.axMapControl, "axMapControl");
            this.axMapControl.Name = "axMapControl";
            this.axMapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl.OcxState")));
            this.axMapControl.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl_OnMouseDown);
            this.axMapControl.OnMouseUp += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseUpEventHandler(this.axMapControl_OnMouseUp);
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
            // dockManager
            // 
            this.dockManager.DockingOptions.DockPanelInCaptionRegion = DevExpress.Utils.DefaultBoolean.True;
            this.dockManager.DockingOptions.ShowCloseButton = false;
            this.dockManager.Form = this;
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // commercial_service_exportTableAdapter1
            // 
            this.commercial_service_exportTableAdapter1.ClearBeforeFill = true;
            // 
            // commercial_service_exportTableAdapter2
            // 
            this.commercial_service_exportTableAdapter2.ClearBeforeFill = true;
            // 
            // progressPanel
            // 
            this.progressPanel.AnimationToTextDistance = 0;
            this.progressPanel.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("progressPanel.Appearance.BackColor")));
            this.progressPanel.Appearance.Options.UseBackColor = true;
            resources.ApplyResources(this.progressPanel, "progressPanel");
            this.progressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.progressPanel.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.progressPanel.Name = "progressPanel";
            this.progressPanel.ShowCaption = false;
            this.progressPanel.ShowDescription = false;
            this.progressPanel.Click += new System.EventHandler(this.progressPanel_Click);
            // 
            // globeTradeDataSet1
            // 
            this.globeTradeDataSet1.DataSetName = "GlobeTradeDataSet";
            this.globeTradeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.label_eventexpressdet);
            this.panelControl.Controls.Add(this.label_Eventexpress);
            this.panelControl.Controls.Add(this.label_rangedet);
            this.panelControl.Controls.Add(this.label_Range);
            this.panelControl.Controls.Add(this.label_namedet);
            this.panelControl.Controls.Add(this.label_Name);
            resources.ApplyResources(this.panelControl, "panelControl");
            this.panelControl.Name = "panelControl";
            // 
            // label_eventexpressdet
            // 
            resources.ApplyResources(this.label_eventexpressdet, "label_eventexpressdet");
            this.label_eventexpressdet.Name = "label_eventexpressdet";
            // 
            // label_Eventexpress
            // 
            resources.ApplyResources(this.label_Eventexpress, "label_Eventexpress");
            this.label_Eventexpress.Name = "label_Eventexpress";
            // 
            // label_rangedet
            // 
            resources.ApplyResources(this.label_rangedet, "label_rangedet");
            this.label_rangedet.Name = "label_rangedet";
            this.label_rangedet.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_Range
            // 
            resources.ApplyResources(this.label_Range, "label_Range");
            this.label_Range.Name = "label_Range";
            this.label_Range.Click += new System.EventHandler(this.label_Range_Click);
            // 
            // label_namedet
            // 
            resources.ApplyResources(this.label_namedet, "label_namedet");
            this.label_namedet.Name = "label_namedet";
            this.label_namedet.Click += new System.EventHandler(this.label_namedet_Click);
            // 
            // label_Name
            // 
            resources.ApplyResources(this.label_Name, "label_Name");
            this.label_Name.Name = "label_Name";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.progressPanel);
            this.Controls.Add(this.windowsUIButtonPanel);
            this.Controls.Add(this.axMapControl);
            this.Controls.Add(this.axLicenseControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ClientSizeChanged += new System.EventHandler(this.MainForm_ClientSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globeTradeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl;
        private System.Windows.Forms.Timer timer_UI_in;
        private System.Windows.Forms.Timer timer_UI_out;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private GlobeTradeDataSetTableAdapters.commercial_service_exportTableAdapter commercial_service_exportTableAdapter1;
        private GlobeTradeDataSetTableAdapters.commercial_service_exportTableAdapter commercial_service_exportTableAdapter2;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel;
        private GlobeTradeDataSet globeTradeDataSet1;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.Windows.Forms.Label label_rangedet;
        private System.Windows.Forms.Label label_Range;
        private System.Windows.Forms.Label label_namedet;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Eventexpress;
        private System.Windows.Forms.Label label_eventexpressdet;
    }
}