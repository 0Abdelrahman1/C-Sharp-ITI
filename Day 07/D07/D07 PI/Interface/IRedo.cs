using System;
using System.Collections.Generic;
using System.Text;

namespace D07_PI.Interface
{
    interface IRedo
    {
        void Redo();
    }

    class passwordTextBox : IRedo
    {
        void IRedo.Redo()
        {
            Console.WriteLine("Text Box Redo");
        }

        public void SecureRedo()
        {
            Console.WriteLine("Secure");
            ((IRedo)this).Redo();
        }
    }

    interface IUndoRedo
    {
        void Redo(); ///public abstract Method
        void UnDo();
    }

    class MaskedTextBox : IRedo, IUndoRedo
    {
        public void Redo()
        {
            Console.WriteLine("Support Both Interfaces");
        }
        public void UnDo()
        {
            Console.WriteLine("Undo");
        }
    }

    class EditTextBox : IRedo, IUndoRedo
    {
        void IUndoRedo.Redo()
        {
            Console.WriteLine("Undo Version");
        }

        public void UnDo()
        {
            throw new NotImplementedException();
        }

        void IRedo.Redo()
        {
            Console.WriteLine("Redo Version");
        }
    }



}
