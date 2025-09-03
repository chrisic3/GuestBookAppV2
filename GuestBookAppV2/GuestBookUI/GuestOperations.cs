using System;
using GuestBookLibrary.Models;

namespace GuestBookUI;

public static class GuestOperations
{
    public static void GetGuests(List<GuestModel> guests)
    {
        bool moreGuests = false;

        do
        {
            GuestModel guest = new GuestModel();

            guest.FirstName = GetInput("Please enter your first name: ");
            guest.LastName = GetInput("Please enter your last name: ");            
            guest.MessageToHost = GetInput("Please enter your message to the host: ");
            
            bool isValidNumber = false;
            do
            {
                string groupCount = GetInput("Please enter the number of people in your group: ");
                isValidNumber = int.TryParse(groupCount, out int number);

                if (!isValidNumber)
                {
                    Console.WriteLine("Invalid number.");
                }
            } while (!isValidNumber);

            guests.Add(guest);

            string input = GetInput("Are there more guests to add? (y/n): ");
            
            if (input.ToLower() == "y")
            {
                moreGuests = true;
            }
            else
            {
                moreGuests = false;
            }
        } while (moreGuests);
    }

    public static string GetInput(string message)
    {
        Console.Write(message);
        string output = Console.ReadLine();

        return output;
    }

    public static void PrintGuestBook(List<GuestModel> guests)
    {
        foreach (GuestModel guest in guests)
        {
            Console.WriteLine(guest.GuestInfo);
        }
    }
}
