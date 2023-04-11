//EmployeeFix person01 = new();
//person01.OutAll();
//EmployeeFix person02 = new("Абзалов", "Азат", new DateTime(2005,02,02), 'М', 5000, 15);
//person02.OutAll();
//Console.WriteLine("Зарплата с учётом премиальных: " + person02.SalaryPlusPrize());
//Console.WriteLine("Налог:" + person02.Tax());
//Console.WriteLine("Чистая прибыль:" + person02.NetIncome());

EmployeeHourly person01 = new();
person01.OutAll();
person01.InpAll();
person01.OutAll();
EmployeeFix[] array = new EmployeeFix[]
{
    new EmployeeFix("Иванов", "Иван", new DateTime(2000,4,1), 'М', 15000, 15),
    new EmployeeFix("Петров", "Сергей", new DateTime(1999,5,4), 'М', 5000, 20),
    new EmployeeHourly("Сидоров", "Николай", new DateTime(1998,1,3), 'М', 500, 15,100),
    new EmployeeHourly("Игорева", "Анастасия", new DateTime(2001,3,22), 'Ж', 50, 15,150)
};

static double AllIncome(EmployeeFix[] array)
{
    double summ = 0;
    for (int i = 0; i < array.Length; i++)
        summ += array[i].SalaryPlusPrize();
    return Math.Round(summ, 3);
}

static double AllTax(EmployeeFix[] array)
{
    double summ = 0;
    for (int i = 0; i < array.Length; i++)
        summ += array[i].Tax();
    return Math.Round(summ, 3);
}

static EmployeeFix MaxIncome(EmployeeFix[] array)
{
    int max_i = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i].NetIncome() > array[max_i].NetIncome())
            max_i = i;
    }
    return array[max_i];
}
Console.WriteLine("Общий доход до вычета налогов = " + AllIncome(array));
Console.WriteLine("Доход с учётом вычета = " + AllTax(array));
Console.WriteLine("Работник с наибольшей чистой зарплатой: ");
MaxIncome(array).OutAll();