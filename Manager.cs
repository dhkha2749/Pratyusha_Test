using System;
using System.Collections.Generic;
using System.Text;

namespace prathyusha_Test
{
    class Manager : SalariedEmployee
    {
        protected override float GetVacationAccumulationRate()
        {
            return 30.0f / 260.0f;
        }


    }
}
