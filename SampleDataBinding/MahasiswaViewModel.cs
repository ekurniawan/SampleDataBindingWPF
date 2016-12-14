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
                new Mahasiswa { Nim = "22002321", Nama = "Budi", IPK = 3.2 },
                new Mahasiswa { Nim = "22002322", Nama = "Erick", IPK = 3.3 },
                new Mahasiswa { Nim = "22002323", Nama = "Joko", IPK = 3.8 }};
        }
    }
}
