using System;
using System.Windows.Forms;

namespace CalculatorCredit
{
    public partial class frmDetaliiCredit : Form
    {
        public frmDetaliiCredit()
        {
            InitializeComponent();
        }

        private void frmDetaliiAngajati_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            frmDetaliiCredit obDetaliiAngajati = new frmDetaliiCredit();
            this.Hide();
           
        }

        private void mnuOptiuniCreditExit_Click(object sender, EventArgs e)
        {
            frmDetaliiCredit obDetaliiAngajati = new frmDetaliiCredit();
            this.Hide();
        }

        private void mnuOptiuniCreditRataLunara_Click(object sender, EventArgs e)
        {
            txtRataLunara.ReadOnly = true;
            txtRataLunara.TabStop = false;
            txtNumarPlati.ReadOnly = false;
            txtNumarPlati.TabStop = true;
            tlsOptiuni.Text = "Rara Lunara";
            txtRataLunara.Text = "";
            txtSumaImprumutata.Text = "";
            txtRataDobanda.Text = "";
            txtNumarPlati.Text = "";
            btnCalculeaza.Enabled = true;
            lstAfisare.Items.Clear();
            txtSumaImprumutata.Focus();
     
        }

        private void mnuOptiuniCreditDurata_Click(object sender, EventArgs e)
        {
            txtNumarPlati.ReadOnly = true;
            txtNumarPlati.TabStop = false;
            txtRataLunara.ReadOnly = false;
            txtRataLunara.TabStop = true;
            tlsOptiuni.Text = "Numar de plati";
            txtRataLunara.Text = "";
            txtSumaImprumutata.Text = "";
            txtRataDobanda.Text = "";
            txtNumarPlati.Text = "";
            btnCalculeaza.Enabled = true;
            lstAfisare.Items.Clear();
            txtSumaImprumutata.Focus();
        }

        //metoda calculeazaratalunara va calcula  rata lunara pentru un anumit credit
        public double CalculeazaRataLunara(double sumaImprumutata, double rataDobanda, int numarPlati)
        {
            double rataLunara;

            double dobandaLunara = rataDobanda / 1200;

            if (rataDobanda == 0)
            {
                rataLunara = sumaImprumutata / numarPlati;
            }
            else
            {
                double multiplicator = Math.Pow(1 + dobandaLunara, numarPlati);

                rataLunara = sumaImprumutata * dobandaLunara * multiplicator / (multiplicator - 1);
            }

            return rataLunara;
        }

        //metoda calculeaza numar plati va calcula numarul de plati sau durata unui credit
        public int CalculeazaNumarPlati(double sumaImprumutata, double rataDobanda, double rataLunara)
        {
            int numarPlati;

            double dobandaLunara = rataDobanda / 1200;

            if (rataDobanda == 0)
            {
                numarPlati = (int)(sumaImprumutata / rataLunara);
            }
            else
            {
                numarPlati = (int)((Math.Log(rataLunara) - Math.Log(rataLunara - sumaImprumutata * dobandaLunara))
                    / Math.Log(1 + dobandaLunara));

            }


            return numarPlati;
        }

