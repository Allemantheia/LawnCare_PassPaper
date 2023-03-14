using System.Runtime.CompilerServices;


// This method checks to see if a field by the user only contains alphabetic letters if there is anything else present it will decline the entry

bool CheckAllLetters(string s)
{
    string temp = s.Replace(" ", "");
    foreach (char c in temp)

    {
        if (!char.IsLetter(c))

        {
            return false;

        }

    }
    return true;

}

// Same as method above, except it checks for digits and will decline if anything else is entered

bool CheckAllDigits(string s)

{

    string temp = s.Replace(" ", "");

    foreach (char c in temp)

    {

        if (!char.IsDigit(c))

        {

            return false;

        }

    }

    return true;

}

// Same as above but checks for letters and digits (used for the address field)

bool CheckAllLettersAndDigits(string s)

{

    string addresstemp = s.Replace(" ", "");

    foreach (char c in addresstemp)

    {

        if (!char.IsLetterOrDigit(c))

        {

            return false;

        }

    }

    return true;

}

// Current functions

bool name_flag = true;
bool namecheck_flag = true;
bool address_flag = true;
bool addresscheck_flag = true;
bool LawnLength_flag = true;
bool LawsizeLengthCheck_Flag = true;
bool lawnsizeWidthCheck_Flag = true;
string customers_name = "";
string customers_address = "";
int Lawn_Length = 0;
int Lawn_Width = 0;

// User will input thier name here 

while (namecheck_flag)

{

    while (name_flag)

    {

        Console.WriteLine("Enter in the customers name");

        customers_name = Console.ReadLine().Trim();

        if (customers_name == "")

        {
            Console.WriteLine("Customers name cannot be blank, please try again");
        }

        else if (!CheckAllLetters(customers_name))

        {
            Console.WriteLine("Customers name must be alphabetic, please try again");
        }

        else if (customers_name.Length > 30)

        {
            Console.WriteLine("Customers name cannot be greater than 30 characters");
        }

        else

        {
            Console.WriteLine("Customers name: {0}", customers_name);

            name_flag = false;
        }

    }

    Console.WriteLine("The customers name is: {0} is this correct?", customers_name);

    string name_check = Console.ReadLine().ToLower();

    if (name_check == "yes" || name_check == "y")

    {
        namecheck_flag = false;

        Console.WriteLine(@$"The Customers name is {customers_name} 

Name assigned");

    }

    else if (name_check == "no" || name_check == "n")

    {
        name_flag = true;
    }

    else

    {
        Console.WriteLine("Invalid input please try again");
    }

}

// Same as the Name check but applies the properties of the address method

while (addresscheck_flag)

{
    while (address_flag)

    {
        Console.WriteLine("enter the customers address");

        customers_address = Console.ReadLine().Trim();

        if (customers_address == "")
        {
            Console.WriteLine("Customers address cannot be blank");
        }
        else if (!CheckAllLettersAndDigits(customers_address))

        {
            Console.WriteLine("Name must be alphabetic");

        }
        else

        {
            address_flag = false;
        }

    }
    Console.WriteLine("The address of the customer is {0} is this correct", customers_address);

    string address_check = Console.ReadLine().ToLower();

    if (address_check == "yes" || address_check == "y")

    {
        addresscheck_flag = false;

        Console.WriteLine(@$"The address set is {customers_address}  

Address accepted");

    }

    else if (address_check == "no" || address_check == "n")

    {

        addresscheck_flag = true;
    }



    else

    {

        Console.WriteLine("Invalid input please try again");
    }

}

// User inputs Lawn length size

while (LawsizeLengthCheck_Flag)

{
    while (Lawn_Length < 1 || Lawn_Length > 1000)

    {
        Console.WriteLine("Please enter the length of the lawn (Min size 1, Max size 1000)");

        while (!int.TryParse(Console.ReadLine(), out Lawn_Length))

        {

            Console.WriteLine("invalid input try again");

        }
    }

    Console.WriteLine($"Your lawn length is {Lawn_Length} is this correct?");

    string lawnlength = Console.ReadLine().ToLower();

    if (lawnlength == "yes" || lawnlength == "y")

    {
        LawsizeLengthCheck_Flag = false;

        Console.WriteLine($@"Confrimed, the length is set to {Lawn_Length}");
    }

    else if (lawnlength == "no" || lawnlength == "n")

    {
        LawsizeLengthCheck_Flag = true;
    }

    

}
// user inputs lawn width size

while (lawnsizeWidthCheck_Flag)

{

    while (Lawn_Width < 1 || Lawn_Width > 1000)

    {
        Console.WriteLine("Please enter the width of the lawn (Min size 1, max size 1000");

        while (!int.TryParse(Console.ReadLine(), out Lawn_Width))

        {

            Console.WriteLine("invald input try again");
        }
    }

    Console.WriteLine($"Your lawn width is {Lawn_Width} is this correct?");

    string lawnwidth = Console.ReadLine().ToLower();

    if (lawnwidth == "yes" || lawnwidth == "y")

    {
        lawnsizeWidthCheck_Flag = true;

        Console.WriteLine($@"Confrimed, the width is set to {Lawn_Width}");
    }

    else if (lawnwidth == "no" || lawnwidth == "n")

    {
        lawnsizeWidthCheck_Flag = true;
    }
}




