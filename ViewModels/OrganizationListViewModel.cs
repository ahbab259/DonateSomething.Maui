﻿using DonateSomething.Maui.Models;
using DonateSomething.Maui.Services;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DonateSomething.Maui.ViewModels
{
    public partial class OrganizationListViewModel : BaseViewModel
    {
        private readonly OrganizationService orgService;
        public ObservableCollection<Organization> Organizations { get; private set; } = new ObservableCollection<Organization>();

        public OrganizationListViewModel(OrganizationService orgService)
        {
            Title = "Organization List";
            this.orgService = orgService;
        }

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

                var orgs = orgService.GetOrganizations();

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
            }
        }
    }
}