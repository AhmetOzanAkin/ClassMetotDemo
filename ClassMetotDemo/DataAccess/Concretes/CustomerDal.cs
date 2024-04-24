using ClassMetotDemo.DataAccess.Abstracts;
using ClassMetotDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo.DataAccess.Concretes;

public class CustomerDal:ICustomerDal
{
    List<Customer> customers;

    public CustomerDal() 
    {
        Customer customer1 = new Customer();
        customer1.Id = 1;
        customer1.Name = "Ozan";
        customer1.Surname = "Akin";
        customer1.PhoneNumber = "1234567890";
        customer1.NationalIdentity = "1234567890";

        Customer customer2 = new Customer();
        customer2.Id = 2;
        customer2.Name = "Ahmet";
        customer2.Surname = "Akin";
        customer2.PhoneNumber = "1234567891";
        customer2.NationalIdentity = "1234567891";

        customers = new List<Customer> { customer1, customer2 };

    }

    public void Add(Customer customer)
    {
        customers.Add(customer);
    }

    public List<Customer> GetAll()
    {
        return customers;

    }
    
    public void Delete(int id)
    {
        var customerToRemove = customers.Find(c => c.Id == id);

        if (customerToRemove != null)
        {
            customers.Remove(customerToRemove);
            Console.WriteLine("Silindi");
        }else { Console.WriteLine("Silinemedi id bulunmadı"); }
    }
    
}
