using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter Employee Name: ");
        string name = Console.ReadLine()!;

        double hoursWorked = InputHelper.ReadPositiveDouble("Enter Hours Worked: ");
        double hourlyRate = InputHelper.ReadPositiveDouble("Enter Hourly Rate: ");

        Employee employee = new Employee(name, hoursWorked, hourlyRate);

        PayrollCalculator payroll = new PayrollCalculator();

        double regularPay = payroll.RegularPay(employee);
        double overtimePay = payroll.OvertimePay(employee);
        double grossSalary = payroll.GrossSalary(employee);

        Console.WriteLine("Employee Name : " + employee.Name);
        Console.WriteLine("Hours Worked : " + employee.HoursWorked);
        Console.WriteLine("Hourly Rate : " + employee.HourlyRate);
        Console.WriteLine("Regular Pay : " + regularPay.ToString("F2"));
        Console.WriteLine("Overtime Pay : " + overtimePay.ToString("F2"));
        Console.WriteLine("Gross Salary : " + grossSalary.ToString("F2"));
    }
}