// интерфейс
public interface SortingStrategy
{
    void sort(int[] array)
}

// Конкретные стратегии
public class BubleSortStraregy : SortingStrategy
{
    public void BubleSort(int[] array) => Console.WriteLine("Применена пузырьковая сортировка");
}

public class QuickSortStrategy : SortingStrategy
{
    public void QuickSort(int[] array) => Console.WriteLine("Применена быстрая сортировка");
}

// Создание контекста
public class Sorter
{
    private SortingStrategy strategy;

    public void setStrategy(SortingStrategy strategy) => this.strategy = strategy;

    public void sort(int[] array) => strategy.sort(array);
}

