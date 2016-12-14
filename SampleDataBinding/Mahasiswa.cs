using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataBinding
{
    public class Mahasiswa : INotifyPropertyChanged
    {
        private string nim;
        public string Nim
        {
            get { return nim; }
            set
            {
                if (value != nim)
                {
                    nim = value;
                    OnPropertyChanged("Nim");
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

        private double ipk;
        public double IPK
        {
            get
            {
                return ipk;
            }
            set
            {
                if (value != ipk)
                {
                    ipk = value;
                    IPR = HitungIPR();
                    OnPropertyChanged("IPK");
                }
            }
        }

        private double ips;
        public double IPS
        {
            get { return ips; }
            set
            {
                if (value != ips)
                {
                    ips = value;
                    IPR = HitungIPR();
                    OnPropertyChanged("IPS");
                }
            }
        }

        private double HitungIPR()
        {
            return ((ips + ipk) / 2);
        }

        private double ipr;
        public double IPR
        {
            get
            {
                return HitungIPR();
            }
            set
            {
                if(value!=ipr)
                {
                    ipr = value;
                    OnPropertyChanged("IPR");
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
