namespace PooCollege;

public class FibonacciExercise
{
    public void execute()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int firstNumber = 0;
        int nextNumber = 1;
        while (nextNumber <= number)
        {
            Console.WriteLine(firstNumber);
            int total = nextNumber + firstNumber;
            firstNumber = nextNumber;
            nextNumber = total;

        }
        
            
            
    }
    
    
}