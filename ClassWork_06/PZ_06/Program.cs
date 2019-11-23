using System;
using System.Text;

namespace PZ_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("Empty array creation is possible!\nLook at there!\n");
            program.ShowArray(program.EmptyArrayCreation());
            program.ObjectArrayCreation();
            Console.WriteLine(program.RandomArrayCreation());

        }

        public void ShowArray(int[] array)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                builder.Append(array[i]);
                builder.Append(", ");
            }
            Console.WriteLine("[" + builder.ToString().Substring(0, builder.ToString().Length - 2) + "]");
        }

        public int[] EmptyArrayCreation()
        {
            return new int[10];
        }

        public void ObjectArrayCreation()
        {
            object[] objArray;
            Console.WriteLine(objArray = new object[3]{32, 'A', "Hello"});
            objArray[0] = Convert.ToInt32(objArray[0]) + 10;
            objArray[2] = Convert.ToString(objArray[2]) + ", guys!";
            foreach (object obj in objArray)
            {
                Console.WriteLine(obj.ToString());
            }
        }

        public int RandomArrayCreation()
        {
            int maxValue = 0;
            int[] randomArray = new int[13];
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = new Random().Next(1, 100);
                if (randomArray[i] > maxValue) maxValue = randomArray[i];
            }
            ShowArray(randomArray);
            return maxValue;
        }

        public void BoxingUnboxing()
        {
            object obj = new object();
            sbyte sbValue = 12;
            sbyte sbValue1;
            obj = sbValue;
            sbValue1 = (sbyte)obj;

        }
        
    }




}
