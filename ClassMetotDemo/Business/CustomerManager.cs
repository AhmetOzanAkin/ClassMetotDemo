using ClassMetotDemo.DataAccess.Abstracts;
using ClassMetotDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo.Business;

public class CustomerManager
{
    ICustomerDal _customerDal;
    // DATABASE İŞLEMLERİ MANAGER CLASSINDA YAPILACAK. SİLME GÜNCELLEME EKLEME LİSTELEME VS
    public CustomerManager(ICustomerDal customerDal)
    {
        this._customerDal = customerDal;
    }
    public List<Customer> GetAll()
    {

        return _customerDal.GetAll();
    }

    public void Delete(int id)
    {
        _customerDal.Delete(id);
    }
    public void Add(Customer customer)
    {
        _customerDal.Add(customer);

    }
}
