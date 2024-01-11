#define MySQL

#if MySQL
using DbConnection = MySql.Data.MySqlClient.MySqlConnection;
using DbConnectionStringBuilder = MySql.Data.MySqlClient.MySqlConnectionStringBuilder;
using DbCommand = MySql.Data.MySqlClient.MySqlCommand;
#endif

using System.Data.Common;

namespace CS_DL;
public static class DL
{

# if MySQL 
#endif



    static DbConnection conn = new(new DbConnectionStringBuilder()
    {
#if MySQL
        Server = "localhost", //gerçek durumda server ip'si
        UserID = "root", //veri tabanı kullanıcı adı
        Password = "5545228936Zm",
        Database = "coffeeshop",
        //SslMode=MySqlConnector.MySqlSslMode.None,
        //AllowPublicKeyRetrieval = true,
#endif
    }.ConnectionString);

    public static int CalisanEkle(String calisanid, string ad, string soyad, string telefon, DateTime isebaslamatarihi, float maas,
        out string error)
    {
        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string komut = "calisanekle";
            DbCommand com = new DbCommand(komut, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure

            };
            com.Parameters.AddWithValue("in_calisanid", calisanid);
            com.Parameters.AddWithValue("in_ad", ad);
            com.Parameters.AddWithValue("in_soyad", soyad);
            com.Parameters.AddWithValue("in_telefon", telefon);
            com.Parameters.AddWithValue("in_isebaslamatarihi", isebaslamatarihi);
            com.Parameters.AddWithValue("in_maas", maas);
            error = "";
            return com.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            error = ex.Message;
            return -1;
        }
        finally
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }

    public static int CalisanGuncelle(String calisanid, string ad, string soyad, string telefon, DateTime isebaslamatarihi, float maas,
      out string error)
    {
        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string komut = "calisanguncelle";
            DbCommand com = new DbCommand(komut, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure

            };
            com.Parameters.AddWithValue("in_calisanid", calisanid);
            com.Parameters.AddWithValue("in_ad", ad);
            com.Parameters.AddWithValue("in_soyad", soyad);
            com.Parameters.AddWithValue("in_telefon", telefon);
            com.Parameters.AddWithValue("in_isebaslamatarihi", isebaslamatarihi);
            com.Parameters.AddWithValue("in_maas", maas);
            error = "";
            return com.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            error = ex.Message;
            return -1;
        }
        finally
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }

    public static int CalisanSil(String calisanid, out string error)
    {
        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string komut = "calisansil";
            DbCommand com = new DbCommand(komut, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("in_calisanid", calisanid);

            error = "";
            return com.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            error = ex.Message;
            return -1;
        }
        finally
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }


    public static int MusteriEkle(String musteriid, String ad, String soyad, String telefon, string mail,
      out string error)
    {
        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string komut = "musteriekle";
            DbCommand com = new DbCommand(komut, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure

            };
            com.Parameters.AddWithValue("in_musteriid", musteriid);
            com.Parameters.AddWithValue("in_ad", ad);
            com.Parameters.AddWithValue("in_soyad", soyad);
            com.Parameters.AddWithValue("in_telefon", telefon);
            com.Parameters.AddWithValue("in_mail", mail);

            error = "";
            return com.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            error = ex.Message;
            return -1;
        }
        finally
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }

    public static int MusteriGuncelle(String musteriid, String ad, String soyad, String telefon, string mail,
  out string error)
    {
        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string komut = "musteriguncelle";
            DbCommand com = new DbCommand(komut, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure

            };
            com.Parameters.AddWithValue("in_musteriid", musteriid);
            com.Parameters.AddWithValue("in_ad", ad);
            com.Parameters.AddWithValue("in_soyad", soyad);
            com.Parameters.AddWithValue("in_telefon", telefon);
            com.Parameters.AddWithValue("in_mail", mail);

            error = "";
            return com.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            error = ex.Message;
            return -1;
        }
        finally
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }

    public static int MusteriSil(String musteriid, out string error)
    {
        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string komut = "musterisil";
            DbCommand com = new DbCommand(komut, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("in_musteriid", musteriid);

            error = "";
            return com.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            error = ex.Message;
            return -1;
        }
        finally
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }

    public static List<(string musteriid,
                      string ad,
                      string soyad,
                      string telefon,
                      string mail
                      )> TumMusteriler(out string error)
    {

        var liste = new List<(string, string, string, string,string)>();

        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string komut = "tummusteriler";
            DbCommand com = new DbCommand(komut, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure

            };


            error = "";
            var dr = com.ExecuteReader();
            {
                while (dr.Read())
                {
                    liste.Add(
                        (dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString(),
                        dr[4].ToString())
                        );
                }
                return liste;
            }

        }
        catch (Exception ex)
        {

            error = ex.Message;
            return null;
        }
        finally
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }


    }


    public static int UrunEkle(String urunid, String urunadi, float fiyat, int stokmiktari, string kategori,
        string aciklama,
        out string error)
    {
        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string komut = "urunekle";
            DbCommand com = new DbCommand(komut, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure

            };
            com.Parameters.AddWithValue("in_urunid", urunid);
            com.Parameters.AddWithValue("in_urunadi", urunadi);
            com.Parameters.AddWithValue("in_fiyat", fiyat);
            com.Parameters.AddWithValue("in_stokmiktari", stokmiktari);
            com.Parameters.AddWithValue("in_kategori", kategori);
            com.Parameters.AddWithValue("in_aciklama", aciklama);

            error = "";
            return com.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            error = ex.Message;
            return -1;
        }
        finally
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }

    public static int UrunGuncelle(String urunid, String urunadi, float fiyat, int stokmiktari, string kategori,
    string aciklama,
    out string error)
    {
        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string komut = "urunguncelle";
            DbCommand com = new DbCommand(komut, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure

            };
            com.Parameters.AddWithValue("in_urunid", urunid);
            com.Parameters.AddWithValue("in_urunadi", urunadi);
            com.Parameters.AddWithValue("in_fiyat", fiyat);
            com.Parameters.AddWithValue("in_stokmiktari", stokmiktari);
            com.Parameters.AddWithValue("in_kategori", kategori);
            com.Parameters.AddWithValue("in_aciklama", aciklama);

            error = "";
            return com.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            error = ex.Message;
            return -1;
        }
        finally
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }






    public static int UrunSil(String urunid, out string error)
    {
        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string komut = "urunsil";
            DbCommand com = new DbCommand(komut, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure,

            };
            com.Parameters.AddWithValue("in_urunid", urunid);

            error = "";
            return com.ExecuteNonQuery();

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            error = ex.Message;
            return -1;
        }
        finally
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }

    public static List<(string calisanid,
                        string ad,
                        string soyad,
                        string telefon,
                        DateTime isebaslamatarihi,
                        float maas)> TumCalisanlar(out string error)
    {

        var liste = new List<(string, string, string, string, DateTime, float)>();

        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string komut = "tumcalisanlar";
            DbCommand com = new DbCommand(komut, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure

            };


            error = "";
            var dr = com.ExecuteReader();
            {
                while (dr.Read())
                {
                    liste.Add(
                        (dr[0].ToString(),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        dr[3].ToString(),
                        (DateTime)dr[4],
                        (float)dr[5])
                        );
                }
                return liste;
            }

        }
        catch (Exception ex)
        {

            error = ex.Message;
            return null;
        }
        finally
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }


    }

    public static List<(string gid,
                        string kid,
                        float miktar,
                        DateTime tarih,
                        string aciklama)> TumGirdiler(out string error)
    {
        var liste = new List<(string, string, float, DateTime, string)>();

        try
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }
            string komut = "TumGirdiler";
            DbCommand com = new DbCommand(komut, conn)
            {
                CommandType = System.Data.CommandType.StoredProcedure

            };


            error = "";
            var dr = com.ExecuteReader();
            {
                while (dr.Read())
                {
                    liste.Add(
                        (dr[0].ToString(),
                        dr[1].ToString(),
                        (float)dr[2],
                       (DateTime)dr[3],
                        dr[4].ToString())
                        );
                }
                return liste;
            }

        }
        catch (Exception ex)
        {

            error = ex.Message;
            return null;
        }
        finally
        {
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
        }
    }

}



