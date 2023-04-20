using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class YemYenildiSonucArgs : EventArgs
{
    int _iPuan;
    int _iIndex;

    public YemYenildiSonucArgs(int iPuan, int iIndex)
    {
        this._iPuan = iPuan;
        this._iIndex = iIndex;
    }

    public int iPuan
    {
        get
        {
            return _iPuan;
        }
    }

    public int iIndex
    {
        get
        {
            return _iIndex;
        }
    }
}

public class YilanHereketEttiSonucArgs : EventArgs
{
    int _iX;
    int _iY;
    int _iW;

    public YilanHereketEttiSonucArgs(int iX,int iY,int iW)
    {
        this._iX = iX;
        this._iY = iY;
        this._iW = iW;
    }

    public int iX
    {
        get
        {
            return _iX;
        }
    }

    public int iY
    {
        get
        {
            return _iY;
        }
    }

    public int iW
    {
        get
        {
            return _iW;
        }
    }
}