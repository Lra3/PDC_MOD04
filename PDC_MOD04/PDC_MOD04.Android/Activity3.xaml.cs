using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace PDC_MOD04
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Activity3 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

        public ObservableCollection<Employee> Employees { get { return employees; } }
        public Activity3()
        {
            InitializeComponent();

            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Twice Nayeon", position = "Lead Vocalist", Image = "nayeon1.jpg" });
            employees.Add(new Employee { DisplayName = "Twice Nayeon", position = "Lead Vocalist", Image = "nayeon2.jpg" });
            employees.Add(new Employee { DisplayName = "Twice Nayeon", position = "Lead Vocalist", Image = "nayeon3.jpg" });
            employees.Add(new Employee { DisplayName = "Twice Nayeon", position = "Lead Vocalist", Image = "nayeon4.jpg" });
            employees.Add(new Employee { DisplayName = "Twice Nayeon", position = "Lead Vocalist", Image = "nayeon5.jpg" });
        }
    }
}