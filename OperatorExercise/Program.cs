namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int additionResults = a + b;
            //int substractionResult = a - b;
            //int multiplicationResult = a * b;
            //int divisionResult = a / b;
            //int Modulus = a % b;
             
            int a = 17;
            int b = 4;
            int Quotient = a / b;
            int Remainder = (a % b);

            Console.WriteLine($"{a}/{b} is {Quotient}, Remainder {Remainder}");

            PrintAreaofCircle();



        }
         
        public static double AreaOfCircle(double radius)
        {
           
           
            return Math.PI * radius * radius;


        }
        public static void PrintAreaofCircle()
        {
            Console.WriteLine("What is the radius of the circle?");

            double radius = double.Parse(Console.ReadLine());
           
            Console.WriteLine($"The area of a circle with a radius of {radius} is {AreaOfCircle(radius)}");




        }

       
            







       
    
    
    } 
}
