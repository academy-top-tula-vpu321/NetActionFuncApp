Action method = PrintHello;
Action<string> method2 = PrintHelloName;

Func<int> method100 = Return100;
Func<float, int> squareFloatInt = SquareNumber;

Predicate<float> predicate = Filter;

Func<int, Action> outer1 = FuncOuter;
Action counter = outer1(0);
for(int i = 0; i < 5; i++)
    counter();

var acc1 = AccCreate(50);
for(int i = 0; i < 5; i++)
    Console.WriteLine(acc1((i + 1) * 10));


Action FuncOuter(int countInit = 0)
{
    int count = countInit;
    //void FuncInner()
    //{
    //    Console.WriteLine(count++);
    //}
    //return FuncInner;
    return () => Console.WriteLine(count++);
}

Func<int, int> AccCreate(int accInit)
{
    int amount = accInit;
    return (number) => amount += number;
}



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