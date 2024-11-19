using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonateSomething.Maui.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string CountryOfOrigin { get; set; }
        public string CountryCode { get; set; }
        public Int64 Budget { get; set; }
    }
}
