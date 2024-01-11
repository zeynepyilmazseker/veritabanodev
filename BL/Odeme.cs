using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_BL
{
    public class Odeme : INotifyPropertyChanged
    {
        private string id = null;
        private DateTime odemetarihi;
        private float tutar;
        private string odemeturu;

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

        public string siparisid { get; set; }

        public DateTime OdemeTarihi
        {
            get => odemetarihi;
            set
            {
                odemetarihi = value;
                NotifyPropertyChanged();
            }
        }

        public float Tutar
        {
            get => tutar;
            set
            {
                tutar = value;
                NotifyPropertyChanged();
            }
        }

        public string OdemeTuru
        {
            get => odemeturu;
            set
            {
                odemeturu = value;
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



