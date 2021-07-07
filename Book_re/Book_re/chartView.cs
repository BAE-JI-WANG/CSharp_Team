using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_re
{
    public partial class chartView : Form
    {
        const string CATE0 = "총류";
        const string CATE0_Q = "select count(category) as '카테고리' from book where category= '총류'";
        const string CATE1 = "철학";
        const string CATE1_Q = "select count(category) as '카테고리' from book where category= '철학'";
        const string CATE2 = "종교";
        const string CATE2_Q = "select count(category) as '카테고리' from book where category= '종교'";
        const string CATE3 = "사회과학";
        const string CATE3_Q = "select count(category) as '카테고리' from book where category= '사회과학'";
        const string CATE4 = "자연과학";
        const string CATE4_Q = "select count(category) as '카테고리' from book where category= '자연과학'";
        const string CATE5 = "기술과학";
        const string CATE5_Q = "select count(category) as '카테고리' from book where category= '기술과학'";
        const string CATE6 = "예술";
        const string CATE6_Q = "select count(category) as '카테고리' from book where category= '예술'";
        const string CATE7 = "언어";
        const string CATE7_Q = "select count(category) as '카테고리' from book where category= '언어'";
        const string CATE8 = "문학";
        const string CATE8_Q = "select count(category) as '카테고리' from book where category= '문학'";
        const string CATE9 = "역사";
        const string CATE9_Q = "select count(category) as '카테고리' from book where category= '역사'";

        public chartView()
        {
            InitializeComponent();
            DataManager dm = new DataManager();
            int cate00 = dm.count_category(CATE0_Q);
            int cate01 = dm.count_category(CATE1_Q);
            int cate02 = dm.count_category(CATE2_Q);
            int cate03 = dm.count_category(CATE3_Q);
            int cate04 = dm.count_category(CATE4_Q);
            int cate05 = dm.count_category(CATE5_Q);
            int cate06 = dm.count_category(CATE6_Q);
            int cate07 = dm.count_category(CATE7_Q);
            int cate08 = dm.count_category(CATE8_Q);
            int cate09 = dm.count_category(CATE9_Q);

            chart1.ChartAreas[0].AxisY.LabelStyle.Interval = 50;
            chart1.Series[0].Name = CATE0;
            chart1.Series.Add(CATE1);
            chart1.Series.Add(CATE2);
            chart1.Series.Add(CATE3);
            chart1.Series.Add(CATE4);
            chart1.Series.Add(CATE5);
            chart1.Series.Add(CATE6);
            chart1.Series.Add(CATE7);
            chart1.Series.Add(CATE8);
            chart1.Series.Add(CATE9);


            chart1.Series[0].Points.AddXY("장르", cate00);
            chart1.Series[1].Points.AddY(cate01);
            chart1.Series[2].Points.AddY(cate02);
            chart1.Series[3].Points.AddY(cate03);
            chart1.Series[4].Points.AddY(cate04);
            chart1.Series[5].Points.AddY(cate05);
            chart1.Series[6].Points.AddY(cate06);
            chart1.Series[7].Points.AddY(cate07);
            chart1.Series[8].Points.AddY(cate08);
            chart1.Series[9].Points.AddY(cate09);

/*            chart1.Series[0].Points.AddXY(CATE0, cate00);
            chart1.Series[1].Points.AddXY(CATE1, cate01);
            chart1.Series[2].Points.AddXY(CATE2, cate02);
            chart1.Series[3].Points.AddXY(CATE3, cate03);
            chart1.Series[4].Points.AddXY(CATE4, cate04);
            chart1.Series[5].Points.AddXY(CATE5, cate05);
            chart1.Series[6].Points.AddXY(CATE6, cate06);
            chart1.Series[7].Points.AddXY(CATE7, cate07);
            chart1.Series[8].Points.AddXY(CATE8, cate08);
            chart1.Series[9].Points.AddXY(CATE9, cate09);*/
        }

    }
}
