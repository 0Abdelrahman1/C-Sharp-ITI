namespace Model
{
    ///default Access Modifier inside NameSpace : Internal
    
    public struct TypeA
    {
        int X; ///default Access Level : Private

        internal int Y; ///inside the same Assembly File (Project)

        public int Z;

        public void Show ()
        {
            Console.WriteLine($"{X} {Z}");
        }
    }
}
