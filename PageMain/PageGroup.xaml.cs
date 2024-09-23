using KinderGarten.Class;
using KinderGarten.Model;
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
    /// Логика взаимодействия для PageGroup.xaml
    /// </summary>
    public partial class PageGroup : Page
    {
        public PageGroup()
        {
            InitializeComponent();
            ViewGroupCmb.SelectedValuePath = "Id";
            ViewGroupCmb.DisplayMemberPath = "Name";
            ViewGroupCmb.ItemsSource = App.context.VidGroup.ToList();

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(GroupTb.Text))
                mes += "Введите группу\n";
            if (string.IsNullOrWhiteSpace(ViewGroupCmb.Text))
                mes += "Выберите вид группы\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                    mes = "";
                return;

            }

            GroupDS groupDS = new GroupDS()
            {
                Name = GroupTb.Text,
                VidGroup = ViewGroupCmb.SelectedItem as VidGroup

            };

            App.context.GroupDS.Add(groupDS);
            App.context.SaveChanges();
            MessageBox.Show("Группа добавлена");

            GroupTb.Text = "";
            ViewGroupCmb.Text = "";
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.GoBack();

        }
    }
}
