using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.manager
{
    class ProductEntity
    {
        DBManager manager = new DBManager();

        public ProductEntity()
        {

        }

        public void Connect(string path)
        {
            try
            {
                manager.ConnectDataBase(path);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void CreateTable()
        {
            try
            {
                manager.ExecuteNonQuery("create table product(id integer primary key autoincrement," +
                                                                "name text not null," +
                                                                "category text not null," +
                                                                "size integer not null," +
                                                                "color text not null," +
                                                                "photo blob not null," +
                                                                "price decimal not null" +
                                                                ");");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void InsertValues(string name, string category, int size, string color, byte[] photo, decimal price)
        {
            try
            {
                manager.ExecuteNonQuery("insert into product(name, category, size, color, photo, price) " +
                                        "values ('" + name + "','" + category + "'," + size + ",'" + color + "','" + photo.ToArray() + "'," + price + ");");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable GetAllData()
        {
            try
            {
                return manager.ExecuteReader("select * from product;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void CleanTable()
        {
            try
            {
                manager.ExecuteNonQuery("delete from product;");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
