using KinderGarten.Class;
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

namespace KinderGarten.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageJournal.xaml
    /// </summary>
    public partial class PageJournal : UserControl
    {
        public PageJournal()
        {
            InitializeComponent();
        }

        private void JournalLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void NameGroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BackBtn_Click_1(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.GoBack();

        }

        private void DatGr_Loaded(object sender, RoutedEventArgs e)
        {
            DatGr.ItemsSource = App.context.Journal.ToList();
        }
    }
}
