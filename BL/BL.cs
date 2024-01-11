using CS_DL;
namespace CS_BL;

public static class BL
{

    public static List<Calisan> Calisanlar = new List<Calisan>();
    public static List<Musteri> Musteriler = new List<Musteri>();


    public static bool CalisanEkle(Calisan c, out string error)
    {

        var res = DL.CalisanEkle(c.ID, c.Ad, c.Soyad, c.Telefon, c.IseBaslamaTarihi, c.Maas, out error);
        if (res != -1)
        {
            Calisanlar.Add(c);
            return true;
        }

        return false;
    }

    public static bool CalisanDuzenle(Calisan c, out string error)
    {

        var res = DL.CalisanGuncelle(c.ID, c.Ad, c.Soyad, c.Telefon, c.IseBaslamaTarihi, c.Maas, out error);
        if (res != -1)
        {
            var kisi = Calisanlar.Find(o => o.ID == c.ID);
            if (kisi != null)
            {
                kisi.Ad = c.Ad;
                kisi.Soyad = c.Soyad;
                kisi.Telefon = c.Telefon;
                kisi.IseBaslamaTarihi = c.IseBaslamaTarihi;
                kisi.Maas = c.Maas;
            }
            return true;
        }
        return false;
    }

    public static bool CalisanSil(Calisan c, out string error)
    {

        var res = DL.CalisanSil(c.ID, out error);
        if (res != -1)
        {
            var kisi = Calisanlar.Find(o => o.ID == c.ID);
            if (kisi != null)
            {
                Calisanlar.Remove(kisi);
            }

            return true;
        }
        return false;
    }

    public static bool CalisanlariYukle(out string error)
    {
        var liste = DL.TumCalisanlar(out error);
        if (liste == null)
            return false;
        else
        {
            Calisanlar.Clear();
            foreach (var e in liste)
            {
                Calisanlar.Add(
                    new Calisan
                    {
                        ID = e.calisanid,
                        Ad = e.ad,
                        Soyad = e.soyad,
                        Telefon = e.telefon,
                        IseBaslamaTarihi = e.isebaslamatarihi,
                        Maas = e.maas,

                    }
                    );
            }


        }
        return true;
    }
    public static bool MusteriEkle(Musteri m, out string error)
    {

        var res = DL.MusteriEkle(m.ID, m.Ad, m.Soyad, m.Telefon, m.Mail,out error);
        if (res != -1)
        {
            Musteriler.Add(m);
            return true;
        }

        return false;
    }

    public static bool MusteriDuzenle(Musteri m, out string error)
    {

        var res = DL.MusteriGuncelle(m.ID, m.Ad, m.Soyad, m.Telefon,m.Mail, out error);
        if (res != -1)
        {
            var kisi = Musteriler.Find(o => o.ID == m.ID);
            if (kisi != null)
            {
                kisi.Ad = m.Ad;
                kisi.Soyad = m.Soyad;
                kisi.Telefon = m.Telefon;
                kisi.Mail = m.Mail;

            }
            return true;
        }
        return false;
    }


    public static bool MusteriSil(Musteri m, out string error)
    {

        var res = DL.MusteriSil(m.ID, out error);
        if (res != -1)
        {
            var kisi = Musteriler.Find(o => o.ID == m.ID);
            if (kisi != null)
            {
                Musteriler.Remove(kisi);
            }

            return true;
        }
        return false;
    }

    public static bool MusterileriYukle(out string error)
    {
        var liste = DL.TumMusteriler(out error);
        if (liste == null)
            return false;
        else
        {
            Musteriler.Clear();
            foreach (var e in liste)
            {
                Musteriler.Add(
                    new Musteri
                    {
                        ID = e.musteriid,
                        Ad = e.ad,
                        Soyad = e.soyad,
                        Telefon = e.telefon,
                        Mail = e.mail
                    }
                    ) ;
            }


        }
        return true;
    }

}


public static class Ext
{
    public static float ToFloat(this string val)
    {
        float f = 0;
        if (float.TryParse(val, out f))
            return f;
        else
            return 0;
    }
}