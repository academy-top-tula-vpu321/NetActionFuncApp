Action method = PrintHello;
Action<string> method2 = PrintHelloName;

Func<int> method100 = Return100;
Func<float, int> squareFloatInt = SquareNumber;

Predicate<float> predicate = Filter;

bool Filter(float item)
{
    return item > 0;
}


int Return100()
{
    return 100;
}

int SquareNumber(float number)
{
    return (int)number * (int)number;
}

void PrintHello()
{
    Console.WriteLine("Hello");
}

void PrintHelloName(string name)
{ 
    Console.WriteLine($"Hello {name}"); 
}


// delegate void Method(); // Action

delegate void Method1<T>( T var1 );

delegate void Method2<T1, T2>(T1 var1, T2 var2);