using GuestBookLibrary.Models;

GuestModel guest = new GuestModel();
guest.FirstName = "John";
guest.LastName = "Tester";
guest.MessageToHost = "Beautiful place.";
guest.GuestCount = 4;

Console.WriteLine(guest.GuestInfo);