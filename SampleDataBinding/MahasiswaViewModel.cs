using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataBinding
{
    public class MahasiswaViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Mahasiswa> listMahasiswa;
        public ObservableCollection<Mahasiswa> ListMahasiswa
        {
            get { return listMahasiswa; }
            set
            {
                if (value != listMahasiswa)
                {
                    listMahasiswa = value;
                    OnPropertyChanged("ListMahasiswa");
                }
            }
        }

        public MahasiswaViewModel()
        {
            ListMahasiswa = new ObservableCollection<Mahasiswa>(new List<Mahasiswa>() {
                new Mahasiswa { Nim = "22002329", Nama = "Zack", IPK = 3.9,IPS=3.9 },
                new Mahasiswa { Nim = "22002322", Nama = "Erick", IPK = 3.3,IPS=3.7 },
                new Mahasiswa { Nim = "22002323", Nama = "Joko", IPK = 3.8,IPS=2.8 }
            });

            ListDosen = new ObservableCollection<Dosen>(new List<Dosen>()
            {
                new Dosen {Nik="478899",Nama="Bambang",Alamat="Jl Mangga 11" },
                new Dosen {Nik="5589FF",Nama="Joko",Alamat="Jl Rambutan 12" },
                new Dosen {Nik="334455",Nama="Christ",Alamat="Jl Duren 10" }
            });
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Dosen> listDosen;
        public ObservableCollection<Dosen> ListDosen
        {
            get { return listDosen; }
            set
            {
                if (value != listDosen)
                {
                    listDosen = value;
                    OnPropertyChanged("ListDosen");
                }
            }
        }

    }
}
