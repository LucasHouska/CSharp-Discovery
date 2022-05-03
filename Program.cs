// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("The current time is " + DateTime.Now);

// int myNum = 7;
// long longNum = 1000000000000000000L;
// float halfMyNumber = 3.5F;
// double halfMyNumberWithDouble = 3.50000D;
// bool isCSharpFun = true;
// bool isFishTasty = false;
// char myFirstInitial = 'L';
// string myFirstString = "hello world";
// string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

// Console.WriteLine(myNum);
// Console.WriteLine(longNum);
// Console.WriteLine(halfMyNumber);
// Console.WriteLine(halfMyNumberWithDouble);
// Console.WriteLine(isCSharpFun);
// Console.WriteLine(isFishTasty);
// Console.WriteLine(myFirstInitial);
// Console.WriteLine(myFirstString);
// Console.WriteLine(cars[0]);


// //Implicit type casting (changing one data type to a bigger one)
// int myInt = 9;
// double myDouble = myInt;       // Automatic casting: int to double

// Console.WriteLine(myInt);      // Outputs 9
// Console.WriteLine(myDouble);   // Outputs 9


// //Explicit type casting
// double myOtherDouble = 9.78;
// int myOtherInt = (int) myDouble;    // Manual casting: double to int

// Console.WriteLine(myOtherDouble);   // Outputs 9.78
// Console.WriteLine(myOtherInt);      // Outputs 9



// // Type your username and press enter
// // Console.WriteLine("Enter username:");

// // // Create a string variable and get user input from the keyboard and store it in the variable
// // // string userName = Console.ReadLine();

// // // Print the value of the variable (userName), which will display the input value
// // Console.WriteLine("Username is: " + userName);


// //You need to type cast from string to int for numbers
// // Console.WriteLine("Enter your age:");
// // // int age = Convert.ToInt32(Console.ReadLine());
// // Console.WriteLine("Your age is: " + age);




// Math.Max(5, 10);

// Math.Min(1, 5);

// Math.Sqrt(64);

// Math.Abs(-4.7);

// int x = 10;
// int y = 9;
// Console.WriteLine(x > y);

// if(9>7){
//     Console.WriteLine("oh it's true");
// }

// if(1>4){
//     Console.WriteLine("true");
// } else {
//     Console.WriteLine("false");
// }



// int day = 4;
// switch (day) 
// {
//   case 1:
//     Console.WriteLine("Monday");
//     break;
//   case 2:
//     Console.WriteLine("Tuesday");
//     break;
//   case 3:
//     Console.WriteLine("Wednesday");
//     break;
//   case 4:
//     Console.WriteLine("Thursday");
//     break;
//   case 5:
//     Console.WriteLine("Friday");
//     break;
//   case 6:
//     Console.WriteLine("Saturday");
//     break;
//   case 7:
//     Console.WriteLine("Sunday");
//     break;
// }

// for (int i=0; i <  3; i++){
//     Console.WriteLine(i);
// }



// class Car
// {
//     string color = "red";

//     static void Main(string[] args)
//     {
//         Car myObj1 = new Car();
//         Car myObj2 = new Car();
//         Console.WriteLine(myObj1.color);
//         Console.WriteLine(myObj2.color);
//     }
// }



class Program
{
    static void MyMethod()
    {
        Console.WriteLine("hello");
    }

    static void Main(string[] args)
    {
        MyMethod();
    }
}