using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Rank_Sheet_Generator
{
    internal class GeneratorUtility : IGenerator
    {
        private District[] districts;
        private readonly int noOfDistricts;
        private int studentIndex;
        private int districtIndex;

        public GeneratorUtility()
        {
            noOfDistricts = 5;
            districts = new District[noOfDistricts];
            studentIndex = 0;
            districtIndex = 0;

        }
        public void AddDistrict()
        {
            if (districtIndex >= noOfDistricts)
            {
                Console.WriteLine("\nDistrict Array is Full\n");
                return;
            }
            Console.Write("\nEnter District Name : ");
            string districtName = Console.ReadLine();
            Console.Write("Enter number of Students : ");
            int noOfStudents = int.Parse(Console.ReadLine());

            District district = new District(noOfStudents, districtName);
            districts[districtIndex++] = district;

        }
        public void AddStudent()
        {
            Console.Write("\nEnter Existing District Name : ");
            string districtName = Console.ReadLine();

            District district = null;
            for (int i=0; i<districtIndex; i++)
            {
                if (districts[i].GetDistrictName() == districtName)
                {
                    district = districts[i];
                }
            }

            if(district == null)
            {
                Console.WriteLine("\nDistrict Is Not Exist\n");
                return;
            }

            if(studentIndex >= district.GetNoOfStudents())
            {
                Console.WriteLine("\nStudent Array Is Full\n");
                return;
            }

            Console.WriteLine("\nYou Have To Enter Details Of " + district.GetNoOfStudents() + " Students\n");

            for (int i = 0; i < district.GetNoOfStudents(); i++)
            {
                Student[] studentArray = district.GetStudents();
                Console.WriteLine("Enter Name of Student " + i + 1 + " : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Score of Student " + i + 1 + " : ");
                int score = int.Parse(Console.ReadLine());
                Student student = new Student(name, score);
                studentArray[i] = student;

                studentIndex++;
            }

            SortStudentsOfAllDistricts();

        }

        public void DisplayStudentsOfAllDistricts()
        {
            // Step 1: Count total students
            int totalStudents = 0;

            for (int i = 0; i < districtIndex; i++)
            {
                totalStudents += districts[i].GetNoOfStudents();
            }

            if (totalStudents == 0)
            {
                Console.WriteLine("\nNo students available\n");
                return;
            }

            // Step 2: Create combined array
            Student[] allStudents = new Student[totalStudents];
            int index = 0;

            for (int i = 0; i < districtIndex; i++)
            {
                Student[] students = districts[i].GetStudents();

                for (int j = 0; j < students.Length; j++)
                {
                    if (students[j] != null)
                    {
                        allStudents[index++] = students[j];
                    }
                }
            }

            // Step 3: Sort using Merge Sort (already written)
            MergeSort(allStudents, 0, allStudents.Length - 1);

            // Step 4: Display result
            Console.WriteLine("\n===== ALL STUDENTS (DESCENDING ORDER) =====");
            Console.WriteLine("Rank\tName\t\tScore");

            for (int i = 0; i < allStudents.Length; i++)
            {
                Console.WriteLine(
                    (i + 1) + "\t" +
                    allStudents[i].GetStudentName() + "\t\t" +
                    allStudents[i].GetStudentScore()
                );
            }

            Console.WriteLine();
        }

        private void SortStudentsOfAllDistricts()
        {
            for (int i = 0; i < districtIndex; i++)
            {
                Student[] students = districts[i].GetStudents();

                if (students != null && students.Length > 0)
                {
                    MergeSort(students, 0, students.Length - 1);
                }
            }

            Console.WriteLine("\nStudents sorted district-wise using Merge Sort\n");
        }

        private void MergeSort(Student[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(arr, left, mid);       // Left half
                MergeSort(arr, mid + 1, right);  // Right half

                Merge(arr, left, mid, right);    // Merge both
            }
        }

        private void Merge(Student[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            Student[] L = new Student[n1];
            Student[] R = new Student[n2];

            for (int i = 0; i < n1; i++)
                L[i] = arr[left + i];

            for (int j = 0; j < n2; j++)
                R[j] = arr[mid + 1 + j];

            int iIndex = 0, jIndex = 0, k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (L[iIndex].GetStudentScore() >= R[jIndex].GetStudentScore())
                {
                    arr[k] = L[iIndex];
                    iIndex++;
                }
                else
                {
                    arr[k] = R[jIndex];
                    jIndex++;
                }
                k++;
            }

            while (iIndex < n1)
            {
                arr[k] = L[iIndex];
                iIndex++;
                k++;
            }

            while (jIndex < n2)
            {
                arr[k] = R[jIndex];
                jIndex++;
                k++;
            }
        }


    }
}
