using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserSection
{
    class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }

        public int ULike { get; set; } = 0;
        public int UView { get; set; } = 0;

        public AdminSection.Post[] Posts { get; set; }
        public int PostCount { get; set; } = default;


        public User()
        {
       
            ULike += 1;
            UView += 1;
        }
        public void UserShow()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n ==== Log in for User ========================================================= ");
            Console.WriteLine($"\n Id: \t\t {Id}");
            Console.WriteLine($" Username: \t {Username}");
            Console.WriteLine($" Password: \t {Password}");
            Console.WriteLine($" Gender: \t {Gender} ");
            Console.WriteLine($" Email: \t {Email} \n");
            Console.WriteLine(" =============================================================================== \n");
        }

    

        public void Userpostreaction()
        {
                Console.Write($" Like post -> 1: ");
                int liker = 0;
            liker = Convert.ToInt32(Console.ReadLine());
            if (liker == 1)
            {
              
                Console.WriteLine("\n ==== Post Reaction ========================================================= ");
                Console.WriteLine($"\n Like: \t\t {ULike}");
                Console.WriteLine($" View: \t\t {UView} \n");
                Console.WriteLine(" =============================================================================== \n");

            }

            else
            {
                Console.WriteLine("\n ==== Post Reaction ========================================================= ");
                Console.WriteLine($"\n Like: \t\t {0}");
                Console.WriteLine($" View: \t\t {UView} \n");
                Console.WriteLine(" =============================================================================== \n");
            }
        }

        public void UserpostreactionForAdmin()
        {
          
              
                Console.WriteLine("\n ==== Post Reaction ========================================================= ");
                Console.WriteLine($"\n Like: \t\t {ULike}");
                Console.WriteLine($" View: \t\t {UView} \n");
                Console.WriteLine(" =============================================================================== \n");

            
        }

        }
}
