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

            public int GetDay() { return day; }
            public int getMonth() { return month; }
            public int GetYear() { return year; }

            public void SetDay(int day) { this.day = day; }
            public void SetMonth(int month) { this.month = month; }
            public void SetYear(int year) { this.year = year; }

            public void SetNow()
            {
                this.day = DateTime.Now.Day;
                this.month = DateTime.Now.Month;
                this.year = DateTime.Now.Year;
            }

            public HiringDate(int day, int month, int year)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            public override string ToString()
            {
                return $"[Day:{day} Month:{month} Year:{year}]";
            }
        }

        struct Employee
        {
            private int _id;
            private SecurityLevel _securityLevel;
            private double _salary;
            private HiringDate _hireDate;
            private Gender _gender;

            public int GetId() { return _id; }
            public SecurityLevel GetSecurityLevel() { return _securityLevel; }
            public double GetSalary() { return _salary; }
            public HiringDate GetHiringDate() { return _hireDate; }
            public Gender GetGender() { return _gender; }

            public void SetId(int id) { this._id = id; }
            public void SetSecurityLevel(SecurityLevel securityLevel) { this._securityLevel = securityLevel; }
            public void SetSalary(double salary) { this._salary = salary; }
            public void SetGender(Gender gender) { this._gender = gender; }
            public void SetHiringDate(int? day = null, int? month = null, int? year = null)
            {
                this._hireDate.SetDay(day ?? DateTime.Now.Day);
                this._hireDate.SetMonth(month ?? DateTime.Now.Month);
                this._hireDate.SetYear(year ?? DateTime.Now.Year);
            }


            public Employee(int id, SecurityLevel securityLevel, double salary = default, Gender gender = default)
            {
                _id = id;
                _securityLevel = securityLevel;
                _salary = salary;
                _gender = gender;
                _hireDate.SetNow();
            }
            public override string ToString()
            {
                return String.Format($"id: {_id}\tsecurity level: {_securityLevel}\tsalary: {_salary:C}\thire date: {_hireDate.ToString()}\tgender: {_gender}");
            }
        }



        static void Main(string[] args)
        {
            const int sz = 3;
            Employee[] employees = new Employee[sz] { new(1, SecurityLevel.DBA), new(2, SecurityLevel.GUEST), new(3, SecurityLevel.SECURITY_OFFICER) };

            for (int i = 0; i < sz; i++)
            {
                Console.WriteLine($"Enter Data of The {employees[i].GetSecurityLevel()}:");
                Console.Write("\tsalary: ");
                employees[i].SetSalary(double.Parse(Console.ReadLine()));
                Console.Write("\tgender (M|F): ");
                employees[i].SetGender(Enum.Parse<Gender>(Console.ReadLine()));
                Console.Write("\tHiring Date Day: ");
                employees[i].SetHiringDate(int.Parse(Console.ReadLine()));
                Console.WriteLine();
            }


            for (int i = 0; i < sz; i++)
            {
                Console.WriteLine($"Emp#{i + 1}");
                Console.WriteLine($"\t{employees[i].ToString()}");
            }
        }
    }
}