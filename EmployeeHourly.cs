class EmployeeHourly : EmployeeFix
{
    private int workhours;
    public int WorkHours { get { return WorkHours; } }

    public EmployeeHourly(string firstName, string lastName, DateTime birth, char sex, double salary, double prizepercent,int workhours) :
        base(firstName, lastName, birth, sex, salary, prizepercent)
    { 
    this.workhours = workhours;
    }
    public EmployeeHourly() : base()
    {
        this.workhours = 0;
    }
    public void InputWorkHours()
    {
        Console.Write("Введите кол-во отработанных часов: ");
        workhours = int.Parse(Console.ReadLine()); 
    }

    public override void OutAll()
    {
        base.OutAll();
        Console.WriteLine("Кол-во отработанных часов: ");
        Console.WriteLine(workhours);
        Console.WriteLine();
    }
    public override void InpAll()
    {
        base.InpAll();
        InputWorkHours();
    }
    public override double SalaryPlusPrize()
    {
        return (Salary + Salary * PrizePercent / 100) * workhours;
    }
}