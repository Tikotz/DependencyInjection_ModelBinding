using System.Collections.Generic;

namespace DependencyInjection_ModelBinding.Models
{
    public class CrimeOrganization : ICrimeOrganization
    {
        public List<string> crimesList { get; set; }

        public CrimeOrganization()
        {
            crimesList = new List<string>();
        }

    }
}
