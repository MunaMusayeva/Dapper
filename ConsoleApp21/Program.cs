using ConsoleApp21;
using Dapper;
using System.Data.SqlClient;

var connectionString = "Server=DESKTOP-JI95IOS;Database=Dapper2;Trusted_Connection=True;Initial Catalog=Dapper2;Connect Timeout=30;Encrypt=False;";

using var connection = new SqlConnection(connectionString);

var sqlCommand = "INSERT INTO Teachers(Id,Name,GroupId) VALUES('1','Jane',1)";
connection.ExecuteAsync(sqlCommand);

var sqlCommand1 = "UPDATE Teachers SET Name = 'Jack' WHERE Id = 1";
connection.Execute(sqlCommand1);

var sqlCommand2 = "DELETE Teachers WHERE Id = 1";
connection.Execute(sqlCommand2);