# Using C# with databases

## SQL Server

Connection to SQL Server using Windows Authentication:


''''
string connectionString = "Server=.\\SQLEXPRESS;Database=NBA;Trusted_Connection=Yes";
''''

creating a connection object

''''
SqlConnection conn = new SqlConnection(connectionString);
''''