using DonateSomething.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonateSomething.Maui.Services
{
    public class OrganizationService
    {
        public List<Organization> GetOrganizations()
        {
            return new List<Organization>
            {
                new Organization
                {
                    Id = 1, Name = "OneOrganization", Budget = 100000
                },

                new Organization
                {
                    Id = 2, Name = "TwoOrganization", Budget = 200000
                }
            };
        }
    }
}
