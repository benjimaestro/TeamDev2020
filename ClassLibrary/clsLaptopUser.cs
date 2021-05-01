using System;
using System.Linq;

public class clsLaptopUser
{
    public int ID { get; set; }
    public string LaptopUserAddress { get; set; }
    public bool LaptopUserActive { get; set; }
    public string LaptopUserEmail { get; set; }
    public string LaptopUserFirstName { get; set; }
    public string LaptopUserLastName { get; set; }
    public string LaptopUserTelephoneNumber { get; set; }
    public int LaptopUserId { get; set; }
    public string LaptopUser { get; set; }
    public int LaptopUserNo { get; set; }
    public DateTime LaptopUserCreatedAt { get; set; }
    public string LaptopUserPassword { get; set; }
    public bool LaptopStaff { get; set; }

    bool FindLaptopUser(int staffID)
    {
        throw new NotImplementedException();
    }

    public string Valid(string LaptopUserAddress, string LaptopUserEmail, string LaptopUserFirstName, string LaptopUserLastName, string LaptopUserPassword, string LaptopUserTelephoneNumber)
    {
        return "";
    }

    public string ValidateLaptopUser(string LaptopUserAddress, string LaptopUserPassword, string LaptopUserEmail, string LaptopUserFirstName, string LaptopUserLastName, string LaptopUserTelephoneNumber)
    {
        string errorMessage = "";

        //Validation for first name
        if (LaptopUserFirstName.Length == 0)
        {
            errorMessage += "First name is a required field!" + "<br />";
        }
        else if (LaptopUserFirstName.Length > 14)
        {
            errorMessage += "First name must be 14 characters or shorter!" + "<br />";
        }
        else if (LaptopUserFirstName.Any(char.IsDigit))
        {
            errorMessage += "First name must not contain any numbers!" + "<br />";


        }

        //Validation for last name
        if (LaptopUserLastName.Length == 0)
        {
            errorMessage += "Last name is a required field!" + "<br />";
        }
        else if (LaptopUserLastName.Length > 14)
        {
            errorMessage += "Last name must be 14 characters or shorter!" + "<br />";
        }
        else if (LaptopUserLastName.Any(char.IsDigit))
        {
            errorMessage += "Last name must not contain any numbers!" + "<br />";
        }
        //Validation for email
        if (LaptopUserEmail.Length == 0)
        {
            errorMessage += "E-Mail address is a required field!" + "<br />";
        }
        else if (LaptopUserEmail.Length > 30)
        {
            errorMessage += "E-Mail address must be 30 characters or shorter!" + "<br />";
        }
        else if (LaptopUserEmail.Length < 13) //shorted existing email is in format e@hotmail.com
        {
            errorMessage += "E-Mail address must be 13 characters or longer!" + "<br />";
        }
        else if (!LaptopUserEmail.Any(c => c == '@')) //Check if @ is present in string
        {
            errorMessage += "You must enter a valid E-Mail address!" + "<br />";

        }

        //Validation for address
        if (LaptopUserAddress.Length == 0)
        {
            errorMessage += "Address is a required field!" + "<br />";
        }
        else if (LaptopUserAddress.Length > 100)
        {
            errorMessage += "Address must be 100 characters or shorter!" + "<br />";
        }
        else if (LaptopUserAddress.Length < 12)
        {
            errorMessage += "Address must be 12 characters or longer!" + "<br />";
        }

        //Validation for Password
        if (LaptopUserPassword.Length == 0)
        {
            errorMessage += "TelephoneNumber is a required field!" + "<br />";
        }
        else if (LaptopUserPassword.Length > 14)
        {
            errorMessage += "TelephoneNumber must be 14 characters or shorter!" + "<br />";
        }
        else if (LaptopUserPassword.Length < 10)
        {
            errorMessage += "TelephoneNumber must be 10 characters or longer!" + "<br />";
        }
        //Validation for TelephoneNumber
        if (LaptopUserTelephoneNumber.Length == 0)
        {
            errorMessage += "TelephoneNumber is a required field!" + "<br />";
        }
        else if (LaptopUserTelephoneNumber.Length > 14)
        {
            errorMessage += "TelephoneNumber must be 14 characters or shorter!" + "<br />";
        }
        else if (LaptopUserTelephoneNumber.Length < 12)
        {
            errorMessage += "TelephoneNumber must be 12 characters or longer!" + "<br />";
        }
        return errorMessage;
    }

    public bool FindLaptopUserId(int LaptopUserId)
    {
        //always return true
        return true;
    }

}