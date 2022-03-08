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
    public partial class Dania : Form
    {
        public Dania()
        {
            InitializeComponent();
        }

        private void btnStronaGlowna_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
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

        private void btnCzytaj1_Click(object sender, EventArgs e)
        {
            Artykul artykul = new Artykul();
            Form1 x = new Form1();
            artykul.DodajArtykul += x.DodajSniadanie;

            this.Hide();
            artykul.Show();
        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void btnCzytaj2_Click(object sender, EventArgs e)
        {
            Artykul stek = new Artykul();
            this.Hide();
            stek.Show();
            stek.label3.Text = "Stek z frytkami";
            stek.label5.Text = @"Zamarynuj steki:

        Kotlety opłucz, wysusz i zalej marynatą z oleju, sosu worchester i wyciśniętego czosnku 
        - schowaj do lodówki najlepiej na noc.

        Przygotuj masło:

        Masło w temperaturze pokojowej wymieszaj widelcem z posiekaną kolendrą i wyciśniętym jednym ząbkiem czosnku, 
        uformuj gruba roladę, owiń w folię spożywczą i włóż do lodówki najlepiej na noc.

        Przygotuj frytki:

        Obierz ziemniaki, pokrój w grube słupki grubości mniej więcej 1cm i opłucz pod zimną wodą.
        Przełóż ziemniaki na papier kuchenny i dokładnie je przed smażeniem osusz.
        Rozgrzej w garnku olej (bądź frytownicę do 180 stopni) - jest gotowy do 
        smażenia, kiedy wokół włożonej doń drewnianej łyżki powstają bąble.
        Frytki wkładamy do garnka w sitku bądź w sitku do gotowania na parze.
        Smaż jw przez około 8 minut, aż będą lekko rumiane na krawędziach.
        Następnie wyjmij je z oleju, przełóż do miski wyłożonej papierem kuchennym, odsącz z tłuszczu i dobrze wystudź.
        Przełóż do pojemnika i zamroź.";
            Form1 x = new Form1();
            stek.DodajStek += x.DodajSniadanie;
        }
    }
}
