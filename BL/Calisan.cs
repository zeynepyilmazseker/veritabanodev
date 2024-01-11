using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace CS_BL
{
    public class Calisan : INotifyPropertyChanged
    {
        private String id = null;
        private string ad, soyad, telefon;
        private DateTime isebaslamatarihi;
        private float maas;

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



        public string Ad
        {
            get => ad;
            set
            {
                soyad = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("AdSoyad");
            }
        }
        public string Soyad
        {
            get => soyad;
            set
            {
                soyad = value;
                NotifyPropertyChanged();
                NotifyPropertyChanged("AdSoyad");
            }
        }

        public string AdSoyad => Ad + " " + Soyad;

        public string Telefon
        {
            get => telefon;
            set
            {
                telefon = value;
                NotifyPropertyChanged();
            }
        }

        public DateTime IseBaslamaTarihi
        {
            get => isebaslamatarihi;
            set
            {
                isebaslamatarihi = value;
                NotifyPropertyChanged();
            }

        }

        public float Maas
        {
            get => maas;
            set
            {
                maas = value;
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



