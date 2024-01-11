using CS_BL;
namespace CoffeeShopUI;

public partial class CalisanEditPage : ContentPage
{
	Calisan calisan;

    public Action<Calisan> AddMetod { get; internal set; }

    public Action<Calisan> EditMetod { get; internal set; }

    public CalisanEditPage(Calisan c=null)
	{
		InitializeComponent();
        if (c != null)
        {
            txtAd.Text = c.Ad;
            txtSoyad.Text = c.Soyad;
            txtTelefon.Text = c.Telefon;
            txtIseBaslamaTarihi.Date = new DateTime(txtIseBaslamaTarihi.Date.Year, txtIseBaslamaTarihi.Date.Month, txtIseBaslamaTarihi.Date.Day);
            txtMaas.Text = c.Maas.ToString();

        }

        calisan = c;
    }


    void OkClicked(System.Object sender, System.EventArgs e)
    {

        if (calisan == null)
        {
            calisan = new Calisan()
            {
                
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                Telefon = txtTelefon.Text,
                IseBaslamaTarihi = getDateTime(),
                Maas = txtMaas.Text.ToFloat()

            };

            if (AddMetod != null)
            {
                AddMetod(calisan);
            }
        }
        else
        {
            calisan.Ad = txtAd.Text;
            calisan.Soyad = txtSoyad.Text;
            calisan.Telefon = txtSoyad.Text;
            calisan.IseBaslamaTarihi = getDateTime();
            calisan.Maas = txtMaas.Text.ToFloat();

            EditMetod(calisan);
        }
        Navigation.PopModalAsync(); //asıl sayfasına geri dönecek

    }

    void CancelClicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopModalAsync();
    }

    DateTime getDateTime()
    {
        return new DateTime(txtIseBaslamaTarihi.Date.Year, txtIseBaslamaTarihi.Date.Month, txtIseBaslamaTarihi.Date.Day
            );
    }
}
