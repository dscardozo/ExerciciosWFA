using Escola_POO_BASE.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_BASE.Classes
{
    public class Professor : Usuario
    {
        #region Propriedades
             

        public string Cpf { get; set; }
        public int NivelAcesso { get; set; }


        #endregion

        #region Construtores
        public Professor()
        {

        }

        public Professor(int id, string nome, DateTime dtNascimento, string cpf, string email, string senha, int nivelAcesso, bool ativo) : base(id, nome, dtNascimento, email, senha, ativo)
        {
            Cpf = cpf;
            NivelAcesso = nivelAcesso;
        }

        #endregion

        #region Métodos
        public void Cadastrar(List<Professor> professores)
        {                                                                                                                                            // Pega o último valor AutoIncremento
            string query = string.Format($"INSERT INTO Professor VALUES ('{Nome}','{DtNascimento}','{Cpf}','{Email}','{Crypto.Sha256(Senha)}',1,1); SELECT SCOPE_IDENTITY()");

            Conexao cn = new Conexao(query);


            //Aluno usuario = new Aluno();

            //Bloco - try..catch
            try
            {
                cn.AbrirConexao();//AutoIncremento ID
                Id = Convert.ToInt32(cn.comando.ExecuteScalar()); // Para o Select ExecuteReader()
                professores.Add(this);

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
        public void Alterar()
        {
            string query = string.Format($"UPDATE Professor SET Nome = '{Nome}', DtNascimento = '{DtNascimento}', Cpf = '{Cpf}', Email = '{Email}', NivelAcesso = '{NivelAcesso}', Ativo = '{Ativo}' WHERE Id = '{Id}'");
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
            string query = string.Format($"UPDATE Professor SET Ativo = '{0}' WHERE Id = '{Id}'");
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
        public static List<Professor> Buscar(List<Professor> professores, int indexCbbBuscar, string texto)
        {
            switch (indexCbbBuscar)
            {
                case 0:
                    //Busca por nome
                    return professores.Where(p => p.Nome.ToUpper().Normalize(NormalizationForm.FormKD).Contains(texto.ToUpper())).ToList();
                //break; quando não for returno o Break é obrigatório
                case 1:
                    // Busca por E-mail
                    return professores.Where(p => p.Email.ToUpper().Normalize(NormalizationForm.FormKD).Contains(texto.ToUpper())).ToList();
                //break; quando não for returno o Break é obrigatório
                case 2:
                    // Buscar por matricula (id)
                    return professores.Where(p => p.Id == Convert.ToInt32(texto)).ToList();
                //break; quando não for returno o Break é obrigatório

                default:
                    // Retorna sem filtro
                    return professores;
                    //break; quando não for returno o Break é obrigatório
            }
        }
        public void Reativar()
        {
            string query = string.Format($"UPDATE Professor SET Ativo = '{1}' WHERE Id = '{Id}'");
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
        #endregion
    }
}
