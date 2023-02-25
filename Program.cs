using Microsoft.Data.SqlClient;
using static System.Console;

SqlConnection connection = null;
try
{
    string connectionString = 
        @"Data Source=(localdb)\MSSQLLocalDB;" +
        "Initial Catalog=Library01;" +
        "Integrated Security=True";
    connection = new SqlConnection(connectionString);
    connection.Open();

    string commandText = 
        "insert Authors values " +
        "('Paul', 'Deitel')," +
        "('John', 'Deitel')";
    SqlCommand command = 
        new SqlCommand(commandText, connection);
    command.ExecuteNonQuery();
    WriteLine("Success.");
}
catch(Exception ex)
{ 
    Console.WriteLine(ex.Message); 
}
finally
{
    if (connection is not null)
    {
        connection.Close();
    }
    ReadKey();
}

