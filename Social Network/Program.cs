using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Social_Network
{
    class Program
    {
        static void Main(string[] args)
        {

       
            AdminSection.Post p1 = new AdminSection.Post();
            AdminSection.Post p2 = new AdminSection.Post();

            for (int i = 0; i < 1000; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n 1 <- Admin ");
                Console.WriteLine("\n 2 <- User ");
                Console.Write("\n Enter: ");
                string sa = Console.ReadLine();
                int pa;
                int.TryParse(sa, out pa);

                if (pa == 1)
                {

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n Enter Admin name: ");
                    string adminname1 = Console.ReadLine();

                    for (int j = 0; j < 3; j++)
                    {
                        if (adminname1 == null || adminname1 != "admin")
                        {
                            Console.WriteLine($"\n {j + 1} chance ");
                            Console.Write("\n Enter Admin name: ");
                            adminname1 = Console.ReadLine();
                        }

                    }


                    Console.Write("\n Enter Admin password: ");
                    string spassword1 = Console.ReadLine();
                    int password1;
                    int.TryParse(spassword1, out password1);
                    Console.ForegroundColor = ConsoleColor.White;

       

                    int.TryParse(spassword1, out password1);
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int j = 0; j < 3; j++)
                    {
                        if (password1 == null || password1 != 1)
                        {
                            Console.WriteLine($"\n {j + 1} chance ");
                            Console.Write("\n Enter User password: ");
                            spassword1 = Console.ReadLine();
                            int.TryParse(spassword1, out password1);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }

                    if (password1 == 1 && adminname1 == "admin")
                    {

                        AdminSection.Admin a1 = new AdminSection.Admin()
                        {
                            Id = 1,
                            Username = "admin",
                            Password = 1,
                            Gender = "Male",
                            Email = "adminsite@gmail.com"
                        };


                        a1.AdminShow();


                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n 1 <- Add post ");
                        Console.WriteLine("\n 2 <- Show post ");
                        Console.WriteLine("\n 3 <- Notification ");

                        Console.Write("\n Enter: ");
                        string c = Console.ReadLine();
                        int ci;
                        int.TryParse(c, out ci);
                        if (ci == 1)
                        {
                            a1.AddPost(ref p1);
                            p1.AdminPost();

                            a1.AddPost(ref p2);
                            p2.AdminPost();

                        }
                        if (ci == 2)
                        {
                            p1.AdminPostShow();

                            p2.AdminPostShow();




                        }

                        if (ci == 3)
                        {

                            p1.UserpostreactionForAdmin();
                            p2.UserpostreactionForAdmin();

                        }
                    }

                    if (password1 != 1 || adminname1 != "admin")
                    {

                        Console.Write("\n Enter Error: ");
                        break;
                    }
                }
                

           

                if (pa == 2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n Enter User name: ");
                    string username1 = Console.ReadLine();
                    for (int j = 0; j < 3; j++)
                    {
                        if(username1==null || username1 != "user")
                        {
                            Console.WriteLine($"\n {j+1} chance ");
                            Console.Write("\n Enter User name: ");
                            username1 = Console.ReadLine();
                        }
                         
                    }

                        Console.Write("\n Enter User password: ");
                    string supassword1 = Console.ReadLine();
                    int upassword1;

                    int.TryParse(supassword1, out upassword1);
                    Console.ForegroundColor = ConsoleColor.White;

                    for (int j = 0; j < 3; j++)
                    {
                        if (upassword1 == null || upassword1 != 1)
                        {
                            Console.WriteLine($"\n {j+1} chance ");
                            Console.Write("\n Enter User password: ");
                            supassword1 = Console.ReadLine();
                            int.TryParse(supassword1, out upassword1);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    }

                    if (upassword1 == 1 && username1 == "user")
                    {

                        UserSection.User u1 = new UserSection.User()
                        {
                            Id = 1,
                            Username = "user",
                            Password = 1,
                            Gender = "Male",
                            Email = "user@socialprojectalfabeta.com"
                        };

                        u1.UserShow();


                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("\n 1 <- Show post ");
                        Console.WriteLine("\n 2 <- Like post ");
                   

                        Console.Write("\n Enter: ");
                        string c2 = Console.ReadLine();
                        int ci2;
                        int.TryParse(c2, out ci2);
                        if (ci2 == 1)
                        {

                        p1.AdminPostShow();
                        p2.AdminPostShow();
                        }

                        if (ci2 == 2)
                        {

                           
                        p1.AdminPostShow();
                        p1.Userpostreaction();
                        p2.AdminPostShow();
                        p2.Userpostreaction();
                        }



                    }

                    if (upassword1 != 1 && username1 != "user")
                    {
                        Console.Write("\n Enter Error: ");
                        break;
                    }
                }



 






















                Console.ReadKey();
            }
        }
    }
}
