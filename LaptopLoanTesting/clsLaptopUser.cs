using System;
using System.Linq;

class clsLaptopUser
{
    public int ID { get; set; }
    public string LaptopUserAddress { get; internal set; }
    public bool LaptopUserActive { get; internal set; }
    public string LaptopUserEmail { get; internal set; }
    public string LaptopUserFirstName { get; internal set; }
    public string LaptopUserLastName { get; internal set; }
    public string LaptopTelephoneNumber { get; internal set; }

    internal bool FindLaptopUser(int staffID)
    {
        throw new NotImplementedException();
    }

    internal string Valid(string LaptopUserAddress, string LaptopUserEmail, string LaptopUserFirstName, string LaptopUserLastName, string LaptopUserPassword,string LaptopUserTelephoneNumber)
    {
        return "";
    }

    public string ValidateLaptopUser(string LaptopUserAddress, string LaptopUserPassword, string LaptopUserEmail, string LaptopUserFirstName, string LaptopUserLastName,string LaptopUserTelephoneNumber)
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
        return errorMessage;
    }
}