using System;
using System.Collections.Generic;
using System.Text;

namespace prathyusha_Test
{
    class HourlyEmployee : Employee
    {
        protected override float GetVacationAccumulationRate()
        {
            return 10.0f / 260.0f;
        }



    }
}
