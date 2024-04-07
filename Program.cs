namespace Boucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int sizeArr = 32;
            string[] moves = new string[sizeArr];
            int iteration = 0;


            while (true)
            {
                // Affichage du nombre de pas restant : 
                if (Math.Abs(iteration - moves.Length) > 0)
                    Console.WriteLine($"il vous reste {Math.Abs(iteration - moves.Length)} de pas disponible");

                // Verification si l'iteration exede la taille du tableau : 
                if (iteration > moves.Length - 1)
                    break;

                // Recuperation du pas de danse : 
                Console.Write("Saisit un pas de danse :");
                string? saisitUser = Console.ReadLine();

                // Verification du pas de danse : 
                if (string.IsNullOrEmpty(saisitUser))
                    Console.WriteLine("Pas de danse invalid.");
                else
                {
                    // Verification si l'utilisateur decide de stopper : 
                    if (saisitUser == "done")
                        break;

                    // Recuperation de l'iteration de pas de danse : 
                    Console.Write("Saisit une iteration de cette suite de pas de danse :");
                    string? saisitIterationPas = Console.ReadLine();


                    // Verification du nombre d'iteration : 
                    if (int.TryParse(saisitIterationPas, out int sizeIteration) && sizeIteration > 0)
                    {
                        if (iteration + sizeIteration > sizeArr)
                            Console.WriteLine($"Trop d'itérations, il ne reste que {Math.Abs(sizeArr - iteration)} pas disponibles.");
                        else
                        {
                            // on ajoute au tableau de moves le nombre d'iteration : 
                            for (int i = 0; i < sizeIteration; i++)
                            {
                                moves[iteration] = saisitUser;
                                iteration++;
                            }
                        }
                    }
                    else Console.WriteLine("Nombre d'itérations invalide.");

                    Console.Clear();
                }
            }

            // Affichage des pas de dances : 
            Console.WriteLine("\n\nList de vos pas de dances :");
            for (int i = 0; i < moves.Length; i++)
            {
                if (moves[i] != null)
                    Console.WriteLine($"[{i + 1}]: {moves[i]}");
            }

        }
    }
}
