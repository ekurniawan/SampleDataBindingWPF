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
        public SampleBinding1()
        {
            InitializeComponent();
            this.DataContext = new MahasiswaViewModel();
           
        }
    }
}
