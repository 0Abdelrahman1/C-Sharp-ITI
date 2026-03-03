using System;
using System.Collections.Generic;
using System.Text;

namespace D07_PI.Interface
{
    internal interface IPerson
    {
        string FName { get; set; }
        string LName { get; set; }

        void SetLvl(int Lvl);

        ///Default Implementation
        internal void Promote(int LVL)
        {
            SetLvl(LVL);
        }
    }

    class Employee : IPerson
    {
        public string FName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SetLvl(int Lvl)
        {
        }
    }

    class Manager : IPerson
    {
        public string FName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void SetLvl(int Lvl)
        {
            throw new NotImplementedException();
        }

        internal /*virtual*/ void Promote(int LVL)
        {
            SetLvl(++LVL);
        }


    }

}
