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
        private MahasiswaViewModel mhsViewModel;
        public SampleBinding1()
        {
            InitializeComponent();
            mhsViewModel = new MahasiswaViewModel();
            this.DataContext = mhsViewModel;

            btnShow.Click += BtnShow_Click;
            btnUpdate.Click += BtnUpdate_Click;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var mhs1 = mhsViewModel.ListMahasiswa[0];
            mhs1.Nama = "Jovan Kurniawan";
            mhs1.IPK = 4.0;
        }

        private void BtnShow_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(mhsViewModel.ListMahasiswa[0].Nama + " " +
                mhsViewModel.ListMahasiswa[0].IPK.ToString());
        }
    }
}
