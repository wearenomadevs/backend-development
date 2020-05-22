using System;

namespace Exercise05
{
    class Time
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour
        {
            get
            {
                return hour;  
            }
            private set
            {
                if (value < 0 || value > 23)
                {
                    Console.WriteLine("Wrong Value in hour");

                }
                else
                {
                    hour = value;
                }
            }
        }
        public int Minute
        {
            get
            {
                return minute;
            }
            private set
            {
                if (value < 0 || value > 59)
                {
                    Console.WriteLine("Wrong Value in minute");

                }
                else
                {
                    minute = value;
                }
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            private set
            {
                if (value < 0 || value > 59)
                {
                    Console.WriteLine("Wrong Value in second");
                }
                else
                {
                    second = value;
                }
            }
        }

        public Time()
        {
            Hour = 0;
            Minute = 0;
            Second = 0;
        }

        public Time(int h, int m, int s)
        {
            Hour = h;
            Minute = m;
            Second = s;
        }

        public void NextSecond()
        {
            if (Second == 59)
            {
                Second = 0;

                if (Minute == 59)
                {
                    Minute = 0;
                    if (Hour == 23)
                    {
                        Hour = 0;
                    }
                    else
                    {
                        Hour += 1;
                    }
                }
                else
                {
                    Minute += 1;
                }
            }
            else
            {
                Second += 1;
            }
        }

        public string Format()
        {
            return $"{Hour}:{Minute}:{Second}";
        }

        public int DifferenceFrom(Time other)
        {
            int diffhour = Hour - other.Hour;
            int diffmin = Minute - other.Minute;
            int diffsec = Second - other.Second;

            return diffhour * 3600 + diffmin * 60 + diffsec;
        }
        

    }





    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // default constructor -> 00:00:00
            Time t1 = new Time();

            // custom constructor -> 10:42:56
            Time t2 = new Time(10, 42, 59);

            Console.WriteLine(t2.Format());
            t2.NextSecond();
            Console.WriteLine(t2.Format());

            Time t3 = new Time(10, 30, 17);
            Console.WriteLine(t3.Format());

            int difference = t2.DifferenceFrom(t3);
            Console.WriteLine(difference);

            Time t4 = new Time(1, 10, 00);
            Time t5 = new Time(0, 50, 00);
            Console.WriteLine(t4.DifferenceFrom(t5));
        }
    }
}
