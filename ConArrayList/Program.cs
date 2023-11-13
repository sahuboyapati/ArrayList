using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Task 1: ArrayList Initialization and Population
        // 1.1 Declare an ArrayList named studentGrades.
        ArrayList studentGrades = new ArrayList();

        // 1.2 Initialize studentGrades with the following integer values: 85, 92, 78, 95, 88.
        studentGrades.Add(85);
        studentGrades.Add(92);
        studentGrades.Add(78);
        studentGrades.Add(95);
        studentGrades.Add(88);

        // Task 2: Display and Sum
        // 2.1 Display the contents of studentGrades using a loop.
        Console.WriteLine("Task 2.1: Displaying studentGrades");
        foreach (int grade in studentGrades)
        {
            Console.WriteLine(grade);
        }

        // 2.2 Calculate and display the sum of all the grades in studentGrades.
        int sum = 0;
        foreach (int grade in studentGrades)
        {
            sum += grade;
        }
        Console.WriteLine("\nTask 2.2: Sum of studentGrades: " + sum);

        // Task 3: Grade Addition
        // 3.1 Add a new grade of 90 to the end of studentGrades.
        studentGrades.Add(90);

        // 3.2 Display the updated contents of studentGrades after the addition.
        Console.WriteLine("\nTask 3.2: Updated studentGrades after adding a grade of 90");
        foreach (int grade in studentGrades)
        {
            Console.WriteLine(grade);
        }

        // Task 4: Grade Removal
        // 4.1 Remove the grade of 78 from studentGrades.
        studentGrades.Remove(78);

        // 4.2 Display the contents of studentGrades after the removal.
        Console.WriteLine("\nTask 4.2: Updated studentGrades after removing the grade of 78");
        foreach (int grade in studentGrades)
        {
            Console.WriteLine(grade);
        }

        // Task 5: Search and Update
        // 5.1 Search for the index of the grade 95 in studentGrades.
        int indexOfGrade95 = studentGrades.IndexOf(95);

        // 5.2 Update the grade at the found index to 96.
        if (indexOfGrade95 != -1)
        {
            studentGrades[indexOfGrade95] = 96;
        }

        // Display the contents of studentGrades after the update.
        Console.WriteLine("\nTask 5.2: Updated studentGrades after changing the grade at index " + indexOfGrade95 + " to 96");
        foreach (int grade in studentGrades)
        {
            Console.WriteLine(grade);
        }
        Console.ReadKey();
    }
}

//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleAppArrayList
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int sum = 0;
//            ArrayList StudentGrades = new ArrayList
//            {
//                85,92,78,95,88
//            };
//            Console.WriteLine("Grades present in List is:" + StudentGrades.Count);
//            foreach (int i in StudentGrades)
//            {
//                Console.WriteLine(i);
//            }
//            Console.WriteLine("Sum of all grades in studentGrades:");
//            foreach (int i in StudentGrades)
//            {
//                sum += (int)i;
//            }
//            Console.WriteLine($"The sum of the grades in studentgrades is {sum}");
//            Console.WriteLine("updates students grade after adding new data");
//            StudentGrades.Add(90);
//            foreach (int i in StudentGrades)
//            {
//                Console.Write(i);
//            }
//            Console.WriteLine("Removal of the contents in studentGrades");
//            StudentGrades.RemoveAt(2);
//            Console.WriteLine("updates students grade after Removing data");
//            foreach (int i in StudentGrades)
//            {
//                Console.WriteLine(i);
//            }
//            Console.WriteLine("Updating the studentgrades list:");
//            StudentGrades.Insert(3, 96);
//            foreach (int i in StudentGrades)
//            {
//                Console.WriteLine(i);
//            }
//            Console.ReadKey();
//        }
//    }
//}