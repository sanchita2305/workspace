

// //**CONNECTED ARCHITECTURE**//

// // See https://aka.ms/new-console-template for more information
// using System.Data.SqlClient;
// using System;
// AddRecord();
// Show();

// string connectionString="User ID=sa;password=examlyMssql@123;server=localhost;Database=Sanchitaa;trusted_connection=false;Persist Security Info=false;Encrypt=False";
// string cmdtext="select *from Product";
// void AddRecord()
//     {
//         string connectionString="User ID=sa;password=examlyMssql@123;server=localhost;Database=Sanchitaa;trusted_connection=false;Persist Security Info=false;Encrypt=False";
//         string cmdtext="insert into Product values(@id,@name,@price,@stock)";
//         Console.WriteLine("Enter Id");
//         int id=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter Product Name");
//         string name=Console.ReadLine();
//         Console.WriteLine("Enter Price");
//         int price=Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter Stock");
//         int stock=Convert.ToInt32(Console.ReadLine());
//         SqlConnection con=null;
//         SqlCommand command=null;

//         try{
//     con=new SqlConnection(connectionString);
//     command=new SqlCommand(cmdtext,con);
//     command.Parameters.AddWithValue("@id",id);
//     command.Parameters.AddWithValue("@name",name);
//     command.Parameters.AddWithValue("@price",price);
//     command.Parameters.AddWithValue("@stock",stock);
//     con.Open();
//     command.ExecuteNonQuery();
//     Console.WriteLine("Record Added");

// }
// catch(Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
//  finally{con.Close();}

// }
// Show();
// void Show(){
// string connectionString="User ID=sa;password=examlyMssql@123;server=localhost;Database=Sanchitaa;trusted_connection=false;Persist Security Info=false;Encrypt=False";
// string cmdtext="select *from Product";
// try{
//     SqlConnection con=new SqlConnection(connectionString);
//     con.Open();
//     Console.WriteLine("Connection Opened Successfully");
//     SqlCommand command=new SqlCommand(cmdtext,con);
//     SqlDataReader reader=command.ExecuteReader();
//     while(reader.Read())
//     {
//     Console.WriteLine($"{reader["id"]} --- {reader["name"]} --- {reader["price"]} --- {reader["stock"]}");
//     }
//     con.Close();
// }
//     catch(Exception ex){

//         Console.WriteLine(ex.Message);

//     }

// }




//**DISCONNECTED ARCHITECTURE**//

// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;
using System;
using System.Data;
ShowDisconnect();
AddDisconnect();
// AddRecord();
// Show();
void AddDisconnect()
{
    string connectionString="User ID=sa;password=examlyMssql@123;server=localhost;Database=Sanchitaa;trusted_connection=false;Persist Security Info=false;Encrypt=False";
    Console.WriteLine("Enter Id");
        int id=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Product Name");
        string name=Console.ReadLine();
        Console.WriteLine("Enter Price");
        int price=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Stock");
        int stock=Convert.ToInt32(Console.ReadLine());

    SqlConnection connection=null;
    SqlDataAdapter adapter=null;
    DataSet ds=null;
    DataTable prodTable=null;
    try{
    ds=new DataSet();
    connection=new SqlConnection(connectionString);
    adapter=new SqlDataAdapter("select * from Product",connection);
    adapter.Fill(ds,"Prods");
    prodTable=ds.Tables["Prods"];
    DataRow prodrow=prodTable.NewRow();
    prodrow["id"]=id;
    prodrow["name"]=name;
    prodrow["price"]=price;
    prodrow["stock"]=stock;
    prodTable.Rows.Add(prodrow);
    SqlCommandBuilder scb=new SqlCommandBuilder(adapter);
    Console.WriteLine(scb.GetInsertCommand().CommandText);

    adapter.Update(prodTable);
    Console.WriteLine("Row Added");

    }
    catch(Exception ex)
    {
                Console.WriteLine(ex.Message);


    }

}
void ShowDisconnect()
{
    string connectionString="User ID=sa;password=examlyMssql@123;server=localhost;Database=Sanchitaa;trusted_connection=false;Persist Security Info=false;Encrypt=False";
    string cmdtext="insert into Product values(@id,@name,@price,@stock)";
    SqlConnection connection=null;
    SqlDataAdapter adapter=null;
    DataSet ds=null;
    DataTable prodTable=null;
   try{
    ds=new DataSet();
    connection=new SqlConnection(connectionString);
    adapter=new SqlDataAdapter("select * from Product",connection);
    adapter.Fill(ds,"Prods");
    prodTable=ds.Tables["Prods"];
    Console.WriteLine($"Rows= {prodTable.Rows.Count}");
    Console.WriteLine($"Columns ={prodTable.Columns.Count}");
    foreach(DataRow row in prodTable.Rows)
    {
        Console.WriteLine($"{row["id"]} --- {row["name"]} ---{row ["price"]} --- {row["stock"]}");
    }


   }
   catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}


}

string connectionString="User ID=sa;password=examlyMssql@123;server=localhost;Database=Sanchitaa;trusted_connection=false;Persist Security Info=false;Encrypt=False";
string cmdtext="select *from Product";
void AddRecord()
    {
        string connectionString="User ID=sa;password=examlyMssql@123;server=localhost;Database=Sanchitaa;trusted_connection=false;Persist Security Info=false;Encrypt=False";
        string cmdtext="insert into Product values(@id,@name,@price,@stock)";
        Console.WriteLine("Enter Id");
        int id=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Product Name");
        string name=Console.ReadLine();
        Console.WriteLine("Enter Price");
        int price=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Stock");
        int stock=Convert.ToInt32(Console.ReadLine());
        SqlConnection con=null;
        SqlCommand command=null;

        try{
    con=new SqlConnection(connectionString);
    command=new SqlCommand(cmdtext,con);
    command.Parameters.AddWithValue("@id",id);
    command.Parameters.AddWithValue("@name",name);
    command.Parameters.AddWithValue("@price",price);
    command.Parameters.AddWithValue("@stock",stock);
    con.Open();
    command.ExecuteNonQuery();
    Console.WriteLine("Record Added");

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
 finally{con.Close();}

}
Show();
void Show(){
string connectionString="User ID=sa;password=examlyMssql@123;server=localhost;Database=Sanchitaa;trusted_connection=false;Persist Security Info=false;Encrypt=False";
string cmdtext="select *from Product";
try{
    SqlConnection con=new SqlConnection(connectionString);
    con.Open();
    Console.WriteLine("Connection Opened Successfully");
    SqlCommand command=new SqlCommand(cmdtext,con);
    SqlDataReader reader=command.ExecuteReader();
    while(reader.Read())
    {
    Console.WriteLine($"{reader["Id"]} --- {reader["name"]} --- {reader["price"]} --- {reader["stock"]}");
    }
    con.Close();
}
    catch(Exception ex){

        Console.WriteLine(ex.Message);

    }

}
