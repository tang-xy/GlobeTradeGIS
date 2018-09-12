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
        public FormMap()
        {
            InitializeComponent();
            countryChart = new ChartControl();
            dockContainer = new ControlContainer();
            dockContainer.Resize += new System.EventHandler(this.dockContainer_Resize);
        }

        private void queryData(String sql, SqlDataSource sqlDataSourceTrend)
        {
            CustomSqlQuery query = new CustomSqlQuery();
            query.Name = "country";
            query.Sql = sql;
            sqlDataSourceTrend.ConnectionName = "GlobeTradeGIS.Properties.Settings.GlobeTradeConnectionString";//用到了connectionstrings下的连接名
            sqlDataSourceTrend.Queries.Add(query);
            sqlDataSourceTrend.Fill();
        }
        private void showChart(ChartControl chart, String type, String name = "", String year = "")
        {
            if(type == "country")
            {
                string sql = "SELECT [1990],[2000],[2008],[2009],[2010],[2011],[2012],[2013],[2014],[2015],[2016],[2017] FROM GDP WHERE [Country Code] = \"" + name + "\"";
                SqlDataSource sqlDataSourceTrend = new SqlDataSource();
                queryData(sql, sqlDataSourceTrend);
                //countryChart.DataSource = sqlDataSourceTrend;
                Series series1 = new Series(name, ViewType.StackedBar);
                ITable src = sqlDataSourceTrend.Result[type];
                DataTable table = new DataTable(type);
                foreach (IColumn column in src.Columns)
                    table.Columns.Add(column.Name, column.Type);
                foreach (IRow row in src)
                    table.Rows.Add(row.ToArray());
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    {
                        for (int j = 0; j < table.Rows.Count; j++)
                        {
                            double num = 0;
                            num = (double)table.Rows[j][i];
                            series1.Points.Add(new SeriesPoint(table.Columns[i].ColumnName, num));
                        }
                        

                    }

                }
                //series1.DataSource = sqlDataSourceTrend;
                //series1.ArgumentDataMember = ;
                countryChart.Series.Clear();
                countryChart.Series.Add(series1);
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
            //填充数据
            showChart(countryChart, "country", "ARM");
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
