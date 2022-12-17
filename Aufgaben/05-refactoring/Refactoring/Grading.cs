namespace Refactoring;

public class Grading
{
    public static char GetLetterGrade(int grade)
    {
        char result = 'A';

        if (grade < 0 || grade > 6)
        {
            throw new ArgumentException("unknown grade " + grade);
        }

        for(int i = 1; i < grade; i++)
        {
            result++;
        }

        return result;
    }
}