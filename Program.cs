/*
  The following code is a simple calculator that asks the user to enter two numbers-
  and an operator to perform basic arithmetic operations.
  The code continues to run until the user chooses to exit.
 */


while(true)
{
    try
    {
        double firstNumber=0,secondNumber=0;
        char operation;

        Console.WriteLine("Enter first number:");
        firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter Operator:\n a.+\n b.-\n c.*\n d./");
        operation = Char.ToLower(Console.ReadLine()[0]);

        if(operation !='a' && operation !='+' && operation != 'b' && operation != '-' &&
           operation !='c' && operation !='*' && operation !='d' && operation!= '/')
        {
            throw new InvalidOperationException("Invalid Operation, TryAgain!");
        }

        Console.WriteLine("Enter second number:");
        secondNumber = Convert.ToDouble(Console.ReadLine());

        switch(operation)   
        {
            case 'a':
            case '+':  
                    addNumbers(firstNumber,secondNumber);
                    break;
            case 'b':
            case '-':  
                    subtractNumbers(firstNumber,secondNumber);
                    break;
            case 'c':
            case '*':  
                    multiplyNumbers(firstNumber,secondNumber);
                    break;
            case 'd':
            case '/':  
                    divideNumbers(firstNumber,secondNumber);
                    break;
            default: 
                    throw new InvalidOperationException("Invalid Operation, TryAgain!");

        }
    }
     catch (Exception e)
     {
            Console.WriteLine(e.Message);
            continue;
     }
Console.WriteLine("Do you want to continue? yes/no");
string answer = Console.ReadLine().ToLower();
if(answer != "yes" && answer != "y")
{
    break;
}

}


static void addNumbers(double firstNumber ,double secondNumber)
{
    double result = firstNumber+secondNumber;
    Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");

}

static void subtractNumbers(double firstNumber ,double secondNumber)
{       
    double result = firstNumber-secondNumber;
    Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");

}

static void multiplyNumbers(double firstNumber ,double secondNumber)
{
     double result = firstNumber*secondNumber;
     Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
}

static void divideNumbers(double firstNumber ,double secondNumber)
{
    if(secondNumber !=0)
    {
     double result = firstNumber/secondNumber;
     Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
    }
    else
    {
        Console.WriteLine("Division by zero is not allowed!");
    }

}

