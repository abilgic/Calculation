using System.Collections.Generic;
using System.Xml.Linq;

public class Calculation
{
    public int calculation(LinkedList<int> list)
    {
        var count = 0;

        LinkedListNode<int> temp = list.First;

        if (temp.Next != null)
        {
            Console.Write("The list: ");
            while (temp.Next != null)
            {
                count++;
                Console.Write(temp.Value + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The list is empty.");
        }

        return count;
    }
    public static void Main(String[] args)
    {
        int[] arr = { 5, -1, 1, 2, 4, 3 };
        Array.Sort(arr);
        Array.Reverse(arr);

        LinkedList<int> list = new LinkedList<int>(arr);
        var calculation = new Calculation();

        var result = calculation.calculation(list);
        Console.WriteLine(result);

    }


}