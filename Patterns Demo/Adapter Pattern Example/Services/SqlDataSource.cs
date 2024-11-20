using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Patterns_Demo.Adapter_Pattern_Example.Interfaces;
using Patterns_Demo.Adapter_Pattern_Example.Models;

namespace Patterns_Demo.Adapter_Pattern_Example.Services;

public class SqlDataSource : IDataSource
{
    private const string ConnectionString = "Data Source=.;Initial Catalog=RandomUserDb;Integrated Security=SSPI;TrustServerCertificate=True";

    public Root? GetData()
    {
        string query = $"SELECT * FROM RandomUsers";
        using var connection = new SqlConnection(ConnectionString);
        connection.Open();
        using var adapter = new SqlDataAdapter(query, connection);
        var myDataSet = new DataSet();
        adapter.Fill(myDataSet);
        // foreach (DataTable table in myDataSet.Tables)
        // {
        //
        // }
        var result = JsonConvert.DeserializeObject<Root>(DataTableToJson(myDataSet.Tables[0]));
        return result;
    }
    
    private static string DataTableToJson(DataTable dataTable)
    {
        return JsonConvert.SerializeObject(dataTable);
    }
}