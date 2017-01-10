using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_Part1.Problem_2._Students_and_workers
{
    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHrsPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHrsPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHrsPerDay = workHrsPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            private set
            {
                if (value <= 0M)
                {
                    throw new ArgumentException("Week salary must be a positive value.");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHrsPerDay
        {
            get
            {
                return this.workHrsPerDay;
            }

            private set
            {
                if (value <= 0 || value > 12)
                {
                    throw new ArgumentException("Work hours per day must be a positive value between 1 and 12.");
                }

                this.workHrsPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (5 * this.WorkHrsPerDay);
        }
    }
}
