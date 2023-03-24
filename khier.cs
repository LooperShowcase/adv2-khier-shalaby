using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kheirshalaby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("welcome to my game");

            char[] lines = { '_', '_', '_', '_'};
            for(int i = 0; i < lines.Length; i++)
            {
                Console.Write(lines[i]+" ");
            }
            Console.WriteLine();
            string todayWord = getTodayWord();
            int heart = getTodayWord().Length ;

            while (heart > 0)
            {
                char c = askuser();
                int result = checkLetter(todayWord,c,lines);
                if(result==-1)
                {
                    Console.WriteLine("You have " + heart + " <3 left");
                    heart--;
                }
                else
                {
                    lines[result] = c;
                    for (int i = 0; i < lines.Length; i++)
                    {
                        Console.Write(lines[i]+" ");
                    }
                    
                    Console.WriteLine("You got it right! keep going (:");
                }
                if(checkWin(lines)==true)
                {
                    Console.WriteLine("You win!!!");
                }

            }
            Console.WriteLine("You lose, loser hahahahaha");
            Console.ReadKey();
        }
        public static char askuser ()
        {
            Console.WriteLine("please enter a char:");
            char c = Console.ReadLine()[0];
            return c;
        }
        public static string getTodayWord()
        {
            string[] words = { "home", "word", "farm", "camp", "luck", "love","duck","sing","dark","step","come","rain","mood","free","bird", "sing"};
            Random rnd = new Random();
            int num = rnd.Next(0,words.Length);
            return words[num];
        }

        public static bool checkWin(char[] lines) {
            for (int i = 0; i < lines.Length; i++) {
                if (lines[i] == '_') {
                    return false;
                }
            }

            return true;
        }

        public static int checkLetter (string todayword,char ch , char[] lines)
        {
            for (int i = 0; i<todayword.Length; i++)
            {
                if (todayword[i] == ch) {
                    return i;
                }
            }
            return -1;
        }
    }
}
