using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Text;

namespace Detect_StarDate
{
    public partial class Star_Trek_Form : Form
    {
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);
        private PrivateFontCollection fonts = new PrivateFontCollection();
        Font myFont;

        public Star_Trek_Form()
        {
            InitializeComponent();

            byte[] fontData = Properties.Resources.Montalban_Condensed;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Montalban_Condensed.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Montalban_Condensed.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            myFont = new Font(fonts.Families[0], 8F);
        }

        private void Get_StarDate_Click(object sender, EventArgs e)
        {
            CurrentDate.Value = DateTime.Now;
            if (IsUTC.Checked)
            {
                TNG_StarDate.Text = ConvertDate_toStarDate(CurrentDate.Value.ToUniversalTime());
            }
            else
            {
                TNG_StarDate.Text = ConvertDate_toStarDate(CurrentDate.Value);
            }

            STO_StarDate.Text = ConvertStarDate_toSTO(TNG_StarDate.Text);
        }

        private string ConvertDate_toStarDate(DateTime Date_Conv)
        {
            DateTime Epoch = DateTime.Parse("01.01.2000 00:00:00");
            double daysSinceEpoch = (Date_Conv.ToOADate() - Epoch.ToOADate());
            double stardate = daysSinceEpoch / (double)36525;
            stardate = stardate * 1e5;

            return stardate.ToString("F2").Replace(',', '.');
        }

        private string ConvertStarDate_toSTO(string StarDate)
        {
            double SD = double.Parse(StarDate.Replace('.', ','));
            double STO_SD = SD + 77603.69;
            return STO_SD.ToString("F2").Replace(',', '.');
        }

        private void Star_Trek_Form_Load(object sender, EventArgs e)
        {
            this.Font = myFont;
            CurrentDate.Value = DateTime.Now;
            Get_StarDate.PerformClick();
        }

        private void CopyToClipBoard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Star date TNG: " + TNG_StarDate.Text + " star date STO: " + STO_StarDate.Text);
        }
    }
}
