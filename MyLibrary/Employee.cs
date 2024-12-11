using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary;
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual decimal CalculateMonthlyPayment() 
    {
        return 12000;
    }

    public int GetPaymentsDays()
    { 
        return 30;
    }
}  

public class Secretary : Employee
{
        public override decimal CalculateMonthlyPayment() => 15000;        
}

public class Manager : Employee
{
        public override decimal CalculateMonthlyPayment()
    {
        return 30000;
    }
    
}

public class Developer : Employee 
{
   // public override int GetPaymentsDays() => 20;
    public new int GetPaymentsDays()
    {
        return 20;
    }
}

