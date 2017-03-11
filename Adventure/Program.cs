using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Welcome To an Adventure Tale! -------");
            Console.WriteLine("-- It's not only an Adventure, it's a Tale! --");
            Console.WriteLine("----------Press enter to continue ----------");
            Console.ReadLine();

            Console.WriteLine("You awake, dizzy and disheveled. You have no idea where you are, but you have a huge headache. You look around and it looks as though you're stuck in a maze with 20 meter high hedges. Behind you, a dead end. In front, a large open area and 3 seperate paths.");
            Console.ReadLine();
            Console.Write("When you're ready, Get up. \n");
            string input1 = Console.ReadLine();
                
                    while (input1 != "Get up")
                    {
                        Console.Write("You're still lying down. You can 'Get up' whenever you want. \n");
                        input1 = Console.ReadLine();
                    }
            Console.WriteLine("\n");
            Console.Write("You finally muster up some strength and get up on your feet. You move towards the center, and now, in front of you, is a big door. Do you want to open it? \n");
            string input2 = Console.ReadLine();

                    while (input2 != "Yes")
                    {
                        Console.Write("Are you going to open it or not? We can sit here all day bud, until you decide to say 'Yes' to open it. \n");
                        input2 = Console.ReadLine();
                    }
            Console.WriteLine("\n");
            Console.WriteLine("You walk through, and the door is automatically shut. Spooky.");
            Console.ReadLine();
            Console.WriteLine("You immediately turn around, and see behind the door hanging a shining sword. What is this, the 1200s?");
            Console.ReadLine();
            Console.Write("Do you want to grab the sword? \n");
            string input3 = Console.ReadLine();

                    while (input3 != "Yes")
                    {
                        Console.Write("Are you crazy? 'Yes', Take the damn sword you fool \n");
                        input3 = Console.ReadLine();
                    }

            Console.WriteLine("\n");
            Console.Write("Now lets traverse this maze. You start walking straight, and after a minute you reach a fork. You want to turn Right or Left? \n");
            string input4 = Console.ReadLine();

                    while(input4 != "Right")
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("You walk a 100 meters, and you see a figure. It's a tall, slender man ? ...");
                        Console.ReadLine();
                        Console.WriteLine("You rub your eyes, where'd it go? You must be hallucinating, no no, you can't be you assure yourself. You clench your sword tighter.");
                        Console.ReadLine();
                        Console.Write("Like the idiot you are, you keep walking ahead. You reach another fork. Left, or Straight? \n");
                        string input5 = Console.ReadLine();
                        Console.WriteLine("\n");
                        Console.WriteLine("5 meters in, IT ATTACKS! AHHHHHHHH YOU DROP YOUR SWORD AND RUNNNNN");
                        Console.ReadLine();
                        Console.Write("You run and run until you reach back to the first fork, but this time you head RIGHT \n");
                        input4 = "Right";
                    }
           Console.ReadLine();
           Console.WriteLine("\n");
           Console.WriteLine("You head right, and you see a light! Oh my god is that the end? Thank god I'm finally getting out");
           Console.ReadLine();
           Console.WriteLine("You finally get out but WHAT?! WHERE THE HELL AM I?");
           Console.ReadLine();
           Console.WriteLine("DUN DUN DUNNNNNNNNNN");
           Console.ReadLine();
           Console.WriteLine("To Be Continued...");
           Console.ReadLine();
           Console.WriteLine("-------- THANKS FOR FINISHING THE GAME! ---------");
           Console.WriteLine("------------- Story by: Tareq Karimi ----------");
           Console.WriteLine("----------- First game, more on the way!-------");
           Console.WriteLine("----------- Made it in an hour on-------");
           Console.WriteLine("---- a Friday Night, because yeah coding!-------");
            

           Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();
            Console.ReadLine();




        }
    }
}
