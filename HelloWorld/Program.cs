// // // See https://aka.ms/new-console-template for more information

// // //Console.WriteLine("Hello, World!");
// // // Console.WriteLine("My name is Atok");
// // // Console.Write("Congratulations!");
// // // Console.Write(" ");
// // // Console.Write("You wrote your first lines of code!");

// // // Console.WriteLine("Congratulations!");
// // // Console.Write("You wrote your first lines of code!");

// Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
// Console.WriteLine("Invoice: 1021\t\tComplete!");
// Console.WriteLine("Invoice: 1022\t\tComplete!");
// Console.WriteLine("\nOutput Directory:\t");
// Console.WriteLine(@"c:\invoices");
// // // Console.WriteLine(@"    c:\source\repos(this is where your code goes)");

// // // Format output using verbatim string literals



// // // Unicode escape characters

// // // Kon'nichiwa World!
// // // Console.WriteLine("\u3053\u3093\u306b\u3061\u306F World!");

// // To generate Japanese invoices:
// // Nihon no seikyū-sho o seisei suru ni wa:
// Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// // User command to run an application
// Console.WriteLine(@"\invoices\app.exe -j");

// Perform basic string formatting in C# 

// string firstName = "Atok";
// string message = $"Hello {firstName}!";

// Console.WriteLine(message);

// int version = 11;
// string updateText = "Update to Windows";
// Console.WriteLine($"{updateText} {version}");

// string projectName = "ACME";
// Console.WriteLine($@"C:\Output\{projectName}\Data");

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\Data.txt\n");
Console.WriteLine($"{russianMessage}:\n\tc:\\Exercise\\{projectName}\\ru-RU\\Data.txt\n");