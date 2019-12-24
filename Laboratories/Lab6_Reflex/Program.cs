
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Lab6_Reflex
{
    class Program
    {
        public static bool GetPropertyAttribute(PropertyInfo checkType, Type attributeType, out object attribute)
        {
            bool Result = false;
            attribute = null;
            var isAttribute = checkType.GetCustomAttributes(attributeType, false);
            if (isAttribute.Length > 0)
            {
                Result = true;
                attribute = isAttribute[0];
            }
            return Result;
        }


        static void AssemblyInfo()
        {
            Console.WriteLine("Вывод информации о сборке:");
            Assembly i = Assembly.GetExecutingAssembly();
            Console.WriteLine("Полное имя:" + i.FullName);
            Console.WriteLine("Исполняемый файл:" + i.Location);
        }


        static void TypeInfo()
        {
            Test obj = new Test();
            Type t = obj.GetType();
            Console.WriteLine("\nИнформация о типе:");
            Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);
            Console.WriteLine("Пространство имен " + t.Namespace);
            Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);

            Console.WriteLine("\nКонструкторы:");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nМетоды:");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства:");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nПоля данных (public):");
            foreach (var x in t.GetFields(BindingFlags.Public))
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nTest реализует IComparable -> " +
            t.GetInterfaces().Contains(typeof(IComparable))
            );
        }


        static void InvokeMemberInfo()
        {
            Type t = typeof(Test);
            Console.WriteLine("\nВызов метода:");

            Test fi = (Test)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });


            object[] parameters = new object[] { 3, 2 };

            object Result = t.InvokeMember("Multiply", BindingFlags.InvokeMethod, null, fi, parameters);
            Console.WriteLine("Multiply:(3,2)={0}", Result);
        }


        static void AttributeInfo()
        {
            Type t = typeof(Test);
            Console.WriteLine("\nСвойства, помеченные атрибутом:");
            foreach (var x in t.GetProperties())
            {
                object attrObj;
                if (GetPropertyAttribute(x, typeof(NewAttribute), out attrObj))
                {
                    NewAttribute attr = attrObj as NewAttribute;
                    Console.WriteLine(x.Name + " - " + attr.Description);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа 6 - 'Работа с рефлексией");
            Console.Title = "Выполнил:Ли М.В. Группа:ИУ5-34Б";
            AssemblyInfo();
            TypeInfo();
            InvokeMemberInfo();
            AttributeInfo();

            Console.ReadLine();
        }
    }
}