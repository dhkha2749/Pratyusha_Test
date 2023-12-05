using System;
using System.Collections.Generic;

namespace prathyusha_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating 10 instances of each type of employee
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                employees.Add(new HourlyEmployee());
                employees.Add(new SalariedEmployee());
                employees.Add(new Manager());
            }

            foreach (var emp in employees)
            {
                emp.Work(20); // Simulating 20 days worked
                emp.TakeVacation(5); // Simulating taking 5 days of vacation
                Console.WriteLine($"Employee Vacation Days: {emp.VacationDays}");
            }

        }
    }
}
