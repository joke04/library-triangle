namespace lib_triangle
{
    public class Triangle
    {
        double a, b, c;

        public double A { get { return a; } set { a = value; } }
        public double B { get { return b; } set { b = value; } }
        public double C { get { return c; } set { c = value; } }
        public double SQ()
        {
            return Math.Sqrt((a + b + c) / 2 * (((a + b + c) / 2) - a) * (((a + b + c) / 2) - b) * (((a + b + c) / 2) - c));
        }
        public bool Trian()
        {
            if (a == b || a == c || b == c) return true;
            else return false;
        }
    }
    public class Figure
    {
        List<Triangle> y = new List<Triangle>();
        List<Triangle> n = new List<Triangle>();
        Triangle tr = new Triangle();

        public List<Triangle> Y { get { return y; } }
        public List<Triangle> N { get { return n; } }
        public bool Y_N()
        {
            if (tr.A == tr.B || tr.A == tr.C || tr.B == tr.C)
            {
                y.Add(tr);
                Console.WriteLine(y);
                return true;
            }
            else
            {
                n.Add(tr);
                Console.WriteLine(n);
                return false;
            }
        }
    }
}