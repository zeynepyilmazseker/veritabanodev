using CS_BL;
namespace CoffeeShopUI;

public partial class CalisanPage : ContentPage
{
	public CalisanPage()
	{
		InitializeComponent();
		listCalisanlar.ItemsSource = BL.Calisanlar;

    }
    string error;
    private void KisileriYukle()
    {
        bool res = BL.CalisanlariYukle(out error);
        if (!res)
        {
            DisplayAlert("hata oluştu", error, "OK");
        }


    }

    void AddKisi(Calisan c)
    {
        var res = BL.CalisanEkle(c, out error);
        if (!res)
        {
            DisplayAlert("hata oluştu", error, "OK");
        }
    }

    private void KisiEkleClicked(System.Object sender, System.EventArgs e)
    {
        CalisanEditPage page = new CalisanEditPage() { AddMetod = AddKisi };
        Navigation.PushModalAsync(page);
    }

    void KisileriYukleClicked(System.Object sender, System.EventArgs e)
    {
        KisileriYukle();
        refreshView.IsRefreshing = false;
    }

    void KisiDuzenleClicked(System.Object sender, System.EventArgs e)
    {
        var b = sender as ImageButton;
        if (b != null)
        {
            var kisi = BL.Calisanlar.First(o => o.ID == b.CommandParameter.ToString());
            CalisanEditPage page = new CalisanEditPage(kisi) { EditMetod = EditKisi };
            Navigation.PushModalAsync(page);
        }
    }

    private void EditKisi(Calisan c)
    {
        BL.CalisanDuzenle(c, out error);
    }

    async void KisiSilClicked(System.Object sender, System.EventArgs e)
    {
        var b = sender as ImageButton;
        if (b != null)
        {
            var y = await DisplayAlert("silinsin mi?", "silmeyi onayla", "OK", "CANCEL");
            if (y)
            {
                var kisi = BL.Calisanlar.First(o => o.ID == b.CommandParameter.ToString());
                var res = BL.CalisanSil(kisi, out error);
                if (!res)
                {
                    await DisplayAlert("hata oluştu", error, "OK");
                }
            }


        }
    }

 
  /*   void listKisiler_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
      {
          if (e.CurrentSelection?.Count == 0)
              return;
          var calisan = e.CurrentSelection[0] as Kisi;
          GirdilerPage page = new GirdilerPage(kisi);
          Navigation.PushAsync(page);


      }
  */
}
