using System;
using System.Collections.Generic;
using System.Text;

namespace prathyusha_Test
{
  public  class Employee
    {
        public float VacationDays { get; protected set; }

        public Employee()
        {
            VacationDays = 0;
        }

        public virtual void Work(int daysWorked)
        {
            VacationDays = Math.Min(VacationDays + daysWorked * GetVacationAccumulationRate(), 260);
        }

        public virtual void TakeVacation(float daysTaken)
        {
            VacationDays = Math.Max(VacationDays - daysTaken, 0);
        }

        protected virtual float GetVacationAccumulationRate()
        {
            return 0;
        }
    }
}
