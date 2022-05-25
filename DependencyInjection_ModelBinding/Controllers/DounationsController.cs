using DependencyInjection_ModelBinding.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DependencyInjection_ModelBinding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        //[BindProperty]
        //public string donatorName { get; set; }
        //public string donatorLastName { get; set; }

        private IDonations _donations{ get; set; }

        public DonationsController(IDonations donations)
        {
            _donations = donations;

        }

        [HttpPost]
        [Route("give/{donatorName}/{donatorLastName}")]
        public IActionResult PostDonation([FromRoute] string donatorName, [FromRoute] string donatorLastName, [FromRoute] int donationNum, [FromRoute] int associationNumber, [FromRoute] DateTime donationDate, [FromRoute] int largeAmount)
        {
            var donation = new Donation()
            {
                AsosiationNumber = associationNumber,
                DonationAmount = donationNum,
                LargeAmount = largeAmount,
                DonatorName = donatorName,
                DonatorLastName = donatorLastName,
            };

            _donations.AddDonation(donation);
            return Ok();
        }
    

    }
}
