using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        PrintStatus("After Creation", numbers);
        numbers.Add(1);
        PrintStatus("After Adding 1", numbers);
        numbers.Add(2);
        PrintStatus("After Adding 2", numbers);
        numbers.Add(3);
        PrintStatus("After Adding 3", numbers);
        numbers.Add(4);
        PrintStatus("After Adding 4", numbers);
        numbers.Add(5);
        PrintStatus("After Adding 5", numbers);
        numbers.AddRange(new [] { 6, 7, 8 });
        PrintStatus("After Adding 6,7,8", numbers);
        numbers.Add(9);
        PrintStatus("After Adding 9", numbers);

        numbers.Remove(1);

        PrintStatus("After Removing 1", numbers);
        numbers.RemoveRange(2,3);
        PrintStatus("After Removing 3 items from index 2", numbers);
        numbers.TrimExcess();
        PrintStatus("After TrimExcess ", numbers);
        static void PrintStatus(string action, List<int> numbers)
        {
            Console.WriteLine($"{action.PadRight(25)}"+
                            $"Count    : {numbers.Count.ToString().PadLeft(2)},"+
                            $"Capacity : {numbers.Capacity.ToString().PadLeft(2)}");
        }
    }
}