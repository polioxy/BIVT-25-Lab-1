namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            if (a==0 || b == 0)
            {
                answer = false;
            }
            if (a > 0 && b > 0)
            {
                answer = true;
            }
            else if (a < 0 && b < 0)
            { 
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            if (d != Math.Round(d))
            {
                answer = true;
            }
            // end

            return answer;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            if (a % b == 0)
            {
                answer = true;
            }
            else {answer = false; }
            if (b == 0)
            {
                answer = false;
            }
            // end

                return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // code here
            if((Math.Abs(d) > Math.Abs(f)) && (Math.Abs(d) > Math.Abs(g)))
            {
                answer = d;
            }
            if ((Math.Abs(f) > Math.Abs(d)) && (Math.Abs(f) > Math.Abs(g)))
            {
                answer = f;
            }
            if ((Math.Abs(g) > Math.Abs(d)) && (Math.Abs(g) > Math.Abs(f)))
            {
                answer = g;
            }
                // end

                return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1)
            {
                answer = 0;
            }
            else if (-1<x && x <= 0)
            {
                answer = x + 1;
            }
            else if (x > 0)
            {
                answer = 1;
            }
                // end

                return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double storona = Math.Sqrt(squareS);
            double diametr = 2 * (Math.Sqrt(circleS / Math.PI));
            if (storona - diametr >= 0)
            {
                answer = true;
            }
            else { answer = false; }
                // end

                return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            
            // end

            return answer;
        }
    }
}