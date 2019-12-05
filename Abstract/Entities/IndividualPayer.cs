using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Entities
{
    class IndividualPayer : Payer
    {
        public double HealthExpenditures { get; set; }

        public IndividualPayer(string name, double anualIncome, double healthExpenditures) :
            base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxCalc()
        {
            double tax, health = 0;
            
            if (AnualIncome < 20000.0)
            {
                tax = AnualIncome * 0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0)
            {
                health = HealthExpenditures * 0.5;
            }

            return tax - health;
        }
    }
}
