using System.Collections.Generic;
namespace BloodClinic
{
    public class DonationStorageList : IStoreDonations
    {

        private List<Donation> _donations;

        public DonationStorageList()
        {
            this._donations = new List<Donation>();
        }

        public void createDonation(Donation donation)
        {
            this._donations.Add(donation);
        }
    }
}