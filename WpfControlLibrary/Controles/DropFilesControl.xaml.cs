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
    /// Interaction logic for DropFilesControl.xaml
    /// </summary>
    public partial class DropFilesControl : UserControl
    {
        public DropFilesControl()
        {
            InitializeComponent();
        }

        public string[] Files { set; get; }
        public delegate void FilesUpdated(string[] files);
        public event FilesUpdated Uploaded;

        private void StackPanel_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Note that you can have more than one file.
                Files = (string[])e.Data.GetData(DataFormats.FileDrop);
                Uploaded?.Invoke(Files); 
            }
        }
    }
}
