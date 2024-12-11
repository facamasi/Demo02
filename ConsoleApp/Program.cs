﻿//using MyLibrary;

//int i = 5;
//string Name = "Hello";

//Product Leche;
//Leche = new Product(1, "Leche entera", 19, 100);

using MyLibrary;

Secretary Maria = new Secretary();
Maria.Name = "Maria";
Manager Pedro = new Manager();
Pedro.Name = "Pedro";
Developer Miguel = new Developer();
Miguel.Name = "Miguel";
Console.WriteLine($"Dias: {Miguel.GetPaymentsDays()}");

WriteEmployeeInfo(Maria);
WriteEmployeeInfo(Pedro);
WriteEmployeeInfo(Miguel);

void WriteEmployeeInfo(Employee employee)
    {
    Console.WriteLine($"{employee.Name}:{ employee.CalculateMonthlyPayment()}");
    Console.WriteLine($"Days: {employee.GetPaymentsDays()}");
}