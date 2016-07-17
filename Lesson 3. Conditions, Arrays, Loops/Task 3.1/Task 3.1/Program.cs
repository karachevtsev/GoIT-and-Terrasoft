using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string login;
            string password;
            byte probe;
            int countOfUsers = 0;
            string nameOfUsers = "";

            string[] userRole = new string[] { "Admin", "Moderator", "Moderator", "User", "User", "User" };
            string[] userLogin = new string[] { "Admin", "Moder", "Moderforum", "Pupkin", "Kesha", "Gosha"};
            string[] userPassword = new string[] { "Admin123", "Moder123", "Moderfg123", "Pupkin123", "Kesha123", "Gosha123"};

            Console.Write("Please, enter your login:");
            login = Console.ReadLine();

            //Set 3 probes 
            probe = 3;

            for (int i = 0; i < userLogin.Length; i++)
            {
                if (login == userLogin[i])
                {
                    for (int j = 0; j < probe; j++)
                    {
                        Console.Write("Please, enter your password:");
                        password = Console.ReadLine();

                        if (password == userPassword[i])
                        {
                            if (userRole[i] == "Admin")
                            {
                                for (int k = 0; k < userLogin.Length; k++)
                                {
                                    Console.WriteLine("{0}: Login: {1}, Password: {2}", userRole[k], userLogin[k], userPassword[k]);
                                }
                            }
                            else if (userRole[i] == "Moderator")
                            {
                                Console.WriteLine("Quantity of all users: {0}", userLogin.Length);
                            }
                            else
                            {
                                for (int l = 0; l < userRole.Length; l++)
                                {
                                    if (userRole[l] == "User")
                                    {
                                        countOfUsers++;
                                        nameOfUsers += userLogin[l] + "; ";
                                    }
                                }
                                Console.WriteLine("Quantity with role users {0}-users. User names: {1}", countOfUsers, nameOfUsers);
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Password is incorrect");
                        }
                    }
                }               
            }
            Console.ReadKey();
        }
    }
}
