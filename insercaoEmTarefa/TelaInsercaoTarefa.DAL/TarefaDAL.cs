using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using TelaInsercaoTarefa.DTO;

namespace TelaInsercaoTarefa.DAL
{
    public class TarefaDAL
    {
        public int InserirDados(TarefaDTO TAREFA)
        {
            try
            {
                SqlConnection connection = new SqlConnection();

                connection.ConnectionString = Properties.Settings.Default.CST;

                SqlCommand command = new SqlCommand();

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "USE TAREFAS_BOMBEIRO;\n" +
                    "GO\n" +
                    "INSERT INTO TAREFA (task, cliente, urgencia, tempo, versao, motivo, taskorigem, data,obs, AREA, TIME, atendente, trello) VALUES " +
                    "(@task, @cliente, @urgencia, @tempo, @versao, @motivo, @taskorigem, @data, @obs, @AREA, @TIME, @atendente, @trello)";

                command.Parameters.Add("task", System.Data.SqlDbType.Int).Value = TAREFA.Task;
                command.Parameters.Add("cliente", System.Data.SqlDbType.VarChar).Value = TAREFA.Cliente;
                command.Parameters.Add("urgencia", System.Data.SqlDbType.Int).Value = TAREFA.Urgencia;
                command.Parameters.Add("tempo", System.Data.SqlDbType.Int).Value = TAREFA.Tempo;
                command.Parameters.Add("versao", System.Data.SqlDbType.VarChar).Value = TAREFA.Task;
                command.Parameters.Add("motivo", System.Data.SqlDbType.Int).Value = TAREFA.Motivo;
                command.Parameters.Add("taskorigem", System.Data.SqlDbType.Int).Value = TAREFA.TaskOrigem;
                command.Parameters.Add("data", System.Data.SqlDbType.DateTime).Value = TAREFA.Data;
                command.Parameters.Add("obs", System.Data.SqlDbType.VarChar).Value = TAREFA.Obs;
                command.Parameters.Add("AREA", System.Data.SqlDbType.Int).Value = TAREFA.Area;
                command.Parameters.Add("TIME", System.Data.SqlDbType.Int).Value = TAREFA.Time;
                command.Parameters.Add("atendente", System.Data.SqlDbType.VarChar).Value = TAREFA.Atendente;
                command.Parameters.Add("trello", System.Data.SqlDbType.VarChar).Value = TAREFA.Trello;


                connection.Open();
                int qtd = command.ExecuteNonQuery();
                return qtd;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public IList<TarefaDTO> CarregarDadosCmbArea()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT DISTINCT AREA FROM TAREFA";
                command.Connection = connection;

                SqlDataReader DR;
                IList<TarefaDTO> listTarefaDTO = new List<TarefaDTO>();

                connection.Open();
                DR = command.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        TarefaDTO TAREFA = new TarefaDTO();

                        TAREFA.Area = Convert.ToInt32(DR["AREA"]);

                        listTarefaDTO.Add(TAREFA);
                    }
                }

                return listTarefaDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<TarefaDTO> CarregarDadosCmbVersao()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT DISTINCT versao FROM TAREFA";
                command.Connection = connection;

                SqlDataReader DR;
                IList<TarefaDTO> listTarefaDTO = new List<TarefaDTO>();

                connection.Open();
                DR = command.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        TarefaDTO TAREFA = new TarefaDTO();

                        TAREFA.Versao = Convert.ToString(DR["versao"]);

                        listTarefaDTO.Add(TAREFA);
                    }
                }

                return listTarefaDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<TarefaDTO> CarregarDadosCmbMotivo()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT DISTINCT motivo FROM TAREFA";
                command.Connection = connection;

                SqlDataReader DR;
                IList<TarefaDTO> listTarefaDTO = new List<TarefaDTO>();

                connection.Open();
                DR = command.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        TarefaDTO TAREFA = new TarefaDTO();

                        TAREFA.Motivo = Convert.ToInt32(DR["motivo"]);

                        listTarefaDTO.Add(TAREFA);
                    }
                }

                return listTarefaDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<TarefaDTO> CarregarDadosCmbTime()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT DISTINCT TIME FROM TAREFA";
                command.Connection = connection;

                SqlDataReader DR;
                IList<TarefaDTO> listTarefaDTO = new List<TarefaDTO>();

                connection.Open();
                DR = command.ExecuteReader();
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        TarefaDTO TAREFA = new TarefaDTO();

                        TAREFA.Time = Convert.ToInt32(DR["TIME"]);

                        listTarefaDTO.Add(TAREFA);
                    }
                }

                return listTarefaDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
