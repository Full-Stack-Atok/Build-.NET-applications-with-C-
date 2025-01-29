// // // // // // See https://aka.ms/new-console-template for more information

// // // // // //Console.WriteLine("Hello, World!");
// // // // // // Console.WriteLine("My name is Atok");
// // // // // // Console.Write("Congratulations!");
// // // // // // Console.Write(" ");
// // // // // // Console.Write("You wrote your first lines of code!");

// // // // // // Console.WriteLine("Congratulations!");
// // // // // // Console.Write("You wrote your first lines of code!");

// // // // Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
// // // // Console.WriteLine("Invoice: 1021\t\tComplete!");
// // // // Console.WriteLine("Invoice: 1022\t\tComplete!");
// // // // Console.WriteLine("\nOutput Directory:\t");
// // // // Console.WriteLine(@"c:\invoices");
// // // // // // Console.WriteLine(@"    c:\source\repos(this is where your code goes)");

// // // // // // Format output using verbatim string literals



// // // // // // Unicode escape characters

// // // // // // Kon'nichiwa World!
// // // // // // Console.WriteLine("\u3053\u3093\u306b\u3061\u306F World!");

// // // // // To generate Japanese invoices:
// // // // // Nihon no seikyū-sho o seisei suru ni wa:
// // // // Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// // // // // User command to run an application
// // // // Console.WriteLine(@"\invoices\app.exe -j");

// // // // Perform basic string formatting in C# 

// // // // string firstName = "Atok";
// // // // string message = $"Hello {firstName}!";

// // // // Console.WriteLine(message);

// // // // int version = 11;
// // // // string updateText = "Update to Windows";
// // // // Console.WriteLine($"{updateText} {version}");

// // // // string projectName = "ACME";
// // // // Console.WriteLine($@"C:\Output\{projectName}\Data");

// // // string projectName = "ACME";

// // // string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

// // // Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\Data.txt\n");
// // // Console.WriteLine($"{russianMessage}:\n\tc:\\Exercise\\{projectName}\\ru-RU\\Data.txt\n");

// // // Perform basic operations on numbers in C#

// // // int firstNumber = 12;
// // // int secondNumber = 7;
// // // Console.WriteLine(firstNumber + secondNumber);

// // // string firstName = "Bob";
// // // int widgetsSold = 7;
// // // Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

// // // int sum = 7 + 4;
// // // int difference = 7 - 5;
// // // int product = 7 * 5;
// // // int quotient = 7 / 5;

// // // Console.WriteLine("Sum: " + sum);
// // // Console.WriteLine("Difference: " + difference);
// // // Console.WriteLine("Product: " + product);
// // // Console.WriteLine("Quotient: " + quotient);

// // // decimal decimalQuotient = 7.0m / 5;
// // // Console.WriteLine($"Decimal quotient: {decimalQuotient}");

// // int first = 7;
// // int second = 5;
// // decimal quotient = (decimal)first / (decimal)second;
// // Console.WriteLine(quotient);

// // Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
// // Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

// // int value1 = 3 + 4 * 5;
// // int value2 = (3 + 4) * 5;
// // Console.WriteLine(value1);
// // Console.WriteLine(value2);

// // Increment and decrement values

// // int value = 0;
// // value = value + 5;
// // value += 5;
// // Console.WriteLine(value);

// // int value = 0;
// // value = value += 1;
// // value++;
// // Console.WriteLine(value);

// // int value = 1;

// // value = value + 1;
// // Console.WriteLine("First increment: " + value);

// // value += 1;
// // Console.WriteLine("Second increment: " + value);

// // value++;
// // Console.WriteLine("Third increment: " + value);

// // value = value - 1;
// // Console.WriteLine("First decrement: " + value);

// // value -= 1;
// // Console.WriteLine("Second decrement: " + value);

// // value--;
// // Console.WriteLine("Third decrement: " + value);

// // int value = 1;
// // value++;
// // Console.WriteLine("First: " + value);
// // Console.WriteLine($"Second: {value++}");
// // Console.WriteLine("Third: " + value);
// // Console.WriteLine("Fourth: " + (++value));

// int fahrenheit = 94;

// decimal temperature = (fahrenheit - 32) * (5.0m / 9.0m);
// Console.WriteLine($"The temperature is {temperature} Celsius.");

// Guided - Project

// initialize variables - graded assignments 
// initialize variables - graded assignments 
// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");
