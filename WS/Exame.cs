using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WS
{
    public class Exame
    {
        public int Id { get; set; }
        public string Ocupacao { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Funcao { get; set; }
        public string Empresa { get; set; }
        public string Rg { get; set; }
        public string Data { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\Desktop\\Desk\\WS\\WS\\DBMedico.mdf;Integrated Security=True");

        public void InserirExame(string ocupacao,string nome,string idade,string funcao,string empresa, string rg, string data)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            
            string sql = "INSERT INTO ExameClinico(Ocupacao,Nome,Idade,Funcao,Empresa,Rg,Data) VALUES('" + ocupacao + "','" + nome + "','" + idade + "','" + funcao + "','" + empresa + "','"+rg+"','" + data + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void InserirClinica(string doencas, string alergias, string cirurgias, string trans, string medicamentos, string outro)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            string sql = "INSERT INTO HistoricaClinica(DoencasInfecciosas,Alergias,Cirurgias,TransfusaoSangue,MedicamentosContinuo,Outro) VALUES('" + doencas + "','" + alergias + "','" + cirurgias + "','" + trans + "','" + medicamentos + "','" + outro + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void InserirHistorico(string funcoes, string acidentes)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            string sql = "INSERT INTO HistoricoOcupacional(FuncoesAnteriores,AcidentesTrabalho) VALUES('" + funcoes + "','" + acidentes + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
