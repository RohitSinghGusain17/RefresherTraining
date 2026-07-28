using System;

public class PayrollCalculator
{
    public double RegularPay(Employee employee)
    {
        double regularHours = Math.Min(employee.HoursWorked, 40);
        return regularHours * employee.HourlyRate;
    }

    public double OvertimePay(Employee employee)
    {
        if (employee.HoursWorked > 40)
        {
            double overtimeHours = employee.HoursWorked - 40;
            return overtimeHours * employee.HourlyRate * 1.5;
        }
        return 0;
    }

    public double GrossSalary(Employee employee)
    {
        double salary = RegularPay(employee) + OvertimePay(employee);
        return Math.Round(salary, 2);
    }
}