using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Text;

namespace IoUserInputDemo
{
    public class Program
    {

            static void WriteIntoFile()
            {
                try
                {
                    using (FileStream fstream = new FileStream(@"F:\DotNetBatch2021\ConsoleAssignments\ConsoleAssignment-25-01-2021\file.txt", FileMode.Create, FileAccess.ReadWrite))
                    {
                        using (StreamWriter srr = new StreamWriter(fstream))
                        {
                            Console.WriteLine("Enter the String to write in file :");
                            string str = null;
                            while (str != "&")
                            {
                                str = Console.ReadLine();
                                if (str != "&")
                                {
                                    srr.WriteLine(str);
                                }
                            }


                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            static void ReadFromFile()
            {
                try
                {
                    using (StreamReader sr = new StreamReader(@"D:\DotNETBatch2021\Assignments\ConsoleAssignment25Jan2021\ConFileInputOutput\ConFileInputOutput\file.txt"))
                    {

                        Console.WriteLine("Reading contents of input.txt : \n" + sr.ReadToEnd());

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            static void Main(string[] args)
            {

                Program.WriteIntoFile();
                Program.ReadFromFile();

            }
        }
    }
