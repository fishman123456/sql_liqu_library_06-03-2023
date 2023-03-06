
using Azure;
using Microsoft.Data.SqlClient;
using sql_liqu_library_06_03_2023;
using System.Data;
 // нужно созать список обьектов и добавить туда поля в обьекты!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
// строка соединения
string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True";
// запрос для sql
string sqlExpression = "SELECT Title, PRICE, PAGES FROM Books ";

// открываем соединение
using (SqlConnection connection = new SqlConnection(connectionString))
{

    //Console.WriteLine(sqlExpression + "\n");
    connection.Open();
    SqlCommand command = new SqlCommand(sqlExpression, connection);
    SqlDataReader reader = command.ExecuteReader();
    book one =new book();
    List<book> two = new List<book>();
    if (reader.HasRows) // если есть данные
    {
        // выводим названия столбцов
       // Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0),  reader.GetName(1), reader.GetName(2));
        int line = 0;
        while (reader.Read()) // построчно считываем данные
        {
            //if (line == 0)
            //{
            //    line++;
            //}
            //two.Add(new book());
            one.Title = reader.GetString(0);
            one.Price = reader.GetInt32(1);
            one.Pages = reader.GetInt32(2);
            Console.WriteLine($"Имя: {one.Title}  цена: {one.Price}  страниц: {one.Pages}");
        }
    }
  //  Console.WriteLine($"Имя: {one.Title}  цена: {one.Price}  страниц: {one.Pages}");
    reader.Close();
}

Console.Read();