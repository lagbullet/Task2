using System;

public class Student
{
    public String surName;
    public String firstName;
    public String patronymic;
    public String birthdate;
    public Mark[] mark = new Mark[20];
    private int Mcount = 0;

    public Student(String Sname, String Fname,String patronymic, String BthDate, String Subj, int Mark)
    {
        SurName = Sname;
        FirstName = Fname;
        Birthdate = BthDate;
        Patronymic = patronymic;
        mark[Mcount++] = new Mark(Subj, Mark);
    }

    public Student(String Sname, String Fname, String patronymic, String BthDate)
    {
        SurName = Sname;
        FirstName = Fname;
        Birthdate = BthDate;
        Patronymic = patronymic;
    }

    public string SurName
    {
        get
        {
            return surName;
        }
        set
        {
            surName = value;
        }
    }

    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
        }
    }

    public string Patronymic
    {
        get
        {
            return patronymic;
        }
        set
        {
            patronymic = value;
        }
    }

    public string Birthdate
    {
        get
        {
            return birthdate;
        }
        set
        {
            birthdate = value;
        }
    }

    public float GetAvgMark()
    {
        float SumMarks = 0;
        foreach (Mark onemark in mark)
        {
            if (onemark == null) break;
            SumMarks += onemark.Smark;
        }
        return SumMarks / Mcount;
    }

    public void ResetAllMarks()
    {
        int i=0;
        while (mark[i] != null)
            mark[i++].Smark = 0;
    }

    public void Show()
    {
        Console.WriteLine("Second Name -> " + SurName);
        Console.WriteLine("First Name -> " + FirstName);
        Console.WriteLine("Patronymic -> " + Patronymic);
        Console.WriteLine("Birthdate -> " + Birthdate);
        Console.WriteLine("  Marks  ");
        for (int i = 0; i < Mcount; i++)
        {
            Console.WriteLine("Subject -> " + mark[i].Subject);
            Console.WriteLine("Mark -> " + mark[i].Smark);
        }
    }

    public void SetMark(String Subj, int Mark)
    {
        if (Mcount > mark.Length) goto AddEls;
        mark[Mcount++] = new Mark(Subj, Mark);
    AddEls:
        Array.Resize(ref mark, Mcount + 10);
        mark[Mcount++] = new Mark(Subj, Mark);
    }
}