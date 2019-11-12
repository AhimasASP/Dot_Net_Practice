using System;
using System.Linq;
using System.Reflection;

namespace Sample1
{
    class Motorcycle
    {
        public string Name { get; set; }
        public string Model { get; set; }

        private int _vin_number = 111;
        int odometr;

        public Motorcycle(string name)
        {
            Name = name;
        }

        public int GetVinNumber()
        {
            return _vin_number;
        }

        public override string ToString()
        {
            return $"Motorcycle Name: {Name} Model: {Model} Vin: {_vin_number} odometr: {odometr}";
        }
    }
    class Program
    {
        static void Main()
        {
            //Create Motorcycle instance
            Type motoType = typeof(Motorcycle);
            Type ctorParametr = typeof(string);

            ConstructorInfo ctor = motoType.GetTypeInfo()
                .DeclaredConstructors
                .First(ct => ct.GetParameters()[0].ParameterType == ctorParametr);

            object[] args = new object[] {"Honda"};

            object obj = ctor.Invoke(args);
            Console.WriteLine($"Current Type - {obj.GetType()}");
            Console.WriteLine(obj.ToString());

            //ReadWrite field operations

            FieldInfo fieldInfo = obj.GetType().GetTypeInfo().GetDeclaredField("_vin_number");
            Console.WriteLine($"Field info - {fieldInfo.Name}");
            Console.WriteLine($"Is private - {fieldInfo.IsPrivate}");

            fieldInfo.SetValue(obj, 999);

            Console.WriteLine(obj.ToString());
        }
    }
}
