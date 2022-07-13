using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace JokeBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "JokeBot";
            Console.ForegroundColor = ConsoleColor.Red;
            while (true)
            {
                Joke();
                Thread.Sleep(10000);
            }
        }
        static void Joke()
        {
            string joke1 = "- Miért mennek a szőke nők egyszerre 19-en moziba?\n- ??? \n- Mert 18 alatt nem ajánlotrt a film...";
            string joke2 = "Egy gyilkos kivégése van bekötött szemmel áll a\n  kivégzőaztal elött. Megszólal az ítéletvégrehajtó:\n - Eljött az ideje, most van egy utolsó kívánsága! \nA gyilkos:\n- Azt szeretném hogy egy magyar focista lőjön! ";
            string joke3 = "Az első osztályban a tanítónéni megkérdezi:\n - Mit mond a tehén?\n- Múú.\n - Mit mond a macska?\n- Miáúúú.\n - Remek! És az egér?\n - Klikk!";
            string joke4 = "- Miért teszi az informatikus a megmaradt kaját a mélyhűtő helyett a számítógép alá?\n -???\n - Mert Windows alatt minden lefagy!";
            string joke5 = "- Melyik az a Microsoft termék, amivel sohasem fogsz szívni?\n- A Microsoft porszívó...";
            string joke6 = "Két informatikus találkozik.\n Adj már kölcsön egy ezrest -mondja az egyik.\n-REndben, de legyen inkább 1024, hogy kerek legyen.";
            string joke7 = "Mi az abszolút nagyképűség?\n-???\n-Amikor egy giliszta mondja, hogy elmegy horgászni.";
            string joke8 = "-Hogy hívják a medve mellszobrát?\n-???\n-Mackófelső";
            string joke9 = "-Mit eszik a Terminátor?\n-Gépsonkát";
            string joke10 = "- Mi az? Kék és 3 betű?\n-???\n - Kék.";
            var random = new Random();
            int randomnumber = random.Next(1, 11);
            if(randomnumber == 1)
            {
                Console.WriteLine(joke1);
            }
            else if(randomnumber == 2)
            {
                Console.WriteLine(joke2);
            }
            else if(randomnumber == 3)
            {
                Console.WriteLine(joke3);
            }
            else if(randomnumber == 4)
            {
                Console.WriteLine(joke4);
            }
            else if(randomnumber == 5)
            {
                Console.WriteLine(joke5);
            }
            else if(randomnumber == 6)
            {
                Console.WriteLine(joke6);
            }
            else if(randomnumber == 7)
            {
                Console.WriteLine(joke7);
            }
            else if(randomnumber == 8)
            {
                Console.WriteLine(joke8);
            }
            else if(randomnumber == 9)
            {
                Console.WriteLine(joke9);
            }
            else if(randomnumber == 10)
            {
                Console.WriteLine(joke10);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
