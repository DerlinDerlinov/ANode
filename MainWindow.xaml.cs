using ANode.AData.Modules;
using ANode.AData.Pages;
using ANode.Application.Pages;
using System.Windows;
using System.Windows.Input;

namespace ANode
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ANodeManager.ANodeObject = new AData.Modules.ANodeEntities();
            ANodeFrame.FObject = FPages;
            ANodeFrame.FObject.Navigate(new FMainPage());
        }

        private void LeftMenuBar_ClientsBtn_Click(object sender, RoutedEventArgs e)
        {
            ANodeFrame.FObject.Navigate(new FClientsPage());
        }

        private void DragTitleAction(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void GoToEmployeesButton_Click(object sender, RoutedEventArgs e)
        {
            ANodeFrame.FObject.Navigate(new FEmployees());
        }

        private void GoToClientsLevelButton_Click(object sender, RoutedEventArgs e)
        {
            ANodeFrame.FObject.Navigate(new FClientLevels());
        }

        private void GoToServicesButton_Click(object sender, RoutedEventArgs e)
        {
            ANodeFrame.FObject.Navigate(new FServices());
        }

        private void GoToOrdersButton_Click(object sender, RoutedEventArgs e)
        {
            ANodeFrame.FObject.Navigate(new FOrders());
        }

        private void GoToOrderStatusesButton_Click(object sender, RoutedEventArgs e)
        {
            ANodeFrame.FObject.Navigate(new FOrderStatuses());
        }

        private void GoToAboutDeveloperButton_Click(object sender, RoutedEventArgs e)
        {
            ANodeFrame.FObject.Navigate(new FAboutDeveloper());
        }

        private void GoToAboutProgramButton_Click(object sender, RoutedEventArgs e)
        {
            ANodeFrame.FObject.Navigate(new FAboutProgram());
        }
    }
}
