// See https://aka.ms/new-console-template for more information
Console.WriteLine("This program prints FizzBuzz word.");

int limit = 100;

PrintFizzBuzz(limit);

PrintDivisibleBy(limit);

PrintAllNumbersDivisibleByThree(limit);
PrintAllNumbersDivisibleByFive(limit);
PrintAllNumbersDivisibleByThreeAndFive(limit);

static double DivisionOperation(int number, int divideBy)
{
    return (double)number % divideBy;
}

//print number from 1 to 1000
//if number is Divisible by 3
//print "Divisible by 3"
//if number is Divisible by 5
//print "Divisible by 5"
//but if number is Divisible by 3 and 5 both 
//print "Divisible by 3 and 5 both"(Do not show divisible by 3 or divisible by 5)
//if number is not Divisible by 3 and 5
//print "the number it self"
static void PrintDivisibleBy(int limit)
{
    Console.WriteLine($"\nPrint Divisible from 1 to {limit} \n");

    for (int number = 1; number <= limit; number++)
    {
        bool isDivisibleByThree = DivisionOperation(number, 3) == 0;
        bool isDivisibleByFive = DivisionOperation(number, 5) == 0;

        if (isDivisibleByThree) //10 % 3 = 0.4 => false
        {
            if (isDivisibleByFive) ///15 % 5 = 3 => true
            {
                Console.WriteLine($"Number is {number} Divisible by 3 and 5");
            }
            else
            {
                Console.WriteLine($"Number is {number} Divisible by 3");
            }
        }
        else if (isDivisibleByFive) ///10 % 5 = 2 => true
        {
            Console.WriteLine($"Number is {number} Divisible 5");
        }
        else
        {
            Console.WriteLine($"Number is {number}");
        }

    }
}

//print number from 1 to 1000
//if number is Divisible by 3
//print "Divisible by 3"
//if number is Divisible by 5
//print "Divisible by 5"
//but if number is Divisible by 3 and 5 both 
//print "Divisible by 3 and 5 both"(Do not show divisible by 3 or divisible by 5)
//if number is not Divisible by 3 and 5
//print "the number it self"
static void PrintFizzBuzz(int limit)
{
    Console.WriteLine($"\nPrint FizzBuzz from 1 to {limit} \n");

    for (int number = 1; number <= limit; number++)
    {
        bool isDivisibleByThree = DivisionOperation(number, 3) == 0;
        bool isDivisibleByFive = DivisionOperation(number, 5) == 0;

        // Check if i is divisible by both 3 and 5 
        if (isDivisibleByThree && isDivisibleByFive)
            // Add "FizzBuzz" to the console log
            Console.WriteLine($"{number} is FizzBuzz");
        // Check if i is divisible by 3 
        else if (isDivisibleByThree)
            // Add "Fizz" to the console log
            Console.WriteLine($"{number} is Fizz");
        // Check if i is divisible by 5 
        else if (isDivisibleByFive)
            // Add "Buzz" to the console log
            Console.WriteLine($"{number} is Buzz");
        else
            Console.WriteLine($"{number}");

    }

    Console.WriteLine("");
}

static void PrintAllNumbersDivisibleByThree(int limit)
{
    Console.WriteLine($"\nPrint numbers divided by 3, from 1 to {limit} \n");
    for (int number = 1; number <= limit; number++)
    {
        if (number % 3 == 0) //10 % 3 = 0.4 => false
        {
            Console.Write($"{number}, ");
        }
    }

    Console.WriteLine("");
}

static void PrintAllNumbersDivisibleByFive(int limit)
{
    Console.WriteLine($"\nPrint numbers divided by 5, from 1 to {limit} \n");
    for (int number = 1; number <= limit; number++)
    {
        if (number % 5 == 0) //15 % 5 = 0 => true
        {
            Console.Write($"{number}, ");
        }
    }

    Console.WriteLine("");
}

static void PrintAllNumbersDivisibleByThreeAndFive(int limit)
{
    Console.WriteLine($"\nPrint numbers divided by both 3 and 5, from 1 to {limit} \n");
    for (int number = 1; number <= limit; number++)
    {
        if (number % 3 == 0 && number % 5 == 0) //15 % 5 = 0 => true
        {
            Console.Write($"{number}, ");
        }
    }

    Console.WriteLine("");
}