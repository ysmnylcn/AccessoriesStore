using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessoriesStore
{
    public class Repository
    {
        DataTable dt = new DataTable();
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection connect = new SqlConnection(Properties.Resources.sqlConnString);
        public DataTable GetOrders()
        {
            connect.Open();
            da = new SqlDataAdapter("SELECT [OrderID], o.[CustomerID], [CustomerName]+' '+[CustomerSurname] as Customer ,[OrderDate]"+
         " FROM[AccessoriesStoreDB].[dbo].[Orders] o inner join Customers on o.CustomerID = Customers.CustomerID", connect);
            ds = new DataSet();
            da.Fill(ds, "Orders");
            dt = ds.Tables["Orders"];
            connect.Close();
            return dt;
        }
        public DataTable GetProductsByQuery(string query)
        {
            connect.Open();
            da = new SqlDataAdapter(query, connect);
            ds = new DataSet();
            da.Fill(ds, "Products");
            dt = ds.Tables["Products"];
            connect.Close();
            return dt;
        }
        public DataTable GetProduts()
        {
         
            connect.Open();
            da = new SqlDataAdapter("Select ProductID, ProductName,BrandName,c.CategoryName,UnitInStock,UnitPrice,s.CompanyName"+
                " From Products p INNER JOIN Categories c on p.CategoryID = c.CategoryID inner join Suppliers s"+
                " on p.SupplierID = s.SupplierID inner join Brands on brands.BrandID = p.BrandID ", connect);
            ds = new DataSet();
            da.Fill(ds, "Products");
            dt = ds.Tables["Products"];
            connect.Close();
            return dt;
        }
        public DataTable GetCategories()
        {

            connect.Open();
            da = new SqlDataAdapter("Select * from Categories", connect);
            da.Fill(ds, "Categories");
            dt = ds.Tables["Categories"];
            connect.Close();
            return dt;
        }

        public DataTable GetBrands()
        {

            connect.Open();
            da = new SqlDataAdapter("Select * from Brands", connect);
            da.Fill(ds, "Brands");
            dt = ds.Tables["Brands"];
            connect.Close();
            return dt;
        }
        public DataTable GetSuppliers()
        {

            connect.Open();
            da = new SqlDataAdapter("Select [SupplierID],[CompanyName] from Suppliers", connect);
            ds = new DataSet();
            da.Fill(ds, "Suppliers");
            dt = ds.Tables["Suppliers"];
            connect.Close();
            return dt;
        }
        public DataTable GetProdutsByCategory(int categoryId)
        {

            connect.Open();
            da = new SqlDataAdapter("Select ProductID, ProductName,UnitInStock,UnitPrice,s.CompanyName,c.CategoryName From Products p INNER JOIN Categories c on p.CategoryID = c.CategoryID inner join Suppliers s on p.SupplierID = s.SupplierID where p.CategoryID ="+categoryId, connect);
            ds = new DataSet();
            da.Fill(ds, "Products");
            dt = ds.Tables["Products"];
            connect.Close();
            return dt;
        }

        public DataTable GetProdutsByProductID(int productId)
        {

            connect.Open();
            da = new SqlDataAdapter("Select * From Products where ProductID =" + productId, connect);
            ds = new DataSet();
            da.Fill(ds, "Products");
            dt = ds.Tables["Products"];
            connect.Close();
            return dt;
        }

        public DataTable AddGender()
        {

            connect.Open();
            da = new SqlDataAdapter("Select Gender From Products ", connect);
            ds = new DataSet();
            da.Fill(ds, "Products");
            dt = ds.Tables["Products"];
            connect.Close();
            return dt;
        }

        public DataTable GetProdutsBySuppliers(int supplierID)
        {

            connect.Open();
            da = new SqlDataAdapter("Select ProductID, ProductName,UnitInStock,UnitPrice,s.CompanyName,c.CategoryName From Products p INNER JOIN Categories c on p.CategoryID = c.CategoryID inner join Suppliers s on p.SupplierID = s.SupplierID where s.supplierID =" + supplierID, connect);
            ds = new DataSet();
            da.Fill(ds, "Products");
            dt = ds.Tables["Products"];
            connect.Close();
            return dt;
        }

        public DataTable GetCustomers()
        {
            connect.Open();
            da = new SqlDataAdapter("Select * From Customers", connect);
            ds = new DataSet();
            da.Fill(ds, "Customers");
            dt = ds.Tables["Customers"];
            connect.Close();
            return dt;
        }
        public DataTable GetCustomersByQuery(string query)
        {
            connect.Open();
            da = new SqlDataAdapter(query, connect);
            ds = new DataSet();
            da.Fill(ds, "Customers");
            dt = ds.Tables["Customers"];
            connect.Close();
            return dt;
        }
        public DataTable GetCustomersByCustomerID(int customerId)
        {

            connect.Open();
            da = new SqlDataAdapter("Select * From Customers Where CustomerID =" + customerId, connect);
            ds = new DataSet();
            da.Fill(ds, "Customers");
            dt = ds.Tables["Customers"];
            connect.Close();
            return dt;
        }
        public DataTable GetOrderDetails(int orderId)
        {
            connect.Open();
            da = new SqlDataAdapter("SELECT o.OrderID, od.ProductID, c.CustomerID, CustomerName + ' ' + CustomerSurname as Customer," +
            " ProductName, BrandName, Quantity, p.UnitPrice, (p.UnitPrice * Quantity) as Total, OrderDate from OrderDetails od inner join Orders o" +
            " on od.OrderID = o.OrderID inner join Customers c on c.CustomerID = o.CustomerID inner join Products p on p.ProductID = od.ProductID inner" +
            " join Brands b on b.BrandID = p.BrandID where o.OrderID=" + orderId + " ", connect);
            ds = new DataSet();
            da.Fill(ds, "OrderDetails");
            dt = ds.Tables["OrderDetails"];
            connect.Close();
            return dt;
        }
        public DataTable GetDataTable(string query)
        {
            connect.Open();
            DataTable dt=new DataTable();
            da = new SqlDataAdapter(query, connect);
            da.Fill(dt);
            
            connect.Close();
            return dt;
        }

    }
}
