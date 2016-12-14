using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataBinding
{
    public class Dosen : INotifyPropertyChanged
    {
        private string nik;
        public string Nik
        {
            get { return nik; }
            set
            {
                if (value != nik)
                {
                    nik = value;
                    OnPropertyChanged("Nik");
                }
            }
        }

        private string nama;
        public string Nama
        {
            get { return nama; }
            set
            {
                if (value != nama)
                {
                    nama = value;
                    OnPropertyChanged("Nama");
                }
            }
        }

        private string alamat;
        public string Alamat
        {
            get { return alamat; }
            set
            {
                if (value != alamat)
                {
                    alamat = value;
                    OnPropertyChanged("Alamat");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
