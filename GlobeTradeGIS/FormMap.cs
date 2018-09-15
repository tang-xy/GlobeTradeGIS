using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Sql.DataApi;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GlobeTradeGIS
{
    public partial class FormMap : GlobeTradeGIS.MainForm
    {
        ChartControl countryChart;
        ControlContainer dockContainer;
        string[] importtype;
        string[] importname;
        string nowmode;
        public FormMap()
        {
            InitializeComponent();
            countryChart = new ChartControl();
            dockContainer = new ControlContainer();
            importtype = new string[] { "food", "goods", "fuel", "service", "merchandise", "commercial service" };
            importname = new string[] { "food_import", "goods_import", "fuel_import", "service_import", "merchandise_import", "commercial_service_import" };
            dockContainer.Resize += new System.EventHandler(this.dockContainer_Resize);
            nowmode = "home";
        }

        private void SqltoSeries(Series series1, string name,string sql)
        {
            SqlDataSource sqlDataSourceTrend = new SqlDataSource();
            CustomSqlQuery query = new CustomSqlQuery();
            query.Name = name;
            query.Sql = sql;
            sqlDataSourceTrend.ConnectionName = "GlobeTradeGIS.Properties.Settings.GlobeTradeConnectionString";//用到了connectionstrings下的连接名
            sqlDataSourceTrend.Queries.Add(query);
            sqlDataSourceTrend.Fill();
            ITable src = sqlDataSourceTrend.Result[name];
            DataTable table = new DataTable(name);
            foreach (IColumn column in src.Columns)
                table.Columns.Add(column.Name, column.Type);
            foreach (IRow row in src)
                table.Rows.Add(row.ToArray());
            for (int i = 0; i < table.Columns.Count; i++)
            {
                {
                    for (int j = 0; j < table.Rows.Count; j++)
                    {
                        //if(typeof())
                        double num = 0;
                        num = (double)table.Rows[j][i];
                        series1.Points.Add(new SeriesPoint(table.Columns[i].ColumnName, num));
                    }
                }
            }
        }
        private void showChart(ChartControl chart, String type, String name = "", String year = "")
        {
            if(type == "country")
            {
                nowmode = "country";
                countryChart.Name = name;
                countryChart.Series.Clear();
                for(int i = 0; i < importname.Count();i++)
                {
                    string import = importname[i];
                    Series series1 = new Series(importtype[i], ViewType.StackedBar);
                    string sql = "SELECT [2008],[2009],[2010],[2011],[2012],[2013],[2014],[2015],[2016],[2017] FROM " + import + " WHERE [Country Code] = \"" + name + "\"";
                    SqltoSeries(series1, import, sql);
                    countryChart.Series.Add(series1);
                }
                Series series_GDP = new Series("GDP", ViewType.Line);
                string sql_GDP = "SELECT [2008],[2009],[2010],[2011],[2012],[2013],[2014],[2015],[2016],[2017] FROM " + "GDP" + " WHERE [Country Code] = \"" + name + "\"";
                SqltoSeries(series_GDP, "GDP", sql_GDP);
                countryChart.Series.Add(series_GDP);
            }
            else if(type == "timepoint")
            {
                nowmode = "timepoint";
                countryChart.Series.Clear();
                Series series1 = new Series(name, ViewType.Pie);
                string sql = "SELECT [Commercial service import],[Food import],[Fuel import],[Goods import],[Merchandise import],[Service import] FROM import_" + year + " WHERE [Country Code] = \"" + name + "\"";
                SqltoSeries(series1, name, sql);
                series1.LegendPointOptions.PointView = PointView.ArgumentAndValues;
                countryChart.Series.Add(series1);

                Series series2 = new Series(name, ViewType.Pie);
                sql = "SELECT [Commercial service export],[Food export],[Fuel export],[Goods export],[mechandise-export],[Service export] FROM export_" + year + " WHERE [Country Code] = \"" + name + "\"";
                SqltoSeries(series2, name, sql);
                series2.LegendPointOptions.PointView = PointView.ArgumentAndValues;
                countryChart.Series.Add(series2);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //初始化
            countryChart.Dispose();
            dockContainer.Dispose();
            dockClear();
            countryChart = new ChartControl();
            dockContainer = new ControlContainer();
            //显示dock
            dockShow();
            dockpanel.Resize += new System.EventHandler(this.dockpanel_Resize);
            dockContainer.Controls.Add(countryChart);
            dockpanel.Controls.Add(dockContainer);
            //设置属性
            dockContainer.Location = new System.Drawing.Point(0, 0);
            dockContainer.Name = "country_Container";
            dockContainer.Size = new Size(dockpanel.Size.Width, dockpanel.Size.Height - 30);
            dockContainer.TabIndex = 0;
            countryChart.Size = new Size(dockpanel.Size.Width, dockpanel.Size.Height - 20);
            countryChart.RuntimeHitTesting = true;
            countryChart.MouseUp += CountryChart_MouseUp;
            countryChart.CustomDrawCrosshair += CountryChart_CustomDrawCrosshair;
            //填充数据
            showChart(countryChart, "country", "ARM");
        }

        private void CountryChart_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e)
        {

            foreach (CrosshairElement element in e.CrosshairElements)
            {
                SeriesPoint point = element.SeriesPoint;
                element.LabelElement.MarkerImageSizeMode = ChartImageSizeMode.Stretch;
                element.LabelElement.MarkerSize = new Size(10, 10); // 大小
                element.LabelElement.Text = point.Values[0].ToString();//显示要显示的文字
            }
        }

        private void CountryChart_MouseUp(object sender, MouseEventArgs e)
        {
            if (nowmode != "country") return;
            ChartHitInfo hitInfo = countryChart.CalcHitInfo(e.Location);
            if (hitInfo.SeriesPoint != null)
            {
                showChart(countryChart, "timepoint", countryChart.Name, hitInfo.SeriesPoint.Argument);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            countryChart.Dispose();
            dockContainer.Dispose();
            dockClear();
            countryChart = new ChartControl();
            dockContainer = new ControlContainer();
        }

        private void dockContainer_Resize(object sender, EventArgs e)
        {
            countryChart.Size = dockContainer.Size;
        }


        private void dockpanel_Resize(object sender, EventArgs e)
        {
            dockContainer.Size = new Size(dockpanel.Size.Width, dockpanel.Size.Height - 30);
            dockContainer.TabIndex = 0;
            countryChart.Size = new Size(dockpanel.Size.Width, dockpanel.Size.Height - 20);
        }

        private void FormMap_Shown(object sender, EventArgs e)
        {
        }
    }
}
