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
using System.Text.RegularExpressions;

namespace SampleDataBinding
{
    /// <summary>
    /// Interaction logic for MasterDetailSample.xaml
    /// </summary>
    public partial class MasterDetailSample : Window
    {
        private MahasiswaViewModel mhsViewModel;
        public MasterDetailSample()
        {
            InitializeComponent();
            mhsViewModel = new MahasiswaViewModel();
            grid1.DataContext = mhsViewModel.ListMahasiswa;
            grid2.DataContext = mhsViewModel.ListDosen;

            btnUpdateMhs.Click += BtnUpdateMhs_Click;
            btnUpdateDosen.Click += BtnUpdateDosen_Click;

            txtVal.PreviewTextInput += TxtVal_PreviewTextInput;
            btnCheckVal.Click += BtnCheckVal_Click;
        }

        private void BtnCheckVal_Click(object sender, RoutedEventArgs e)
        {
            if(txtVal.Text.EndsWith("%"))
            {
                var isi = txtVal.Text.Substring(0, txtVal.Text.Length - 1);
                MessageBox.Show("Ada persen : "+isi.ToString());
            }
            else
            {
                MessageBox.Show("Tidak ada persen");
            }
        }

        private void TxtVal_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9|%]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BtnUpdateDosen_Click(object sender, RoutedEventArgs e)
        {
            var listDosen = mhsViewModel.ListDosen;
            listDosen[1].Nama = "Robert";
        }

        private void BtnUpdateMhs_Click(object sender, RoutedEventArgs e)
        {
            var listMhs = mhsViewModel.ListMahasiswa;
            listMhs[1].Nama = "Jhonny";
        }

        private void txtVal_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
