using System.Collections.Generic;
using ExercicioWorker_ENUMS.Entities;
using ExercicioWorker_ENUMS.Entities.Enums;

namespace ExercicioWorker_ENUMS {
    class Worker {
        public string Name { get; private set; }
        public WorkLevel Level { get; private set; }
        public double BaseSalary { get; private set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; private set; } = new List<HourContract>();

        public Worker(string name, WorkLevel level, double baseSalary, Department department) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addContract(HourContract contract) {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        public double income(int year, int month) {

        }

        public override string ToString() {
            return Name
                + (", ")
                + Level
                + (", ")
                + BaseSalary;
        }

    }
}
