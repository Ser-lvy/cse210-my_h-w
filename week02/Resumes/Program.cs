using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();


        job1._jobTitle = "Software Engineer";
        job2._jobTitle = "Digital Marketer";

        job1._company = "Bank of Uganda";
        job2._company = "China Town";

        job1._startYear = 2026;
        job2._startYear = 2027;

        job1._endYear = 2030;
        job2._endYear = 2031;



        job1.DisplayJobDeatails();
        Resume yourResume = new Resume();
        yourResume._name = "Levi";

        yourResume._jobs.Add(job1);
        yourResume._jobs.Add(job2);

        yourResume.DisplayJob();


        
    }
}

