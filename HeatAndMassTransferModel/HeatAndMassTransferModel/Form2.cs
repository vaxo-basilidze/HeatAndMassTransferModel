using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeatAndMassTransferModel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Location = new Point(100, 100);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            CalculateDeathTime();
        }

        private void CalculateDeathTime()
        {
            var t1 = Convert.ToDouble(GaHr.Text) + (Convert.ToDouble(GaMin.Text)) / 60;
            var y1 = Convert.ToDouble(Temp1.Text);
            var t2 = Convert.ToDouble(GaHr1.Text) + (Convert.ToDouble(GaMin1.Text)) / 60;
            var y2 = Convert.ToDouble(Temp2.Text);
            var y0 = Convert.ToDouble(Temp0.Text);
            var ye = Convert.ToDouble(Temp.Text);

            //shezgudvebi

            //if (GaHr.Text == null) t1 = (Convert.ToDouble(GaMin.Text)) / 60;
            //if (GaMin == null) t1 = Convert.ToDouble(GaHr.Text);
            //if (GaHr1.Text == null) t2 = (Convert.ToDouble(GaMin1.Text)) / 60;
            //if (GaMin1 == null) t2 = Convert.ToDouble(GaHr1.Text);
            //if (GaMin == null && GaHr == null) throw new Exception("ველები არ უნდა იყოს ცარიელი");
            //if (GaMin1 == null && GaHr1 == null) throw new Exception("ველები არ უნდა იყოს ცარიელი");

            //gamotvla

            var T = (t2 - t1) / (Math.Log((y1-ye)/(y0-ye))-Math.Log((y2-ye)/(y0-ye)));

            var t0 = t1 + T * Math.Log((y1-ye)/(y0-ye));

            Result.Text = (Math.Truncate(t0)).ToString();
            Result1.Text = Math.Round(((100 * (t0 - Math.Floor(t0)))/100)*60).ToString();
        }

        private void GaHr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
