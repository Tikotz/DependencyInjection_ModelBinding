using System.Collections.Generic;

namespace DependencyInjection_ModelBinding.Models
{
    public class Donations : IDonations
    {
        public List<Donation> _DonationsList { get; set; }

        public Donations()
        {
            _DonationsList = new List<Donation>();
        }

        public void AddDonation(Donation donations)
        {
            _DonationsList.Add(donations);
        }

        public List<Donation> GetAllDonations()
        {
            return _DonationsList;
        }
    }
}
