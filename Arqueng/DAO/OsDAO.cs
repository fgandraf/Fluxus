﻿using System;
using System.Data;
using MySql.Data.MySqlClient;
using Arqueng.ENTIDADES;

namespace Arqueng.DAO
{


    public class OsDAO
    {
        MySqlCommand sql;
        CONEXAO con = new CONEXAO();



        //***** LISTAR TODAS AS ORDENS DE SERVIÇO SEM FILTRO *****//
        public DataTable ListarOsDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_os ORDER BY data_ordem", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //***** LISTAR ORDENS DE SERVIÇO À SEREM FATURADAS *****//
        public DataTable ListarOSAFaturarDAO()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT t1.data_ordem, t1.referencia, t1.atividade_cod, t1.cidade, t1.nome_cliente, t1.data_vistoria, t1.data_concluida, t2.valor_atividade, t2.valor_deslocamento FROM tb_os t1 INNER JOIN tb_atividades t2 on t1.atividade_cod = t2.codigo WHERE t1.status = 'CONCLUÍDA' AND t1.fatura_cod = 0 ORDER BY t1.data_concluida", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //***** LISTAR ORDENS DE SERVIÇO JÁ FATURADAS *****//
        public DataTable ListarOSFaturadaDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT t1.data_ordem, t1.referencia, t1.atividade_cod, t1.cidade, t1.nome_cliente, t1.data_vistoria, t1.data_concluida, t2.valor_atividade, t2.valor_deslocamento FROM tb_os t1 INNER JOIN tb_atividades t2 on t1.atividade_cod = t2.codigo WHERE t1.fatura_cod = @fatura_cod ORDER BY t1.data_concluida", con.con);
                sql.Parameters.AddWithValue("@fatura_cod", dado.Fatura_cod);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //***** LISTAR ORDENS DE SERVIÇO NÃO FATURADAS, POR STATUS *****//
        public DataTable ListarOsStatusDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT referencia, titulo FROM tb_os WHERE status = @status AND fatura_cod = 0 ORDER BY data_ordem", con.con);
                sql.Parameters.AddWithValue("@status", dado.Status);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        //***** LISTAR ORDENS DE SERVIÇO NÃO FATURADAS, POR STATUS E PROFISSIONAL *****//
        public DataTable ListarOsStatusProDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT referencia, titulo FROM tb_os WHERE status = @status AND fatura_cod = 0 AND profissional_cod = @profissional_cod ORDER BY data_ordem", con.con);
                sql.Parameters.AddWithValue("@status", dado.Status);
                sql.Parameters.AddWithValue("@profissional_cod", dado.Profissional_cod);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }












        public void BuscarOSDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("SELECT * FROM tb_os WHERE referencia = @referencia", con.con);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                MySqlDataReader dr = sql.ExecuteReader();

                while (dr.Read())
                {
                    dado.Titulo = Convert.ToString(dr["titulo"]);
                    dado.Referencia = Convert.ToString(dr["referencia"]);
                    dado.Data_ordem = Convert.ToDateTime(dr["data_ordem"]);
                    dado.Prazo_execucao = Convert.ToDateTime(dr["prazo_execucao"]);
                    dado.Profissional_cod = Convert.ToString(dr["profissional_cod"]);
                    dado.Atividade_cod = Convert.ToString(dr["atividade_cod"]);
                    dado.Siopi = Convert.ToBoolean(dr["siopi"]);
                    dado.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                    dado.Cidade = Convert.ToString(dr["cidade"]);
                    dado.Nome_contato = Convert.ToString(dr["nome_contato"]);
                    dado.Telefone_contato = Convert.ToString(dr["telefone_contato"]);
                    dado.Status = Convert.ToString(dr["status"]);
                    dado.Data_pendente = Convert.ToDateTime(dr["data_pendente"]);
                    dado.Data_vistoria = Convert.ToDateTime(dr["data_vistoria"]);
                    dado.Data_concluida = Convert.ToDateTime(dr["data_concluida"]);
                    dado.Obs = Convert.ToString(dr["obs"]);
                    dado.Fatura_cod = Convert.ToString(dr["fatura_cod"]);
                }

