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

        //Validation for last name
        if (LaptopUserLastName.Length == 0)
        {
            errorMessage += "Last name is a required field!" + "<br />";
        }
        else if (LaptopUserLastName.Length > 14)
        {
            errorMessage += "Last name must be 50 characters or shorter!" + "<br />";
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
            errorMessage += "E-Mail address must be 8 characters or longer!" + "<br />";
        }
        else if (!LaptopUserEmail.Any(c => c == '@')) //Check if @ is present in string
        {
            errorMessage += "You must enter a valid E-Mail address!" + "<br />";
        }
        return errorMessage;
    }
}