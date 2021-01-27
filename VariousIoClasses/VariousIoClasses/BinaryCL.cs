using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariousIoClasses
{

    //C# BinaryReader Object works at lower level of Streams. 
    // C# BinaryReader is using for read primitive types as binary values in a specific encoding stream. Binaryreader Object works with Stream Objects that provide access to the underlying bytes. For creating a BinaryReader Object , 
    //you have to first create a FileStream Object and then pass BinaryReader to the constructor method .
    //he main advantages of Binary information is that 
    //stores files as Binary format is the best practice of space utilization.
    class BinaryCL
    {
        static void Main()
        {

            BinaryCL b = new BinaryCL();
            b.Writer();
            b.Reader();

        }
        public void Writer()
        {
            try
            {

                FileStream fs = new FileStream(@"F:\DotNetBatch2021\ConsoleAssignments\ConsoleAssignment-25-01-2021\Binary.txt", FileMode.OpenOrCreate,
                FileAccess.Write, FileShare.ReadWrite);

                Console.WriteLine("We are writing in Binary.txt using stream BinaryWriter");
                BinaryWriter bw = new BinaryWriter(fs);


                string name = "Nishi";
                int age = 22;
                double height = 5.2;
                char gender = 'F';


                bw.Write(name);
                bw.Write(age);
                bw.Write(height);
                bw.Write(gender);

                bw.Close();
                Console.WriteLine();
            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void Reader()
        {
            try
            {

                FileStream fin = new FileStream(@"F:\DotNetBatch2021\ConsoleAssignments\ConsoleAssignment-25-01-2021\Binary.txt", FileMode.Open,
                FileAccess.Read, FileShare.ReadWrite);
                Console.WriteLine("We are Reading from BInary.txt using stream BinaryReader");

                BinaryReader br = new BinaryReader(fin);
                br.BaseStream.Seek(0, SeekOrigin.Begin);

                string name = br.ReadString();
                int age = br.ReadInt32();
                double height = br.ReadDouble();
                char gender = br.ReadChar();

                Console.WriteLine("Name :" + name);
                Console.WriteLine("Age :" + age);
                Console.WriteLine("Height :" + height);
                Console.WriteLine("Gender M/F:" + gender);


                br.Close();
            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}

