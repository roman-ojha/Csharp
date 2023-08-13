namespace CollegeExam
{

    class Program
    {
    /*        static public void Main(string[] args)
            {

                *//*            // Data Type ============
                            Console.WriteLine("Hello World");
                            System.Console.Write("This is from Roman\n");
                            int num1 = 10;
                            uint num2 = 20;
                            uint num = (uint)num1 + num2;
                            Console.WriteLine(num);
                            double a = 1.1;
                            short b = 23;
                            char c = 'R';
                            string name = "Roman";
                            float price = 30000.00432F;
                            decimal d = 30.4M;
                            bool isUser = true;
                            object obj = isUser;
                            double dou = double.NaN;
                            Console.WriteLine(decimal.MaxValue);
                            Console.WriteLine(double.IsInfinity(Math.Pow(99, 9999)));
                            Console.WriteLine('\t');
                            name += " Ojha";
                            char[] name2 = { 'r', 'o', 'm', 'a', 'n' };
                            string name3 = new string(name2);
                            Console.WriteLine(name+name3);
                            Console.WriteLine(name2.Length);
                            // String literals
                            string message = """ 
                                \\ This is the message
                                """;
                            Console.WriteLine(message);
                            // String Interpolation
                            string name4 = $"{name3} Ojha";
                            Console.WriteLine(name4);
                            // Array:
                            int[] number = new int[5] { 1,2,3,4,5 };
                            // Multi dimensional Array:
                            int[,] number2 = new int[2, 2] { { 1, 1 },{1, 1 } };
                            int[,] number3 = new int[2, 2] { {1,2},
                                                             {3,4} };
                            Console.WriteLine(number.GetValue(3));
                            Console.WriteLine(number3[0, 1]);
                */
                /*
                            // 3D Array & Jagged Array
                            int[,,] number4 = new int[1, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } } };
                            Console.WriteLine(number4.GetLength(0) + ", " + number4.GetLength(1) + ", " + number4.GetLength(2));
                            for (int i = 0; i < number4.GetLength(0); i++)
                            {
                                for (int j = 0; j < number4.GetLength(1); j++)
                                {
                                    for (int k = 0; k < number4.GetLength(2); k++)
                                    {
                                        Console.Write(number4[i, j, k]);
                                    }
                                }
                            }
                            // Jagged Array:
                            int[][] number5 = new int[3][] {
                                            new int[3]{1,2,3},
                                            new int[2]{4,5},
                                            new int[4]{6,7,8,9},
                                        };
                            Console.WriteLine();
                            for (int i = 0; i < number5.Length; i++)
                            {
                                for (int j = 0; j < number5[i].Length; j++)
                                {
                                    Console.Write(number5[i][j]);
                                }
                                Console.WriteLine();
                            }
                            foreach (int[] ns in number5)
                            {
                                foreach(int n in ns)
                                {

                                    Console.Write(n);
                                }
                                Console.WriteLine();
                            }
                *//*

                // Convert.ToInt32()
                // int.Parse();

            }
    */      

        // Field:
        public string? name;
        // Property:
        public string? FullName { get; set; }

        static void Main(string[] args)
        {
            Calculation calc = new Calculation(1,2);
            Console.WriteLine(calc[0]);
        }
    }

    public class Calculation
    {
        public int A { get; set; }
        public int B { get; set; }

        public Calculation(int A, int B)
        {
            this.A = A;
            this.B = B;
        }
        // Indexer
        public int this[int index]
        {
            get
            {
                return A+B;
            }
            set
            {
                if (index == 0)
                    A = value;
                else
                    B = value;
            }
        }
    }
}