using CommunityToolkit.Mvvm.ComponentModel;
using DonateSomething.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonateSomething.Maui.ViewModels
{
    [QueryProperty(nameof(Organization), "Org")]
    public partial class OrganizationDetailsViewModel:BaseViewModel
    {
        [ObservableProperty]
        Organization org;

        public OrganizationDetailsViewModel()
        {
            Title = $"Org Details: {org.Name}, {org.CountryOfOrigin}";
        }
    }
}
