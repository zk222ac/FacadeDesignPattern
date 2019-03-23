namespace FacadeDesignPattern
{
   public class Student
    {
        public string Name { get; set; }
        public long Salary { get; set; }

        public Student(string name , long salary)
        {
            Name = name;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name},{nameof(Salary)}: {Salary}";
        }
    }
}
