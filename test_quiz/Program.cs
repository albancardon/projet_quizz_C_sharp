using System;
namespace Projet_La_Manu_Quiz_by_Meriem_Alban_and_Marc;
class Quiz
{
    static void Main(string[] args)
    {
        //voir animation titre ?
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Bonjour et bienvenu dans notre agence de recrutement !\n");
        Console.WriteLine("Voici un QUIZ sur le C# qui nous servira à évaluer vos compétences.");
        Console.WriteLine("10 Questions mais ATTENTION ! Une seule réponse est possible par question !");
        Console.WriteLine("Alors appuyer sur la touche ENTRÉE et allons-y !\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();

        string[] questions = new string[10] {
            // vérif réponse correct ?
            "Quelle est l'année de création du langage C# ?",
            "C# est un...",
            "Quelle est la variable correcte ?",
            "Quelle est l'expression utilisée pour conditionner une instruction ?",
            "Parmi les types de données proposés ci-dessous en langage C#, lesquels permettent de stocker des nombres décimaux ?",
            "Vous souhaitez déclarer une variable capable de contenir le nombre 375 456 756. Quel est le type de données de base le plus approprié ?",
            "Si la valeur de A est FALSE et celle de B est TRUE, quelle sera la valeur de A && B ?",
            "Quel élément du langage C# permet de créer des objets pointant vers un bloc d'instructions ?",
            "Quelle méthode est utilisée pour convertir une chaîne de caractères en un entier en utilisant C# ?",
            "Quelle méthode est utilisée pour arrondir un nombre décimal à l'entier le plus proche en utilisant C# ?",
        };

        string[,] answers = new string[10, 4] {
            { "1971", "1981", "1991", "2001" },
            { "Language", "Framework", "Librairie", "CMS" },
            { "string = 3;", "int = x = \"3\";", "string = '3';", "int x = 3;" },
            { "(x == true);", "x == true;", "x &= true;", "x =< true;" },
            { "Float", "Long", "Int", "Byte" },
            { "Int", "Long", "Short", "Byte" },
            { "True", "La console se met en erreur.", "False", "Les trois premières fonctionnent." },
            { "Les énumérations", "Les types nullables", "Les délégués", "L'inférence de type" },
            { "Convert.ToInt32()", "Parsse()", "TryeParse()", "Convert.ToInt16()" },
            { "Math.Round()", "Math.Ceiling()", "Math.Floor()", "Math.Truncate()" }
        };

        int[] correctAnswers = new int[10] {
            4, 1, 4, 1, 1, 2, 3, 3, 1, 1
        };

        string[] correctAnswerDetails = new string[] {
            "2001", "Language", "int x = 3;", "(x == true);", "Float", "Long", "False", "Les délégués", "Convert.ToInt32()", "Math.Round()"
        };

        int score = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Question {i + 1}: {questions[i]}\n");
            Console.ForegroundColor = ConsoleColor.White;

            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine($"{j + 1}. {answers[i, j]}");
            }

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nVotre réponse (entrez le numéro de votre réponse):");
                Console.ForegroundColor = ConsoleColor.White;
                string saisie = Console.ReadLine();
                int userAnswer;
                if (int.TryParse(saisie, out userAnswer))
                {
                    if (userAnswer == correctAnswers[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Bonne réponse !\n");
                        score++;
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Mauvaise réponse :(\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    };
                }
                else
                {
                    Console.WriteLine("veuillez entrer un chiffre\n");
                };
            } while (true);

        }

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Appuyez sur la touche ENTRÉE pour connaître votre résultat");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();

        Console.WriteLine("Récapitulatif de votre résultat:\n");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Votre score est de: {score} sur 10\n");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine("Les bonnes réponses étaient:\n");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Question {i + 1}: {correctAnswerDetails[i]}");
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nMerci d'avoir répondu au test.");
        Console.WriteLine("Notre agence reprendra contact avec vous dans un délai de 48h.");
        Console.WriteLine("Au revoir.");
        Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("| Projet réalisé par Meriem, Alban et Marc | Aprenant Dot .NET au campus de La Manu Compiègne |");
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();

    }
}

//TEST + Vérif orthographe !!!