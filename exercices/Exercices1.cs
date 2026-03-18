namespace PooCollege;

public class Exercises1
{
    public static void Exercise1()
    {
        int interNumber = 10;
        Console.WriteLine(interNumber);

        double b = 5.5;
        Console.WriteLine(b);

        string name = "Gabriel";
        Console.WriteLine(name);
        
        bool boolValue = true;
        Console.WriteLine(boolValue);
    }

    public static void Exercise2()
    {
        int firstNumber = 22;
        int secoundNumber = 33;
        Console.WriteLine(firstNumber + secoundNumber);
        Console.WriteLine(firstNumber - secoundNumber);
        Console.WriteLine(firstNumber * secoundNumber);
        Console.WriteLine(firstNumber / secoundNumber);

        int verifyValue = 99;
        string message = verifyValue > 100 ? "The variable is bigger than 100 "
            :"The variable is 100 or less ";
        Console.WriteLine(message);
    }

    public static void Exercise3()
    {
        int firstNumber = 10;
        string message = firstNumber >= 0 ? "The number is positive"
            :"The number is negative";
        Console.WriteLine(message);

        int yearsOld = 17;
        string oldMessage = yearsOld >= 18 ? "Is of legal age"
            : "Is of legal age less than 18";
        Console.WriteLine(oldMessage);
        
        string numberMessage = firstNumber % 2 == 0 ? "The number is pair"
            : "The number is odd";
        Console.WriteLine(numberMessage);

        int note1 = 4;
        int note2 = 7;
        int average = note1 + note2;
        string averageMessage = average >= 6 ? "The student is approved" :
            "The student is rejected";
        Console.WriteLine(averageMessage);
    }

    public static void Exercise7()
    {
        int[] arrayOfNumbers = { 3, 4, 5, 9, 10 };
        foreach (int number in arrayOfNumbers)
        {
            Console.WriteLine(number);
        }

        List<String> listOfNames = ["José", "Ana", "Ricardo"];
        foreach (string name in listOfNames)
        {
            Console.WriteLine(name);
        }
    }

    public static void Exercise8()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number >= 0)
        {
            for (int initialValue = 1; initialValue <= number; initialValue++)
                Console.WriteLine(initialValue);
            
        }
        else
        {
            Console.WriteLine("The number is negative");
        }
    }

    public static void Exercise9()
    {
        Console.Write("Enter a number: ");
        int initialNumber = int.Parse(Console.ReadLine());
        while (initialNumber <= 0)
        {
            Console.WriteLine("The number is negative, write a new number");
            initialNumber = int.Parse(Console.ReadLine());
        }
        while (initialNumber > 0)
        {
            Console.WriteLine(initialNumber);
            initialNumber--;
        }
    }

    public static void Exercise13()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int firstNumber = 0;
        int secoundNumber = 1;
        while (firstNumber <= number)
        {
            Console.WriteLine(firstNumber);
            int total = firstNumber + secoundNumber;
            firstNumber = secoundNumber;
            secoundNumber = total;
        }
        
    }

}