using System;

public class CSharpExam : Exam
{
    public const int MaxScore = 100;
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score 
    { 
        get
        {
            return this.score;
        }

        private set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Score should be a positive number!");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (this.Score > MaxScore)
        {
            throw new IndexOutOfRangeException("Score cannot be negative or greater than the max score!");
        }
        else
        {
            return new ExamResult(this.Score, 0, MaxScore, "Exam results calculated by score.");
        }
    }
}
