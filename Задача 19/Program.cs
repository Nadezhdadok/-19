using Задача_19;

List<Computer> computers = new List<Computer>()



//internal class Computer
//{
//    public int Code { get; set; }
//    public string Name { get; set; }
//    public string Type { get; set; }
//    public double Frequency { get; set; }
//    public double Amount { get; set; }
//    public double Capacity { get; set; }
//    public double Memory { get; set; }
//    public int Summa { get; set; }
//    public int Quantity { get; set; }
//}
//}
{
    new Computer(){Code=111, Name="qwerty", Type="Pentium", Frequency=3.6, Amount=4, Capacity=2048, Memory=111, Summa=50, Quantity=5},
    new Computer(){Code=222, Name="qwert", Type="Celeron", Frequency=3, Amount=10, Capacity=1000, Memory=11, Summa=150, Quantity=1},
    new Computer(){Code=333, Name="qwer", Type="Core", Frequency=0.9, Amount=15, Capacity=3000, Memory=211, Summa=250, Quantity=15},
    new Computer(){Code=444, Name="qwe", Type="Pentium", Frequency=1, Amount=8, Capacity=500, Memory=1131, Summa=350, Quantity=25},
    new Computer(){Code=555, Name="qw", Type="Core", Frequency=5, Amount=7, Capacity=100, Memory=1000, Summa=450, Quantity=35},
    new Computer(){Code=666, Name="q", Type="Core", Frequency=4.5, Amount=2, Capacity=10000, Memory=411, Summa=550, Quantity=45},
};
//Console.WriteLine("Введите название процессора");
//string name = Console.ReadLine();
//List<Computer> computers1 = computers.Where(x => x.Name == name).ToList();
//Print(computers1);
//Console.WriteLine(computers1);


//Console.WriteLine("Введите объем ОЗУ");
//double amount = Convert.ToDouble(Console.ReadLine());
//List<Computer> computers2 = computers.Where(x => x.Amount >= amount).ToList();
//Print(computers2);
//Console.WriteLine(computers2);

//List<Computer> computers3 = computers.OrderBy(x => x.Summa).ToList();
//Print(computers3);
//Console.WriteLine(computers3);

//IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.Type);
//foreach(IGrouping<string, Computer> gr in computers4)
//{
//    Console.WriteLine(gr.Key);
//    foreach(Computer e in gr)
//    {
//        Console.WriteLine($"{e.Code} {e.Name} {e.Type} {e.Frequency} {e.Amount} {e.Capacity} {e.Memory} {e.Summa} {e.Quantity}");
//    }
//}



//Computer computer5 = computers.OrderByDescending(x => x.Summa).FirstOrDefault();
//Console.WriteLine($"{computer5.Code} {computer5.Name} {computer5.Type} {computer5.Frequency} {computer5.Amount} {computer5.Capacity} {computer5.Memory} {computer5.Summa} {computer5.Quantity}");

//Computer computer6 = computers.OrderByDescending(x => x.Summa).Last();
//Console.WriteLine($"{computer6.Code} {computer6.Name} {computer6.Type} {computer6.Frequency} {computer6.Amount} {computer6.Capacity} {computer6.Memory} {computer6.Summa} {computer6.Quantity}");

Console.WriteLine(computers.Any(x => x.Quantity > 30));


static void Print(List<Computer> computers)
{
    foreach(Computer e in computers)
    {
        Console.WriteLine($"{e.Code} {e.Name} {e.Type} {e.Frequency} {e.Amount} {e.Capacity} {e.Memory} {e.Summa} {e.Quantity}");
    }
    Console.WriteLine();

}