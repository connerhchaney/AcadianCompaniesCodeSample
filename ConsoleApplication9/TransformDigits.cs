using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class TransformDigits
    {
        private ArrayList accountList;
        private ArrayList accountNumberDigitsArray = new ArrayList();

        private int[] accountNumberDigits = new int[9];


        public TransformDigits(ArrayList stringDigits)
        {
            
            accountList = new ArrayList();
            for (int i = 0; i < stringDigits.Count; i++)
            {
                accountList.Add(stringDigits[i]);
            }
        }
        public void Transform()
        {
            int accountDigitCount = 0;
            foreach (var x in accountList)
            {
                accountDigitCount++;
                    if (IsZero(x as String))
                    {
                        accountNumberDigitsArray.Add(0);
                        continue;
                    }
                    if (IsOne(x as String))
                    {
                        accountNumberDigitsArray.Add(1);
                        continue;
                    }
                    if (IsTwo(x as String))
                    {
                        accountNumberDigitsArray.Add(2);
                        continue;
                    }
                    if (IsThree(x as String))
                    {
                        accountNumberDigitsArray.Add(3);
                        continue;
                    }
                    if (IsFour(x as String))
                    {
                        accountNumberDigitsArray.Add(4);
                        continue;
                    }
                    if (IsFive(x as String))
                    {
                        accountNumberDigitsArray.Add(5);
                        continue;
                    }
                    if (IsSix(x as String))
                    {
                        accountNumberDigitsArray.Add(6);
                        continue;
                    }
                    if (IsSeven(x as String))
                    {
                        accountNumberDigitsArray.Add(7);
                        continue;
                    }
                    if (IsEight(x as String))
                    {
                        accountNumberDigitsArray.Add(8);
                        continue;
                    }
                    if (IsNine(x as String))
                    {
                        accountNumberDigitsArray.Add(9);
                        continue;
                    }
                    accountNumberDigitsArray.Add(-1);
            }
        


        }
        private bool IsZero(string digit)
        {
            return String.Compare(digit, " _ \n| |\n|_|") == 0;
        }
        private bool IsOne(string digit)
        {
            return String.Compare(digit, "   \n  |\n  |") == 0;
        }
        private bool IsTwo(string digit)
        {
            return String.Compare(digit, " _ \n _|\n|_ ") == 0;
        }
        private bool IsThree(string digit)
        {
            return String.Compare(digit, " _ \n _|\n _|") == 0;
        }
        private bool IsFour(string digit)
        {
            return String.Compare(digit, "   \n|_|\n  |") == 0;
        }
        private bool IsFive(string digit)
        {
            return String.Compare(digit, " _ \n|_ \n _|") == 0;
        }
        private bool IsSix(string digit)
        {
            return String.Compare(digit, " _ \n|_ \n|_|") == 0;
        }
        private bool IsSeven(string digit)
        {
            return String.Compare(digit, " _ \n  |\n  |") == 0;
        }
        private bool IsEight(string digit)
        {
            return String.Compare(digit, " _ \n|_|\n|_|") == 0;
        }
        private bool IsNine(string digit)
        {
            return String.Compare(digit, " _ \n|_|\n _|") == 0;
        }
        public void PrintAndCheckValidity(ArrayList accountsRead)
        {
            int[] digits = new int[9];
            int count = 0;
            foreach (var x in accountNumberDigitsArray)
            {
                digits[count] = int.Parse(x.ToString());
                count++;
                if (count == 9)
                {
                    bool flag = false;
                    for (int i = 0; i < 9; i++)
                    {
                        if (digits[i] == -1)
                        {
                            flag = true;
                            Console.WriteLine("Invalid Entry");
                            break;
                        }
                    }
                    count = 0;
                    if (flag)
                        continue;
                    for (int i = 0; i < 9; i++)
                    {
                        if (i == 0 )
                        Console.Write("Read : ");
                        Console.Write(digits[i]);
                    }
                        //checksum calculation:
                        //(d1+2*d2+3*d3 +..+9*d9) mod 11 = 0
                    int checksum = (digits[8] + 2 * digits[7] + 3 * digits[6] + 4 * digits[5] + 5 * digits[4] + 6 * digits[3] + 7 * digits[2] + 8 * digits[1] + 9 * digits[0]) % 11;
                    Console.WriteLine("\nChecksum : {0}", checksum);
                    if (checksum == 0)
                    {
                        Console.WriteLine("--Valid Account Number--");
                    }
                    else
                    {
                        Console.WriteLine("--Invalid Account Number--");
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
