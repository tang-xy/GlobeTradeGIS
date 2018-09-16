using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;

namespace GlobeTradeGIS
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public DockPanel dockpanel;
        public Label labelloading;
        public static MainForm instance;

        public MainForm()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            InitializeComponent();
            //重新初始化windowsUIButtonpanel
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(this.ClientSize.Width, this.windowsUIButtonPanel.Height);
            //创建浮动窗口
            //dock();
            //
        }
        //DevExpress.XtraBars.Docking2010.ButtonEventArgs button2;
        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.GroupIndex == 1)
                System.Environment.Exit(0);
            else if (e.Button.Properties.GroupIndex == 0)
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
            if (this.windowsUIButtonPanel.Location.Y >= 0)
            {
                timer_UI_in.Stop();
            }
            else
            {
                this.windowsUIButtonPanel.Location = new System.Drawing.Point((int)(this.windowsUIButtonPanel.Location.X), (int)(this.windowsUIButtonPanel.Location.Y + (this.windowsUIButtonPanel.Size.Height / 4)));
            }

        }
        private void timer_UI_out_Tick(object sender, EventArgs e)
        {
            timer_UI_out.Interval = 1;//时间间隔0.005s           
            if (this.windowsUIButtonPanel.Location.Y <= -this.windowsUIButtonPanel.Size.Height)
            {
                timer_UI_out.Stop();
            }
            else
            {
                this.windowsUIButtonPanel.Location = new System.Drawing.Point((int)(this.windowsUIButtonPanel.Location.X), (int)(this.windowsUIButtonPanel.Location.Y - (this.windowsUIButtonPanel.Size.Height / 4)));
            }

        }
        private void axMapControl1_OnMouseMove(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseMoveEvent e)
        {
            if (e.y <= (0.2*this.ClientSize.Height) && this.windowsUIButtonPanel.Location.Y <= 0)
                UIin();
            else if (e.y >= (0.4 * this.ClientSize.Height) && this.windowsUIButtonPanel.Location.Y >= 0)
                UIout();
        }
        //
        //实现工具条按钮颜色变化函数
        //
        private void worldbutton_color_change()
        {
            windowsUIButtonPanel.Buttons[4].Properties.Appearance.ForeColor = Color.FromArgb(200, 150, 50);
        }
        private void worldbutton_color_reset()
        {
            windowsUIButtonPanel.Buttons[4].Properties.Appearance.ForeColor = Color.Black;
        }

        private void countrybutton_color_change()
        {
            windowsUIButtonPanel.Buttons[3].Properties.Appearance.ForeColor = Color.FromArgb(200, 150, 50);
        }
        private void countrybutton_color_reset()
        {
            windowsUIButtonPanel.Buttons[3].Properties.Appearance.ForeColor = Color.Black;
        }

        private void graphbutton_color_change()
        {
            windowsUIButtonPanel.Buttons[2].Properties.Appearance.ForeColor = Color.FromArgb(200, 150, 50);
        }
        private void graphbutton_color_reset()
        {
            windowsUIButtonPanel.Buttons[2].Properties.Appearance.ForeColor = Color.Black;
        }

        public void dockShow()
        {
            this.dockpanel = new DockPanel();
            this.dockManager.AddPanel(new DockingStyle(), dockpanel);
            dockpanel.Dock = DockingStyle.Float;
            dockpanel.FloatLocation = new System.Drawing.Point((int)(this.ClientSize.Width/2)-25 , (int)(this.ClientSize.Height*0.6));
            dockpanel.FloatSize = new System.Drawing.Size((int)(this.ClientSize.Width / 2), (int)(this.ClientSize.Height * 0.4));
            dockpanel.OriginalSize = new System.Drawing.Size(200, 200);
            dockpanel.Size = new System.Drawing.Size((int)(this.ClientSize.Width / 2), (int)(this.ClientSize.Height * 0.4));
            dockpanel.Text = "图表分析";

        }

        public void showloadingpic()
        {
            this.labelloading = new Label();
            this.labelloading.BackColor = System.Drawing.Color.Transparent;
            this.labelloading.Image = global::GlobeTradeGIS.Properties.Resources.loading;
            this.labelloading.Location = new System.Drawing.Point(this.ClientSize.Width/2-65, this.ClientSize.Height/2-65);
            this.labelloading.Name = "label";
            this.labelloading.Size = new System.Drawing.Size(65, 65);
            this.labelloading.TabIndex = 9;
            this.labelloading.Click += new System.EventHandler(this.label_Click);

        }
        public void dockClear()
        {
            dockManager.Clear();
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

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_ClientSizeChanged(object sender, EventArgs e)
        {
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {


            this.windowsUIButtonPanel.Size = new System.Drawing.Size(this.ClientSize.Width, this.windowsUIButtonPanel.Height);
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void buttonloading_Click(object sender, EventArgs e)
        {
            showloadingpic();
           // MainForm.instance.Enabled = false;
        }
    }
    }