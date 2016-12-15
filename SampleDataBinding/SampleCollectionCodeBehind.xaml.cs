using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for SampleCollectionCodeBehind.xaml
    /// </summary>
    public partial class SampleCollectionCodeBehind : Window
    {
        private MahasiswaViewModel mhsVm;
        private ICollectionView viewMhs;
        private ICollectionView viewDosen;
        public SampleCollectionCodeBehind()
        {
            InitializeComponent();
            mhsVm = new MahasiswaViewModel();

            viewMhs = CollectionViewSource.GetDefaultView(mhsVm.ListMahasiswa);
            viewDosen = CollectionViewSource.GetDefaultView(mhsVm.ListDosen);

            grid1.DataContext = viewMhs;
            grid2.DataContext = viewDosen;

            #region Inisialisasi Button
            btnNext.Click += BtnNext_Click;
            btnCurrent.Click += BtnCurrent_Click;
            btnSort.Click += BtnSort_Click;
            btnSearch.Click += BtnSearch_Click;
            #endregion
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            viewMhs.Filter = SearchByNimNama;
        }

        private bool SearchByNimNama(object o)
        {
            var mhs = o as Mahasiswa;
            return (mhs.Nama.Contains(txtSearch.Text) || mhs.Nim.Contains(txtSearch.Text));
        }

        private void BtnSort_Click(object sender, RoutedEventArgs e)
        {
            if (viewMhs.SortDescriptions.Count > 0 && viewMhs.SortDescriptions[0].PropertyName == "Nama" &&
                       viewMhs.SortDescriptions[0].Direction == ListSortDirection.Ascending)
            {
                viewMhs.SortDescriptions.Clear();
                viewMhs.SortDescriptions.Add(new SortDescription("Nama", ListSortDirection.Descending));
            }
            else
            {
                viewMhs.SortDescriptions.Clear();
                viewMhs.SortDescriptions.Add(new SortDescription("Nama", ListSortDirection.Ascending));
            }
        }

        private void BtnCurrent_Click(object sender, RoutedEventArgs e)
        {
            var currMhs = (viewMhs.CurrentItem as Mahasiswa);
            MessageBox.Show("Nim :" + currMhs.Nim + " Nama :" + currMhs.Nama);
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            viewMhs.MoveCurrentToNext();
        }
    }
}
