using System;

namespace exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var NombreMaqique = new Random().Next(3, 10);
                var NombreDevie = 4;

                while (true)
                {
                    
                   
                    Console.WriteLine("entrer un nombre");
                    var Uitilsateur = Console.ReadLine();
                    var user = Convert.ToInt32(Uitilsateur);


                    if (user < NombreMaqique || user > NombreMaqique)
                    {
                        Console.WriteLine("veuillez entrer un nombre svp!");

                    }
                    else
                    {
                        if (NombreDevie == 0)
                        {
                            Console.WriteLine("vous avez perdu");
                        }

                        if (user > NombreMaqique)
                        {
                            Console.WriteLine("Ce nombre est trop grand");
                        }
                        else if (user < NombreMaqique)
                        {
                            Console.WriteLine("Ce nombre est trop petit");
                        }
                        else
                        {
                            Console.WriteLine("Bravo vous avez trouvé le nombre magique");
                            break;
                        }
                    }
                    

                    
                    
                    NombreDevie--;
                }
               
            }
            catch
            {
                Console.WriteLine("entrer un nombre svp");

            }
        }
    }
}
