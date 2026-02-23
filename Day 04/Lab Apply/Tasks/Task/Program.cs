using System.Runtime.CompilerServices;

namespace Task
{
    internal class Program
    {

        [Flags]
        enum SecurityLevel : byte { GUEST = 1, DEVELOPER = 1 << 1, SECRETARY = 1 << 2, DBA = 1 << 3, SECURITY_OFFICER = (1 << 4) - 1 };

        enum Gender { M, F }
        struct HiringDate
        {
            private int day;
            private int month;
            private int year;

            public int Day { get => day; set => day = value; }
            public int Month { get => month; set => month = value; }
            public int Year { get => year; set => year = value; }


            public void SetNow()
            {
                this.Day = DateTime.Now.Day;
                this.Month = DateTime.Now.Month;
                this.Year = DateTime.Now.Year;
            }

            public HiringDate(int day, int month, int year)
            {
                this.Day = day;
                this.Month = month;
                this.Year = year;
            }
            public override string ToString()
            {
                return $"[Day:{Day} Month:{Month} Year:{Year}]";
            }
        }

        struct Employee
        {
            private int _id;
            private string _name;
            private SecurityLevel _securityLevel;
            private double _salary;
            private HiringDate _hireDate;
            private Gender _gender;

            public int Id { get { return _id; } set { _id = value; } }
            public string Name { get { return _name; } set { _name = value; } }
            public SecurityLevel SecurityLevel { get { return _securityLevel; } set { _securityLevel = value; } }
            public double Salary { get { return _salary; } set { _salary = value; } }
            public HiringDate HireDate { get { return _hireDate; } set { _hireDate = value; } }
            public Gender Gender { get { return _gender; } set { _gender = value; } }

            public void SetHiringDate(int? day = null, int? month = null, int? year = null)
            {
                this._hireDate.Day = day ?? DateTime.Now.Day;
                this._hireDate.Month = month ?? DateTime.Now.Month;
                this._hireDate.Year = year ?? DateTime.Now.Year;
            }


            public Employee(int id, SecurityLevel securityLevel, double salary = default, Gender gender = default)
            {
                Id = id;
                SecurityLevel = securityLevel;
                Salary = salary;
                Gender = gender;
                HireDate.SetNow();
            }
            public override string ToString()
            {
                return String.Format($"id: {Id}\tsecurity level: {SecurityLevel}\tsalary: {Salary:C}\thire date: {HireDate.ToString()}\tgender: {Gender}");
            }
        }

        struct EmployeeSearch
        {
            private Employee[] _employees;

            public EmployeeSearch(Employee[] employees)
            {
                this._employees = employees;
            }

            public Employee this[int id]
            {
                get
                {
                    foreach (Employee e in _employees)
                        if (e.Id == id)
                            return e;
                    return default;
                }
            }

            public Employee this[string name]
            {
                get
                {
                    foreach (Employee e in _employees)
                        if (e.Name == name)
                            return e;
                    return default;
                }
            }

            public Employee this[HiringDate hireDate]
            {
                get
                {
                    foreach (Employee e in _employees)
                        if (e.HireDate.Equals(hireDate))
                            return e;
                    return default;
                }
            }
        }



        static void Main(string[] args)
        {
            const int sz = 1;
            Employee[] employees = new Employee[sz];

            for (int i = 0; i < sz; i++)
            {
                Console.WriteLine($"Enter Data of The Emp#{i}:");
                Console.Write("\tid: ");
                employees[i].Id = int.Parse(Console.ReadLine());
                Console.Write("\tname: ");
                employees[i].Name = Console.ReadLine();
                Console.Write("\tSecurityLevel (GUEST | DEVELOPER | SECRETARY | DBA | SECURITY_OFFICER): ");
                employees[i].SecurityLevel = Enum.Parse<SecurityLevel>(Console.ReadLine());
                Console.Write("\tsalary: ");
                employees[i].Salary = double.Parse(Console.ReadLine());
                Console.Write("\tgender (M|F): ");
                employees[i].Gender = Enum.Parse<Gender>(Console.ReadLine());
                Console.WriteLine("\tHiring Date: ");
                Console.Write("\t\tDay: ");
                int d = int.Parse(Console.ReadLine());
                Console.Write("\t\tMonth: ");
                int m = int.Parse(Console.ReadLine());
                Console.Write("\t\tYear: ");
                int y = int.Parse(Console.ReadLine());
                employees[i].SetHiringDate(d, m, y);
                Console.WriteLine();
            }

            EmployeeSearch es = new EmployeeSearch(employees);

            string[] methods = { "NationalID", "Hiring Dates", "Name" };
            while (true)
            {
                Console.Write($"Enter Search Method [1]{methods[0]} [2]{methods[1]} [3]{methods[2]}: ");
                int m = int.Parse(Console.ReadLine());
                if (m > 3 || m < 1) return;

                Console.Write($"Enter {methods[m - 1]}:");
                switch (m)
                {
                    case 1:
                        Console.WriteLine(es[int.Parse(Console.ReadLine())].ToString());
                        break;
                    case 2:
                        Console.WriteLine(es[new HiringDate(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()))].ToString());
                        break;
                    case 3:
                        Console.WriteLine(es[Console.ReadLine()].ToString());
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}