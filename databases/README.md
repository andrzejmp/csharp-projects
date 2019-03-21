# Using C# with databases

## SQL Server

Connection to SQL Server using Windows Authentication:

string connectionString = "Server=.\\SQLEXPRESS;Database=NBA;Trusted_Connection=Yes";
SqlConnection conn = new SqlConnection(connectionString);
