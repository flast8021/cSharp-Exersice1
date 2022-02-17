using System;

namespace exersice_3inClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
//Answer 1
            Console.WriteLine("-----Answer#1-----");
            deliveryService parcel = new deliveryService();
            parcel.data();
//Answer 2
            Console.WriteLine("-----End of Answer#1-----");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("-----Answer#2-----");
            studentGrading grades = new studentGrading("", 0.0);

            Console.WriteLine("Please enter total number of studnts in class: ");
            int totalStudents = Convert.ToInt32(Console.ReadLine());

            int i;
            double maxGrades = 0.0;
            double avg = 0;
            double achievedGrades = 0.0;
            double totalObtained = 0.0;
            for (i = 1; i <= totalStudents; ++i)
            {
                Console.WriteLine($"Please Enter Student# {i} Name: ");
                grades.name = Console.ReadLine();

                Console.WriteLine($"Plese enter {grades.name}'s Grades: ");
                grades.grades = Convert.ToDouble(Console.ReadLine());


                grades.studentList.Add(new studentGrading(grades.name, grades.grades) { });
                if (i == 0)
                {
                    maxGrades = grades.grades;
                    achievedGrades += grades.grades;
                }
                else
                {
                    if (grades.grades > maxGrades)
                    {
                        maxGrades = grades.grades;
                        achievedGrades += grades.grades;
                    }
                }
                avg = achievedGrades / i;
            }
            Console.WriteLine("The largest grades in class are {0:N}", maxGrades);
            Console.WriteLine("The average grades in class are {0:N}", avg);


            Console.WriteLine("-----End of Answer#2-----");




//Answer 3
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("-----Answer#3-----");

            letterGuessingGame letterGuess = new letterGuessingGame();

            for (int i = 0; i < 9; i++)
            {
                letterGuess.userGuess();
            }


            Console.WriteLine("-----End of Answer#3-----");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("--------------------------");
            Console.WriteLine("-----------------");
            Console.WriteLine("-------");
            Console.WriteLine("--");
        }

    }

}
