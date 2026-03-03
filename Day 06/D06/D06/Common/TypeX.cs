namespace Common
{
    public class TypeX
    {
        int A; ///Defualt Private

        private protected int E; ///Inside Derived classes in the same assembly file ONLY
       ///or protected private int E;

        protected int B;

        internal int C;

        internal protected int D; ///protected internal int D;

        public int F;
        
        public override string ToString()
        {
            return $"{A} {B} {C} {D} {E}";
        }
    }
}
