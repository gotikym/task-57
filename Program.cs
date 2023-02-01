using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        SpecialSquad specialSquad = new SpecialSquad();

        Console.WriteLine("Список солдат в спец отряде: ");
        specialSquad.ShowPersonnel();
    }
}

class SpecialSquad
{
    private List<Soldier> _soldiers = new List<Soldier>();

    public SpecialSquad()
    {
        RecruitSoldiers();
    }

    public void ShowPersonnel()
    {
        var personalInformation = _soldiers.Select(soldier => new
        {
            Name = soldier.Name,
            Rank = soldier.Rank
        });

        foreach (var soldier in personalInformation)
        {
            Console.WriteLine(soldier.Name + " - " + soldier.Rank);
        }
    }

    private void RecruitSoldiers()
    {
        _soldiers.Add(new Soldier("Валера", "Ротомолотилка", "Е*ейший", 56));
        _soldiers.Add(new Soldier("Андрюха", "Снайперская винтовка", "Воин", 23));
        _soldiers.Add(new Soldier("Евген", "Слезоточивая граната", "Псих", 18));
        _soldiers.Add(new Soldier("Антон", "Расщепитель", "Кощей", 30));
        _soldiers.Add(new Soldier("Жека", "Разрезающий всё нож", "Ноунейм", 16));
        _soldiers.Add(new Soldier("Виктор", "Газонокосилка", "Чумачечий", 22));
        _soldiers.Add(new Soldier("Костян", "Трёхметровый гриф", "Качок", 11));
        _soldiers.Add(new Soldier("Сергей", "Убедительный взгляд", "Хитрец", 47));
    }
}

class Soldier
{
    public Soldier(string name, string armament, string rank, int soldiersLife)
    {
        Name = name;
        Armament = armament;
        Rank = rank;
        SoldiersLife = soldiersLife;
    }

    public string Name { get; private set; }
    public string Armament { get; private set; }
    public string Rank { get; private set; }
    public int SoldiersLife { get; private set; }
}