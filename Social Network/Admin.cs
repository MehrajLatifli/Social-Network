using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSection
{
    class Admin
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }


        public Post[] Posts { get; set; }

        public int PostCount { get; set; } = default;

        public void AddPost(ref Post posts)
        {
            Post[] temp = new Post[++PostCount];
            if (Posts != null)
            {
                Posts.CopyTo(temp, 0);

            }
            temp[temp.Length - 1] = posts;
            Posts = temp;
        }


        public bool RemovePost(int ID)
        {
            Console.ForegroundColor = ConsoleColor.White;
        
 

            

            bool found = false;
            for (int i = 0; i < Posts.Length; ++i)
            {
                if (found)
                {
                    Posts[i - 1] = Posts[i];
                }
                else if (Posts[i].Id == ID)
                {
                    found = true;
                }
            }
            return found;

        }

        public Admin()
        {
       
        }

 

        public void AdminShow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n ==== Log in for Admin ========================================================= ");
            Console.WriteLine($"\n Id: \t\t {Id}");
            Console.WriteLine($" Username: \t {Username}");
            Console.WriteLine($" Password: \t {Password}");
            Console.WriteLine($" Gender: \t {Gender} ");
            Console.WriteLine($" Email: \t {Email} \n");
            Console.WriteLine(" =============================================================================== \n");
        }

      
    }
}
