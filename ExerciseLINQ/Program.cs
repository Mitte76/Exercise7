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
            Console.WriteLine("Antal studenter över 20:");
            foreach (var item in ageList)
            {
                Console.WriteLine(item.ToString());
            }
            //• Hämta alla studenter som har mer än 80 poäng.
            List<Student> pointList = studenter.Where(s => s.Poang > 80).ToList();
            Console.WriteLine("\nAntal studenter med mer än 80 poäng:");
            foreach (var item in pointList)
            {
                Console.WriteLine(item.ToString());
            }

            //Select
            //• Visa bara namnen på alla studenter.
            List<string> nameList = studenter.Select(s => s.Namn).ToList();
            Console.WriteLine("\nListar endast namn på alla studenter");
            foreach (var item in nameList)
            {
                Console.WriteLine(item);
            }

            //• Visa namn och poäng i en ny anonym typ.
            List<(string, int)> anonymous = studenter.Select(s => (s.Namn, s.Poang)).ToList();
            Console.WriteLine("\nListar endast namn och poäng på alla studenter");
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

            //Count
            //• Räkna hur många studenter som finns.
            int counted = studenter.Count();
            Console.WriteLine($"\nVisar antal studenter i listan: {counted}");

            //• Räkna hur många som går i klass A
            int countedClass = studenter.Where(s => s.Klass == "A").Count();
            Console.WriteLine($"\nVisar antal studenter i Klass A: {countedClass}");

            //Take
            //• Ta ut de tre första studenterna.
            List<Student> threeFirst = studenter.Take(3).ToList();
            Console.WriteLine("\nListar de tre första studenterna:");
            foreach (var item in threeFirst)
            {
                Console.WriteLine(item.ToString());
            }

            //• Ta ut de två bästa poängen efter sortering.
            List<Student> sortAndTake2 = studenter.OrderByDescending(s => s.Poang).Take(2).ToList();
            Console.WriteLine("\nListar de två studenterna med högst poäng:");
            foreach (var item in sortAndTake2)
            {
                Console.WriteLine(item.ToString());
            }

            //Distinct
            //• Visa alla unika klassnamn.
            List<string> distinctClass = studenter.Select(s => s.Klass).Distinct().ToList();
            Console.WriteLine("\nListar alla olika klasser:");
            foreach (var item in distinctClass)
            {
                Console.WriteLine(item.ToString());
            }
            //• Visa alla unika åldrar.
            List<int> distinctAge = studenter
                .OrderBy(s => s.Alder)
                .Select(s => s.Alder)
                .Distinct()
                .ToList();
            Console.WriteLine("\nListar alla olika åldrar (tog även sorterad efter ålder):");
            foreach (var item in distinctAge)
            {
                Console.WriteLine(item.ToString());
            }

            //Any / All
            //• Finns det någon student med 100 poäng?
            Console.WriteLine("\nFinns det någon student med exakt 100 poäng?");
            bool has100Points = studenter.Any(s => s.Poang == 100);
            Console.WriteLine(has100Points);

            //• Har alla studenter minst 50 poäng?
            Console.WriteLine("\nHar alla studenter mer än 50 poäng?");
            bool min50Points = studenter.All(s => s.Poang > 50);
            Console.WriteLine(min50Points);

            //FirstOrDefault / Last / Single
            //• Hämta första studenten i klass B.
            Console.WriteLine("\nListar första personen som tillhör klass B");
            Student? firstInKlassB = studenter.FirstOrDefault(s => s.Klass == "B");
            if (firstInKlassB != null)
            {
                Console.WriteLine(firstInKlassB.ToString());
            }

            //• Hämta sista studenten i listan.
            Console.WriteLine("\nVisar sista studenten i listan");
            Student? lastInList = studenter.LastOrDefault();
            if (lastInList != null)
            {
                Console.WriteLine(lastInList.ToString());
            }

            //• Hämta studenten med ett visst Id.
            Console.WriteLine("\nVisar student med id 6");
            Student? findStudentWitIdX = studenter.SingleOrDefault(s => s.Id == 6);
            if (findStudentWitIdX != null)
            {
                Console.WriteLine(findStudentWitIdX.ToString());
            }

            //GroupBy
            //• Gruppera studenter per klass.
            //• Skriv ut varje klass och namnen i gruppen.
            var groupedByClass = studenter.GroupBy(s => s.Klass).ToList();
            Console.WriteLine("\nListar studenter klassvis:");
            foreach (var item in groupedByClass)
            {
                Console.WriteLine($"Klass: {item.Key}");

                foreach (Student student in item)
                {
                    Console.WriteLine(student.ToString());
                }
                Console.WriteLine();
            }

            //Sum / Average / Min / Max
            //• Summera alla poäng.

            Console.WriteLine("\nVisar summan av poängen för alla studenter:");
            int totalPoints = studenter.Sum(s => s.Poang);
            Console.WriteLine($"Summa: {totalPoints}");

            //• Räkna ut medelpoäng.
            Console.WriteLine("\nVisar snittpoängen för alla studenter:");
            double averagePoint = studenter.Average(s => s.Poang);
            Console.WriteLine($"Summa: {averagePoint}");

            //• Hitta lägsta och högsta poäng
            Console.WriteLine("\nVisar högsta och lägsta poäng bland studenterna:");
            int highestPoint = studenter.Max(s => s.Poang);
            int lowestPoint = studenter.Min(s => s.Poang);

            Console.WriteLine($"Högst: {highestPoint}, Lägst: {lowestPoint}");
        }
    }
}
