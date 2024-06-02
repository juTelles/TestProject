// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Models;
using TestProject.Models;
using Newtonsoft;
using Newtonsoft.Json;


Console.WriteLine("Hello, World!");

//recommended because of readbility
(int, string, string, decimal) tuple = (1, "Kate", "Sman", 1.5M);
//recommneded naming objects
(int Id, string Name, string LastName, decimal Hight) tuple2 = (1, "Kate", "Sman", 1.5M);

//other sintaxes
ValueTuple<int, string, string, decimal> tuple3 = (1, "Kate", "Sman", 1.5M);

//infer types implictilly - we dont pass the types
var tuple4 = Tuple.Create(1, "Kate", "Sman", 1.5M);

Console.WriteLine(tuple2.Id);

//tuples used in methods

// We can use and return tuples from methods


// For example in the bellow method I want to return 3 values:
//the amount of lines (int), the status of the operation (bool) the lines itself (string)
// but a method can only return one value, but we can use tuples for this

ReadFile file = new ReadFile();
file.showResults("Files/text.txt");
//var (Success, Lines, AmountOfLines) = file.readingFile("Files/text.txt");

//ReadFile file2 = new ReadFile();
//var (Success2, Lines2, _) = file.readingFile("Files/text.txt");

//using descontructor
Person person = new Person("Lua", 15);
person.PresentPerson();
//calling descontructor
// descontruct the object's data in separated variables
(string name, int age) = person;
Console.WriteLine($"{name} and {age}");

//ternary if
int number = 15;
bool isEven = false;
isEven = number % 2 == 0;
Console.WriteLine($"The number {number} is {(isEven ? "even" : "odd")}");

string word = "dam";

Console.WriteLine($"The word is {(word == "boat" ? "yes1" : word == "damm" ? "yes2" : "no")}");

List<Sale> salesList = new List<Sale>();

Sale sale1 = new Sale(1, "Papel", 1.40M);
Sale sale2 = new Sale(1, "Papel Azul", 1.60M);
Sale sale3 = new Sale(1, "Papel Roxo", 1.80M);

salesList.Add(sale1);
salesList.Add(sale2);
salesList.Add(sale3);

string serializedSale1 = JsonConvert.SerializeObject(sale1, Formatting.Indented);
Console.WriteLine(serializedSale1);

string serializedSales = JsonConvert.SerializeObject(salesList, Formatting.Indented);


File.WriteAllText("Files/sales.json", serializedSales);

public class ReadFile
{
  public (bool Success, string[] Lines, int AmountOfLines, int check) ReadingFile(string filePath)
  {
    try
    {
      string[] lines = File.ReadAllLines(filePath);
      return (true, lines, lines.Count(), 1);
    }
    catch (Exception)
    {
      return (false, new string[0], 0, 0);
    }
  }
  public void showResults(string filePath)
  {
    var (Success, Lines, AmountOfLines, _) = ReadingFile(filePath);
    if (Success)
{
  Console.WriteLine($"Amount of lines on the file: {AmountOfLines}");
  foreach (string line in Lines)
  {
    Console.WriteLine(line);
  }
}
else
{
  Console.WriteLine("Erro reading the file.");
}
  }
}
