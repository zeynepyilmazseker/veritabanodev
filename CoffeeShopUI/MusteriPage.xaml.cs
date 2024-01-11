using CS_BL;
namespace CoffeeShopUI;

public partial class MusteriPage : ContentPage
{
	public MusteriPage()
	{
		InitializeComponent();
		listMusteriler.ItemsSource = BL.Musteriler;
	}

    string error;
    private void MusterileriYukle()
    {
        bool res = BL.MusterileriYukle(out error);
        if (!res)
        {
            DisplayAlert("hata oluştu", error, "OK");
        }


    }

    void AddMusteri(Musteri m)
    {
        var res = BL.MusteriEkle(m, out error);
        if (!res)
        {
            DisplayAlert("hata oluştu", error, "OK");
        }
    }

    private void KisiEkleClicked(System.Object sender, System.EventArgs e)
    {
        MusteriEditPage page = new MusteriEditPage() { AddMetod = AddMusteri };
        Navigation.PushModalAsync(page);
    }

    void KisileriYukleClicked(System.Object sender, System.EventArgs e)
    {
        MusterileriYukle();
        refreshView.IsRefreshing = false;
    }

    void KisiDuzenleClicked(System.Object sender, System.EventArgs e)
    {
        var b = sender as ImageButton;
        if (b != null)
        {
            var kisi = BL.Musteriler.First(o => o.ID == b.CommandParameter.ToString());
            MusteriEditPage page = new MusteriEditPage(kisi) { EditMetod = EditKisi };
            Navigation.PushModalAsync(page);
        }
    }

    private void EditKisi(Musteri m)
    {
        BL.MusteriDuzenle(m, out error);
    }

    async void KisiSilClicked(System.Object sender, System.EventArgs e)
    {
        var b = sender as ImageButton;
        if (b != null)
        {
            var y = await DisplayAlert("silinsin mi?", "silmeyi onayla", "OK", "CANCEL");
            if (y)
            {
                var kisi = BL.Musteriler.First(o => o.ID == b.CommandParameter.ToString());
                var res = BL.MusteriSil(kisi, out error);
                if (!res)
                {
                    await DisplayAlert("hata oluştu", error, "OK");
                }
            }


        }
    }

}
