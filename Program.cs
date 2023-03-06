
using Microsoft.Data.SqlClient;
using System.Data;

string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True";

string sqlExpression = "SELECT * FROM Authors";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    Console.WriteLine(sqlExpression + "\n");
    connection.Open();
    SqlCommand command = new SqlCommand(sqlExpression, connection);
    SqlDataReader reader = command.ExecuteReader();

    if (reader.HasRows) // если есть данные
    {
        // выводим названия столбцов
        Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));

        while (reader.Read()) // построчно считываем данные
        {
            object id = reader.GetValue(0);
            object name = reader.GetValue(1);
            object age = reader.GetValue(2);

            Console.WriteLine("{0} \t{1} \t{2}", id, name, age);
        }
    }

    reader.Close();
}

Console.Read();