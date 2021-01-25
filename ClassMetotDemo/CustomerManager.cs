using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
        public void List(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("MÜŞTERİNİN ADI :" +customer.customerName);
                Console.WriteLine("MÜŞTERİNİN SOYADI :" + customer.surname);
                Console.WriteLine("MÜŞTERİNİN ID'Sİ :" + customer.Id);
            }
        }


    }
}
