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
using DevExpress.XtraCharts;

namespace GlobeTradeGIS
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public DockPanel dockpanel;
        public Label labelloading;
        public static MainForm instance;
        protected Scene sc;
        string NowMode;
        public string nowmode
        {
            get
            {
                return NowMode;
            }
            set
            {
                if(value =="home")
                {
                    button_color_allreset();
                    homebutton_color_change();
                }
                else if(value == "globe")
                {
                    button_color_allreset();
                    worldbutton_color_change();
                }
                else if(value =="country")
                {
                    button_color_allreset();
                    countrybutton_color_change();
                }
                else if(value =="timepoint")
                {
                    button_color_allreset();
                    graphbutton_color_change();
                }
                NowMode = value;
            }
        }

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
            nowmode = "home";
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(this.ClientSize.Width, this.windowsUIButtonPanel.Height);
            //创建浮动窗口
            //dock();

            sc = new Scene();
            sc.BeginInit();
            this.Controls.Add(sc);
            sc.Dock = DockStyle.Fill;
            sc.BringToFront();
            sc.OnMouseUp += new ISceneControlEvents_Ax_OnMouseUpEventHandler(sc_OnMouseUp);
            sc.EndInit();
            sc.LoadSxFile("data/tradescene.sxd");
            this.windowsUIButtonPanel.BringToFront();
        }

        private void sc_OnMouseUp(object sender, ISceneControlEvents_OnMouseUpEvent e)
        {
            nowmode = "globe";
            sc.Dispose1();
            return;
        }

        //DevExpress.XtraBars.Docking2010.ButtonEventArgs button2;
        public void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.GroupIndex == 1)
                System.Environment.Exit(0);
            else if (e.Button.Properties.GroupIndex == 0)
                this.WindowState = FormWindowState.Minimized;
            else if (e.Button.Properties.GroupIndex == 5)
            {
                sc = new Scene();
                sc.BeginInit();
                this.Controls.Add(sc);
                sc.Dock = DockStyle.Fill;
                sc.BringToFront();
                sc.EndInit();
                sc.LoadSxFile("data/tradescene.sxd");
                nowmode = "home";
                this.windowsUIButtonPanel.BringToFront();
                sc.OnMouseUp += new ISceneControlEvents_Ax_OnMouseUpEventHandler(sc_OnMouseUp);
            }
            else if(e.Button.Properties.GroupIndex == 3)
            {
                //countryChart.Dispose();
                //dockContainer.Dispose();
               // dockClear();
               // countryChart = new ChartControl();
               // dockContainer = new ControlContainer();
               // nowmode = "country";
            }

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
            windowsUIButtonPanel.Buttons[5].Properties.Appearance.ForeColor = Color.FromArgb(200, 150, 50);
        }
        private void countrybutton_color_change()
        {
            windowsUIButtonPanel.Buttons[4].Properties.Appearance.ForeColor = Color.FromArgb(200, 150, 50);
        }
        private void graphbutton_color_change()
        {
            windowsUIButtonPanel.Buttons[3].Properties.Appearance.ForeColor = Color.FromArgb(200, 150, 50);
        }
        private void homebutton_color_change()
        {
            windowsUIButtonPanel.Buttons[6].Properties.Appearance.ForeColor = Color.FromArgb(200, 150, 50);
        }
        private void button_color_allreset()
        {
            windowsUIButtonPanel.Buttons[6].Properties.Appearance.ForeColor = Color.Black;
            windowsUIButtonPanel.Buttons[4].Properties.Appearance.ForeColor = Color.Black;
            windowsUIButtonPanel.Buttons[3].Properties.Appearance.ForeColor = Color.Black;
            windowsUIButtonPanel.Buttons[5].Properties.Appearance.ForeColor = Color.Black;
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
            this.windowsUIButtonPanel.Size = new System.Drawing.Size(this.ClientSize.Width, this.windowsUIButtonPanel.Size.Height);
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
            if(nowmode == "home")
            {
                nowmode = "globe";
                sc.Dispose();
                return;
            }
            if(nowmode == "globe")
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
                pMap.SelectFeature(pFeatureLayer, feature); 
                //axMapControl1.Map.SelectByShape(point, null, true);//第三个参数为是否只选中一个
                axMapControl.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null); //选中要素高亮显示
                if(feature != null)
                {
                    nowmode = "country";
                    panelControl.Visible = false;
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
            if(nowmode == "globe")
            {
                IMap pMap = axMapControl.Map;
                IActiveView pActiveView = pMap as IActiveView;
                IFeatureLayer pFeatureLayer_event = GetLayerByName(axMapControl, "Eventbuffer") as IFeatureLayer;
                IFeatureLayer pFeatureLayer_country = GetLayerByName(axMapControl, "Trade") as IFeatureLayer;
                IFeatureClass pFeatureClass_event = pFeatureLayer_event.FeatureClass;
                IPoint point = pActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y);
                IFeature feature = GetFeatureOnMouseDown(point, "Eventbuffer", axMapControl);
                if (feature == null)
                {
                    panelControl.Visible = false;
                    return;
                }
                if(feature.Value[0].ToString()=="4")
                {
                    string sql1 = "\"Country_Co\" LIKE \'USA\'";
                    string sql2 = "\"Country_Co\" LIKE \'CHN\'";
                    string sql3 = "\"Country_Co\" LIKE \'BGR\'";
                    string sql4 = "\"Country_Co\" LIKE \'CHE\'";
                    string sql5 = "\"Country_Co\" LIKE \'CZE\'";
                    string sql6 = "\"Country_Co\" LIKE \'DEU\'";
                    string sql7 = "\"Country_Co\" LIKE \'ESP\'";
                    string sql8 = "\"Country_Co\" LIKE \'FRA\'";
                    string sql9 = "\"Country_Co\" LIKE \'GBR\'";
                    string sql10 = "\"Country_Co\" LIKE \'GRC\'";
                    string sql11 = "\"Country_Co\" LIKE \'HRV\'";
                    string sql12 = "\"Country_Co\" LIKE \'LUX\'";
                    string sql13 = "\"Country_Co\" LIKE \'NLD\'";
                    string sql14 = "\"Country_Co\" LIKE \'POL\'";
                    string sql15 = "\"Country_Co\" LIKE \'ROU\'";
                    string sql16 = "\"Country_Co\" LIKE \'SVK\'";
                    string sql17 = "\"Country_Co\" LIKE \'SVN\'";

                    IFeature f1 = QueryAndHight(sql1, pFeatureLayer_country,axMapControl);
                    IFeature f2 = QueryAndHight(sql2, pFeatureLayer_country, axMapControl);
                    IFeature f3 = QueryAndHight(sql3, pFeatureLayer_country, axMapControl);
                    IFeature f4 = QueryAndHight(sql4, pFeatureLayer_country, axMapControl);
                    IFeature f5 = QueryAndHight(sql5, pFeatureLayer_country, axMapControl);
                    IFeature f6 = QueryAndHight(sql6, pFeatureLayer_country, axMapControl);
                    IFeature f7 = QueryAndHight(sql7, pFeatureLayer_country, axMapControl);
                    IFeature f8 = QueryAndHight(sql8, pFeatureLayer_country, axMapControl);
                    IFeature f9 = QueryAndHight(sql9, pFeatureLayer_country, axMapControl);
                    IFeature f10 = QueryAndHight(sql10, pFeatureLayer_country, axMapControl);
                    IFeature f11 = QueryAndHight(sql11, pFeatureLayer_country, axMapControl);
                    IFeature f12 = QueryAndHight(sql12, pFeatureLayer_country, axMapControl);
                    IFeature f13 = QueryAndHight(sql13, pFeatureLayer_country, axMapControl);
                    IFeature f14 = QueryAndHight(sql14, pFeatureLayer_country, axMapControl);
                    IFeature f15 = QueryAndHight(sql15, pFeatureLayer_country, axMapControl);
                    IFeature f16 = QueryAndHight(sql16, pFeatureLayer_country, axMapControl);
                    IFeature f17 = QueryAndHight(sql17, pFeatureLayer_country, axMapControl);

                    pMap.SelectFeature(pFeatureLayer_country, f1);
                    pMap.SelectFeature(pFeatureLayer_country, f2);
                    pMap.SelectFeature(pFeatureLayer_country, f3);
                    pMap.SelectFeature(pFeatureLayer_country, f4);
                    pMap.SelectFeature(pFeatureLayer_country, f5);
                    pMap.SelectFeature(pFeatureLayer_country, f6);
                    pMap.SelectFeature(pFeatureLayer_country, f7);
                    pMap.SelectFeature(pFeatureLayer_country, f8);
                    pMap.SelectFeature(pFeatureLayer_country, f9);
                    pMap.SelectFeature(pFeatureLayer_country, f10);
                    pMap.SelectFeature(pFeatureLayer_country, f11);
                    pMap.SelectFeature(pFeatureLayer_country, f12);
                    pMap.SelectFeature(pFeatureLayer_country, f13);
                    pMap.SelectFeature(pFeatureLayer_country, f14);
                    pMap.SelectFeature(pFeatureLayer_country, f15);
                    pMap.SelectFeature(pFeatureLayer_country, f16);
                    pMap.SelectFeature(pFeatureLayer_country, f17);

                    axMapControl.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null); //选中要素高亮显示
                    panelControl.Location = new System.Drawing.Point(e.x,e.y);
                    panelControl.Visible = true;
                }
                //pMap.SelectFeature(pFeatureLayer_event, feature);
                //axMapControl1.Map.SelectByShape(point, null, true);//第三个参数为是否只选中一个
                //axMapControl.Refresh(esriViewDrawPhase.esriViewGeoSelection, null, null); //选中要素高亮显示
            }
            else if(nowmode!="globe")
            {
                panelControl.Visible = false;
                return;
            }

        }

        public IFeature QueryAndHight(string sql, ILayer pLayer, AxMapControl t)
        {//查询                   
            t.Map.ClearSelection();//清除地图的选择  
            IFeatureLayer pFeatureLayer = pLayer as IFeatureLayer;//定义矢量图层            
            IQueryFilter pQueryFilter = new QueryFilter();//实例化一个查询条件对象            
            pQueryFilter.WhereClause = sql;//将查询条件赋值            
            IFeatureCursor pFeatureCursor = pFeatureLayer.Search(pQueryFilter, false);//进行查询            
            IFeature pFeature;
            pFeature = pFeatureCursor.NextFeature();//此步是将游标中的第一个交给pFeature            
            if (pFeature == null)//判断是否查到结果            
            {//如果没有查到报错并结束                
                MessageBox.Show("没有查询到地物！", "查询提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            return pFeature;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_Range_Click(object sender, EventArgs e)
        {

        }

        private void label_namedet_Click(object sender, EventArgs e)
        {

        }
    }
}