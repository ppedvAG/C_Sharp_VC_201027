using System;

namespace StructVsClass
{
    class PersonC
    {
        public int Alter { get; set; }
        public string Name { get; set; }

        public PersonC(int alter, string name)
        {
            this.Name = name;
            this.Alter = alter;
        }
    }

    struct PersonS
    {
        public int Alter { get; set; }
        public string Name { get; set; }

        public PersonS(int alter, string name)
        {
            this.Name = name;
            this.Alter = alter;
        }
    }

    class Program
    {
        public static void Altern(PersonC person)
        {
            person.Alter++;
        }

        public static void Altern(PersonS person)
        {
            person.Alter++;
        }

        public static void Altern(ref PersonS person)
        {
            person.Alter++;
        }


        static void Main(string[] args)
        {
            PersonC classPerson = new PersonC(30,"Hugo");
            PersonS structPerson = new PersonS(30, "Anna");

            Console.WriteLine($"{classPerson.Name}: {classPerson.Alter}");
            Console.WriteLine($"{structPerson.Name}: {structPerson.Alter}");

            Altern(classPerson);
            Altern(structPerson);

            Console.WriteLine($"{classPerson.Name}: {classPerson.Alter}");
            Console.WriteLine($"{structPerson.Name}: {structPerson.Alter}");

            Altern(ref structPerson);
            Console.WriteLine($"{structPerson.Name}: {structPerson.Alter}");
        }
    }
}
