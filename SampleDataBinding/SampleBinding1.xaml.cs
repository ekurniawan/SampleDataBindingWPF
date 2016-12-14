using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SampleDataBinding
{
    /// <summary>
    /// Interaction logic for SampleBinding1.xaml
    /// </summary>
    public partial class SampleBinding1 : Window
    {
        public List<Mahasiswa> listMahasiswa;
        public SampleBinding1()
        {
            InitializeComponent();

            listMahasiswa = new List<Mahasiswa>() {
                new Mahasiswa { Nim = "22002321", Nama = "Budi", IPK = 3.2 },
                new Mahasiswa { Nim = "22002322", Nama = "Erick", IPK = 3.3 },
                new Mahasiswa { Nim = "22002323", Nama = "Joko", IPK = 3.8 }};

            this.DataContext = listMahasiswa;
        }
    }
}
