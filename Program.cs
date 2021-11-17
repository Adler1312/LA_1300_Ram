using System;
using System.IO;

namespace KarteikartenApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            string inPath = @"C:\Users\Altrim Muharemi\Desktop\KarteiKarten\KarteikartenApp.csv";
            StreamReader sr = new StreamReader(inPath);
            string everything = sr.ReadToEnd();

            string[] lines_ = everything.Split("\r\n");
            string[] english = new string[lines_.Length];
            string[] german = new string[lines_.Length];

            for (int i = 0; i < lines_.Length; i++)
            {
                string[] line = lines_[i].Split(";");
                german[i] = line[0];
                english[i] = line[1];
            }

            int correctattemps = 0;


            Console.WriteLine("Möchten sie in Englisch oder in Deutsch übersetzten: [DE/EN]");
            string language = Console.ReadLine();
            Console.WriteLine("möchten sie mit dem spiel starten? [y|n]");
            string answer = Console.ReadLine();
            bool isEn = true;
            bool isDe = false;


            if (isEn)
            {
                while (true)
                {

                    Random rnd = new Random();
                    int random = rnd.Next(0, lines_.Length);

                    Console.WriteLine("Was ist die Übersetung von: " + german[random]);
                    string userInput = Console.ReadLine();

                    if (userInput == english[random])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The answer is right");
                        Console.ResetColor();
                        correctattemps++;
                        Console.WriteLine("möchten sie weiter spielen [y|n]");
                        answer = Console.ReadLine();
                        if (answer == "n")
                        {
                            Console.WriteLine("Dieser Program wurde beendet");
                            Console.WriteLine("Ihr Highscore beträgt " + correctattemps);
                            Environment.Exit(0);
                        }

                    }



                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("False. The right answer is = " + english[random]);
                        Console.ResetColor();
                        Console.WriteLine("möchten sie weiter spielen [y|n]");
                        answer = Console.ReadLine();
                        if (answer == "n")
                        {
                            Console.WriteLine("Dieser Program wurde beendet");
                            Console.WriteLine("Ihr Highscore beträgt " + correctattemps);
                            Environment.Exit(0);
                        }

                    }

                    Console.ReadKey();
                }
               

            }


            if (isDe)
            {
                while (true)
                {

                    Random rnd = new Random();
                    int random = rnd.Next(0, lines_.Length);


                    Console.WriteLine("Was ist die Übersetung von: " + english[random]);
                    string userInput = Console.ReadLine();

                    if (userInput == german[random])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("The answer is right");
                        Console.ResetColor();
                        correctattemps++;
                        Console.WriteLine("möchten sie weiter spielen [y|n]");
                        answer = Console.ReadLine();
                        if (answer == "n")
                        {
                            Console.WriteLine("Dieser Program wurde beendet");
                            Console.WriteLine("Ihr Highscore beträgt " + correctattemps);
                            Environment.Exit(0);
                        }

                    }





                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("False. The right answer is = " + german[random]);
                        Console.ResetColor();
                        Console.WriteLine("möchten sie weiter spielen [y|n]");
                        answer = Console.ReadLine();
                        if (answer == "n")
                        {
                            Console.WriteLine("Dieser Program wurde beendet");
                            Console.WriteLine("Ihr Highscore beträgt " + correctattemps);
                            Environment.Exit(0);
                        }
                    }


                }
                
            }
            
        }
    }
}