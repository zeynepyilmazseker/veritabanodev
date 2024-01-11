using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace CS_BL
{
    public class Urun : INotifyPropertyChanged
    {
        private string id = null;
        private string urunadi;
        private float fiyat;
        private int stokmiktari;
        private string kategori;
        private string aciklama;

        public string ID
        {
            get
            {
                if (id == null)
                    id = Guid.NewGuid().ToString();
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string UrunAdi
        {
            get => urunadi;
            set
            {
                urunadi = value;
                NotifyPropertyChanged();
            }
        }

        public string Kategori
        {
            get => kategori;
            set
            {
                kategori = value;
                NotifyPropertyChanged();
            }
        }

        public string Aciklama
        {
            get => aciklama;
            set
            {
                aciklama = value;
                NotifyPropertyChanged();
            }
        }

        public int StokMiktari
        {
            get => stokmiktari;
            set
            {
                stokmiktari = value;
                NotifyPropertyChanged();
            }
        }

        public float Fiyat
        {
            get => fiyat;
            set
            {
                fiyat = value;
                NotifyPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

