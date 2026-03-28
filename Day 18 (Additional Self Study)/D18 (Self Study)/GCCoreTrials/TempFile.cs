using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCCoreTrials
{
    class TempFile : IDisposable
    {
        public String FileName { get; protected set; }

        FileStream fileStream;
        byte[] Data;

        public TempFile()
        {
            FileName = $"D:\\TEmpFiles\\TempFile{DateTime.Now.ToShortTimeString().Replace(":", string.Empty)}.dat";

            fileStream = new FileStream(FileName, FileMode.OpenOrCreate);
            Data = new Byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            fileStream.Write(Data, 0, Data.Length);
            fileStream.Close();

            Console.WriteLine($"File {FileName} Created");
        }

        public void DoSomeFileWork() => Console.WriteLine("Processing");

        //User Defined Function for Realeasing UnManaged Resources
        public void Dispose()
        {
            Console.WriteLine("Dispose");
            File.Delete(FileName);
            ///remove this from Finalization List
            GC.SuppressFinalize(this);
        }

        ~TempFile()
        {
            Console.WriteLine("Destructor");
            File.Delete(FileName);
        }
    }
}
