namespace PooCollege;

public class CreateStudents
{
    public List<double> CreateMultipleStudents(int studentsNumber)
    {
        var grades = new List<double>();

        for (var studentIndex = 1; studentIndex <= studentsNumber; studentIndex++)
        {
            var grade = StudentsNumber.ReadStudentGrade(studentIndex);
            grades.Add(grade);
        }

        return grades;
    }
}
