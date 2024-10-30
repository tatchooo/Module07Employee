using Module07DataAccess.Services;
using Module07DataAccess.ViewModel;

namespace Module07DataAccess.View;

public partial class ViewEmployee : ContentPage
{
    public ViewEmployee()
    {
        InitializeComponent();

        var employeeViewModel = new EmployeeViewModel();
        BindingContext = employeeViewModel;
    }
}
