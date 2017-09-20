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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void Form3_Load(object sender, EventArgs e)
        {
            Location = new Point(100, 100);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GaMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void GaHr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Temp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var V = Convert.ToDouble(Vol.Text);
            var tt = (Date2.Value.Subtract(Date1.Value)).ToString().Substring(0, (Date2.Value.Subtract(Date1.Value)).ToString().IndexOf('.'));
            var Q0 = Convert.ToDouble(Mass.Text);
            var rin = Convert.ToDouble(In.Text);
            var cin = Convert.ToDouble(Cin.Text);
            var a = Convert.ToDouble(Coef.Text);
            var NextDate = Date2.Value;
            var t = Convert.ToDouble(tt)/365;
            var Qt = V * cin + (Math.Exp((-rin*t) / V))*(Q0 - V * cin);
            Qt = Math.Round(Qt, 2);
            TotalMass.Text = Qt.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var V = Convert.ToDouble(Vol.Text);
            var a = Convert.ToDouble(Coef.Text);
            var rin = Convert.ToDouble(In.Text);

            var tau = (V * Math.Log(a)) / rin;
            var Days = tau * 365;
            Date3.Value = Date1.Value.AddDays(tau);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
