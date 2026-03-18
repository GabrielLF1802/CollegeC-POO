using System.Globalization;

namespace PooCollege;

public static class StudentsNumber
{
    public static double ReadStudentGrade(int studentNumber)
    {
        while (true)
        {
            Console.Write($"Nota do aluno {studentNumber}: ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Digite um valor.");
                continue;
            }

            input = input.Replace(',', '.');

            if (double.TryParse(input, NumberStyles.Number, CultureInfo.InvariantCulture, out var grade) && grade >= 0 && grade <= 10)
            {
                return grade;
            }

            Console.WriteLine("Nota inválida. Tente novamente.");
        }
    }
}
