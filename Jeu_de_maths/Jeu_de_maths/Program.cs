using System;

namespace jeu_de_maths
{
    internal class Program
    {
        enum e_Operateur
        {
            ADDITION= 1,
            MULTIPLICATION = 2,
            SOUSTRACTION= 3,
        }
        static bool PoserQuestion(int min, int max)
        {
            Random rand = new Random();
            int reponseInt = 0;


            while (true)
            {
                int a = rand.Next(min, max + 1);
                int b = rand.Next(min, max + 1);
                e_Operateur o = (e_Operateur)rand.Next(1, 4);
                int resultatAttendu;

                switch (o)
                {
                   case e_Operateur.ADDITION:
                        Console.Write(a + " + " + b + " = ");
                        resultatAttendu = a + b;
                        break;

                    case e_Operateur.MULTIPLICATION:
                        Console.Write(a + " x " + b + " = ");
                        resultatAttendu = a * b;
                        break;

                    case e_Operateur.SOUSTRACTION:
                        Console.Write(a + " - " + b + " = ");
                        resultatAttendu = a - b;
                        break;
                    default:
                        Console.WriteLine(" Erreur : opération innconu");
                        return false;


                }

                // c mis en commentaires pour moi mais c la m chose que le bloc switch en haut

               /* if (o == e_Operateur.ADDITION) 
                {
                    Console.Write(a + " + " + b + " = ");
                    resultatAttendu = a+b;
                }

                else if (o == e_Operateur.MULTIPLICATION)
                {
                    Console.Write(a + " x " + b + " = ");
                    resultatAttendu = a * b;
                }

                else if (o == e_Operateur.SOUSTRACTION)
                { 
                   Console.Write(a + " - " + b + " = ");
                   resultatAttendu = a - b;
                }
                else
                {
                    Console.WriteLine(" Erreur : opération innconu");
                    return false;
                }*/
                
                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);

                    if (reponseInt == resultatAttendu)
                    {
                        return true;
                    }
                    return false;
                }
                catch
                {
                    Console.WriteLine("Erreur: Vous devez rentrer un nombre");
                }
            }
        }
        static void Main(string[] args)
        {
            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            const int NB_QUESTIONS = 5;
            int points = 0;

            for (int i = 0; i < NB_QUESTIONS; i++)
            {
                Console.WriteLine("Question n°" + (i + 1) + " / " + NB_QUESTIONS);

                bool bonneReponse = PoserQuestion(NOMBRE_MIN, NOMBRE_MAX);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne réponse");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise réponse");
                }
            }
            Console.WriteLine("Nombre de points: " + points + "/" + NB_QUESTIONS);

            int moyenne = NB_QUESTIONS / 2;
           
            if (points == NB_QUESTIONS)
            {
                Console.WriteLine ("Excellent!");
            }
            else if (points == 0)
            {
                Console.WriteLine("Révisez vos maths");
            }
            else if (points > moyenne)
            {
                Console.WriteLine("Pas mal");
            }
            else 
            { 
                Console.WriteLine("Peut mieux faire");
            }

        }
    }
}