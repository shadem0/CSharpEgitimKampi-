using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kategori ekleme işlemi
            //Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            //Console.WriteLine();

            //Console.WriteLine("------------------------");
            
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source = CANAS_EVRAD\\SQLEXPRESS; initial catalog = EgitimKampiDb; integrated security = true;");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi.");
            #endregion

            #region Ürün ekleme işlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = CANAS_EVRAD\\SQLEXPRESS; initial catalog = EgitimKampiDb; integrated security = true;");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice,ProductStatus) values (@p1, @p2, @p3)", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);
            //command.Parameters.AddWithValue("@p3", true);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("Ürün başarıyla eklendi.");

            #endregion

            #region Ürün listeleme işlemi

            //SqlConnection connection = new SqlConnection("Data Source = CANAS_EVRAD\\SQLEXPRESS; initial catalog = EgitimKampiDb; integrated security = true;");

            //connection.Open();
            //SqlCommand command = new SqlCommand("select * from TblProduct", connection);
            ////SqlDataReader dr = command.ExecuteReader();
            ////while (dr.Read())
            ////{
            ////    Console.WriteLine($"{dr[1]} - {dr[2]} TL");
            ////}
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();

            #endregion

            #region Ürün silme işlemi
            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source = CANAS_EVRAD\\SQLEXPRESS; initial catalog = EgitimKampiDb; integrated security = true;");

            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductID = @p1", connection);
            //command.Parameters.AddWithValue("@p1", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi başarılı");
            #endregion

            #region Ürün güncelleme işlemi
            //Console.Write("Güncellenecek verinin Id'si: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source = CANAS_EVRAD\\SQLEXPRESS; initial catalog = EgitimKampiDb; integrated security = true;");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName = @p1, ProductPrice = @p2 where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2", productPrice);

            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Başarıyla Güncellendi");
            #endregion

            Console.Read();

        }
    }
}
