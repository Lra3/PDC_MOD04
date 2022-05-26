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
    public partial class Activity2 : ContentPage
    {
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public ObservableCollection<Employee> Employees { get { return employees; } }

        public Activity2()
        {
            InitializeComponent();
            EmployeeView.ItemsSource = employees;

            employees.Add(new Employee { DisplayName = "Namikaze Minato", position = "Hokage", Image = "minato.jpg" });
            employees.Add(new Employee { DisplayName = "Namikaze Minato", position = "Hokage", Image = "minato.jpg" });
            employees.Add(new Employee { DisplayName = "Namikaze Minato", position = "Hokage", Image = "minato.jpg" });

        }
    }
}