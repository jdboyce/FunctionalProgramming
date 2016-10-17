
using System;


namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            DuplicateRemover duplicateRemover = new DuplicateRemover();
            duplicateRemover.RunDemo();

            GradeAverager gradeAverager = new GradeAverager();
            gradeAverager.RunDemo();

            Console.ReadLine();
        }
    }
}
