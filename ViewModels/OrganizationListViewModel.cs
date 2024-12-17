using DonateSomething.Maui.Models;
using DonateSomething.Maui.Services;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using DonateSomething.Maui.Views;

namespace DonateSomething.Maui.ViewModels
{
    public partial class OrganizationListViewModel : BaseViewModel
    {
        private readonly OrganizationService _orgService;
        public ObservableCollection<Organization> Organizations { get; private set; } = new ObservableCollection<Organization>();

        public OrganizationListViewModel(OrganizationService orgService)
        {
            Title = "Organization List";
            this._orgService = orgService;
        }

        public bool isRefreshing { get; set; }

        [RelayCommand]
        async Task GetOrganizationListAsync()
        {
            if (IsLoading) return;
            try
            {
                IsLoading = true;
                if (Organizations.Any())
                {
                    Organizations.Clear();
                }

                var orgs = _orgService.GetOrganizations();

                foreach (var org in orgs)
                {
                    Organizations.Add(org);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get Organizations: {ex.Message}");
                await Shell.Current.DisplayAlert("Error", "Unable to retrieve Organizations", "OK");
                throw;
            }
            finally
            {
                IsLoading = false;
                isRefreshing = false;
            }
        }
        [RelayCommand]
        async Task GetOrganizationDetails(Organization org)
        {
            if(org == null) return;
            await Shell.Current.GoToAsync(nameof(OrganizationDetails), true, new ShellNavigationQueryParameters()
            {
                { nameof(Organization), org}
            });
        }
    }
}
