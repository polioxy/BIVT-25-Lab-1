namespace Lab1
{
    public class Green
    {
        public bool Task1(double d)
        {
            bool answer = false;

            // code here
            answer = Math.Abs(d) >= 1;
            // end

            return answer;
        }
        public bool Task2(double d, double f)
        {
            bool answer = false;

            // code here
            answer = ((d + f) / 2) > 0;
            // end

            return answer;

        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = (a + b) > Convert.ToDouble(((Math.Abs(a) + Math.Abs(b) / 2)));
            // end

            return answer;
        }
        public int Task4(int a, int b, int c)
        {
            int answer = 0;

            // code here
            answer = Math.Max(a, Math.Max(b, c));
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (Math.Abs(x) > 1)
            {
                answer = 0;
            }
            else if (Math.Abs(x) <= 1)
            {
                answer = Math.Pow(x, 2) - 1;
            }
            // end

            return answer;
        }
        public bool Task6(double x, double y)
        {
            bool answer = false;

            // code here
            if (x < 0)
            {
                answer =  y <= (1 + x);
            }
            else
            {
                answer = y <= (1 - x);
            }
            if (x < -1 || x > 1)
            {
                answer = false;
            }
            if (y < 0)
            {
                answer = false;
            }
            // end

            return answer;
        }

        public bool Task7(int n)
        {
            bool answer = true;

            // code here
            if (n < 0)
            {
                answer = false;
            }
            else if (n%2 == 0)
            {
                answer = false;
            }
            else { answer = true; }
            // end

                return answer;
        }
        public bool Task8(int X, int Y)
        {
            bool answer = false;

            // code here
            int gotosleep = 4*60;
            int wakeup = 14*60;
            for (int i = 1; i <= X; i++)
            {
                if (i%2 == 1)
                {
                    gotosleep = (gotosleep - Y) % 1440; //1440 - минут в сутках
                    while (gotosleep < 0)
                    {
                        gotosleep += 1440;
                       
                    }

                }
                if (wakeup > 7*60)
                {
                    wakeup -= 60;
                }
                int duration = (wakeup - gotosleep + 1440) % 1440;
                if (wakeup == 7 * 60 && duration >= 7 * 60 && duration <= 9 * 60)
                {
                    answer = true;
                }
                else { answer = false; }
            }

                // end

                return answer;
        }
    }
}