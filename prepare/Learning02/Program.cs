using System;

class Program
{
    static void Main(string[] args)
    
    {
        Job job1 = new Job ("BYU", "Electrical Engineering research assistant", 2024, 2024);
        Job job2 = new Job ("Quick Shine Car Wash", "car wash attendant", 2022, 2023);
       

        job1.DisplayNames ();
        job2.DisplayNames ();

    }
}