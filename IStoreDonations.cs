using System;

namespace BloodClinic
{
    // 3.3 Create an interface for storing donations
    public interface IStoreDonations
    {

        void createDonation(Donation donation);

    }

    /*
        Hint: Steps for using IStoreDonations interface (You can also use IStoreDonors as a guide)
        1. In the interface file (IStoreDonations.cs), add a method called Create that accepts a Donation object
        2. Create a class called DonationStorageList.cs, which implements IStoreDonations
        3. Inside that class, create a private List<Donation> member, and make the Create function add onto that list
        4. In BloodBank.cs, replace all references to the _donations list with references to the IStoreDonations interface
        5. Update the BloodBank constructor to take in a IStoreDonations argument, and set a private member using the argument
        6. Update the Program.cs file to init the DonationStorageList, and pass it into the BloodBank constructor
    */
}