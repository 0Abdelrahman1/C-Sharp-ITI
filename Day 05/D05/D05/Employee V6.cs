//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace D05
//{
//    ///Primary Ctor
//    struct Employee(int ID, string Name, decimal Salary)
//    {
//        public string FullName { get { return Name; } /*set { Name = value; }*/ }

//        public Employee() : this(101, "NA", 8000)
//        {
//            //ID = 102; ///Not available
//        }

//        public Employee(int _ID) : this(_ID, "NA", 8000) ///Primary ctor Chaining 
//        {

//        }


//        public override string ToString()
//        {
//            return $"{ID} , {Name} , {Salary}";
//        }
//    }
//}
