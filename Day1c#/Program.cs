namespace Day1c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("Hello, World!");
            Console.WriteLine("My name is shrouk ");
            Console.WriteLine("I am 22 years old ");
            Console.WriteLine("My favourite hobby is reading ");


            Console.WriteLine("\n");
            #endregion

            //Write a C# program that declares variables of different data types (int, double, string, bool) and assigns them values. Then, print these values to the console.

            #region
            string name = "shrouk";
            int age = 22;
            double degree = 77.5;
            bool isPassedExam = true;

            Console.WriteLine("name : " + name);
            Console.WriteLine("age : " + age);
            Console.WriteLine("Your Degree : " + degree);
            Console.WriteLine("Did you pass the exam or not : " + isPassedExam);

            Console.WriteLine("\n");
            #endregion

            //Write a C# program that converts a temperature value from Celsius to Fahrenheit. The Celsius temperature should be stored in a variable.
            #region
            double Celsius = 40.5;

            Console.WriteLine(Celsius + " Is equal to " + ((Celsius * 9 / 5) + 32) + " Fahrenheit");

            Console.WriteLine("\n");
            #endregion
            //Write a C# program that takes two numbers as input and performs the following operations: addition, subtraction, multiplication, and division. Print the results of each operation.
            #region
            Console.WriteLine("Enter the first number : ");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number : ");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("addition of numbers = " + (firstNumber + secondNumber));
            Console.WriteLine("subtraction of numbers = " + (firstNumber - secondNumber));
            Console.WriteLine("multiplication of numbers = " + (firstNumber * secondNumber));
            double division = secondNumber != 0 ? (firstNumber / secondNumber) : double.NaN;
            
            // ANOTHER WAY FOR THE PREVIOUS LINE : string division = secondNumber != 0 ? (firstNumber / secondNumber).tostring():"ERROR";
            Console.WriteLine("division of numbers = " + division);

            Console.WriteLine("\n");

            #endregion

            //Write a C# program that calculates the area of a rectangle. The program should prompt the user to enter the length and width of the rectangle, and then calculate and display the area.
            #region
            Console.WriteLine("Enter length = ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width = ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of a rectangle = " + (length * width) + " square units");

            Console.WriteLine("\n");
            #endregion

            //Write a C# program that takes an integer as input and checks if it is even or odd. Print a message indicating whether the number is even or odd.
            #region
            Console.WriteLine("Enter number =  ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("AN EVEN NUMBER ");

            }
            else
            {
                Console.WriteLine("AN ODD NUMBER ");
            };
            Console.WriteLine("\n");
            #endregion
            //Write a C# program that prompts the user to enter their age. If the age is 18 or older, print "You are eligible to vote." If the age is less than 18, print "You are not eligible to vote."
            #region
            Console.WriteLine("ENTER YOUR AGE : ");
            int agee = int.Parse(Console.ReadLine());
            if (agee >= 18)
            {
                Console.WriteLine("You are eligible to vote.");

            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            };

            Console.WriteLine("\n");
            #endregion

            /*Write a C# program that simulates a simple grading system. The program should prompt the user to enter a score (0-100), and then print the corresponding grade based on the following criteria:
            90 - 100: A
            80-89: B
            70-79: C
            60-69: D
            Below 60: F*/
            #region
            Console.WriteLine("Enter score : ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 0 && score <= 100)
            {
                if (score >= 90)
                {
                    Console.WriteLine("YOUR GRADE IS A ");
                }
                else if (score >= 80)
                {
                    Console.WriteLine("YOUR GRADE IS B ");

                }
                else if (score >= 70)
                {
                    Console.WriteLine("YOUR GRADE IS C ");
                }
                else if (score >= 60)
                {
                    Console.WriteLine("YOUR GRADE IS D ");
                }
                else
                {
                    Console.WriteLine("YOUR GRADE IS F");
                }
            }
            else
            {
                Console.WriteLine("INVALID SCORE");
            };
            Console.WriteLine("\n");
            #endregion
            //Write a C# program that checks if a number entered by the user is positive, negative
            #region
            Console.WriteLine("ENTER THE NUMBER : ");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("It is NULL.");

            }
            else if (x > 0)
            {
                Console.WriteLine("it is a positive number .");
            }
            else
            {

                Console.WriteLine("it is a negatiev number .");
            };

            Console.WriteLine("\n");
            #endregion

            //Write a C# program that checks if a rectangle with given length and width is a square.
            #region
            Console.WriteLine("Enter length = ");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width = ");
            double w = double.Parse(Console.ReadLine());
            if (l==w){
                Console.WriteLine("RECTANGLE IS A SQUARE .");
            }
            else { Console.WriteLine("RECTANGLE IS NOT A SQUARE ."); }
            #endregion
        }
    }
}