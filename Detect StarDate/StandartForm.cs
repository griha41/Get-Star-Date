using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Detect_StarDate
{
    public partial class StandartForm : Form
    {
        public StandartForm()
        {
            InitializeComponent();
        }

        private void Conv_Click(object sender, EventArgs e)
        {
            Star_Date.Text = ConvertDate_toStarDate(DateTime.Parse(CurrentDate.Text));
            STO_StarDate.Text = ConvertStarDate_toSTO(Star_Date.Text);
        }

        private string ConvertDate_toStarDate(DateTime Date_Conv)
        {
            DateTime Epoch = DateTime.Parse("01.01.2000 00:00:00");
            double daysSinceEpoch = (Date_Conv.ToOADate() - Epoch.ToOADate());
            double stardate = daysSinceEpoch / (double)36525;    
            stardate = stardate * 1e5;

            return stardate.ToString("F2").Replace(',','.');
        }

        private string ConvertStarDate_toSTO(string StarDate)
        {
            double SD = double.Parse(StarDate.Replace('.', ','));
            double STO_SD = SD + 77603.69;
            return STO_SD.ToString("F2").Replace(',', '.');
        }
    }
}
