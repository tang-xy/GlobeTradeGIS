namespace GlobeTradeGIS
{
    partial class FormMap
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
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
            // FormMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1272, 456);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormMap";
            this.Shown += new System.EventHandler(this.FormMap_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
    }
}
