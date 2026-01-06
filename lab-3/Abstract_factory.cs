// Интерфейс
public interface MeleeUnit
{
    void Spawn();
    void Attack();
}

public interface RangedUnit
{
    void Spawn();
    void Attack();
}

public interface MageUnit
{
    void Spawn();
    void Attack();
}

// Конкретные продукты 1
public class HumanKnight : MeleeUnit
{
    public void Spawn()
    {
        Console.WriteLine("Создан Рыцарь Альянса: тяжелая броня, меч и щит");
    }

    public void Attack()
    {
        Console.WriteLine("Рыцарь рубит врагов мечом! Урон: 50");
    }
}

public class HumanArcher : RangedUnit
{
    public void Spawn()
    {
        Console.WriteLine("Создан Лучник Альянса: ловкий стрелок с длинным луком");
    }

    public void Attack()
    {
        Console.WriteLine("Лучник поражает цель стрелой! Урон: 30");
    }
}

public class HumanMage : MageUnit
{
    public void Spawn()
    {
        Console.WriteLine("Создан Маг Альянса: мастер огненных шаров и щитов");
    }

    public void Attack()
    {
        Console.WriteLine("Маг метает огненный шар! Урон: 40");
    }
}

// Конкретные продукты 2
public class OrcGrunt : MeleeUnit
{
    public void Spawn()
    {
        Console.WriteLine("Создан Грунг Орды: дикий воин с топором и яростью");
    }

    public void Attack()
    {
        Console.WriteLine("Грунг крушит врагов топором! Урон: 60");
    }
}

public class OrcTroll : RangedUnit
{
    public void Spawn()
    {
        Console.WriteLine("Создан Тролль-стрелок Орды: регенерирующий метатель копий");
    }

    public void Attack()
    {
        Console.WriteLine("Тролль швыряет копье! Урон: 35");
    }
}

public class OrcShaman : MageUnit
{
    public void Spawn()
    {
        Console.WriteLine("Создан Шаман Орды: призыватель молний и тотемов");
    }

    public void Attack()
    {
        Console.WriteLine("Шаман вызывает молнию! Урон: 45");
    }
}

// Абстрактная фабрика
public interface FractionFactory
{
    MeleeUnit CreateMelee();
    RangedUnit CreateRanged();
    MageUnit CreateMage();
}

// Конкретная фабрика 1
public class HumanFractionFactory : FractionFactory
{
    public MeleeUnit CreateMelee() => new HumanKnight();
    public RangedUnit CreateRanged() => new HumanArcher();
    public MageUnit CreateMage() => new HumanMage();
}

// Конкретная фабрика 2
public class OrcFractionFactory : FractionFactory
{
    public MeleeUnit CreateMelee() => new OrcGrunt();
    public RangedUnit CreateRanged() => new OrcTroll();
    public MageUnit CreateMage() => new OrcShaman();
}

