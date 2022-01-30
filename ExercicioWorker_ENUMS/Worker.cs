using System;
using System.Collections.Generic;
using System.Text;
using ExercicioWorker_ENUMS.Entities;

namespace ExercicioWorker_ENUMS {
    class Worker {
        public string Name { get; set; }
        public WorkLevel Level { get; private set; }
        public double BaseSalary { get; private set; }

        public Worker(string name, WorkLevel level, double baseSalary) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public void addContract(HourContract contract) {

        }

        public void removeContract(HourContract contract) {

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
