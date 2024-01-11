using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace CS_BL
{
    public class StokHareketi : INotifyPropertyChanged
    {
        private string id = null;
        private DateTime harekettarihi;
        private string hareketturu;
        private int miktar;



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


        public DateTime HareketTarihi
        {
            get => harekettarihi;
            set
            {
                harekettarihi = value;
                NotifyPropertyChanged();
            }
        }

        public string urunid { get; set; }

        public int Miktar
        {
            get => miktar;
            set
            {
                miktar = value;
                NotifyPropertyChanged();
            }
        }

        public string HareketTuru
        {
            get => hareketturu;
            set
            {
                hareketturu = value;
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

