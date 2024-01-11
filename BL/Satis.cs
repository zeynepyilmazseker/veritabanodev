using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace  CS_BL
{
    public class Satis : INotifyPropertyChanged
    {
        private string id = null;
        private DateTime satistarihi;


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

        public DateTime SatisTarihi
        {
            get => satistarihi;
            set
            {
                satistarihi = value;
                NotifyPropertyChanged();
            }
        }

        public string musteriid { get; set; }
        public string calisanid { get; set; }
        public string urunid { get; set; }
        public string odemeid { get; set; }




        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}



