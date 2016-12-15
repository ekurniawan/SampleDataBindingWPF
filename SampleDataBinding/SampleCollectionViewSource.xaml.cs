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
    /// Interaction logic for SampleCollectionViewSource.xaml
    /// </summary>
    public partial class SampleCollectionViewSource : Window
    {
        private MahasiswaViewModel mhsVm;
        public SampleCollectionViewSource()
        {
            InitializeComponent();
            var objSrc = FindResource("src") as ObjectDataProvider;
            mhsVm = objSrc.Data as MahasiswaViewModel;

            btnNewMhs.Click += BtnNewMhs_Click;
            btnShowMhs.Click += BtnShowMhs_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var delMhs = mhsVm.ListMahasiswa.Where(m => m.Nim == txtNim.Text).SingleOrDefault();
            mhsVm.ListMahasiswa.Remove(delMhs);
            MessageBox.Show("Data " + txtNim.Text + " berhasil didelete");
        }

        private void BtnShowMhs_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(mhsVm.ListMahasiswa[3].Nama);
        }

        private void BtnNewMhs_Click(object sender, RoutedEventArgs e)
        {
            mhsVm.ListMahasiswa.Add(new Mahasiswa
            {
                Nim = "22987678",
                Nama = "Benny",
                IPK = 3.4,
                IPS = 3.7
            });
            MessageBox.Show("Tambah Mahasiswa");
        }
    }
}
