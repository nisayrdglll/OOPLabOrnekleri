using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsSuFaturasi : clsFatura
{
    
    public clsSuFaturasi(int iKullanilanSuMiktari)
    {
        int iFazlaSuMiktari;
        float fCTVTutari;

        FazlaSuMiktariHesapla(iKullanilanSuMiktari, out iFazlaSuMiktari);

        CTVHesapla(iKullanilanSuMiktari, out fCTVTutari);

        FaturaTutariHesapla(iFazlaSuMiktari, fCTVTutari, ref _fFaturaTutari);
    }

    public void FazlaSuMiktariHesapla(int iKullanilanSuMiktari,out int iFazlaSuMiktari)
    {
        if (iKullanilanSuMiktari > 3)
            iFazlaSuMiktari = iKullanilanSuMiktari - 3;
        else
            iFazlaSuMiktari = 0;
    }

    public void CTVHesapla(int iKullanilanSuMiktari, out float fCTVTutari)
    {
        fCTVTutari = iKullanilanSuMiktari * 0.50f;
    }

    public void FaturaTutariHesapla(int iFazlaSuMiktari, float fCTVTutari, ref float fFaturaTutari)
    {
        fFaturaTutari = iFazlaSuMiktari * 5.56f;
        fFaturaTutari = fFaturaTutari + fCTVTutari;
    }
}
