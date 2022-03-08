using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitMasa
{
    public partial class Artykul : Form
    {
        public Artykul()
        {
            InitializeComponent();
        }

        private void btnStronaGlowna_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnDania_Click(object sender, EventArgs e)
        {
            Dania dania = new Dania();
            dania.Show();
            this.Hide();
        }

        private void btnBMI_BMR_Click(object sender, EventArgs e)
        {
            BMI_BMR bmi_bmr = new BMI_BMR();
            bmi_bmr.Show();
            this.Hide();
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            Progress progress = new Progress();
            progress.Show();
            this.Hide();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
        public double[] Makro = new double[4];
        public double[] Stek = new double[4];

        public event EventHandler<double[]> DodajArtykul;
        public event EventHandler<double[]> DodajStek;
        private void DodajPrzepis_Click(object sender, EventArgs e)
        {
            Makro[0] = 825.5;
            Makro[1] = 57.5;
            Makro[2] = 44;
            Makro[3] = 85;
            this.Hide();
            this.DodajArtykul?.Invoke(this, new double[] { Makro[0], Makro[1], Makro[2], Makro[3]});

            Stek[0] = 900;
            Stek[1] = 30;
            Stek[2] = 45;
            Stek[3] = 110;
            this.DodajStek?.Invoke(this, new double[] { Stek[0], Stek[1], Stek[2], Stek[3]});
        }
    }
}
