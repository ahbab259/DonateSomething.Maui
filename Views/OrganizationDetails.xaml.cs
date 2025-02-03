using DonateSomething.Maui.ViewModels;

namespace DonateSomething.Maui.Views;

public partial class OrganizationDetails : ContentPage
{
	public OrganizationDetails(OrganizationDetailsViewModel organizationDetailsViewModel)
	{
		InitializeComponent();
		BindingContext = organizationDetailsViewModel;
	}
}