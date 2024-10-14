using System;
//Jakob,daoud 
//.net24
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 21); // Slumpar ett tal mellan 1 och 20
        int numberOfTries = 5;

        Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

        for (int i = 0; i < numberOfTries; i++)
        {
            Console.Write("Gissa ett tal: ");
            string input = Console.ReadLine();
            int userGuess;

            // Kontrollera om användarens inmatning är ett giltigt tal
            if (int.TryParse(input, out userGuess))
            {
                if (CheckGuess(userGuess, numberToGuess))
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    return; // Avsluta programmet om gissningen är korrekt
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                }
                else
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                }
            }
            else
            {
                Console.WriteLine("Vänligen mata in ett giltigt heltal.");
            }
        }

        Console.WriteLine($"Tyvärr, du lyckades inte gissa talet på fem försök! Det rätta talet var {numberToGuess}.");
    }

    static bool CheckGuess(int guess, int correctNumber)
    {
        return guess == correctNumber;
    }
}