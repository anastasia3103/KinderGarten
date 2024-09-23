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
    /// Логика взаимодействия для PageAccounting.xaml
    /// </summary>
    public partial class PageAccounting : Page
    {
        public PageAccounting()
        {
            InitializeComponent();

            EventCmb.SelectedValuePath = "Id";
            EventCmb.DisplayMemberPath = "Name";
            EventCmb.ItemsSource = App.context.Activity.ToList();

            GroupCmb.SelectedValuePath = "Id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.GroupDS.ToList();

            ViewEventCmb.SelectedValuePath = "Id";
            ViewEventCmb.DisplayMemberPath = "Name";
            ViewEventCmb.ItemsSource = App.context.Direction.ToList();

            ViewGroupCmb.SelectedValuePath = "Id";
            ViewGroupCmb.DisplayMemberPath = "Name";
            ViewGroupCmb.ItemsSource = App.context.VidGroup.ToList();

            MarkCmb.SelectedValuePath = "Id";
            MarkCmb.DisplayMemberPath = "Name";
            MarkCmb.ItemsSource = App.context.Mark.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(DateDp.Text))
                mes += "Выберите дату\n";

            if (string.IsNullOrWhiteSpace(GroupCmb.Text))
                mes += "Выберите группу\n";

            if (string.IsNullOrWhiteSpace(EventCmb.Text))
                mes += "Выберите мероприятие\n";

            if (string.IsNullOrWhiteSpace(ViewEventCmb.Text))
                mes += "Выберите вид мероприятия\n";

            if (string.IsNullOrWhiteSpace(MarkCmb.Text))
                mes += "Выберите оценку\n";

            if (string.IsNullOrWhiteSpace(ViewGroupCmb.Text))
                mes += "Выберите вид группы\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            Journal journal = new Journal()
            {
                DateZan = (DateTime)DateDp.SelectedDate,
                GroupDS = GroupCmb.SelectedItem as GroupDS,
                Activity = EventCmb.SelectedItem as Activity,
                Mark = MarkCmb.SelectedItem as Mark

            };

            App.context.Journal.Add(journal);
            App.context.SaveChanges();
            MessageBox.Show("Оценка добавлена");

            DateDp.Text = "";
            EventCmb.Text = "";
            GroupCmb.Text = "";
            MarkCmb.Text = "";
            ViewEventCmb.Text = "";
            ViewGroupCmb.Text = "";

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameMenu.GoBack();
        }

        private void ViewGroupCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectedViewGroupCmb = Convert.ToInt32(ViewGroupCmb.SelectedValue);
            GroupCmb.ItemsSource = App.context.GroupDS.Where(x => x.IdVidGroup == SelectedViewGroupCmb).ToList();
        }

        private void ViewEventCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            int SelectedViewEventCmb = Convert.ToInt32(ViewEventCmb.SelectedValue);
            EventCmb.ItemsSource = App.context.Activity.Where(x => x.IdDirection == SelectedViewEventCmb).ToList();
        }
    }
}
