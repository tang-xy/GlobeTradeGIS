using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using GlobeTradeGIS.Properties;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;

namespace GlobeTradeGIS
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public DockPanel dockpanel;
        public Label labelloading;
        public static MainForm instance;
        public string nowmode;

        public MainForm()
        {
            ESRI.ArcGIS.RuntimeManager.Bind(ESRI.ArcGIS.ProductCode.EngineOrDesktop);
            InitializeComponent();
            if (axMapControl.CheckMxFile("data/trade.mxd"))
                axMapControl.LoadMxFile("data/trade.mxd");
            else
                MessageBox.Show("地图信息加载发生错误");
            //重新初始化windowsUIButtonpanel
            axMapControl.MousePointer = esriControlsMousePointer.esriPointerPan;

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
            timer_UI_out.Stop();
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
            timer_UI_in.Stop();
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
            labelloading = new Label();
            labelloading.BackColor = System.Drawing.Color.Transparent;
            labelloading.Image = global::GlobeTradeGIS.Properties.Resources.loading;
            labelloading.Location = new System.Drawing.Point(this.ClientSize.Width/2-65, this.ClientSize.Height/2-65);
            labelloading.Name = "label";
            labelloading.Size = new System.Drawing.Size(65, 65);
            labelloading.TabIndex = 9;
            this.Controls.Add(this.labelloading);
            // labelloading.Click += new System.EventHandler(this.label_Click);

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
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(this.ClientSize.Width, (int)(this.ClientSize.Height*0.07));
            this.progressPanel.Location = new System.Drawing.Point(this.ClientSize.Width / 2 , this.ClientSize.Height / 2 );
            //this.progressBarControl.Location = new System.Drawing.Point(this.ClientSize.Width-this.progressBarControl.Size.Width,this.ClientSize.Height-this.progressBarControl.Size.Height);
        }


        private void buttonloading_Click(object sender, EventArgs e)
        {
            this.progressPanel.Visible = true;
            this.Enabled = false;
        }

        private void progressPanel_Click(object sender, EventArgs e)
        {

        }
        int x = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (x == 1)
            {
                this.popupContainerControl.Show();
                x = 0;
            }
            else if(x==0)
            {
                this.popupContainerControl.Hide();
                x = 1;
            }

        }

        private void axMapControl_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            if(e.button == 2)
            {
                ESRI.ArcGIS.Geometry.IEnvelope ipEnv;
                ipEnv = axMapControl.Extent;
                this.axMapControl.Pan();
            }
        }

        public void axMapControl_OnMouseUp(object sender, IMapControlEvents2_OnMouseUpEvent e)
        {
            if(nowmode == null)
            {
                //nowmode = "country";
                IMap pMap = axMapControl.Map;
                IActiveView pActiveView = pMap as IActiveView;
                if (e.shift == 0)
                {
                    ClearSelect(axMapControl);
                }
                IFeatureLayer pFeatureLayer = GetLayerByName(axMapControl, "Trade") as IFeatureLayer;
                IFeatureClass pFeatureClass = pFeatureLayer.FeatureClass;
                IPoint point = pActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y);
                IFeature feature = GetFeatureOnMouseDown(point, "Trade", axMapControl);
                pMap.SelectFeature(GetLayerByName(axMapControl, "Trade"), feature);
                //axMapControl1.Map.SelectByShape(point, null, true);//第三个参数为是否只选中一个
                axMapControl.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null); //选中要素高亮显示
                if(feature != null)
                {
                    nowmode = "country";
                    axMapControl.CenterAt((feature.Shape as ESRI.ArcGIS.Geometry.IPolygon).ToPoint);
                    for (int i = 0; i < feature.Fields.FieldCount; i++)
                    {
                        if (feature.Fields.get_Field(i).Name == "Country_Co")
                        {
                            progressPanel.Location = new System.Drawing.Point(this .ClientSize.Width/2-this.progressPanel.Width/2,this.ClientSize.Height/2-this.progressPanel.Height/2);
                            progressPanel.Visible = true;
                            this.Enabled = false;
                            ToCountry(feature.Value[i].ToString());
                            progressPanel.Visible = false;
                            this.Enabled = true;
                            return;
                        }
                    }
                }
            }
        }
        virtual public void ToCountry(string countryName)
        {

        }
        private void ClearSelect(AxMapControl t)
        {
            IMap pMap = t.Map;
            IActiveView pActiveView = pMap as IActiveView;
            pActiveView.FocusMap.ClearSelection();
            pActiveView.PartialRefresh(esriViewDrawPhase.esriViewGeoSelection, null, pActiveView.Extent);
            t.CurrentTool = null;
        }
        private ILayer GetLayerByName(AxMapControl axMapControl, string name)
        {
            try
            {
                ILayer layer;
                for (int i = 0; i < 1000; i++)
                {
                    layer = axMapControl.get_Layer(i);
                    if (layer.Name == name)
                    {
                        return layer;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
        public IFeature GetFeatureOnMouseDown(IPoint point, string name, AxMapControl axMapControl1)
        {
            try
            {
                ILayer layer = GetLayerByName(axMapControl1, name);
                if (layer == null)
                {
                    MessageBox.Show("请加载图层！", "提示");
                    return null;
                }
                //IFeatureLayer fLayer = layer as IFeatureLayer;
                //IFeatureSelection featureSelection = fLayer as IFeatureSelection;
                //featureSelection.Clear();
                //if (featureSelection == null)
                //{
                //    return null;
                //}

                IFeatureLayer featureLayer = layer as IFeatureLayer;
                if (featureLayer == null)
                    return null;
                IFeatureClass featureClass = featureLayer.FeatureClass;
                if (featureClass == null)
                    return null;

                //IPoint point = axMapControl1.ActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(x, y);
                IGeometry geometry = point as IGeometry;

                double length = ConvertPixelsToMapUnits(axMapControl1.ActiveView, 4);
                ITopologicalOperator pTopo = geometry as ITopologicalOperator;
                IGeometry buffer = pTopo.Buffer(length);
                geometry = buffer.Envelope as IGeometry;

                ISpatialFilter spatialFilter = new SpatialFilterClass();
                spatialFilter.Geometry = geometry;
                switch (featureClass.ShapeType)
                {
                    case esriGeometryType.esriGeometryPoint:
                        spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelContains;
                        break;
                    case esriGeometryType.esriGeometryPolygon:
                        spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects;
                        break;
                    case esriGeometryType.esriGeometryPolyline:
                        spatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelCrosses;
                        break;
                }
                spatialFilter.GeometryField = featureClass.ShapeFieldName;
                IQueryFilter filter = spatialFilter as IQueryFilter;

                IFeatureCursor cursor = featureClass.Search(filter, false);
                IFeature pfeature = cursor.NextFeature();
                if (pfeature != null)
                {
                    return pfeature;
                    //featureSelection.Add(pfeature);
                    //pfeature = cursor.NextFeature();
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {

                return null;
            }
        }
        private double ConvertPixelsToMapUnits(IActiveView pActiveView, double pixelUnits)
        {
            // Uses the ratio of the size of the map in pixels to map units to do the conversion
            IPoint p1 = pActiveView.ScreenDisplay.DisplayTransformation.VisibleBounds.UpperLeft;
            IPoint p2 = pActiveView.ScreenDisplay.DisplayTransformation.VisibleBounds.UpperRight;
            int x1, x2, y1, y2;
            pActiveView.ScreenDisplay.DisplayTransformation.FromMapPoint(p1, out x1, out y1);
            pActiveView.ScreenDisplay.DisplayTransformation.FromMapPoint(p2, out x2, out y2);
            double pixelExtent = x2 - x1;
            double realWorldDisplayExtent = pActiveView.ScreenDisplay.DisplayTransformation.VisibleBounds.Width;
            double sizeOfOnePixel = realWorldDisplayExtent / pixelExtent;
            return pixelUnits * sizeOfOnePixel;
        }
    }
}