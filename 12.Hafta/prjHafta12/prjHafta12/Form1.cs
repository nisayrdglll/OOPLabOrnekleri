using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHafta12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            clsElektrikFaturasi elektrik;
            clsInternetFaturasi internet;
            clsSuFaturasi su;
            float fKiloWatt, fGunduz = 0, fPuant = 0, fGece = 0;
            float fFaturaTutari = 0;
            int iKota, iKullanilanGB = 0;
            int iKullanilanSuMiktari;
            bool bDonusumDogruMu = true;

            switch (tabFaturalar.SelectedIndex)
            {
                case 0://elektrik
                    if (rbTekZamanli.Checked)
                    {
                        bDonusumDogruMu = float.TryParse(txtKiloWatt.Text, out fKiloWatt);
                        elektrik = new clsElektrikFaturasi(fKiloWatt);
                        fFaturaTutari = elektrik.fFaturaTutari;
                    }
                    else
                    {
                        bDonusumDogruMu = float.TryParse(txtGunduz.Text, out fGunduz);
                        bDonusumDogruMu = bDonusumDogruMu && float.TryParse(txtPuant.Text, out fPuant);
                        bDonusumDogruMu = bDonusumDogruMu && float.TryParse(txtGece.Text, out fGece);
                        elektrik = new clsElektrikFaturasi(fGunduz, fPuant, fGece);
                        fFaturaTutari = elektrik.fFaturaTutari;
                    }
                    break;
                case 1://internet
                    bDonusumDogruMu = int.TryParse(txtKota.Text, out iKota);
                    bDonusumDogruMu = bDonusumDogruMu && int.TryParse(txtKullanilanGB.Text, out iKullanilanGB);
                    internet = new clsInternetFaturasi(iKota, iKullanilanGB);
                    fFaturaTutari = internet.fFaturaTutari;
                    break;
                case 2://su
                    bDonusumDogruMu = int.TryParse(txtKullanilanSuMiktari.Text, out iKullanilanSuMiktari);
                    su = new clsSuFaturasi(iKullanilanSuMiktari);
                    fFaturaTutari = su.fFaturaTutari;
                    break;
            }

            if (!bDonusumDogruMu)
            {
                fFaturaTutari = 0;
                MessageBox.Show("SENİN PROGRAM BOZUHHH BOZUHHH");
            }

            lblFaturaTutari.Text = fFaturaTutari.ToString();
        }
    }
}
