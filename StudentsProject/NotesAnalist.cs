namespace PooCollege;

public class NotesAnalist
{
    private readonly CreateStudents _createStudents = new();

    public void Run()
    {
        Console.Write("Quantos alunos? ");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out var quantity) || quantity <= 0)
        {
            if (quantity == 0)
            {
                Console.WriteLine("Sala sem alunos");
                Console.WriteLine("Não há média de notas na sala");
            }
            else
            {
                Console.WriteLine("Quantidade inválida.");
            }
            return;
        }

        var grades = _createStudents.CreateMultipleStudents(quantity);
        var average = grades.Average();

        Console.WriteLine($"Média da turma: {average}");
    }
}
