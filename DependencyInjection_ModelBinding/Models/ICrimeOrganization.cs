using System.Collections.Generic;

namespace DependencyInjection_ModelBinding.Models
{
    public interface ICrimeOrganization
    {
        List<string> crimesList { get; set; }
    }
}