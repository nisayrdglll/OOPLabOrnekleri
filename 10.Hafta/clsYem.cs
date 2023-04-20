using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

public enum YemTurleri
{
    Kiraz = 1,
    Lime = 2,
    Uzum = 3,
    Karpuz = 4,
    Ejder = 5,
}

public class clsYem:IDisposable
{
    int _iX;
    int _iY;
    int _iW;
    int _iH;
    int _iTur;
    int _iPuan;
    PictureBox _pb;

    public clsYem(Panel pnlAlan)
    {
        int iTur;
        string sDosyaYolu;
        Random rnd= new Random();
        iTur = rnd.Next(5) + 1;
        this._iTur = iTur;
        this._iPuan = iTur * 10;
        this._iW = 50;
        this._iH = 50;

        this._iX = rnd.Next((pnlAlan.Width- this._iW)/50)*50;
        this._iY = rnd.Next((pnlAlan.Height - this._iH) / 50) * 50;

        sDosyaYolu ="yemler\\" + iTur.ToString() + ".png";
        _pb = new PictureBox();
        _pb.Width = this._iW;
        _pb.Height = this._iH;
        _pb.ImageLocation = sDosyaYolu;
        _pb.SizeMode = PictureBoxSizeMode.StretchImage;
        _pb.Location = new Point(this._iX, this._iY);
        pnlAlan.Controls.Add(_pb);
    }


    public int iX
    {
        get
        {
            return _iX;
        }
        set
        {
            _iX = value;
        }
    }

    public int iY
    {
        get
        {
            return _iY;
        }
        set
        {
            _iY = value;
        }
    }

    public int iW
    {
        get
        {
            return _iW;
        }
        set
        {
            _iW = value;
        }
    }

    public int iPuan
    {
        get
        {
            return _iPuan;
        }
    }

    public void Dispose()
    {
        this._pb.Visible = false;
        this._pb = null;
        GC.SuppressFinalize(this);
    }
}
