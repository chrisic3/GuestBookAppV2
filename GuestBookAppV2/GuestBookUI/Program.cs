using GuestBookLibrary.Models;

bool moreGuests = false;

do
{
    GuestModel guest = new GuestModel();

    Console.Write("Please enter your first name: ");
    guest.FirstName = Console.ReadLine();

    Console.Write("Please enter your last name: ");
    guest.LastName = Console.ReadLine();

    Console.Write("Please enter your message to the host: ");
    guest.MessageToHost = Console.ReadLine();

    bool isValidNumber = false;
    do
    {
        Console.Write("Please enter the number of people in your group: ");
        string groupCount = Console.ReadLine();
        isValidNumber = int.TryParse(groupCount, out int number);

        if (!isValidNumber)
        {
            Console.WriteLine("Invalid number.");
        }
    } while (!isValidNumber);

    Console.Write("Are there more guests to add? (y/n): ");
    string input = Console.ReadLine();

    if (input.ToLower() == "y")
    {
        moreGuests = true;
    }
    else
    {
        moreGuests = false;
    }
} while (moreGuests);
