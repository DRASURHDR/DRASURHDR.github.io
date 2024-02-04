using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ASM
{
    internal class WaterBilling
    {
        static void Main(string[] args)
        {
            Intro();              //INTRODUCE
            TypeofCustomer();     //SELECT THE CUSTOM TYPE
            Select();             //SELECT
            Greeting();           //CUSTOMER GREETING
            QUESTION1();          //ANSWER THE QUESTION
            double lastMonthConsumption = Convert.ToDouble(Console.ReadLine());            //ANSWER THE QUESTION
            QUESTION2();          //ANSWER THE QUESTION
            double thisMonthConsumption = Convert.ToDouble(Console.ReadLine());
            //START----STORE WATER BILL VALUE----//
                  //START----HOUSEHOLD----
            double Baserate = 5.937;
            double Rate1 = 7.052;
            double Rate2 = 8.699;
            double Rate3 = 15.929;
            double Rate10 = 59.37;
            double Rate20 = 129.89;
            double Rate30 = 216.88;
                  //END----HOUSEHOLD----

                  //START----ADMINSER----
            double AdminSerRate = 9.955;
                   //END----ADMINSER----

                   //START----PRODUC----
            double ProducRate = 11.615;
                   //END----PRODUC----

                  //START----BUSINESS----
            double BusinessRate = 22.068;
                  //END----BUSINESS----
            //END----STORE WATER BILL VALUE----//
            //TOTAL CACULATE WATER BILL
            double HouseholdlastMonthTotalBill = CalculateHouseholdBill(lastMonthConsumption, Baserate, Rate1, Rate2, Rate3, Rate10, Rate20, Rate30);
            double HouseholdthisMonthTotalBill = CalculateHouseholdBill(thisMonthConsumption, Baserate, Rate1, Rate2, Rate3, Rate10, Rate20, Rate30);
            double AdminSerlastMonthTotalBill = CaculateAdminSerBill(lastMonthConsumption, AdminSerRate);
            double AdminSerthisMonthTotalBill = CaculateAdminSerBill(thisMonthConsumption, AdminSerRate);
            double ProduclastMonthTotalBill = CalculateProducBill(lastMonthConsumption, ProducRate);
            double ProducthisMonthTotalBill = CalculateProducBill(thisMonthConsumption, ProducRate);
            double BusinesslastMonthTotalBill = CalculateBusinessBill(lastMonthConsumption, BusinessRate);
            double BusinessthisMonthTotalBill = CalculateBusinessBill(thisMonthConsumption, BusinessRate);
            //DISPLAY VALUE
            DisplayWaterBill("Household's Last Month", HouseholdlastMonthTotalBill);
            DisplayWaterBill("Household's This Month", HouseholdthisMonthTotalBill);
            DisplayWaterBill("AdminSer's Last Month", AdminSerlastMonthTotalBill);
            DisplayWaterBill("AdminSer's This Month", AdminSerthisMonthTotalBill);
            DisplayWaterBill("Produc's Last Month", ProduclastMonthTotalBill);
            DisplayWaterBill("Produc's This Month", ProducthisMonthTotalBill);
            DisplayWaterBill("Business's Last Month", BusinesslastMonthTotalBill);
            DisplayWaterBill("Business's This Month", BusinessthisMonthTotalBill);
        }



        //START----INTRODUCE----//
        static void Intro()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\tWelcome to water bill caculation!!!");
        }
        //END----INTRODUCE----//



        //START----SELECT THE CUSTOM TYPE----//
        static void TypeofCustomer()
        {
            Console.WriteLine("Select customer type \n1: Household \n2:Administrative agency or public services \n3:Production units \n4:Business ");
            Console.WriteLine("Enter your section with a number from 1-4");
        }
        //END----SELECT THE CUSTOM TYPE----//




        //START----PRICE LIST FOR CUSTOMERS----//
        static void Household()
        {
            Console.WriteLine("Below is the price list for Household");
            Console.WriteLine("To 10 m3/people/month is 5.973 VND/m3 and fees is 10%");
            Console.WriteLine("From 10-20 m3/people/month is 7.052 VND/m3 and fees is 10%");
            Console.WriteLine("From 20-30 m3/people/month is 8.699 VND/m3 and fees is 10%");
            Console.WriteLine("Over 30 m3/people/month is 15.929 VND/m3 and fees is 10%");
        }
        static void AdminSer()
        {
            Console.WriteLine("Below is the price list for Administrative agency or public services");
            Console.WriteLine("9.955 VND/m3 and fees is 10%");
        }
        static void Produc()
        {
            Console.WriteLine("Below is the price list for Production units");
            Console.WriteLine("11.615 VND/m3 and  fees is 10%");
        }
        static void Business()
        {
            Console.WriteLine("Below is the price list for Business");
            Console.WriteLine("22.068 VND/m3 and fees is 10%");
        }
        //END----PRICE LIST FOR CUSTOMERS----//



        //START----CUSTOMER GREETING----//
        static void Greeting()
        {
            Console.WriteLine("What is your name ?");
            string NameofCustomer = Console.ReadLine();
            Console.WriteLine("Hello " + NameofCustomer + " Can you write the following information ?");
        }
        //END----CUSTOMER GREETING----//



        //START----QUESTION----//
        static void QUESTION1()
        {
            Console.WriteLine("Last month's water meter readings ?");
        }
        static void QUESTION2()
        {
            Console.WriteLine("This month's water meter readings ?");
        }
        //END----QUESTION----//



        //START----DISPLAY VALUE----//
        static void DisplayWaterBill(string month, double billvalue) 
            {
            Console.WriteLine($"Water bill for {month} month: {billvalue}");
        }
        //END----DISPLAY VALUE----//




        //START----WATER BILL CALCULATER----//
              //START----HOUSEHOLD----
        static double CalculateHouseholdBill(double Consumption, double Baserate, double Rate1, double Rate2, double Rate3, double Rate10, double Rate20, double Rate30, double fixbug = 0.0)
        {
            double Bill = 0.0;
            if (Consumption <= 10)
            {
                //Rate 1
                Bill = Baserate * Consumption;
            }
            else if (Consumption <= 20)
            {
                //Rate 2
                Bill = Rate1 * Consumption + Rate10;
            }
            else if (Consumption <= 30)
            {
                //Rate 3
                Bill = Rate2 * Consumption + Rate20;
            }
            else
            {
                //Rate 4
                Bill = Rate3 * Consumption + Rate30;
            }
            
            return Bill;
        }
             //END----HOUSEHOLD----

        //START----ADMINSER----
        static double CaculateAdminSerBill(double Consumption, double AdminSerRate)
        {
            double Bill = 0.0;
            Bill = Consumption * AdminSerRate;
            return Bill;
        }
        //END----ADMINSER----

           //START----PRODUC----
        static double CalculateProducBill(double Consumption, double ProducRate)
        {
            double Bill = 0.0;
            Bill = Consumption * ProducRate;
            return Bill;
        }
           //END----PRODUC----

                 //START----BUSINESS----
        static double CalculateBusinessBill(double Consumption, double BusinessRate) { 
            double Bill = 0.0;
            Bill = Consumption * BusinessRate;
            return Bill; 
        }
                 //END----BUSINESS----

        //END----WATER BILL CALCULATER----//



        //START----SELECT----//
        static void Select() {
            int UserChoice = Convert.ToInt32(Console.ReadLine());
            switch (UserChoice).
            {
                    case 1:
                    Household();
                    CalculateHouseholdBill();
                    break;
                    case 2:
                    AdminSer();
                    CaculateAdminSerBill();
                    break;
                    case 3:
                    Produc();
                    CalculateProducBill();
                    break;
                    case 4:
                    Business();
                    CalculateBusinessBill();
                    break;

            }
            //END----SELECT----//

        }
    }
}














