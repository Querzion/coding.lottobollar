using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottobollar
{
    internal class G_LB
    {
        private static Random Rand = new Random();

        public static int RInt(int i, int j)
        {

            int Nummer = Rand.Next(i, j);

            return Nummer;
        }

        public static void Lottobollar() {

            //*     Variables:
            int RandomNR = Rand.Next(1, 21);
            string Name;
            //*/

            //*    Arrays:
            string[] lottobollar = new string[11];
            string[] answer = new string[11];
            //*/

            //*     Player Name:
            Console.Write("\n |----------------------------------------------------------------| \n" +
                          "\n   Detta är Lottobollar. Vad heter du? \n" + 
                          "\n |----------------------------------------------------------------| \n" +
                          "\n       Svara:  » ");

            Name = Console.ReadLine();
            //*/

            Console.Clear();
            Console.WriteLine("\n |----------------------------------------------------------------| \n" +
                              "\n   Välkommen {0}! \n" + 
                              "\n |----------------------------------------------------------------| ", Name);
            //*     Lottobollar:      
            for (int i = 1; i < answer.Length; i++)
            {

                Console.Write("\n   Gissa på Lottobollens nummer: (1 - 21) \n" +
                              "\n       Omgång {0} av 10: » ", i);

                answer[i] = Console.ReadLine();
                lottobollar[i] = Convert.ToString(RInt(1, 22));
                
                if (Convert.ToInt32(answer[i]) >= 1 && Convert.ToInt32(answer[i]) <= 21) {

                    if (answer[i] == lottobollar[i])
                    {
                        Console.Clear();
                        Console.WriteLine("\n |----------------------------------------------------------------| \n" +
                                          "\n   Du hade rätt " + Name + "! Rätt nummer var: {0} \n" +
                                          "\n |----------------------------------------------------------------| ", lottobollar[i]);

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n |----------------------------------------------------------------| \n" +
                                          "\n   " + Name + ", du hade fel. Rätt nummer var: {0} \n" +
                                          "\n |----------------------------------------------------------------| ", lottobollar[i]);
                    }
                } else { 
                    
                    Console.Clear();
                    Console.WriteLine("\n |----------------------------------------------------------------| \n" +
                                      "\n   Försök igen {0}. Numret måste vara mellan 1 och 21.\n" +
                                      "\n |----------------------------------------------------------------| ", Name);
                    i--;
                    continue;
                }
            }       //*/


            Console.Clear();

            //*
            Console.Write("\n |----------------------------------------------------------------| \n" +
                          "\n   Dina gissningar");
            foreach (string i in answer)
            {
                Console.Write(i + ". ");
            }       //*/
            //*
            Console.Write("\n   Samt Lottobollar");
            foreach (string i in lottobollar)
            {
                Console.Write(i + ". ");
            }       //*/
            
            //*
            Console.WriteLine("\n\n   Tack för att du spelat: LOTTOBOLLAR! \n" +
                              "\n |----------------------------------------------------------------| \n" +
                              "\n   Tryck ENTER för att återgå till menyn.");
            //*/
            Console.ReadKey();

        }
    }
}
