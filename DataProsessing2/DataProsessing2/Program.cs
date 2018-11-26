using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;


namespace DataProsessing2
{
    class Program
    {

        static void Main(string[] args)
        {
            bool isValidDate(int year, int month, int day)
            {
                if (year > 2099 || year < 0)
                {
                    return false;
                }
                if (month > 12 || month < 1)
                {
                    return false;
                }
                if (day > 31 || day < 1)
                {
                    return false;
                }
                switch (day)
                {
                    case 29:
                        if (month == 02)
                        {
                            if (!isLeapYear(year))
                            {
                                return false;
                            }
                        };
                        break;
                    case 31:
                        if (!has31Days(month))
                        {
                            return false;
                        }

                        break;

                    default:
                        return true;
                }
                return true;
            }

                bool isLeapYear(int LeapYearCandidate)
                {
                    if (LeapYearCandidate % 4 == 0
                        && LeapYearCandidate % 100 != 0)
                    {
                        if (LeapYearCandidate % 100 == 0)
                        {
                            return true;
                        }

                    }
                    return false;
                }
                bool has31Days(int days31)
                {
                    if (days31 == 1 || days31 == 3 || days31 == 5 || days31 == 7 || days31 == 8 || days31 == 10 || days31 == 12)
                    {
                        return true;

                    }
                    return false;
                }


                if (isValidDate(2011, 03, 32))
                {
                    Console.WriteLine("Gyldig");
                Console.ReadLine();


            }
            else
                {
                    Console.WriteLine("Ikke gyldig");
                Console.ReadLine();
                }
            Console.WriteLine($"{day}/{month}/{year}");
        }
        
        }
    }

                