        //metoda afiseaza un rezultat al amrotizarii imprumutului si va afisa rezultatul in lista creata
        public void AfisareAmortizareImprumut(double sumaImprumtata, double rataDobanda, double rataLunara, double plataFinala, int numarPlati)
        {
            lstAfisare.Items.Add("Suma Imprumutata: " + String.Format("{0:f2}", sumaImprumtata +" Lei"));
            lstAfisare.Items.Add("\r\nRata de Dobanda: " + String.Format("{0:f2}", rataDobanda + " %"));
            lstAfisare.Items.Add("\r\nRata Lunara: " + String.Format("{0:f2}", rataLunara + "Lei"));
            lstAfisare.Items.Add("\r\n" + Convert.ToString(numarPlati - 1) + " Numar de Plati de :" + String.Format("{0:f2}", rataLunara + " Lei"));
            lstAfisare.Items.Add("\r\nPlata Finala de: " + String.Format("{0:f2}", plataFinala + " Lei"));
            lstAfisare.Items.Add("\r\nPlata Totala de: " + String.Format("{0:f2}", (numarPlati - 1) * rataLunara + plataFinala + " Lei"));
            lstAfisare.Items.Add("\r\nPlata Dobanda de: " + String.Format("{0:f2}", (numarPlati - 1) * rataLunara + plataFinala - sumaImprumtata + " Lei"));

        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            //declarare variabile
            double plataFinala, soldImprumut, rataDobanda, sumaImprumutata, rataLunara;
            int numarPlati;
            //metoda tryparse este utilizata pentru an converti datele de tip sir(string) in date de tip numeric
            double.TryParse(txtSumaImprumutata.Text, out sumaImprumutata);
            double.TryParse(txtRataDobanda.Text , out rataDobanda);
            double.TryParse(txtRataLunara.Text, out rataLunara);
            int.TryParse(txtNumarPlati.Text, out numarPlati);

            double rataDobandaLunara = rataDobanda / 1200;

            //proprietatea enable = false va face ca butonul sa fie dezactivat dupa ce apasam pe el si sa
            // afiseze mesajul calculeaza 
            // enable = true -> va activa butonul calculeaza 
            //f2 = data de tip real cu 2 zecimale dupa virgule
            if (txtSumaImprumutata.Text != "" && txtNumarPlati.Text != "" && txtRataDobanda.Text != "" && txtSumaImprumutata.Text != "0"
                     && txtNumarPlati.Text != "0")
            {
                if (!double.TryParse(txtSumaImprumutata.Text, out sumaImprumutata))
                {
                    MessageBox.Show("Trebuie sa introduceti o valoare numerica", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSumaImprumutata.Focus();
                    return;
                }
                else if (!int.TryParse(txtNumarPlati.Text, out numarPlati))
                {
                    MessageBox.Show("Trebuie sa introduceti o valoare numerica", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumarPlati.Focus();
                    return;
                }
                else if (!double.TryParse(txtRataDobanda.Text, out rataDobanda))
                {
                    MessageBox.Show("Trebuie sa introduceti o valoare numerica", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRataDobanda.Focus();
                    return;
                }
                else
                {
                    rataLunara = CalculeazaRataLunara(sumaImprumutata, rataDobanda, numarPlati);
                    txtRataLunara.Text = String.Format("{0:f2}", rataLunara);
                }

            }
            else if (txtSumaImprumutata.Text != "" && txtRataLunara.Text != "" && txtRataDobanda.Text != "" && txtSumaImprumutata.Text != "0")
            {
                if (!double.TryParse(txtSumaImprumutata.Text, out sumaImprumutata))
                {
                    MessageBox.Show("Trebuie sa introduceti o valoare numerica", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSumaImprumutata.Focus();
                    return;
                }
                else if (!double.TryParse(txtRataDobanda.Text, out rataDobanda))
                {
                    MessageBox.Show("Trebuie sa introduceti o valoare numerica", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRataDobanda.Focus();
                    return;
                }
                else if (!double.TryParse(txtRataLunara.Text, out rataLunara))
                {
                    MessageBox.Show("Trebuie sa introduceti o valoare numerica", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRataLunara.Focus();
                    return;
                }
                else if (rataLunara > sumaImprumutata)
                {
                    MessageBox.Show("Rata Lunara trebuie sa fie mai mica sau egala cu suma Imprumutata", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRataLunara.Focus();
                    return;
                }
                else
                {
                    if (rataLunara <= (sumaImprumutata * rataDobandaLunara + 1.0))
                    {
                        if (MessageBox.Show("Plata minima trebuie sa fie Lei " + String.Format("{0:f2}", (int)(sumaImprumutata * rataDobandaLunara + 1.0)) + "\r\n" +
                        "Doriti sa utilzati plata minima?", "Input Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            txtRataLunara.Text = String.Format("{0:f2}", (int)(sumaImprumutata * rataDobandaLunara + 1.0));
                            rataLunara = Convert.ToDouble(txtRataLunara.Text);
                        }
                        else
                        {
                            txtRataLunara.Focus();
                            return;
                        }
                    }

                }

                numarPlati = CalculeazaNumarPlati(sumaImprumutata, rataDobanda, rataLunara);
                txtNumarPlati.Text = String.Format("{0:f2}", numarPlati);
            }
            else
            {
                MessageBox.Show("Trebuie sa introduceti o valoare", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //partea de cod ce va calcula rata de plata finala
            double.TryParse(txtRataLunara.Text, out rataLunara);

            soldImprumut = sumaImprumutata;
            for (int contor = 1; contor <= numarPlati - 1; contor++)
            {
                soldImprumut += soldImprumut * rataDobandaLunara - rataLunara;
            }

            plataFinala = soldImprumut;
            if (plataFinala > rataLunara)
            {
                soldImprumut += soldImprumut * rataDobandaLunara - rataLunara;
                plataFinala = soldImprumut;
                numarPlati++;
                txtNumarPlati.Text = numarPlati.ToString();
            }

            AfisareAmortizareImprumut(sumaImprumutata, rataDobanda, rataLunara, plataFinala, numarPlati);

            btnCalculeaza.Enabled = false;
            btnCalculeaza.Text = "Calculeaza";
        }

        private void btnNouaCalculatie_Click(object sender, EventArgs e)
        {
            txtSumaImprumutata.Text = "";
            txtNumarPlati.Text = "";
            txtRataDobanda.Text = "";
            txtRataLunara.Text = "";
            btnCalculeaza.Enabled = true;
            lstAfisare.Items.Clear();
        }
    }
}