using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ITableRepository
    {
        public List<TablesRe> getListTable();
        public void tableDelete(TablesRe table);
        public TablesRe getTableByIndex(int index);
        public TablesRe getTableById(int id);
        public void tableNew(TablesRe table);
        public void tableUpdate(TablesRe tables);
        public TablesRe checkAlreadyId(int id);
    }
}
