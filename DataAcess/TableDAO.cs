using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class TableDAO
    {  //Using Singleton Pattern
        private static TableDAO instance = null;
        private static readonly object instanceLock = new object();
        public static TableDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new TableDAO();
                    }
                    return instance;
                }
            }
        }
        public List<TablesRe> listTable;
        public List<TablesRe> getListTable()
        {    
            try
            {
                using var db = new restaurant2Context();
                listTable = db.TablesRes.ToList();
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listTable;
        }
        public void tableDelete(TablesRe table)
        {
            try
            {
                using var db = new restaurant2Context();
                db.TablesRes.Remove(table);
                db.SaveChanges();
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public TablesRe getTableByIndex(int index)
        {
            
            try
            {
                using var db = new restaurant2Context();
                listTable = db.TablesRes.ToList();
                return listTable[index];
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public TablesRe getTableById(int id)
        {
            try
            {
                using var db = new restaurant2Context();
                listTable = db.TablesRes.ToList();
                return listTable[id];
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void tableNew(TablesRe table)
        {
            try
            {
                using var db = new restaurant2Context();
                var tableCheck = db.TablesRes.FirstOrDefault(x => x.Tid == table.Tid);
                if(tableCheck == null)
                {
                    db.TablesRes.Add(table);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Table Id is already");
                }
               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void tableUpdate(TablesRe tables)
        {
            try
            {
                using var db = new restaurant2Context();
                db.Entry<TablesRe>(tables).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public TablesRe checkAlreadyId(int id)
        {
            TablesRe table;
            try
            {
                using var db = new restaurant2Context();
                 table = db.TablesRes.FirstOrDefault(p => p.Tid == id);
            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return table;
        }


    }
}
