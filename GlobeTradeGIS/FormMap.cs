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

        private void button1_Click(object sender, EventArgs e)
        {
            dockShow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dockClear();
        }
    }
}
