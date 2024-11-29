using DonateSomething.Maui.ViewModels;

namespace DonateSomething.Maui
{
    public partial class MainPage : ContentPage
    {
        //private readonly OrganizationListViewModel _orgListViewModel;
        public MainPage(OrganizationListViewModel orgListViewModel)
        {
            InitializeComponent();
            //this._orgListViewModel = orgListViewModel;
            BindingContext = orgListViewModel;
        }

       
    }

}
