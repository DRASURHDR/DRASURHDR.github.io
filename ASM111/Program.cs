using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM11
{
    // Class containt about the customer information
    public class Customer
    {
        public string Name { get; set; }
        public double ThisMonthReading { get; set; }
        public double LastMonthReading { get; set; }
        public double WaterRate { get; set; }
        public Customer(string name, double thismonthreading, double lastmonthreading, double waterrate)
        {
            Name = name;
            ThisMonthReading = thismonthreading;
            LastMonthReading = lastmonthreading;
            WaterRate = waterrate;
        }
    }
    // Class chứa logic tính toán tiền nước
    public class WaterCaculator
    {
        public static double WaterCaculatorBill(Customer customer)
        {
            double Bill = 0.0;
            double consumption = customer.LastMonthReading - customer.ThisMonthReading;
            if (customer is HouseHold)
            {
                return ((HouseHold)customer).CaculatorHouseHoldWaterBill(consumption);
            }
            else
            {
                return consumption * customer.WaterRate + consumption * customer.WaterRate * 0.1;
            }


        }
    }
    // Class cho loại Household
    public class HouseHold : Customer
    {
        public HouseHold(string name, double lastmonthreading, double thismonthreading, double waterrate)
            : base(name, lastmonthreading, thismonthreading, waterrate)
        { }
        // Phương thức tính tiền nước theo bậc thang
        public double CaculatorHouseHoldWaterBill(double consumption)
        {
            double rate1 = 5.073;
            double rate2 = 7.052;
            double rate3 = 8.699;
            double rate4 = 15.929;
            if (consumption <= 10)

            {
                return consumption * rate1 + consumption * rate1 * 0.1;
            }
            else if (consumption <= 20)
            {
                return consumption * rate2 + consumption * rate2 * 0.1;
            }
            else if (consumption <= 30)
            {
                return consumption * rate3 + consumption * rate3 * 0.1;
            }
            else
            {
                return consumption * rate4 + consumption * rate4 * 0.1;
            }
        }
    }
    // Class chứa Main

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================= WATER BILLING PROGRAM =================\n");
            Console.Write("Enter your name: ");
            string name;
            name = Console.ReadLine();
            Console.WriteLine($"\nWelcome {name} to the water billing program!!\n");
            Console.WriteLine("=========================================================");
            Console.WriteLine("Select customer type \n1: Household \n2: Administrative agency or public services \n3: Production units \n4: Business ");
            Console.WriteLine("Enter your section with a number from 1-4");
            int enterTheCustomerType = Convert.ToInt32(Console.ReadLine());
            double lastMonthReading, thisMonthReading;
            Console.WriteLine("Enter your last month's water meter readings:");
            lastMonthReading = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your this month's water meter readings:");
            thisMonthReading = Convert.ToDouble(Console.ReadLine());
            double waterRate = 0.0;
            switch (enterTheCustomerType) 
            {
                case 1:
                    // Household
                    Console.WriteLine("Below is the price list for Household");
                    Console.WriteLine("To 10 m3/people/month is 5.973 VND/m3 and fees is 10%");
                    Console.WriteLine("From 10-20 m3/people/month is 7.052 VND/m3 and fees is 10%");
                    Console.WriteLine("From 20-30 m3/people/month is 8.699 VND/m3 and fees is 10%");
                    Console.WriteLine("Over 30 m3/people/month is 15.929 VND/m3 and fees is 10%");
                    waterRate = 0.0; // Since the rate is calculated based on consumption
                    break;
                case 2:
                    // Administrative agency or public services
                    Console.WriteLine("Below is the price list for Administrative agency or public services");
                    Console.WriteLine("9.955 VND/m3 and fees is 10%");
                    waterRate = 9.955;
                    break;
                case 3:
                    // Production units
                    Console.WriteLine("Below is the price list for Production units");
                    Console.WriteLine("11.615 VND/m3 and fees is 10%");
                    waterRate = 11.615;
                    break;
                case 4:
                    // Business
                    Console.WriteLine("Below is the price list for Business");
                    Console.WriteLine("22.068 VND/m3 and fees is 10%");
                    waterRate = 22.068;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Exiting program.");
                    return;
            }
            Customer customer;
            if (enterTheCustomerType == 1)
            {
                customer = new HouseHold(name, lastMonthReading, thisMonthReading, waterRate);
            }
            else
            {
                customer = new Customer(name, lastMonthReading, thisMonthReading, waterRate);
            }
            double totalBill = WaterCaculator.WaterCaculatorBill(customer);

            WaterCaculator.WaterCaculatorBill(customer);

            Console.WriteLine($"Water Bill for {customer.Name}: {totalBill}");
        }
    }
}
