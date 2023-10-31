// See https://aka.ms/new-console-template for more information
using EntityFrameworkExamples;

Console.WriteLine("Hello, World!");

NorthwindContext context = new();

var data = context.Employees.ToList();
Console.WriteLine($"Employees: {data}");