// Продукт
public class Character
{
    private string name;
    private string weapon;
    private string armor;

    public void SetName(string name) => this.name = name;
    public void SetWeapon(string weapon) => this.weapon = weapon;
    public void SetArmor(string armor) => this.armor = armor;

    public override string ToString()
    {
        return "Персонаж: {name}\nОружие: {weapon}\nБроня: {armor}";
    }
}

// Интерфейс строителя
public interface CharacterBuilder
{
    void BuildName();
    void BuildWeapon();
    void BuildArmor();
    Character GetResult();
}

// Конкретный строитель 1
public class WarriorBuilder : CharacterBuilder
{
    private readonly Character character = new();

    public void BuildName() => character.SetName("Рагнар");
    public void BuildWeapon() => character.SetWeapon("Двуручный боевой топор");
    public void BuildArmor() => character.SetArmor("Тяжёлые кованые латы");

    public Character GetResult() => character;
}

// Конкретный строитель 2
public class MageBuilder : CharacterBuilder
{
    private readonly Character character = new();

    public void BuildName() => character.SetName("Мерлин");
    public void BuildWeapon() => character.SetWeapon("Древний магический посох");
    public void BuildArmor() => character.SetArmor("Шёлковая мантия с защитными рунами");

    public Character GetResult() => character;
}

// Директор
public class GameMaster
{
    private CharacterBuilder builder;

    public GameMaster(CharacterBuilder builder)
    {
        this.builder = builder;
    }

    public void ConstructCharacter()
    {
        builder.BuildName();
        builder.BuildWeapon();
        builder.BuildArmor();
    }

    public Character GetCharacter() => builder.GetResult();
}


