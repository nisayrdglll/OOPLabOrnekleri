using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsElektrikFaturasi : clsFatura
{
    public clsElektrikFaturasi(params float[] fKiloWatt)
    {
       if(fKiloWatt.Length==1)
        {
            //tek zamanli
            TekZamanliFaturaHesapla(fKiloWatt[0],ref _fFaturaTutari);
        }
        else
        {
            //cok zamanli
            CokZamanliFaturaHesapla(ref _fFaturaTutari, fKiloWatt);
        }
    }

    void TekZamanliFaturaHesapla(float fKiloWatt, ref float fFaturaTutari)
    {
        fFaturaTutari = fKiloWatt * 0.551544f;
    }

    void CokZamanliFaturaHesapla(ref float fFaturaTutari,params float[] fKiloWatt)
    {
        fFaturaTutari = fKiloWatt[0] * 0.559104f;
        fFaturaTutari = fFaturaTutari + fKiloWatt[1] * 0.920586f;
        fFaturaTutari = fFaturaTutari + fKiloWatt[2] * 0.267352f;
    }
}
