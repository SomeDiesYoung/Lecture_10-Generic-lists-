using System.ComponentModel.DataAnnotations;

namespace Lecture_10_Generics_
{
    internal class Program
    {
        static void Main()
        {
            var numbers = new List<int> { 15, 63, 26, 85, 26 };

            int firstIndex = Algorytms<int>.FirstObjectIndexFinder(numbers, 26);

            Console.WriteLine($"from start position 26: {firstIndex}");

            int lastIndex = Algorytms<int>.LastObjectIndexFinder(numbers, 26);

            Console.WriteLine($"last position index 26: {lastIndex}");

            var allIndex = Algorytms<int>.AllObjectsIndexFinder(numbers, 26);
            Console.WriteLine($"all positions indexes 26: {string.Join(", ", allIndex)}");

            int maxValue = Algorytms<int>.FindingMaxValue(numbers);
            Console.WriteLine($"Max value: {maxValue}");

            Console.ReadKey();
        }


        public class Algorytms<T>
        {
            //დაწერეთ ფუნქცია რომელიც ლისტში იპოვის პირველივე შემხვედრი ობიექტის ინდექსს.

            public static int FirstObjectIndexFinder(List<T> objList, T value)
            {
                for (int i = 0; i < objList.Count; i++)
                {
                    if (objList[i].Equals(value))
                    {
                        return i;
                    }
                }
                return -1;
            }
            //დაწერეთ ფუნქცია რომელიც ლისტში იპოვის ბოლო შემხვედრი ობიექტის ინდექსს.

            public static int LastObjectIndexFinder(List<T> objList, T value)
            {
                for (int i = objList.Count - 1; i >= 0; i--)
                {
                    if (objList[i].Equals(value))
                    {
                        return i;
                    }
                }
                return -1;
            }

            //დაწერეთ ფუნქცია რომელიც ლისტში იპოვის ყველა შემხვედრი ობიექტის ინდექსებს დაა დააბრუნებს ინდექსების ლისტს

            public static List<int> AllObjectsIndexFinder(List<T> objList, T value)
            {
                List<int> list = new List<int>();
                for (int i = 0; i < objList.Count; i++)
                {
                    if (objList[i].Equals(value))
                    {
                        list.Add(i);
                    }
                }
                return list;
            }

            public static int FindingObjectInList(List<T> objList, T value)
            {
                for (int i = 0; i < objList.Count; i++)
                {
                    if (objList[i].Equals(value))
                    {
                        return i;
                    }
                }
                return -1;
            }

            public static T FindingMaxValue(List<T> objList) where T : struct, IComparable<T>
            {
                if (objList == null || objList.Count == 0)
                {
                    throw new ArgumentException("The list cannot be null or empty.");
                }

                T maxValue = objList[0];

                for (int i = 1; i < objList.Count; i++)
                {
                    if (objList[i].CompareTo(maxValue) > 0)
                    {
                        maxValue = objList[i];
                    }
                }

                return maxValue;
            }

        }
        }
}