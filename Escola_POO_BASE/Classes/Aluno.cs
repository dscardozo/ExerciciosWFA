﻿using Escola_POO_BASE.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Escola_POO_BASE.Telas
{

    public class Aluno : Usuario
    {


        #region Propriedades
        public DateTime DtMatricula { get; set; }
        #endregion

        #region Construtores
        public Aluno()
        {
        }

        public Aluno(int id, string nome, DateTime dtNascimento, DateTime dtMatricula, string email, string senha, bool ativo) : base(id, nome, dtNascimento, email, senha, ativo)
        {
            DtMatricula = dtMatricula;
        }
        #endregion

        #region Métodos
        public void Cadastrar(List<Aluno> alunos)
        {                                                                                                                                            // Pega o último valor AutoIncremento
            string query = string.Format($"INSERT INTO Aluno VALUES ('{Nome}','{DtNascimento}','{DtMatricula}','{Email}','{Crypto.Sha256(Senha)}',1); SELECT SCOPE_IDENTITY()");

            Conexao cn = new Conexao(query);


            //Aluno usuario = new Aluno();

            //Bloco - try..catch
            try
            {
                cn.AbrirConexao();//AutoIncremento ID
                Id = Convert.ToInt32(cn.comando.ExecuteScalar()); // Para o Select ExecuteReader()
                alunos.Add(this);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        public void Alterar(List<Aluno> alunos)
        {
            string query = string.Format($"UPDATE Aluno SET Nome = '{Nome}', DtNascimento = '{DtNascimento}', DtMatricula = '{DtMatricula}', Email = '{Email}', Ativo = '{Ativo}' WHERE Id = '{Id}'");
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
            finally
            {
                cn.FecharConexao();
            }

        }
        public void Excluir()
        {
            string query = string.Format($"UPDATE Aluno SET Ativo = '{0}' WHERE Id = '{Id}'");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
            finally
            {
                cn.FecharConexao();
            }

        }

        public static List<Aluno> Buscar(List<Aluno> alunos, int indexCbbBuscar, string texto)
        {
            switch (indexCbbBuscar)
            {
                case 0:
                    //Busca por nome
                    return alunos.Where(a => a.Nome.ToUpper().Normalize(NormalizationForm.FormKD).Contains(texto.ToUpper())).ToList();
                //break; quando não for returno o Break é obrigatório
                case 1:
                    // Busca por E-mail
                    return alunos.Where(a => a.Email.ToUpper().Normalize(NormalizationForm.FormKD).Contains(texto.ToUpper())).ToList();
                //break; quando não for returno o Break é obrigatório
                case 2:
                    // Buscar por matricula (id)
                    return alunos.Where(a => a.Id == Convert.ToInt32(texto)).ToList();
                //break; quando não for returno o Break é obrigatório

                default:
                    // Retorna sem filtro
                    return alunos;
                    //break; quando não for returno o Break é obrigatório
            }
        }

        public void Reativar()
        {
            string query = string.Format($"UPDATE Aluno SET Nome = '{Nome}', DtNascimento = '{DtNascimento}', DtMatricula = '{DtMatricula}', Email = '{Email}', Ativo = '{Ativo}' WHERE Id = '{Id}'");
            
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }


        #endregion
    }
}
