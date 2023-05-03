namespace ReferenceOut
{

    class RefOut
    {
        public void Addition(out int result, out int x, out int y)
        {
            x = 6;
            y = 9;
            result = x + y;
        }

        public int Multiply(ref int x, ref int y)
        {
            x = 2;
            y = 4;
            return x * y;
        }
    }
}
