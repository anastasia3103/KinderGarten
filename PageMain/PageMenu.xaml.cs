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
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EventBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new PageMain.PageEvent());

        }

        private void GroupBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new PageMain.PageGroup());
        }

        private void JournalBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new PageMain.PageJournal());
        }

        private void AccountingBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.Navigate(new PageMain.PageAccounting());

        }
    }
}
