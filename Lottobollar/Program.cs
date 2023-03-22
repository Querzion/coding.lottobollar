using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lottobollar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      Turn any section of by deleting one of the slashes before the segment.


            //*     Music:   »   Downloaded from https://archive.org/details/TobyFoxMegalovania
            Ambiance.PlayMusic("bgm.wav");
            //*/

            //*     Variables:
            string Input;
            //*/

            //  LOOP THE MENU - TRUE
            while (true)
            {
                Console.Clear();


                //*     Output: MENU
                Console.WriteLine("\n |----------------------------------------------------------------| \n" +
                                  "\n   1. [L] Starta: Lottobollar \n" +
                                  "\n   2. [A] Avsluta Programmet: \n" +
                                  "\n |----------------------------------------------------------------| ");
                //*/

                //*     Input: MENU
                Console.Write("\n   Skriv in ditt meny val: \n      »   ");
                Input = Console.ReadLine();
                
                //*     MENU: Option 1
                if (Input == "L" || Input == "l" )
                {
                    Console.Clear();
                    G_LB.Lottobollar();
                    Console.ReadKey();
                }       //*/

                //*     MENU: Exit Application
                else if (Input == "A" || Input == "a")
                {
                    Console.Clear();
                    Console.WriteLine("\n |----------------------------------------------------------------| \n" +
                                      "\n   Tack för din tid! Välkommen åter. \n" +
                                      "\n |----------------------------------------------------------------| \n" +
                                      "\n   Tryck ENTER för att Avsluta programmet.");
                    Console.ReadKey();
                    break;
                }       //*/


                //*     MENU: Not Valid Option
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n |----------------------------------------------------------------| \n" + 
                                      "\n   Det valet finns inte! Gör ett nytt val i menyn! \n" + 
                                      "\n |----------------------------------------------------------------| \n" +
                                      "\n   Tryck ENTER för att gå tillbaka till menyn.");

                    Console.ReadKey();
                }       //*/
            }
        }
    }
}
