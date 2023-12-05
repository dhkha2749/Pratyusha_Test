using System;
using System.Collections.Generic;
using System.Text;

namespace prathyusha_Test
{
    class SalariedEmployee : Employee
    {
        protected override float GetVacationAccumulationRate()
        {
            return 15.0f / 260.0f;
        }

    }
}
