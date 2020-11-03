using System;
using System.Collections.Generic;

namespace BloodClinic
{
    public class BloodBank
    {
        public BloodBank(IStoreDonors donorStorageArg, IStoreDonations donations)
        {
            _donorStorage = donorStorageArg;
            _donations = donations; // 3.3: This should be replaced with a constructor argument

            _receivers = new List<Receiver>();

            // TODO: Add all blood types
            BloodType typeONeg = new BloodType("O", '-');
            BloodType typeAbPos = new BloodType("AB", '+');

            // Test donors
            Donor firstDonor = new Donor("Pablo", "Listingart", new DateTime(1980, 2, 23), typeONeg, "pablo@comit.org");
            Console.WriteLine($"ID: {firstDonor.Id}");
            Donor secondDonor = new Donor("Jesselyn", "Popoff", new DateTime(1990, 1, 1), typeAbPos, "jesselyn@comit.org");

            // Test receiver
            Receiver testReceiver = new Receiver("Homer", "Simpson", new DateTime(1970, 3, 22), typeONeg, "test@comit.org");

            _donorStorage.Create(firstDonor);
            _donorStorage.Create(secondDonor);
            _receivers.Add(testReceiver);
        }


        // Storage
        private IStoreDonors _donorStorage;
        private IStoreDonations _donations; // 3.3: This should be replaced with an interface
        private List<Receiver> _receivers;



        public Donation MakeDonation(Guid donorId)
        {
            var donor = _donorStorage.GetById(donorId);

            // Create the new donation
            var newDonation = new Donation()
            {
                Donor = donor,
                DonationDate = DateTime.Now,
                Id = Guid.NewGuid()
            };

            // Updating properties
            donor.Donate();

            // Store the donation
            _donations.createDonation(newDonation); // 3.3: This should be replaced with an interface

            return newDonation;
        }

        public void RequestDonation()
        {
            // TODO: Implement this
            Console.WriteLine("Request donation");
        }

        public void SendUpdateToAllMembers()
        {
            // TODO: Implement this
        }

        public string GetAllMemberDetails()
        {
            // TODO: Implement this
            return "";
        }
    }
}