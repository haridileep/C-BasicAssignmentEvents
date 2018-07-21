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
           EventDetails eventDetails = new EventDetails();
           bool menuPage = true;
           Console.Clear();
           while (menuPage)
           {
                Console.WriteLine("\n\tNeudesic Events \n1. Add Events \t2. View Event\t3.Delete Event");
                Console.WriteLine("\nEnter your choice :\t");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                case 1:
                        Console.WriteLine("\nEnter the Event Name");
                        eventDetails.EventName.Add(Console.ReadLine());
                        Console.WriteLine("\nEnter the Event Venue");
                        eventDetails.EventVenue.Add(Console.ReadLine());
                        break;
                case 2:
                        for (int eventInput = 0; eventInput < eventDetails.EventName.Count ; eventInput++)
                        {
                        Console.Write("Event Id:\t");
                        Console.Write(eventInput);
                        Console.Write("\n");
                        Console.Write("Event name:\t");
                        Console.Write(eventDetails.EventName[eventInput]);
                        Console.Write("\n");
                        Console.Write("Event Venue:\t");
                        Console.Write(eventDetails.EventVenue[eventInput]);
                        Console.Write("\n");
                        }
                        Console.ReadLine();
                        break; 
                case 3:
                        for (int eventInput = 0; eventInput < eventDetails.EventName.Count ; eventInput++)
                        {
                        Console.Write("Event Id:\t");
                        Console.Write(eventInput);
                        Console.Write("\n");
                        Console.Write("Event name:\t");
                        Console.Write(eventDetails.EventName[eventInput]);
                        Console.Write("\n");
                        Console.Write("Event Venue:\t");
                        Console.Write(eventDetails.EventVenue[eventInput]);
                        Console.Write("\n");
                        }
                        Console.WriteLine("Enter the Event Id to be deleted\n");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        eventDetails.EventName.Remove(eventDetails.EventName[deleteId]);
                        eventDetails.EventVenue.Remove(eventDetails.EventVenue[deleteId]);
                        break;
                case 4:
                        menuPage = false;
                        break;
                default:
                        Console.WriteLine("Invalid Key");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
           }
        }
    }
}
