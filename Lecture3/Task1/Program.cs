// simple function example:
// int Square(int value) - name and parameters
// {
//     int result = value * value;
//     return value; - to return the value in varaible
// }


// second example:
// int Multiply(int value1, int value2) - name and parameters
// {
//     int result = value1 * value2;
//     return result;
// }

// if function doesn't return anything, we show data type "void":
// void Square(int value)
// {
//     int result = value * value;
//     Console.Write(result);
// }

double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}



double result = CalculateFormula(1, 3, 5, 6);
Console.WriteLine(result);