                con.FecharConexao();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void InsertOsDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO tb_os(titulo, referencia, data_ordem, prazo_execucao, profissional_cod, atividade_cod, siopi, nome_cliente, cidade, nome_contato, telefone_contato, status, data_pendente, data_vistoria, data_concluida, obs) VALUES (@titulo, @referencia, @data_ordem, @prazo_execucao, @profissional_cod, @atividade_cod, @siopi, @nome_cliente, @cidade, @nome_contato, @telefone_contato, @status, @data_pendente, @data_vistoria, @data_concluida, @obs)", con.con);

                sql.Parameters.AddWithValue("@titulo", dado.Titulo);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.Parameters.AddWithValue("@data_ordem", dado.Data_ordem);
                sql.Parameters.AddWithValue("@prazo_execucao", dado.Prazo_execucao);
                sql.Parameters.AddWithValue("@profissional_cod", dado.Profissional_cod);
                sql.Parameters.AddWithValue("@atividade_cod", dado.Atividade_cod);
                sql.Parameters.AddWithValue("@siopi", dado.Siopi);
                sql.Parameters.AddWithValue("@nome_cliente", dado.Nome_cliente);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@nome_contato", dado.Nome_contato);
                sql.Parameters.AddWithValue("@telefone_contato", dado.Telefone_contato);
                sql.Parameters.AddWithValue("@status", dado.Status);
                sql.Parameters.AddWithValue("@data_pendente", dado.Data_pendente);
                sql.Parameters.AddWithValue("@data_vistoria", dado.Data_vistoria);
                sql.Parameters.AddWithValue("@data_concluida", dado.Data_concluida);
                sql.Parameters.AddWithValue("@obs", dado.Obs);

                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public void UpdateOsDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_os SET titulo = @titulo, data_ordem = @data_ordem, prazo_execucao = @prazo_execucao, profissional_cod = @profissional_cod, atividade_cod = @atividade_cod, siopi = @siopi, nome_cliente = @nome_cliente, cidade = @cidade, nome_contato = @nome_contato, telefone_contato = @telefone_contato, status = @status, data_pendente = @data_pendente, data_vistoria = @data_vistoria, data_concluida = @data_concluida, obs = @obs WHERE referencia = @referencia", con.con);
                sql.Parameters.AddWithValue("@titulo", dado.Titulo);
                sql.Parameters.AddWithValue("@data_ordem", dado.Data_ordem);
                sql.Parameters.AddWithValue("@prazo_execucao", dado.Prazo_execucao);
                sql.Parameters.AddWithValue("@profissional_cod", dado.Profissional_cod);
                sql.Parameters.AddWithValue("@atividade_cod", dado.Atividade_cod);
                sql.Parameters.AddWithValue("@siopi", dado.Siopi);
                sql.Parameters.AddWithValue("@nome_cliente", dado.Nome_cliente);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@nome_contato", dado.Nome_contato);
                sql.Parameters.AddWithValue("@telefone_contato", dado.Telefone_contato);
                sql.Parameters.AddWithValue("@status", dado.Status);
                sql.Parameters.AddWithValue("@data_pendente", dado.Data_pendente);
                sql.Parameters.AddWithValue("@data_vistoria", dado.Data_vistoria);
                sql.Parameters.AddWithValue("@data_concluida", dado.Data_concluida);
                sql.Parameters.AddWithValue("@obs", dado.Obs);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public void UpdateOsFaturada(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("UPDATE tb_os SET fatura_cod = @fatura_cod WHERE referencia = @referencia", con.con);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.Parameters.AddWithValue("@fatura_cod", dado.Fatura_cod);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


        public void DeleteOsDAO(OsENT dado)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("DELETE FROM tb_os WHERE referencia = @referencia", con.con);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.ExecuteNonQuery();
                con.FecharConexao();
            }
            catch (Exception)
            {
                con.FecharConexao();
                throw;
            }
        }


    }


}
