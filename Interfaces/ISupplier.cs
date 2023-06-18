using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryBeginners.Models;
using CodesByAniz.Tools;

namespace InventoryBeginners.Interfaces
{
    public interface ISupplier
    {
        PaginatedList<Supplier> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5); //read all
        Supplier GetItem(int id); // read particular item

        Supplier Create(Supplier supplier);
        Supplier Edit(Supplier supplier);
        Supplier Delete(Supplier supplier);
        public bool IsSupplierNameExists(string name);
        public bool IsSupplierNameExists(string name, int Id);

        public bool IsSupplierFNameExists(string fname);
        public bool IsSupplierFNameExists(string fname, int Id);

        public bool IsSupplierCodeExists(string code);
        public bool IsSupplierCodeExists(string code, int Id);

        public bool IsSupplierDepartmentExists(string department);
        public bool IsSupplierDepartmentExists(string department, int Id);

        public bool IsSupplierJobExists(string job);
        public bool IsSupplierJobExists(string job, int Id);

        public bool IsSupplierEmailExists(string email);
        public bool IsSupplierEmailExists(string email, int Id);
    }
}
