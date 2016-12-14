using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataBinding
{
    public class MahasiswaViewModel
    {
        private List<Mahasiswa> listMahasiswa;
        public List<Mahasiswa> ListMahasiswa
        {
            get { return listMahasiswa; }
            set { listMahasiswa = value; }
        }

        public MahasiswaViewModel()
        {
            ListMahasiswa = new List<Mahasiswa>() {
                new Mahasiswa { Nim = "22002321", Nama = "Budi", IPK = 3.2,IPS=3.9 },
                new Mahasiswa { Nim = "22002322", Nama = "Erick", IPK = 3.3,IPS=3.7 },
                new Mahasiswa { Nim = "22002323", Nama = "Joko", IPK = 3.8,IPS=2.8 }};

            ListDosen = new List<Dosen>()
            {
                new Dosen {Nik="478899",Nama="Bambang",Alamat="Jl Mangga 11" },
                new Dosen {Nik="5589FF",Nama="Joko",Alamat="Jl Rambutan 12" },
                new Dosen {Nik="334455",Nama="Christ",Alamat="Jl Duren 10" }
            };
        }

        private List<Dosen> listDosen;
        public List<Dosen> ListDosen
        {
            get { return listDosen; }
            set { listDosen = value; }
        }

    }
}
