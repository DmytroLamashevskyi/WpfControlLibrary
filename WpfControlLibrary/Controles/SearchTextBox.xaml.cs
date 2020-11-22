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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfControlLibrary.Controles
{
    /// <summary>
    /// Interaction logic for SearchTextBox.xaml
    /// </summary>
    public partial class SearchTextBox : UserControl
    {
        public string SearchString { set; get; }

        public delegate void  Search(string arg);
        public event Search SearchClick;

        public SearchTextBox()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SearchClick?.Invoke(SearchString); 
        }
    }
}
