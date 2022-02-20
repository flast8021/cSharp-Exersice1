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
            Console.WriteLine("-----End of Answer#1-----");
            Console.WriteLine("---------------------------------------------------");
//Answer 2
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----Answer#2-----");
            //calling studenGrading instance
            studentGrading grades = new studentGrading("", 0.0);
            //printing and getting user input
            Console.WriteLine("Please enter total number of studnts in class: ");
            int totalStudents = Convert.ToInt32(Console.ReadLine());
            //variables
            int i;
            double maxGrades = 0.0;
            double avg = 0;
            double achievedGrades = 0.0;
            //looping to get all student's details
            for (i = 1; i <= totalStudents; ++i)
            {
                //printing and getting student's name and grades. 
                Console.WriteLine($"Please Enter Student# {i} Name: ");
                grades.name = Console.ReadLine();
                Console.WriteLine($"Plese enter {grades.name}'s Grades: ");
                grades.grades = Convert.ToDouble(Console.ReadLine());
                //adding student's name and marks in list 
                grades.studentList.Add(new studentGrading(grades.name, grades.grades) { });
                //conditions
                //condition 1
                if (i == 0)
                {
                    //assining grades to variable
                    maxGrades = grades.grades;
                    //adding all grades to a variable to get max and average.
                    achievedGrades += grades.grades;
                }//condition 2
                else
                {
                    //nested condition
                    if (grades.grades > maxGrades)
                    {
                        //assining grades to variable
                        maxGrades = grades.grades;
                        //adding all grades to a variable to get max and average.
                        achievedGrades += grades.grades;
                    }
                }
                //dividing, added grades to total no of students to get average scores of class.
                avg = achievedGrades / i;
            }
            //printing results in two decimal place.
            Console.WriteLine("The largest grades in class are {0:N}", maxGrades);
            Console.WriteLine("The average grades in class are {0:N}", avg);
            Console.WriteLine("-----End of Answer#2-----");
            
//Answer 3
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("-----Answer#3-----");
            //calling instance of letterGuessingGame class.
            letterGuessingGame letterGuess = new letterGuessingGame();
            //calling method for letter Guessing game.
            letterGuess.userGuess();

            Console.WriteLine("-----End of Answer#3-----");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("------------------End of programe------------------");   
        }
    }
}
