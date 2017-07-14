using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class ReadAccountNumbers
    {

        private ArrayList accountNumbers;
        private StreamReader file;
        private String fileNameStored;
        private string d1;
        private string d2;
        private string d3;
        private string d4;
        private string d5;
        private string d6;
        private string d7;
        private string d8;
        private string d9;
        public ReadAccountNumbers() {
            Console.Write("Enter the path to the text file: ");

            fileNameStored = Console.ReadLine();
            
        }
        public ArrayList Read() {
            try
            {
                file = new StreamReader(fileNameStored);
                accountNumbers = new ArrayList();
                string line;
                int count = 0;
                while (true)
                {
                    if (count == 4)
                    {
                        count = 0;
                    }

                    line = file.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    if (line.Length != 27)
                    {
                        int length = line.Length;
                        length = 27 - length;
                        for (int i = 0; i < length; i++)
                        {
                            line += " ";
                        }
                    }
                    accountNumbers.Add(line);
                    count++;
                }
                file.Close();



            }
            catch (IOException)
            {
                Console.WriteLine("IOException occurred!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            return accountNumbers;
        }

        public void BreakDownIntoDigits(out  ArrayList accountNumberDigits) {
            int count = 0;
            accountNumberDigits = new ArrayList();
            String splitString;
            for (int i = 0; i < accountNumbers.Count; i++)
            {
                    splitString = accountNumbers[i] as String;
                if (count != 3)
                {
                    if (count == 0)
                    {
                        d1 = splitString.Substring(0, 3) + "\n";
                        d2 = splitString.Substring(3, 3) + "\n";
                        d3 = splitString.Substring(6, 3) + "\n";
                        d4 = splitString.Substring(9, 3) + "\n";
                        d5 = splitString.Substring(12, 3) + "\n";
                        d6 = splitString.Substring(15, 3) + "\n";
                        d7 = splitString.Substring(18, 3) + "\n";
                        d8 = splitString.Substring(21, 3) + "\n";
                        d9 = splitString.Substring(24, 3) + "\n";
                    }
                    else if (count == 1)
                    {
                        d1 += splitString.Substring(0, 3) + "\n";
                        d2 += splitString.Substring(3, 3) + "\n";
                        d3 += splitString.Substring(6, 3) + "\n";
                        d4 += splitString.Substring(9, 3) + "\n";
                        d5 += splitString.Substring(12, 3) + "\n";
                        d6 += splitString.Substring(15, 3) + "\n";
                        d7 += splitString.Substring(18, 3) + "\n";
                        d8 += splitString.Substring(21, 3) + "\n";
                        d9 += splitString.Substring(24, 3) + "\n";
                    }
                    else 
                    {
                        d1 += splitString.Substring(0, 3);
                        d2 += splitString.Substring(3, 3);
                        d3 += splitString.Substring(6, 3);
                        d4 += splitString.Substring(9, 3);
                        d5 += splitString.Substring(12, 3);
                        d6 += splitString.Substring(15, 3);
                        d7 += splitString.Substring(18, 3);
                        d8 += splitString.Substring(21, 3);
                        d9 += splitString.Substring(24, 3);
                    }
                    count++;
                }
                else
                {
                    count = 0;
                    accountNumberDigits.Add(d1);
                    accountNumberDigits.Add(d2);
                    accountNumberDigits.Add(d3);
                    accountNumberDigits.Add(d4);
                    accountNumberDigits.Add(d5);
                    accountNumberDigits.Add(d6);
                    accountNumberDigits.Add(d7);
                    accountNumberDigits.Add(d8);
                    accountNumberDigits.Add(d9);
                }

            }
            accountNumberDigits.Add(d1);
            accountNumberDigits.Add(d2);
            accountNumberDigits.Add(d3);
            accountNumberDigits.Add(d4);
            accountNumberDigits.Add(d5);
            accountNumberDigits.Add(d6);
            accountNumberDigits.Add(d7);
            accountNumberDigits.Add(d8);
            accountNumberDigits.Add(d9);
        }

        
    }
}
