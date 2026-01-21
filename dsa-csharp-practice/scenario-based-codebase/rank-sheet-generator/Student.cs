using System;
using System.Collections.Generic;
using System.Text;

namespace Rank_Sheet_Generator
{
    internal class Student
    {
        private string studentName;
        private int studentScore;

        public Student(string name , int score)
        {
            studentName = name;
            studentScore = score;
        }

        public string GetStudentName()
        {
            return studentName;
        }

        public int GetStudentScore()
        {
            return studentScore;
        }

        public override string? ToString()
        {
            return "Student Name : "+ studentName + "  |  Student Score : "+ studentScore;
        }
    }
}
