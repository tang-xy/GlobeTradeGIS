using DevExpress.XtraBars.Docking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GlobeTradeGIS
{
    public partial class FormMap : GlobeTradeGIS.MainForm
    {
        public FormMap()
        {
            InitializeComponent();
        }

        private void dockpanel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showDock();
        }

        private void showDock()
        {
            this.dockpanel = new DockPanel();
            this.dockManager.AddPanel(new DockingStyle(), dockpanel);
            dockpanel.Dock = DockingStyle.Float;
            dockpanel.FloatLocation = new System.Drawing.Point((int)(this.ClientSize.Width / 2) - 25, (int)(this.ClientSize.Height * 0.6));
            dockpanel.FloatSize = new System.Drawing.Size((int)(this.ClientSize.Width / 2), (int)(this.ClientSize.Height * 0.4));
            dockpanel.OriginalSize = new System.Drawing.Size(200, 200);
            dockpanel.Size = new System.Drawing.Size((int)(this.ClientSize.Width / 2), (int)(this.ClientSize.Height * 0.4));
            dockpanel.Text = "dockPane";
            dockpanel.Size = new System.Drawing.Size(0, 0);
            dockpanel.FloatSize = new System.Drawing.Size(0, 0);
        }
    }
}
