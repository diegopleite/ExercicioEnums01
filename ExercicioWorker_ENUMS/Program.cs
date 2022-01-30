using System;
using ExercicioWorker_ENUMS.Entities.Enums;


namespace ExercicioWorker_ENUMS {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter Department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this Worker: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (Hours): ");
                int hour = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valueperHour, hour);

                worker.addContract(contract);

            }

            Console.WriteLine();
            Console.Write("Enter Month and year to calculate income (MM/YYYY): ");
            string[] monthAndYear = Console.ReadLine().Split('/');
            int month = int.Parse(monthAndYear[0]);
            int year = int.Parse(monthAndYear[1]);

            

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for: " + month +"/" + year + ": " + worker.income(year, month));
        
       }
    }
}
