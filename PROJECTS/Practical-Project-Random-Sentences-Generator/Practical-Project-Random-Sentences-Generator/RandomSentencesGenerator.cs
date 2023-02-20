using System;

namespace Practical_Project_Random_Sentences_Generator
{
    class RandomSentencesGenerator
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "George", "John", "Rony", "Christian", "Melany", "Polly", "Krasimir", "Radoslav" };
            string[] places = { "London", "Paris", "Madrid", "Sofia", "Belgrad", "Bucharest" , "Berlin", "Manchester"};
            string[] nouns = { "stones", "cake", "grape", "computer", "motorbike", "mobile phone", "book", "car" };
            string[] verbs = { "eats", "sees", "plays with", "brings", "holds", "jumps", "is running", "sends", "sleeps" };
            string[] adverbs = { "warmly", "slowly", "diligently", "rapidly", "sadly", "carefully", "arrogantly", "almost" };
            string[] details = { "at home", "in the park", "near the river", "in the sea", "in the garden", "on the beach", "at work" };

            string GetRandomWord(string[] words)
            {
                Random random = new Random();
                int randomIndex = random.Next(words.Length);
                string word = words[randomIndex];
                return word;
            }

            Console.WriteLine("Hello, this is your first random generated sentence: ");
            Console.WriteLine("Press [Enter]");
            while (true)
            {
                string generator = Console.ReadLine().ToLower();
                if (generator == "exit")
                {
                    break;
                }
                string randomName = GetRandomWord(names);
                string randomPlace = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(nouns);
                string randomAdverb = GetRandomWord(adverbs);   
                string randomDetails = GetRandomWord(details);

                string who = $"{randomName} from {randomPlace}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string sentence = $"{who} {action} {randomDetails}.";

                Console.WriteLine(sentence);
                Console.WriteLine();
                Console.WriteLine("Click [Enter] to generate a new one.");
                Console.WriteLine();
                Console.WriteLine("Type 'EXIT' if you want to quit the program.");
            }

            




        }
    }
}
