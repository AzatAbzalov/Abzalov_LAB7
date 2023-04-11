class EmployeeFix : Person
{
    private double salary;
    private double prizepercent;
    public double Salary { get { return salary; } }

    public double PrizePercent { get { return prizepercent; } }
    public EmployeeFix(string firstName, string lastName, DateTime birth, char sex, double salary, double prizepercent) : base(firstName, lastName, birth, sex)
    {
        this.salary = salary;
        this.prizepercent = prizepercent;
    }
    public EmployeeFix() : base()
    {
        salary = 0;
        prizepercent = 0;
    }
    public override void OutAll()
    {
        base.OutAll();
        Console.WriteLine("Зарплата:");
        Console.WriteLine(salary);
        Console.WriteLine("Премия в процентах:");
        Console.WriteLine(prizepercent);
    }
    public override void InpAll()
    {
        base.InpAll();
        InputPrizepercent();
        InputSalary();
    }
    public void InputSalary()
    {
        Console.WriteLine("Введите зарплату: ");
        salary = Convert.ToDouble(Console.ReadLine());
    }
    public void InputPrizepercent()
    {
        Console.WriteLine("Введите процент премиальных: ");
        prizepercent = Convert.ToDouble(Console.ReadLine());
    }
    public virtual double SalaryPlusPrize()
    {
        return (salary + salary * prizepercent / 100);
    }

    public double Tax()
    {
        return (SalaryPlusPrize() * 0.13);
    }

    public double NetIncome()
    {
        return (SalaryPlusPrize() - Tax());
    }
}

