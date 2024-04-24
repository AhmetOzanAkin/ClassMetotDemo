using ClassMetotDemo.Business;
using ClassMetotDemo.DataAccess.Concretes;
using ClassMetotDemo.Entities;
CustomerManager customerManager = new(new CustomerDal());

List<Customer> customerList = customerManager.GetAll();

foreach (var customer in customerList.ToList())
{
    Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname + " " + customer.NationalIdentity + " " + customer.PhoneNumber);
    customerManager.Add(customer);
}


customerManager.Delete(1);

customerList = customerManager.GetAll();

foreach (var customer in customerList)
{
    Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname + " " + customer.NationalIdentity + " " + customer.PhoneNumber);
}

