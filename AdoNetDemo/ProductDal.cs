using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\ProjectModels;Initial Catalog=ETrade;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public List<Product> GetAlls()
        {
            ConnectionControl();

            SqlCommand cmd = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = cmd.ExecuteReader();

            List<Product> products = new List<Product>();

            while (reader.Read())
            {
                products.Add(new Product(
                    Convert.ToInt32(reader["Id"]),
                    Convert.ToString(reader["Name"]),
                    Convert.ToString(reader["UnitPrice"]),
                    Convert.ToInt32(reader["StockAmount"])
                    ));
            }

            reader.Close();
            _connection.Close();
            return products;
        }


        public DataTable GetAll()
        {
            ConnectionControl();

            SqlCommand cmd = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();

            SqlCommand cmd = new SqlCommand("insert into Products values (@name, @unitPrice, @stockAmount)", _connection);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            cmd.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            cmd.ExecuteNonQuery();
            _connection.Close();
        }


        public void Update (Product product)
        {
            ConnectionControl();

            SqlCommand cmd = new SqlCommand("Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _connection);
            cmd.Parameters.AddWithValue("@id", product.Id);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            cmd.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            cmd.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete (int  id)
        {
            ConnectionControl();

            SqlCommand cmd = new SqlCommand("Delete From Products where Id=@id", _connection);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
