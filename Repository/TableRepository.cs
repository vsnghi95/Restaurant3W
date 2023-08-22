using BussinessObject;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TableRepository : ITableRepository
    {
        public TablesRe checkAlreadyId(int id) => TableDAO.Instance.checkAlreadyId(id);
        public List<TablesRe> getListTable() => TableDAO.Instance.getListTable();
        

        public TablesRe getTableById(int id)=> TableDAO.Instance.getTableById(id);
        

        public TablesRe getTableByIndex(int index)=> TableDAO.Instance.getTableByIndex(index);
        

        public void tableDelete(TablesRe table)=> TableDAO.Instance.tableDelete(table);
        

        public void tableNew(TablesRe table)=> TableDAO.Instance.tableNew(table);
        

        public void tableUpdate(TablesRe tables)=> TableDAO.Instance.tableUpdate(tables);
        
    }
}
