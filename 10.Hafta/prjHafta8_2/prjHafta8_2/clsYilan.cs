using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjHafta8_2
{
    public class clsYilan
    {
        List<ucntrlParca> parcalar = new List<ucntrlParca>();
        List<clsYem> yemler = new List<clsYem>();
        int _iHareketMiktari = 50;
        int _iYon = 1;
        int _iToplamPuan = 0;
        int _iAlanW, _iAlanH;
        bool _bCarptiMi = false;

        Panel _pnlOyun;
        Label _lblPuan;
        Timer _timer;

        public clsYilan(int iParcaSayisi, Panel pnlOyun, Label lblPuan)
        {
            int iSayac, iX, iY;
            ucntrlParca parca;
            clsYem yem;
            this._lblPuan = lblPuan;
            this._pnlOyun = pnlOyun;

            this._iAlanW = pnlOyun.Width;
            this._iAlanH = pnlOyun.Height;

            for (iSayac = 0; iSayac < iParcaSayisi; iSayac++)
            {
                parca = new ucntrlParca();
                iX = (iParcaSayisi - iSayac) * parca.Width;
                iY = pnlOyun.Height / 2;
                parca.Ayarla(iSayac == 0 ? 1 : 0, iX, iY);
                parcalar.Add(parca);
                pnlOyun.Controls.Add(parca);
            }

            _timer = new Timer();
            _timer.Interval = 200;
            _timer.Enabled = true;
            _timer.Tick += _timer_Tick;

            yem = new clsYem(_pnlOyun);
            yemler.Add(yem);
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (!_bCarptiMi)
            {
                HareketEttir();
            }
            else
            {
                _timer.Enabled = false;
                MessageBox.Show("Oyun bitti...");
            }
        }

        public int iYon
        {
            set
            {
                _iYon = value;
            }
        }

        public void HareketEttir()
        {
            int iSayac = 0;
            ucntrlParca parca;

            for (iSayac = parcalar.Count - 1; iSayac > 0; iSayac--)
            {
                parcalar[iSayac].iX = parcalar[iSayac - 1].iX;
                parcalar[iSayac].iY = parcalar[iSayac - 1].iY;
            }

            parca = parcalar[0];
            switch (_iYon)
            {
                case 1: //saga
                    parca.iX = parca.iX + _iHareketMiktari;
                    break;
                case 2: //sola
                    parca.iX = parca.iX - _iHareketMiktari;
                    break;
                case 3: //asagi
                    parca.iY = parca.iY + _iHareketMiktari;
                    break;
                case 4: //yukari
                    parca.iY = parca.iY - _iHareketMiktari;
                    break;
            }
            this.YilanHareketEttiginde(this, new YilanHereketEttiSonucArgs(parca.iX, parca.iY, parca.Width));
        }

        public void YemYenildiginde(object sender, YemYenildiSonucArgs e)
        {
            clsYem yem;
            ucntrlParca parca;

            _iToplamPuan += e.iPuan;
            _lblPuan.Text = _iToplamPuan.ToString();
            yemler[e.iIndex].Dispose();
            yemler[e.iIndex] = null;

            yem = new clsYem(_pnlOyun);
            yemler.Add(yem);

            parca = new ucntrlParca();
            parca.Ayarla(0, parcalar[parcalar.Count()-1].iX, parcalar[parcalar.Count() - 1].iY);
            parcalar.Add(parca);
            _pnlOyun.Controls.Add(parca);
        }

        public void YilanHareketEttiginde(object sender, YilanHereketEttiSonucArgs e)
        {
            int iSayac;
            Rectangle parcaRectangle, yemRectangle;
            clsYem yem;
            if (
                e.iX < 0
                || e.iX > _iAlanW - e.iW
                || e.iY < 0
                || e.iY > _iAlanH - e.iW
                )
            {
                _bCarptiMi = true;
            }

            parcaRectangle = new Rectangle(e.iX, e.iY, e.iW, e.iW);

            for (iSayac = 0; iSayac < yemler.Count; iSayac++)
            {
                if (yemler[iSayac] != null)
                {
                    yem = yemler[iSayac];
                    yemRectangle = new Rectangle(yem.iX, yem.iY, yem.iW, yem.iW);
                    if (parcaRectangle.IntersectsWith(yemRectangle))
                    {
                        this.YemYenildiginde(this, new YemYenildiSonucArgs(yem.iPuan, iSayac));
                    }
                }
            }
        }
    }
}