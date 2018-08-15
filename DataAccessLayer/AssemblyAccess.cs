using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OnTheSpot.Models;
using DataAccessLayer.AssemblyDB;
namespace DataAccessLayer
{
    
    public class AssemblyAccess
    {
        Assembly assemblyEnties;
        
        public AssemblyAccess()
        {
            assemblyEnties = new Assembly();
        }

        public AutoSortInfo GetCustomerInfoFromAssembly(string itemID)
        {
            AutoSortInfo AssemblyStuff = (from auto in assemblyEnties.AutoSorts
                        where auto.ArticleCode == itemID
                        join inv in assemblyEnties.Invoices on auto.InvoiceID equals inv.InvoiceID
                             select new AutoSortInfo() { CustomerID = auto.CustomerID, InvoiceNumber = inv.InvoiceID, dept = inv.Department, Duedate = auto.DueDate , rfid = auto.RFID, storeid = auto.StoreID}).SingleOrDefault();


            return AssemblyStuff;
        }

        public bool GetInfoFromAssembly(string itemID)
        {
            int id = Int32.Parse(itemID);
            Invoice item = assemblyEnties.Invoices.Where(i => i.OrderID == id).SingleOrDefault();
            if (item == null)
                return false;
            else
                return true;
        }
    }
}

