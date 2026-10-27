namespace ExerciseLINQ
{
    public class Student
    {
        public int Id { get; set; }
        public string Namn { get; set; } = "";
        public int Alder { get; set; }
        public string Klass { get; set; } = "";
        public int Poang { get; set; }

        public override string? ToString()
        {
            return $"ID: {Id}, Namn: {Namn}, Ålder: {Alder}, Klass: {Klass}, Poäng: {Poang}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Exempeldata
            List<Student> studenter = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Namn = "Anna",
                    Alder = 19,
                    Klass = "A",
                    Poang = 85,
                },
                new Student
                {
                    Id = 2,
                    Namn = "Bertil",
                    Alder = 22,
                    Klass = "B",
                    Poang = 72,
                },
                new Student
                {
                    Id = 3,
                    Namn = "Cecilia",
                    Alder = 20,
                    Klass = "A",
                    Poang = 91,
                },
                new Student
                {
                    Id = 4,
                    Namn = "David",
                    Alder = 24,
                    Klass = "C",
                    Poang = 64,
                },
                new Student
                {
                    Id = 5,
                    Namn = "Eva",
                    Alder = 19,
                    Klass = "B",
                    Poang = 85,
                },
                new Student
                {
                    Id = 6,
                    Namn = "Felix",
                    Alder = 21,
                    Klass = "A",
                    Poang = 77,
                },
                new Student
                {
                    Id = 7,
                    Namn = "Gustav",
                    Alder = 23,
                    Klass = "C",
                    Poang = 58,
                },
                new Student
                {
                    Id = 8,
                    Namn = "Hanna",
                    Alder = 20,
                    Klass = "B",
                    Poang = 95,
                },
            };
            Console.WriteLine("LINQ-ÖVNINGAR MED STUDENTER\n");

            List<Student> ageList = studenter.Where(s => s.Alder > 20).ToList();

            Console.WriteLine("Personer över 20:");
            foreach (var item in ageList)
            {
                Console.WriteLine(item.ToString());
            }

            List<Student> pointList = studenter.Where(s => s.Poang > 80).ToList();
            Console.WriteLine("\nPersoner med mer än 80 poäng:");
            foreach (var item in pointList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

//LINQ övningar – Övn. 7
//Praktisera nedanstående metoder.
//Where
//• Hämta alla studenter som är äldre än 20.
//• Hämta alla studenter som har mer än 80 poäng.
//Select
//• Visa bara namnen på alla studenter.
//• Visa namn och poäng i en ny anonym typ.
//OrderBy
//• Sortera studenter efter ålder.
//• Sortera studenter efter poäng, högst först.
//Count
//• Räkna hur många studenter som finns.
//• Räkna hur många som går i klass A
//Take
//• Ta ut de tre första studenterna.
//• Ta ut de två bästa poängen efter sortering.
//Distinct
//• Visa alla unika klassnamn.
//• Visa alla unika åldrar.
//Any / All
//• Finns det någon student med 100 poäng?
//• Har alla studenter minst 50 poäng?
//FirstOrDefault / Last / Single
//• Hämta första studenten i klass B.
//• Hämta sista studenten i listan.
//• Hämta studenten med ett visst Id.
//GroupBy
//• Gruppera studenter per klass.
//• Skriv ut varje klass och namnen i gruppen.
//Sum / Average / Min / Max
//• Summera alla poäng.
//• Räkna ut medelpoäng.
//• Hitta lägsta och högsta poäng
