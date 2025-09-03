using GuestBookLibrary.Models;
using GuestBookUI;


List<GuestModel> guests = new List<GuestModel>();
GuestOperations.GetGuests(guests);
GuestOperations.PrintGuestBook(guests);
