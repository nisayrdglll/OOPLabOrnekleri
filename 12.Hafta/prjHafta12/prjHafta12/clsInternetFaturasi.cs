using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class clsInternetFaturasi:clsFatura
{
    public clsInternetFaturasi(int iKota,int iKullanilanGB)
    {
        //float fFazlaTutar=0;        
        //FazlaTutarHesapla( iKota, iKullanilanGB, ref fFazlaTutar);
        //FaturaTutariHesapla(iKota, fFazlaTutar, ref _fFaturaTutari);
        FazlaTutarHesapla(iKota, iKullanilanGB, ref _fFaturaTutari);
        FaturaTutariHesapla(iKota, ref _fFaturaTutari);
    }

    public void FazlaTutarHesapla(int iKota, int iKullanilanGB,ref float fFaturaTutari)
    {
        if (iKullanilanGB > iKota)
            fFaturaTutari += (iKullanilanGB - iKota) * 0.25f;
    }

    public void FaturaTutariHesapla(int iKota, ref float fFaturaTutari)
    {
        fFaturaTutari += iKota == 25 ? 60 : (iKota == 50 ? 80 : 110);
    }

    //public void FazlaTutarHesapla(int iKota, int iKullanilanGB, ref float fFazlaTutar)
    //{
    //    if (iKullanilanGB > iKota)
    //        fFazlaTutar += (iKullanilanGB - iKota) * 0.25f;
    //}

    //public void FaturaTutariHesapla(int iKota, float fFazlaTutar, ref float fFaturaTutari)
    //{
    //    fFaturaTutari = iKota == 25 ? 60 : (iKota == 50 ? 80 : 110);
    //    fFaturaTutari += fFazlaTutar;
    //}
}
