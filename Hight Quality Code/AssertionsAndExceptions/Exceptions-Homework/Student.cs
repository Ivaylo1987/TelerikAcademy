using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private string firstname;
    private string lastname;
    private IList<Exam> exams; 

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName
    {
        get
        {
            return this.firstname;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException("First name cannot be null of empty!");
            }

            this.firstname = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastname;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentOutOfRangeException("First name cannot be null of empty!");
            }

            this.lastname = value;
        }
    }

    public IList<Exam> Exams
    {
        /* X DO NOT return null values from collection properties or from methods returning collections. Return an empty collection or an empty array instead.
           The general rule is that null and empty (0 item) collections or arrays should be treated the same.
         * For more info:
           http://msdn.microsoft.com/en-us/library/dn169389(v=vs.110).aspx
        */
        get
        {
            // This check eliminates all other check in the methods below.
            // It will return empty list therefor Exams.Cout == 0;
            return this.exams ?? new List<Exam>();
        }

        set
        {
            this.exams = value;
        }
    }

    public IList<ExamResult> CheckExams()
    {
        IList<ExamResult> results = new List<ExamResult>();

        // if this.Exams.Count == 0 method will return empty list wich is a best practice.
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }
        
        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = this.CheckExams();

        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] =
                ((double)examResults[i].Grade - examResults[i].MinGrade) /
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();
    }
}
