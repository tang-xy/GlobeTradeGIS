using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace GlobeTradeGIS
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            InitializeComponent();
            //重新初始化windowsUIButtonpanel
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(this.ClientSize.Width,this.windowsUIButtonPanel1.Height);
        }
        //DevExpress.XtraBars.Docking2010.ButtonEventArgs button2;
        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.GroupIndex == 0)
                System.Environment.Exit(0);
            else if (e.Button.Properties.GroupIndex == 1)
                this.WindowState = FormWindowState.Minimized;
             // this.notifyIcon1.Visible = true;

        }

        //
        //实现操作条进入退出动画
        //
        private void UIin()
        {
            timer_UI_in.Start();
        }

        private void UIout()
        {
            timer_UI_out.Start();
        }

        private void timer_UI_in_Tick(object sender, EventArgs e)
        {
            timer_UI_in.Interval = 1;//时间间隔0.005s            
            if (this.windowsUIButtonPanel1.Location.Y >= 0)
            {
                timer_UI_in.Stop();
            }
            else
            {
                this.windowsUIButtonPanel1.Location = new System.Drawing.Point((int)(this.windowsUIButtonPanel1.Location.X), (int)(this.windowsUIButtonPanel1.Location.Y + (this.windowsUIButtonPanel1.Size.Height / 4)));
            }

        }
        private void timer_UI_out_Tick(object sender, EventArgs e)
        {
            timer_UI_out.Interval = 1;//时间间隔0.005s           
            if (this.windowsUIButtonPanel1.Location.Y <= -this.windowsUIButtonPanel1.Size.Height)
            {
                timer_UI_out.Stop();
            }
            else
            {
                this.windowsUIButtonPanel1.Location = new System.Drawing.Point((int)(this.windowsUIButtonPanel1.Location.X), (int)(this.windowsUIButtonPanel1.Location.Y - (this.windowsUIButtonPanel1.Size.Height / 4)));
            }

        }
        private void axMapControl1_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            if (e.y <= 200&&this.windowsUIButtonPanel1.Location.Y<=0)
                UIin();
            else if(e.y>=400&&this.windowsUIButtonPanel1.Location.Y>=0)
                UIout();
        }

        private void windowsUIButtonPanel1_ButtonClicked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {

        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {

        }


    }
}