// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
using System;
private string connectionString="User ID=sa;passward=examlyMssql@123;server=localhost;Database=Sanchitaa;trusted_connection=false;Persist Security Info=false;Encrypt=False";
string cmdtext="select *from Product";
try{
    SqlConnection con=new SqlConnection(connectionString);
    con.Open();
    Console.WriteLine("Connection Opened Successfully");
    sqlCommand command=new sqlCommand(cmdtext,con);
    SqlDataRepeater reader=command.ExecuteReader();
    while(reader.Read())
    {
     Console.WriteLine($"{reader["id"]} --- {reader["name]} --- {reader["price"]} --- {reader["stock"]}");
    }
    con.Close();
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);

    }
}