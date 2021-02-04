using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminSection
{
    class Post
    {


        public string Posting { get; set; }
        public string Posttime { get; set; } = default;
        public int Id { get; set; }
        public static int Post_id { get; set; } = 0;
        public int Like { get; set; } = 0;
        public int View { get; set; } = 0;
        public int ULike { get; set; } = 0;
        public int UView { get; set; } = 0;

        public Post()
        {
            Id = Post_id++;

          
            
        }
        public string Date()
        {
 





            DateTime cardDate =  DateTime.Now;

            string year_ = cardDate.Year.ToString();
            string month_ = cardDate.Month.ToString();
            string day_ = cardDate.Day.ToString();
            string hour_ = cardDate.Hour.ToString();
            string minute_ = cardDate.Minute.ToString();
            string second_ = cardDate.Minute.ToString();
            string millisecond_ = cardDate.Millisecond.ToString();


            string time = $"{day_} / {month_} / {year_}    ||    {hour_} : {minute_} : {second_}: {millisecond_}";

            return time;

        }
        public void AdminPost ()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n Input posting: ");
            Posting = Console.ReadLine();
        }
        public void AdminPostShow()
        {
             
            Posttime = Date();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n ==== Posting ================================================================ ");
            Console.WriteLine($"\n Id: \t\t {Id}");
            Console.WriteLine($" Post: \t\t\t {Posting}");
            Console.WriteLine($" Post time: \t\t {Posttime} \n");
            Console.WriteLine($" Like: \t\t\t {ULike}");
            Console.WriteLine($" View: \t\t {UView} \n");
            Console.WriteLine(" =============================================================================== \n");
        }

        public void Userpostreaction()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($" Like post -> 1: ");
            int liker = 0;
            liker = Convert.ToInt32(Console.ReadLine());
            if (liker == 1)
            {
                ULike= (Like += 1);
                UView = (View += 1);
                Console.WriteLine("\n ==== Post Reaction ========================================================= ");
                Console.WriteLine($"\n Id: \t\t {Id}");
                Console.WriteLine($" Post: \t\t\t {Posting}");
                Console.WriteLine($"\n Like: \t\t {ULike}");
                Console.WriteLine($" View: \t\t {UView} \n");
                Console.WriteLine(" =============================================================================== \n");

            }

            else
            {
                ULike = Like;
                UView = (View += 1);

                Console.WriteLine("\n ==== Post Reaction ========================================================= ");
                Console.WriteLine($"\n Id: \t\t {Id}");
                Console.WriteLine($" Post: \t\t\t {Posting}");
                Console.WriteLine($"\n Like: \t\t {ULike}");
                Console.WriteLine($" View: \t\t {UView} \n");
                Console.WriteLine(" =============================================================================== \n");
            }
        }

        public void UserpostreactionForAdmin()
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n ==== Post Reaction ========================================================= ");
            Console.WriteLine($"\n Id: \t\t {Id}");
            Console.WriteLine($" Post: \t\t\t {Posting}");
            Console.WriteLine($"\n Like: \t\t {ULike}");
            Console.WriteLine($" View: \t\t {UView} \n");
            Console.WriteLine(" =============================================================================== \n");

     
        }


      
    }
}
