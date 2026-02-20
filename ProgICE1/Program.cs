// See https://aka.ms/new-console-template for more information
//student name
Console.Write("Enter Student Name: ");
var studentName = Console.ReadLine();

//preferred programming language
Console.Write("Enter Preferred Programming Language: ");
string? languageInput = Console.ReadLine();

//name= caps
var formattedName = studentName?.ToUpper();

// C# if nothung is typed
var formattedLanguage = string.IsNullOrWhiteSpace(languageInput)
    ? "C#"
    : languageInput.Trim();

//store
var message = $"Student {formattedName} has registered and prefers {formattedLanguage}.";


Console.WriteLine(message);
