using System.Collections.Generic;

namespace DependencyInjection_ModelBinding.Models
{
    public interface IDonations
    {
        void AddDonation(Donation donations);
        List<Donation> GetAllDonations();
    }
}