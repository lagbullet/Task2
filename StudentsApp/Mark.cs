using System;

public class Mark
{
    public String subject;
    public int smark;

    public int Smark
    {
        get
        {
            return smark;
        }
        set
        {
            if (value >= 0 && value <= 10)
            smark = value;
        }
    }

    public string Subject
    {
        get
        {
            return subject;
        }
        set
        {
            subject = value;
        }
    }


    public Mark(String subj, int mrk)
	{
        subject = subj;
        smark = mrk;
	}
}