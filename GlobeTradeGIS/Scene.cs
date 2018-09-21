using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Controls;

namespace GlobeTradeGIS
{
    public class Scene : AxSceneControl
    {
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components = null;
        public Scene()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Enabled = true;
        }
        public void Show3D()
        {
            Camera.Rotate(1.0);
            Refresh();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Show3D();
        }
        public void Dispose1()
        {
            this.timer1.Stop();
            this.Dispose();
        }
    }

}
