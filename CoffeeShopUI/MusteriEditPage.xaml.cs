using CS_BL;

namespace CoffeeShopUI;

public partial class MusteriEditPage : ContentPage
{


    Musteri musteri;

    public Action<Musteri> AddMetod { get; internal set; }

    public Action<Musteri> EditMetod { get; internal set; }

    public MusteriEditPage(Musteri m = null)
    {
        InitializeComponent();
        if (m != null)
        {
            txtAd.Text = m.Ad;
            txtSoyad.Text = m.Soyad;
            txtTelefon.Text = m.Telefon;
            txtMail.Text = m.Mail;

        }

        musteri = m;
    }


    void OkClicked(System.Object sender, System.EventArgs e)
    {

        if (musteri == null)
        {
            musteri = new Musteri()
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                Mail = txtMail.Text
             
            };

            if (AddMetod != null)
            {
                AddMetod(musteri);
            }
        }
        else
        {
            musteri.Ad = txtAd.Text;
            musteri.Soyad = txtSoyad.Text;
            musteri.Telefon = txtSoyad.Text;
            musteri.Mail = txtMail.Text;
           

            EditMetod(musteri);
        }
        Navigation.PopModalAsync(); //asıl sayfasına geri dönecek

    }

    void CancelClicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopModalAsync();
    }

   
}
