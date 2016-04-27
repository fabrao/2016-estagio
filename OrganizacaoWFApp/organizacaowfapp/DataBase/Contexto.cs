using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OrganizacaoWFApp.DataBase {
    public class Contexto {
        private SqlConnection conexao;
        private SqlParameterCollection sqpParameterCollection = new SqlCommand().Parameters;
       

        private SqlConnection CriarConexao() {
          
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString);
            return conexao;
        }
        private SqlCommand CriarComando(CommandType cmdType, string nomeProcedure) {
            conexao = CriarConexao();
            conexao.Open();
            SqlCommand cmd = conexao.CreateCommand();
            cmd.CommandType = cmdType;
            cmd.CommandText = nomeProcedure;
            cmd.CommandTimeout = 7200;
            foreach (SqlParameter sqlParameter in sqpParameterCollection) {
                sqlParameter.IsNullable = true;
                cmd.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value ?? DBNull.Value));
            }
            return cmd;
        }
        protected void AdicionarParametros(string nomeParametro, object valorParametro) {
            sqpParameterCollection.AddWithValue(nomeParametro, valorParametro);
        }
        protected void LimparParametro() {
            sqpParameterCollection.Clear();
        }
        protected object ExecutarComando(CommandType cmdType, string nomeProcedure) {
            try {
                SqlCommand cmd = CriarComando(cmdType, nomeProcedure);
                return cmd.ExecuteScalar();
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            } finally {
                conexao.Close();
            }
        }
        protected DataTable ExecutarConsulta(CommandType cmdType, string nomeProcedure) {
            try {
                SqlCommand cmd = CriarComando(cmdType, nomeProcedure);
                DataTable dt = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
                return dt;
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            } finally {
                conexao.Close();
            }
        }
    }
}