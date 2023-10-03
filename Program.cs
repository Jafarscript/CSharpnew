// See https://aka.ms/new-console-template for more information


namespace Program
{
    class Program
    {
        static void Main()
        {
            string kolade = "Jafar";
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;

            Console.WriteLine($"{kolade}, this is the range of decimal in CSharp {min} and {max}");

            decimal a = 1.5M;
            decimal b = 3.5M;

            Console.WriteLine(a / b);

            double d = 1.5;
            double c = 3.5;

            Console.WriteLine(c / d);

            // Area of a circle


            double radius = 2.0;
            double area = Math.PI * radius * radius;

            Console.WriteLine($"The area of a circle with the radius of {radius} equals to {area}");


            // Working with strings

            // Replace(1,2) just line in python
            // Contains(1)
            //StartsWith()
            // EndsWith()

            string name = "    Jafar    ";
            string newName = name.Trim().Replace("Jafar", "Anas");
            name = name.Trim();
            Console.WriteLine(newName);
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine("I go to school");

            int num1 = 10;
            int num2 = 15;
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else
            {
                Console.WriteLine($"{num2} is greater than {num1}");
            }

            //Loop 
            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine("I am the goat");
                counter++;
            }

            for (int i = 0; i < 101; i++)
            {
                if ((i % 5 == 0) && (i % 3 == 0)){
                    Console.WriteLine("FizzBuzz");
                }
                else if(i % 5 == 0){
                    Console.WriteLine("Fizz");
                }
                else if(i % 3 == 0){
                    Console.WriteLine("Buzz");
                }
                else{
                    Console.WriteLine(i);
                }
            }

        }
    }
}