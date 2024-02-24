using System;

public class Subject
{
    protected string _subjectName;
    protected string _subjectTeacher;
    protected int _totalClassTestScore;
    protected int _totalExamsScore;  
    protected int _expectedNumberOfClassTests;
    protected int _marksForEachTest;
    protected int _numberOfCompletedClassTests;
    protected string _finalGrade;
  
    public Subject(string subjectName, string subjectTeacher, int totalClassTestScore, int totalExamsScore, int expectedNumberOfClassTests, int marksForEachTest, int numberOfCompletedClassTests, string finalGrade)
    {
        _subjectName = subjectName;
        _subjectTeacher = subjectTeacher;
        _totalClassTestScore = totalClassTestScore;
        _totalExamsScore = totalExamsScore;
        _expectedNumberOfClassTests = expectedNumberOfClassTests;
        _marksForEachTest = marksForEachTest;
        _numberOfCompletedClassTests = numberOfCompletedClassTests;
        _finalGrade = finalGrade;
    
    }
    
    public virtual string GetSubjectName()
    {
       return $"{_subjectName}.";
    }

    public virtual string GetSubjectTeacher()
    {
       return $"{_subjectTeacher}.";
    }

    public virtual void RecordClassTest()
    {
      

        _totalClassTestScore += _marksForEachTest;
        _numberOfCompletedClassTests++;
    }
    
    public virtual int GetTotalTestScoreForRecording()
    {
        return _totalClassTestScore/2;
    }
    
    public virtual int GetTotalExamsScoreForRecording()
    {
        return _totalExamsScore/2;
    }
    public virtual void RecordExamScore()
    {
        Console.WriteLine("New Exams score?: ");
        string responds = Console.ReadLine();
        int examsScore = int.Parse(responds);

        _totalExamsScore += examsScore;
    }
    public virtual void UpdateFinalGrade()
    {
        int totalPercent = _totalClassTestScore/(_expectedNumberOfClassTests * _marksForEachTest) * 100;

        if ( totalPercent>= 93)
        {
            _finalGrade = "A+";
        }

        else if (totalPercent < 93 && totalPercent > 89 )
        {
            _finalGrade = "A-";
        }

        else if (totalPercent < 90 && totalPercent > 79 )
        {
            _finalGrade = "B";
        }

        else if (totalPercent < 80 && totalPercent > 59 )
        {
            _finalGrade = "C";
        }

        else if (totalPercent < 60 && totalPercent > 49 )
        {
            _finalGrade = "D";
        }

        else if (totalPercent < 50)
        {
            _finalGrade = "F";
        }

        else
        {
            _finalGrade = "Invalid";
        }

    }
    public virtual string GetFinalGrade()
    {
        return $"{_finalGrade}";
    }

    public virtual string GetSubjectDetailsString()
    {
        
        return $"";
    }

    public  virtual string GetSubjectStringRepresentation() 
    {    

        return $"";
    }
   
}    