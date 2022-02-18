using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorCredit
{
    public partial class frmCalculatorCredit : Form
    {
        public frmCalculatorCredit()
        {
            InitializeComponent();
        }

        //Accesare formular de la distanta
        frmDetaliiCredit frmDetaliiCredit;

        private void frmCalculatorCredit_Load(object sender, EventArgs e)
        {
            frmDetaliiCredit = new frmDetaliiCredit();
        }

        private void btnRataLunara_Click(object sender, EventArgs e)
        {
            frmDetaliiCredit.Show();
            frmDetaliiCredit.txtRataLunara.ReadOnly = true;  //readonly= true => Casuta rata lunara nu poate fi utilizata sa introduc date in ea . ea poate doar sa afiseze mesajul
            frmDetaliiCredit.txtRataLunara.TabStop = false;// tabstop=false => face cursorul sa sara peste cutia de text rata lunara utilizant tasta tab
            frmDetaliiCredit.txtNumarPlati.ReadOnly = false;
            frmDetaliiCredit.txtNumarPlati.TabStop = true;
            frmDetaliiCredit.tlsOptiuni.Text = "Rara Lunara";
            frmDetaliiCredit.txtRataLunara.Text = "";
            frmDetaliiCredit.txtSumaImprumutata.Text = "";
            frmDetaliiCredit.txtRataDobanda.Text = "";
            frmDetaliiCredit.txtNumarPlati.Text = "";
            frmDetaliiCredit.btnCalculeaza.Enabled = true;
            frmDetaliiCredit.lstAfisare.Items.Clear();
            frmDetaliiCredit.txtSumaImprumutata.Focus();//metoda focus determina focusarea cursorului pe casuta suma imprumutata atunci cand incepem o noua calculatie

        }

        private void mnuOptiuniRataLunara_Click(object sender, EventArgs e)
        {
            frmDetaliiCredit.Show();
            frmDetaliiCredit.txtRataLunara.ReadOnly = true; 
            frmDetaliiCredit.txtRataLunara.TabStop = false;
            frmDetaliiCredit.txtNumarPlati.ReadOnly = false;
            frmDetaliiCredit.txtNumarPlati.TabStop = true;
            frmDetaliiCredit.tlsOptiuni.Text = "Rara Lunara";
            frmDetaliiCredit.txtRataLunara.Text = "";
            frmDetaliiCredit.txtSumaImprumutata.Text = "";
            frmDetaliiCredit.txtRataDobanda.Text = "";
            frmDetaliiCredit.txtNumarPlati.Text = "";
            frmDetaliiCredit.btnCalculeaza.Enabled = true;
            frmDetaliiCredit.lstAfisare.Items.Clear();
            frmDetaliiCredit.txtSumaImprumutata.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuOptiuniExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuOptiuniDurata_Click(object sender, EventArgs e)
        {
            frmDetaliiCredit.Show();
            frmDetaliiCredit.txtNumarPlati.ReadOnly = true;
            frmDetaliiCredit.txtNumarPlati.TabStop = false;
            frmDetaliiCredit.txtRataLunara.ReadOnly = false;
            frmDetaliiCredit.txtRataLunara.TabStop = true;
            frmDetaliiCredit.tlsOptiuni.Text = "Numar de plati";
            frmDetaliiCredit.txtRataLunara.Text = "";
            frmDetaliiCredit.txtSumaImprumutata.Text = "";
            frmDetaliiCredit.txtRataDobanda.Text = "";
            frmDetaliiCredit.txtNumarPlati.Text = "";
            frmDetaliiCredit.btnCalculeaza.Enabled = true;
            frmDetaliiCredit.lstAfisare.Items.Clear();
            frmDetaliiCredit.txtSumaImprumutata.Focus();
        }

        private void btnDurata_Click(object sender, EventArgs e)
        {
            frmDetaliiCredit.Show();
            frmDetaliiCredit.txtNumarPlati.ReadOnly = true;
            frmDetaliiCredit.txtNumarPlati.TabStop = false;
            frmDetaliiCredit.txtRataLunara.ReadOnly = false;
            frmDetaliiCredit.txtRataLunara.TabStop = true;
            frmDetaliiCredit.tlsOptiuni.Text = "Numar de plati";
            frmDetaliiCredit.txtRataLunara.Text = "";
            frmDetaliiCredit.txtSumaImprumutata.Text = "";
            frmDetaliiCredit.txtRataDobanda.Text = "";
            frmDetaliiCredit.txtNumarPlati.Text = "";
            frmDetaliiCredit.btnCalculeaza.Enabled = true;
            frmDetaliiCredit.lstAfisare.Items.Clear();
            frmDetaliiCredit.txtSumaImprumutata.Focus();
        }
    }
}
