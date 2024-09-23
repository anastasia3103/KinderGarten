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
    /// Логика взаимодействия для PageEvent.xaml
    /// </summary>
    public partial class PageEvent : Page
    {
        public PageEvent()
        {
            InitializeComponent();


            EventCmb.SelectedValuePath = "Id";
            EventCmb.DisplayMemberPath = "Name";
            EventCmb.ItemsSource = App.context.Direction.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(EventTb.Text))
                mes += "Введите название мероприятия\n";
            if (string.IsNullOrWhiteSpace(EventCmb.Text))
                mes += "Выберите вид мероприятия\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;

            }

            Activity activity = new Activity()
            {
                Name = EventTb.Text,
                Direction= EventCmb.SelectedItem as Direction

            };

            App.context.Activity.Add(activity);
            App.context.SaveChanges();
            MessageBox.Show("Группа добавлена");

            EventTb.Text = "";
            EventCmb.Text = "";
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.GoBack();

        }
    }
}
