using System.Data.SQLClient;

class Banco
{
    public static void Main()
    {
        string strConexao = "DataSource=Servidor;User id=sa;pwd=Senha;" + "Initial Catalog=Northwind";

        SqlConnection conn = new SqlConnection(strConexao);

        conn.Open();
    }
}