using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ASM1
{
    internal class WaterBillCaculater
    {
        static void Main(string[] args)
        {
            //Introduce
            Console.WriteLine("\t\t\t\t\t\t\t\t\tWelcome to water bill caculation!!!");
            //Enter the customer type
            Console.WriteLine("Select customer type \n1: Household \n2:Administrative agency or public services \n3:Production units \n4:Business ");
            Console.WriteLine("Enter your section with a number from 1-4");
            int Enterthecustomertype = Convert.ToInt32(Console.ReadLine());
            switch (Enterthecustomertype)
            {
                    case 1:
                    Console.WriteLine("Below is the price list for Household");
                    Console.WriteLine("To 10 m3/people/month is 5.973 VND/m3 and fees is 10%");
                    Console.WriteLine("From 10-20 m3/people/month is 7.052 VND/m3 and fees is 10%");
                    Console.WriteLine("From 20-30 m3/people/month is 8.699 VND/m3 and fees is 10%");
                    Console.WriteLine("Over 30 m3/people/month is 15.929 VND/m3 and fees is 10%");
                    Console.WriteLine("What is your name ?");
                    string NameofHousehold = Console.ReadLine();
                    Console.WriteLine("Hello "+ NameofHousehold + " Can you write the following information ?");
                    Console.WriteLine("Last month’s water meter readings");
                    double householdwaterconsumptionlastmonth = Convert.ToDouble(Console.ReadLine());
                    if (householdwaterconsumptionlastmonth <= 10)
                    {
                        double Householdlastmonthwaterbill = householdwaterconsumptionlastmonth * 5.937;
                        Console.WriteLine("Your last month's water bill is " + Householdlastmonthwaterbill);
                    }
                    else if (householdwaterconsumptionlastmonth < 20)
                    {
                        double householdlastmonthwaterbillbetterthan10 = ((householdwaterconsumptionlastmonth - 10) * 7.052) + (10 * 5.937);
                        Console.WriteLine("Your last month's water bill is " + householdlastmonthwaterbillbetterthan10);
                    }
                    else if (householdwaterconsumptionlastmonth < 30)
                    { 
                        double Householdlastmonthwaterbillbetterthan20 = ((householdwaterconsumptionlastmonth - 20) * 8.699) + (10 * 5.937) + (10 * 7.052);
                        Console.WriteLine("Your last month's water bill is " + Householdlastmonthwaterbillbetterthan20);
                    }
                    else
                    {
                        double Householdlastmonthwaterbill = ((householdwaterconsumptionlastmonth - 30) * 15.929) + (10 * 5.937) + (10 * 7.052) + (10 * 8.699);
                        Console.WriteLine("Your last month's water bill is " + Householdlastmonthwaterbill);
                    }
                    Console.WriteLine("This month’s water meter readings");
                    double householdwaterconsumptionthismonth = Convert.ToDouble(Console.ReadLine());
                    if (householdwaterconsumptionthismonth <= 10)
                    {
                        double Householdthismonthwaterbill = householdwaterconsumptionthismonth * 5.937;
                        Console.WriteLine("Your last month's water bill is " + Householdthismonthwaterbill);
                    }
                    else if (householdwaterconsumptionlastmonth < 20)
                    {
                        double Householdthismonthwaterbillbetterthan10 = ((householdwaterconsumptionthismonth - 10) * 7.052) + (10 * 5.937);
                        Console.WriteLine("Your last month's water bill is " + Householdthismonthwaterbillbetterthan10);
                    }
                    else if (householdwaterconsumptionlastmonth < 30)
                    {
                        double Householdthismonthwaterbillbetterthan20 = ((householdwaterconsumptionthismonth-20) * 8.699) + (10 * 5.937) + (10 * 7.052);
                        Console.WriteLine("Your last month's water bill is " + Householdthismonthwaterbillbetterthan20);
                    }
                    else
                    {
                        double Householdthismonthwaterbillbetterthan30 = ((householdwaterconsumptionthismonth-30) * 15.929) + (10 * 5.937) + (10 * 7.052) + (10 * 8.699);
                        Console.WriteLine("Your last month's water bill is " + Householdthismonthwaterbillbetterthan30);
                    }
                    Console.WriteLine("Thanks for your information");
                    break;
                    case 2:
                    Console.WriteLine("Below is the price list for Administrative agency or public services");
                    Console.WriteLine("9.955 VND/m3 and fees is 10%");
                    Console.WriteLine("What is your name ?");
                    string NameofAdministrativeagencyorpublicservices = Console.ReadLine();
                    Console.WriteLine("Hello " + NameofAdministrativeagencyorpublicservices + " Can you write the following information ?");
                    Console.WriteLine("This month's water meter readings");
                    double Administrativeagencyorpublicserviceswaterconsumptionthismonth = Convert.ToDouble(Console.ReadLine());
                    double Administrativeagencyorpublicserviceslastmonthwaterbill = Administrativeagencyorpublicserviceswaterconsumptionthismonth * 9.955;
                    Console.WriteLine("Your last month's water bill is " + Administrativeagencyorpublicserviceslastmonthwaterbill);
                    Console.WriteLine("Last month's water meter reading");
                    double Administrativeagencyorpublicserviceswaterconsumptionlastmonth = Convert.ToDouble(Console.ReadLine());
                    double Administrativeagencyorpublicservicesthismonthwaterbill = Administrativeagencyorpublicserviceswaterconsumptionlastmonth * 9.955;
                    Console.WriteLine("Your this month water bill is "+ Administrativeagencyorpublicservicesthismonthwaterbill);
                    Console.WriteLine("Thanks for your information");
                    break;
                    case 3:
                    Console.WriteLine("Below is the price list for Production units");
                    Console.WriteLine("11.615 VND/m3 and  fees is 10%");
                    Console.WriteLine("What is your name ?");
                    string NameofProductionunits = Console.ReadLine();
                    Console.WriteLine("Hello " + NameofProductionunits + " Can you write the following information ?");
                    Console.WriteLine("Last month's water meter reading");
                    double Productionunitswaterconsumptionlastmonth = Convert.ToDouble(Console.ReadLine());
                    double Productionunitslastmonthwaterbill = Productionunitswaterconsumptionlastmonth * 11.615;
                    Console.WriteLine("Your last month's water bill is " + Productionunitslastmonthwaterbill);
                    Console.WriteLine("This month's water meter readings");
                    double Productionunitsconsumptionwaterthismonth = Convert.ToDouble(Console.ReadLine());
                    double Productionunitsthismonthwaterbill = Productionunitsconsumptionwaterthismonth * 11.615;
                    Console.WriteLine("Your this month water bill is " + Productionunitsthismonthwaterbill);

                    Console.WriteLine("Thanks for your information");
                    break;
                    case 4:
                    Console.WriteLine("Below is the price list for Business");
                    Console.WriteLine("22.068 VND/m3 and fees is 10%");
                    Console.WriteLine("What is your name ?");
                    string NameofBusiness = Console.ReadLine();
                    Console.WriteLine("Hello " + NameofBusiness + " Can you write the following information ?");
                    Console.WriteLine("Last month's water meter reading");
                    double Businesswaterconsumptionlastmonth = Convert.ToDouble(Console.ReadLine());
                    double Businesslastmonthwaterbill = Businesswaterconsumptionlastmonth * 22.068;
                    Console.WriteLine("Your last month's water bill is " + Businesslastmonthwaterbill);
                    Console.WriteLine("This month's water meter readings");
                    double Businessconsumptionwaterthismonth = Convert.ToDouble(Console.ReadLine());
                    double Businessthismonthwaterbill = Businessconsumptionwaterthismonth * 22.068;
                    Console.WriteLine("Your this month water bill is " + Businessthismonthwaterbill);
                    Console.WriteLine("Thanks for your information");
                    break;
            }


            
            
        }
    }
}
