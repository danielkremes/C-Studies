// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");
Console.WriteLine();

// Format output using character escape sequences
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Verbatim string literal
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

Console.Write(@"c:\invoices");
Console.WriteLine();

string firstName = "Bob";
string message = "Hello " + firstName;
Console.WriteLine(message);
Console.WriteLine();

string secondName = "jose";
string greeting = "Hello";
string secondMessage = greeting + " " + secondName + "!";
Console.WriteLine(secondMessage);
Console.WriteLine();

string threeName = "John";
string greeting_one = "Hello";
Console.WriteLine(greeting_one + " " + threeName + "!");
Console.WriteLine();

string message_text = $"{greeting} {firstName}!";

string fourName = "Jack";
string messageFourName = $"Hello {fourName}!";
Console.WriteLine(messageFourName);
Console.WriteLine();

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}!");
