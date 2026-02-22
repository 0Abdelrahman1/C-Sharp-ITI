using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace D04_PII
{
    internal struct PhoneBook
    {
        long[] Numbers;
        string[] Names;
        int size;

        public int Size { get { return size; } }

        public PhoneBook(int _size)
        {
            size = _size;
            Numbers = new long[size];
            Names = new string[size];
        }

        public void SetEntry (int Index , string Name,  long Number)
        {
            if ((Index >=0)&&(Index < size))
            {
                Names[Index] = Name;
                Numbers[Index] = Number;
            }
        }

        public long GetNumber(string Name)
        {
            for(int i = 0;i <Names?.Length; i++)
                if (Names[i] == Name)
                    return Numbers[i];
            return -1;
        }

        public long this[int Index , string Name]
        {
            set
            {
                if ((Index >= 0) && (Index < size))
                {
                    Names[Index] = Name;
                    Numbers[Index] = value;
                }

            }
        }

        public string this[int Index]
        {
            get
            {
                if ((Index >= 0) && (Index < size))
                    return $"{Names[Index]}::::{Numbers[Index]}";
                return string.Empty;

            }
        }

        public long this[string Name]
        {
            get 
            {
                for (int i = 0; i < Names?.Length; i++)
                    if (Names[i] == Name)
                        return Numbers[i];
                return -1;
            }
            set 
            {
                for (int i = 0; i < Names?.Length; i++)
                    if (Names[i] == Name)
                        Numbers[i] = value;
            }
        }

    }
}
