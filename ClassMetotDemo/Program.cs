using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.customerName = "Ayşe";
            customer.surname = "Yayla";
            customer.Id = 56985;

            Customer customer1 = new Customer();
            customer1.customerName = "Fatma";
            customer1.surname = "Uygur";
            customer1.Id = 87465;

            Customer[] customers = new Customer[2];
            customers[0] = customer;
            customers[1] = customer1;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);
            customerManager.Update(customer1);
            customerManager.List(customers);
            customerManager.Delete(customer);




        }
    }
}
