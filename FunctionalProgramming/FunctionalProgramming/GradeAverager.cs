
using System;
using System.Collections.Generic;
using System.Linq;


namespace FunctionalProgramming
{
    class GradeAverager
    {
        List<string> classGradesList;
        List<double> studentAverageGrades;

        public GradeAverager ()
        {
            classGradesList = new List<string>();
            studentAverageGrades = new List<double>();
        }


        public void RunDemo()
        {
            classGradesList.AddRange(new string[] {"90,90,90,90,90", "80,75,100,100,100", "65,60,80,75,80", "100,95,85,60,80", "85,90,100,90,95"});
            int numberOfStudents = classGradesList.Count;
            Console.WriteLine("\n\n\n\n______________________________________________________________________________________________________________" +
                              "\n\n\nHere is a list of students' individual grades, then the average grade minus the lowest grade:");

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentGradesList = ConvertStringToArray(i);
                int[] studentGradesAsInts = ConvertStringsToInts(studentGradesList);
                studentGradesAsInts = DropLowestGrade(studentGradesAsInts);
                double averageGrade = studentGradesAsInts.Average();
                studentAverageGrades.Add(averageGrade);
                Console.WriteLine("\nStudent #{0}\nIndividual Grades: {1}\nAverage (Minus Lowest): {2}", i+1, classGradesList[i], averageGrade);
            }
            Console.WriteLine("\n\n\nHere is the class average: {0}\n\n\n", studentAverageGrades.Average());
        }


        public string[] ConvertStringToArray(int gradeGroupIndex)
        {
            string[] gradesAsStrings = classGradesList[gradeGroupIndex].Split(',');
            return gradesAsStrings;
        }


        public int[] ConvertStringsToInts(string[] grades)
        {
            int[] gradesAsInts = grades.Select(int.Parse).ToArray();
            return gradesAsInts;
        }


        public int[] DropLowestGrade(int[] grades)
        {
            List<int> gradesList = grades.ToList();

            if (grades.All(element => element == grades.Min()))
            {
                return grades;
            }
            else
            {
                gradesList.RemoveAll(item => item == grades.Min());
                int[] newGrades = gradesList.ToArray();
                return newGrades;
            }
        }
    }
}
