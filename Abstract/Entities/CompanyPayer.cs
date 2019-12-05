
namespace Abstract.Entities
{
    class CompanyPayer : Payer
    {
        public int NumberEmployees { get; set; }

        public CompanyPayer(string name, double anualIncome, int numberEmployees)
            : base(name, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        public override double TaxCalc()
        {
            if (NumberEmployees > 10)
                return AnualIncome * 0.14;
            else
                return AnualIncome * 0.16;
        }
    }
}
