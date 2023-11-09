using System.Data.SqlClient;
using System.Text.Json;

namespace CopilotCsharp.Algorithm;
{
public class Fault
{

    // string userInput = "Dave'; DROP TABLE Users;--"; 
    public static void SqlInjection(string connectionString, string userInput)
    {

        string query = "SELECT * FROM Users WHERE Name = '" + userInput + "'";

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            // Read data
            while (reader.Read())
            {
                string name = reader.GetString(0);
                string password = reader.GetString(1);
                Console.WriteLine("Name: {0}\tPassword: {1}", name, password);

            }
        }
    }

    public static void PathTraversal(string fileName)
    {
        string path = "uploads/" + fileName;
        File.ReadAllText(path);
    }

    public static void BufferOverflow(byte[] input)
    {
        byte[] buffer = new byte[32];
        Buffer.BlockCopy(input, 0, buffer, 0, input.Length);        
    }

    public static void ImproperErrorHandling()
    {
        try {
        // risky operation  
        }
        catch (Exception ex) {
        throw new ApplicationException("Operation failed");
        }        
    }
}