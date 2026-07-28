using System.Data.OleDb;
class Banco
{
    public static void Main()
    {
        string strConexao = "Provider=SQLOLEDB;Server=Servidor;" +
         "Database=NorthWind;User id=sa;pwd=Senha";

        OleDbConnection conn = new OleDbConnection(strConexao);

        conn.Open();
    }
}
