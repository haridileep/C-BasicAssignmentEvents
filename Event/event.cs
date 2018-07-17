using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neudesic.Events.Models;


namespace Neudesic.Events.ConsoleApp
{
    class Event
    {
        static void Main(string[] args)
        {
            login:   User user = new User();
                     user.UserLogin();
                     EventDetails eventDetails = new EventDetails();
            eventMenu:Console.Clear();
                     Console.WriteLine("\n\tNeudesic Events \n1. Add Events \t2. View Event\t3.Delete Event");
                     Console.WriteLine("\nEnter your choice :\t");
                     int choice = Convert.ToInt32(Console.ReadLine());
                     eventDetails.EventAdmin = user.NameInput;
                     Console.Clear();
          

            switch (choice)
            {
                case 1:
                   
                    Console.WriteLine("\nEnter the Event Name");
                    eventDetails.EventName.Add(Console.ReadLine());
                    Console.WriteLine("\nEnter the Event Venue");
                    eventDetails.EventVenue.Add(Console.ReadLine());
                     goto eventMenu;
                    
                case 2:
                    for(int eveInp= 0;eveInp< eventDetails.EventName.Count;eveInp++)
                    {
                        Console.Write("Event Id:\t");
                        Console.Write(eveInp);
                        Console.Write("\n");
                        Console.Write("Event name:\t");
                        Console.Write(eventDetails.EventName[eveInp]);
                        Console.Write("\n");
                        Console.Write("Event Venue:\t");
                        Console.Write(eventDetails.EventVenue[eveInp]);
                        Console.Write("\n");
                        Console.Write("Event Admin:\t");
                        Console.Write(eventDetails.EventAdmin);
                        Console.Write("\n");
                    

                    }
                    Console.ReadLine();

                    goto eventMenu;
                case 3:
                    for (int eveInp = 0; eveInp < eventDetails.EventName.Count; eveInp++)
                    {
                        Console.Write("Event Id:\t");
                        Console.Write(eveInp);
                        Console.Write("\n");
                        Console.Write("Event name:\t");
                        Console.Write(eventDetails.EventName[eveInp]);
                        Console.Write("\n");
                        Console.Write("Event Venue:\t");
                        Console.Write(eventDetails.EventVenue[eveInp]);
                        Console.Write("\n");
                        Console.Write("Event Admin:\t");
                        Console.Write(eventDetails.EventAdmin);
                        Console.Write("\n");
                    }
                    Console.WriteLine("Enter the Event Id to be deleted\n");
                    int deleteId= Convert.ToInt32(Console.ReadLine());
                    eventDetails.EventName.Remove(eventDetails.EventName[deleteId]);
                    eventDetails.EventVenue.Remove(eventDetails.EventVenue[deleteId]);
                    
                    goto eventMenu;


                case 4: goto login;
                default:
                    Console.WriteLine("Invalid Key");
                    Console.ReadLine();
                    Console.Clear();
                    goto eventMenu;
            }

        }
    }
}
