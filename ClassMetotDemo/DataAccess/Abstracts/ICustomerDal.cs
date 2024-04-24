using ClassMetotDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo.DataAccess.Abstracts;

public interface ICustomerDal
{
    List<Customer> GetAll();
    void Add(Customer customer);
    void Delete(int id);

}
