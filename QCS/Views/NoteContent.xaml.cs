using QCS.ViewModels;
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
using static QCS.ViewModels.QCSVM;

namespace QCS.Views
{
    /// <summary>
    /// Interaction logic for NoteContent.xaml
    /// </summary>
   
    public partial class GetNote : Window
    {
        QSSVM vm = null;
        public GetNote(QSSVM vm)
        {
            InitializeComponent();
            this.vm = vm;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            vm.Note = NoteText.Text;
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }
}
