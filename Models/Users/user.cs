using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neudesic.Events.Models
{
    public class User
    {
        public List<string> UserName { get; set; } = new List<string>();
        public List<string> UserPassword { get; set; } = new List<string>();
        public string NameInput {get; set;}
        public string PassInput {get; set;}
        public int valid = 0;
        public void UserLogin()

             {
                 
                 userLogin:Console.Clear();

                 Console.WriteLine("\n\tUser Details \n1.User Login \t2.User Register");
                 int userChoice = Convert.ToInt32(Console.ReadLine());
                 Console.Clear();

                 switch (userChoice)
                     {
                        case 1:
                                 Console.WriteLine("Enter Username\n");
                                 NameInput = Console.ReadLine();
                                 Console.WriteLine("Enter Password\n");
                                 PassInput = Console.ReadLine();

                                      if (UserName.Contains(NameInput) && UserPassword.Contains(PassInput))
                                         {
                                            valid = 1;
                                         }

                                      if (valid == 1)
                                         {
                                         break;
                                         }
                                      else
                                         goto userLogin; 

                    
                         case 2:
                                 Console.WriteLine("Enter Username\n");
                                 UserName.Add(Console.ReadLine());
                                 Console.WriteLine("Enter Password\n");
                                 UserPassword.Add(Console.ReadLine());
                                 goto userLogin;
                        default:
                                 Console.WriteLine("Invalid Key");
                                 Console.ReadLine();
                                 goto userLogin;


            }
            }




    }
}
