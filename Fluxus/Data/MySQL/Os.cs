﻿using System;
using System.Data;
using MySql.Data.MySqlClient;
using Fluxus.Model.ENT;

namespace Fluxus.Data.MySQL
{


    public class Os
    {
        
        
        MySqlCommand sql;
        ConnectionToServer con = new ConnectionToServer();





        //:INSERT
        public long Insert(OsENT dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("INSERT INTO tb_os(titulo, referencia, agencia, data_ordem, prazo_execucao, profissional_cod, atividade_cod, siopi, nome_cliente, cidade, nome_contato, telefone_contato, coordenada, status, data_pendente, data_vistoria, data_concluida, obs) VALUES (@titulo, @referencia, @agencia, @data_ordem, @prazo_execucao, @profissional_cod, @atividade_cod, @siopi, @nome_cliente, @cidade, @nome_contato, @telefone_contato, @coordenada, @status, @data_pendente, @data_vistoria, @data_concluida, @obs)", con.Conn);

                sql.Parameters.AddWithValue("@titulo", dado.Titulo);
                sql.Parameters.AddWithValue("@referencia", dado.Referencia);
                sql.Parameters.AddWithValue("@agencia", dado.Agencia);
                sql.Parameters.AddWithValue("@data_ordem", dado.Data_ordem);
                sql.Parameters.AddWithValue("@prazo_execucao", dado.Prazo_execucao);
                sql.Parameters.AddWithValue("@profissional_cod", dado.Profissional_cod);
                sql.Parameters.AddWithValue("@atividade_cod", dado.Atividade_cod);
                sql.Parameters.AddWithValue("@siopi", dado.Siopi);
                sql.Parameters.AddWithValue("@nome_cliente", dado.Nome_cliente);
                sql.Parameters.AddWithValue("@cidade", dado.Cidade);
                sql.Parameters.AddWithValue("@nome_contato", dado.Nome_contato);
                sql.Parameters.AddWithValue("@telefone_contato", dado.Telefone_contato);
                sql.Parameters.AddWithValue("@coordenada", dado.Coordenada);
                sql.Parameters.AddWithValue("@status", dado.Status);
                sql.Parameters.AddWithValue("@data_pendente", dado.Data_pendente);
                sql.Parameters.AddWithValue("@data_vistoria", dado.Data_vistoria);
                sql.Parameters.AddWithValue("@data_concluida", dado.Data_concluida);
                sql.Parameters.AddWithValue("@obs", dado.Obs);

                sql.ExecuteNonQuery();
                return sql.LastInsertedId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        //:UPDATE
        public void Update(long id, OsENT dado)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("UPDATE tb_os SET titulo = @titulo, data_ordem = @data_ordem, prazo_execucao = @prazo_execucao, profissional_cod = @profissional_cod, atividade_cod = @atividade_cod, siopi = @siopi, nome_cliente = @nome_cliente, cidade = @cidade, nome_contato = @nome_contato, telefone_contato = @telefone_contato, coordenada = @coordenada, status = @status, data_pendente = @data_pendente, data_vistoria = @data_vistoria, data_concluida = @data_concluida, obs = @obs WHERE id = @id", con.Conn);
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
                sql.Parameters.AddWithValue("@coordenada", dado.Coordenada);
                sql.Parameters.AddWithValue("@status", dado.Status);
                sql.Parameters.AddWithValue("@data_pendente", dado.Data_pendente);
                sql.Parameters.AddWithValue("@data_vistoria", dado.Data_vistoria);
                sql.Parameters.AddWithValue("@data_concluida", dado.Data_concluida);
                sql.Parameters.AddWithValue("@obs", dado.Obs);
                sql.Parameters.AddWithValue("@id", id);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public void UpdateFaturaCod(long id, long fatura_cod)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("UPDATE tb_os SET fatura_cod = @fatura_cod WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                sql.Parameters.AddWithValue("@fatura_cod", fatura_cod);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }






        public void UpdateStatus(long id, string status)
        {
            try
            {
                con.OpenConnection();

                if (status == "RECEBIDA")
                {
                    sql = new MySqlCommand("UPDATE tb_os SET status = 'RECEBIDA' WHERE id = @id", con.Conn);
                    sql.Parameters.AddWithValue("@id", id);
                }
                else if (status == "PENDENTE")
                {
                    sql = new MySqlCommand("UPDATE tb_os SET status = 'PENDENTE', data_pendente = @data_pendente WHERE id = @id", con.Conn);
                    sql.Parameters.AddWithValue("@id", id);
                    sql.Parameters.AddWithValue("@data_pendente", DateTime.Now);
                }
                else if (status == "VISTORIADA")
                {
                    sql = new MySqlCommand("UPDATE tb_os SET status = 'VISTORIADA', data_vistoria = @data_vistoria WHERE id = @id", con.Conn);
                    sql.Parameters.AddWithValue("@id", id);
                    sql.Parameters.AddWithValue("@data_vistoria", DateTime.Now);
                }
                else
                {
                    sql = new MySqlCommand("UPDATE tb_os SET status = 'CONCLUÍDA', data_concluida = @data_concluida WHERE id = @id", con.Conn);
                    sql.Parameters.AddWithValue("@id", id);
                    sql.Parameters.AddWithValue("@data_concluida", DateTime.Now);
                }

                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }




        //:DELETE
        public void Delete(long id)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("DELETE FROM tb_os WHERE id = @id", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                sql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        //:SELECT
        public DataTable GetOrdensDoFluxo()
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT id, referencia, titulo, status, profissional_cod FROM tb_os WHERE fatura_cod = 0 ORDER BY data_ordem", con.Conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public DataTable GetOrdensFaturadasBy(long fatura_cod)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT t1.id, t1.data_ordem, t1.referencia, t1.profissional_cod, t1.atividade_cod, t1.cidade, t1.nome_cliente, t1.data_vistoria, t1.data_concluida, t1.fatura_cod, t1.status, t2.valor_atividade, t2.valor_deslocamento FROM tb_os t1 INNER JOIN tb_atividades t2 on t1.atividade_cod = t2.codigo WHERE t1.fatura_cod = @fatura_cod ORDER BY t1.data_concluida", con.Conn);
                sql.Parameters.AddWithValue("@fatura_cod", fatura_cod);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public DataTable GetOrdensConcluidasAFaturar()
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT t1.id, t1.data_ordem, t1.referencia, t1.profissional_cod, t1.atividade_cod, t1.cidade, t1.nome_cliente, t1.data_vistoria, t1.data_concluida, t2.valor_atividade, t2.valor_deslocamento FROM tb_os t1 INNER JOIN tb_atividades t2 on t1.atividade_cod = t2.codigo WHERE t1.fatura_cod = 0 AND status = 'CONCLUÍDA' ORDER BY t1.data_concluida", con.Conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public DataTable GetFiltered(string filtro)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand(filtro, con.Conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public DataTable GetProfissionaisDaFatura(long fatura_cod)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT DISTINCT t1.profissional_cod, t2.nomeid FROM tb_os t1 INNER JOIN tb_profissionais t2 on t1.profissional_cod = t2.codigo WHERE t1.fatura_cod = @fatura_cod ORDER BY t2.nomeid", con.Conn);
                sql.Parameters.AddWithValue("@fatura_cod", fatura_cod);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public DataTable GetCidadesDasOrdens()
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT DISTINCT cidade FROM tb_os ORDER BY cidade", con.Conn);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





        public OsENT GetBy(long id)
        {
            try
            {
                con.OpenConnection();
                sql = new MySqlCommand("SELECT * FROM tb_os WHERE id = @id ORDER BY data_ordem", con.Conn);
                sql.Parameters.AddWithValue("@id", id);
                MySqlDataReader dr = sql.ExecuteReader();


                OsENT os = new OsENT();
                if (dr.Read())
                {

                    os.Id = Convert.ToInt64(dr["id"]);
                    os.Referencia = Convert.ToString(dr["referencia"]);
                    os.Agencia = Convert.ToString(dr["agencia"]);
                    os.Titulo = Convert.ToString(dr["titulo"]);
                    os.Data_ordem = Convert.ToString(dr["data_ordem"]);
                    os.Prazo_execucao = Convert.ToDateTime(dr["prazo_execucao"]);
                    os.Profissional_cod = Convert.ToString(dr["profissional_cod"]);
                    os.Atividade_cod = Convert.ToString(dr["atividade_cod"]);
                    os.Siopi = Convert.ToBoolean(dr["siopi"]);
                    os.Nome_cliente = Convert.ToString(dr["nome_cliente"]);
                    os.Cidade = Convert.ToString(dr["cidade"]);
                    os.Nome_contato = Convert.ToString(dr["nome_contato"]);
                    os.Telefone_contato = Convert.ToString(dr["telefone_contato"]);
                    os.Coordenada = Convert.ToString(dr["coordenada"]);
                    os.Status = Convert.ToString(dr["status"]);
                    os.Data_pendente = Convert.ToString(dr["data_pendente"]);
                    os.Data_vistoria = Convert.ToString(dr["data_vistoria"]);
                    os.Data_concluida = Convert.ToString(dr["data_concluida"]);
                    os.Obs = Convert.ToString(dr["obs"]);
                    os.Fatura_cod = Convert.ToInt64(dr["fatura_cod"]);
                }
                return os;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.CloseConnection();
            }
        }





    }
}