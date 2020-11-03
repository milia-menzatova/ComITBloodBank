using System;

namespace BloodClinic
{
    class Program
    {
        static void Main(string[] args)
        {
            var donorStorageSystem = new DonorStorageDB();
            var donationsListStorage = new DonationStorageList();
            // 3.3: Initialize the donationStorageSystem and inject it into the BloodBank constructor
            var theBloodBank = new BloodBank(donorStorageSystem, donationsListStorage);

            Console.WriteLine("Welcome to the ComIT Blood bank!");

            while (true)
            {
                Console.WriteLine("d - make donation; r - request donation; u - send update; p - print details; q - quit");

                string userInput = Console.ReadLine();

                if (userInput == "d")
                {
                    Console.WriteLine("Please enter the Donor ID:");
                    string donorId = Console.ReadLine();

                    try
                    {
                        Guid donorIdGuid = Guid.Parse(donorId);
                        var donation = theBloodBank.MakeDonation(donorIdGuid);
                        Console.WriteLine($"Donation complete. ID: {donation.Id}");
                    }
                    catch (Exception e)
                    {
                        // Handle the exception in here
                        Console.WriteLine($"Exception generated: {e.Message}");
                    }
                }

                if (userInput == "r")
                {
                    theBloodBank.RequestDonation();
                }

                if (userInput == "u")
                {
                    theBloodBank.SendUpdateToAllMembers();
                }

                if (userInput == "p")
                {
                    string memberDetails = theBloodBank.GetAllMemberDetails();
                    Console.WriteLine(memberDetails);
                }

                if (userInput == "q")
                {
                    break;
                }

            }

            Console.WriteLine("See you later!");


        }
    }
}
