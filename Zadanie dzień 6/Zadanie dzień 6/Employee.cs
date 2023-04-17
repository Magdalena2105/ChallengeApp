namespace Zadanie_dzień_6
{
    public class Employee
    { 
        //Lista
        private List<int> score = new List<int>();
        public Employee(string name, string surname, int age) //Konstruktor
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        //Pole
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }


        //Metoda (AddScore)
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
