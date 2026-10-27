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

            //Where
            //• Hämta alla studenter som är äldre än 20.
            List<Student> ageList = studenter.Where(s => s.Alder > 20).ToList();
            Console.WriteLine("Personer över 20:");
            foreach (var item in ageList)
            {
                Console.WriteLine(item.ToString());
            }
            //• Hämta alla studenter som har mer än 80 poäng.
            List<Student> pointList = studenter.Where(s => s.Poang > 80).ToList();
            Console.WriteLine("\nPersoner med mer än 80 poäng:");
            foreach (var item in pointList)
            {
                Console.WriteLine(item.ToString());
            }

            //Select
            //• Visa bara namnen på alla studenter.
            List<string> nameList = studenter.Select(s=> s.Namn).ToList();
            Console.WriteLine("\nListar endast namn på alla personer");
            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }

            //• Visa namn och poäng i en ny anonym typ.
            List<(string, int)> anonymous = studenter.Select(s => (s.Namn, s.Poang)).ToList();
            Console.WriteLine("\nListar endast namn och poäng på alla personer");
            foreach (var item in anonymous)
            {
                Console.WriteLine($"{item.Item1} {item.Item2}");
            }

            //OrderBy
            //• Sortera studenter efter ålder.
            List<Student> sortByAge = studenter.OrderBy(s => s.Alder).ToList();
            Console.WriteLine("\nListar studenter efter ålder:");
            foreach (var item in sortByAge)
            {
                Console.WriteLine(item.ToString());
            }

            //• Sortera studenter efter poäng, högst först.
            List<Student> sortByPoints = studenter.OrderByDescending(s => s.Poang).ToList();
            Console.WriteLine("\nListar studenter efter poäng, högst först.:");
            foreach (var item in sortByPoints)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }
}


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
