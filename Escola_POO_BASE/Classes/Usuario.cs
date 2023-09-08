using Escola_POO_BASE.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_POO_BASE.Classes
{

    public class Usuario
    {

        #region Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }


        #endregion

        #region Construtores
        public Usuario()
        {

        }

        public Usuario(int id, string nome, DateTime dtNascimento, string email, string senha, bool ativo)
        {
            Id = id;
            Nome = nome;
            DtNascimento = dtNascimento;
            Email = email;
            Senha = senha;
            Ativo = ativo;

        }

        public Usuario(string nome, DateTime dtpDtNascimentoTlCad, string email, DateTime dtpDtMatriculaTlCad)
        {
            Nome = nome;
            DtNascimento = dtpDtNascimentoTlCad;
            Email = email;

        }
        #endregion

        #region Métodos

        #region Antigo RealizarLogin sem BD
        //public static Usuario RealizarLogin(string email, string senha, List<Usuario> usuarios)
        //{
        //    Usuario usuario = usuarios.Find(a => a.Email == email);

        //    //Bloco - try..catch
        //    try
        //    {
        //        if (usuario == null)
        //        {
        //            //E-mail é inexistente
        //            throw new Exception("E-mail inexistente!");
        //        }
        //        else
        //        {
        //            if (usuario.Senha == senha)
        //            {
        //                if (usuario.Ativo)
        //                {
        //                    //Deu tudo certo
        //                    return usuario;
        //                }
        //                else
        //                {
        //                    //Usuário bloqueado
        //                    throw new Exception("Usuário bloqueado");
        //                }
        //            }
        //            else
        //            {
        //                //Senha incorreta
        //                throw new Exception("Senha incorreta!");
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        #endregion


        public static Usuario RealizarLogin(string email, string senha, bool tipoAcesso)
        {
            if (tipoAcesso)
            {
                string query = string.Format($"SELECT * FROM Aluno WHERE Email = '{email}'");
                Conexao cn = new Conexao(query);

                Aluno usuario = new Aluno();

                //Bloco - try..catch
                try
                {
                    cn.AbrirConexao();
                    cn.dr = cn.comando.ExecuteReader(); // Para o Select ExecuteReader()

                    if (cn.dr.HasRows)
                    {
                        // Achou os dados do usuário de acordo com o email pesquisado
                        while (cn.dr.Read())
                        {
                            usuario.Id = Convert.ToInt32(cn.dr[0]);
                            usuario.Nome = cn.dr[1].ToString();
                            usuario.DtNascimento = Convert.ToDateTime(cn.dr[2]);
                            usuario.DtMatricula = Convert.ToDateTime(cn.dr[3]);
                            usuario.Email = cn.dr[4].ToString();
                            usuario.Senha = cn.dr[5].ToString();
                            usuario.Ativo = Convert.ToBoolean(cn.dr[6]);

                        }

                        if (usuario.Senha == Crypto.Sha256(senha))
                        {
                            if (usuario.Ativo)
                            {
                                //Deu tudo certo
                                return usuario;
                            }
                            else
                            {
                                //Usuário bloqueado
                                throw new Exception("Usuário bloqueado");
                            }
                        }
                        else
                        {
                            //Senha incorreta
                            throw new Exception("Senha incorreta!");
                        }

                    }
                    else
                    {
                        //Não teve retorno de linhas
                        throw new Exception("E-mail inexistente!");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                string query = string.Format($"SELECT * FROM Professor WHERE Email = '{email}'");
                Conexao cn = new Conexao(query);

                Professor usuario = new Professor();

                //Bloco - try..catch
                try
                {
                    cn.AbrirConexao();
                    cn.dr = cn.comando.ExecuteReader(); // P/ Select! ExecuteReader()!!!!!

                    if (cn.dr.HasRows)
                    {
                        //Achou os dados do usuário de acordo com o E-mail pesquisado
                        while (cn.dr.Read())
                        {
                            usuario.Id = Convert.ToInt32(cn.dr[0]);
                            usuario.Nome = cn.dr[1].ToString();
                            usuario.DtNascimento = Convert.ToDateTime(cn.dr[2]);
                            usuario.Cpf = cn.dr[3].ToString();
                            usuario.Email = cn.dr[4].ToString();
                            usuario.Senha = cn.dr[5].ToString();
                            usuario.NivelAcesso = Convert.ToInt32(cn.dr[6]);
                            usuario.Ativo = Convert.ToBoolean(cn.dr[7]);
                        }

                        if (usuario.Senha == Crypto.Sha256(senha))
                        {
                            if (usuario.Ativo)
                            {
                                //Deu tudo certo
                                return usuario;
                            }
                            else
                            {
                                //Usuário bloqueado
                                throw new Exception("Usuário bloqueado");
                            }
                        }
                        else
                        {
                            //Senha incorreta
                            throw new Exception("Senha incorreta!");
                        }

                    }
                    else
                    {
                        //Não teve retorno de linhas
                        throw new Exception("E-mail inexistente!");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }

        // Gerar Listas 
        //public static List<Usuario> GerarUsuarios()
        //{
        //    List<Usuario> usuarios = new List<Usuario>();
        //    Usuario aluno1 = new Aluno(1, "Danilo Cardoso", Convert.ToDateTime("28/08/1978"), Convert.ToDateTime("20/05/2020"), "danilo@gmail", "321", true);
        //    Usuario aluno2 = new Aluno(2, "Ana Júlia", Convert.ToDateTime("28/06/1993"), Convert.ToDateTime("20/12/2020"), "ana@gmail", "123", true);
        //    Usuario aluno3 = new Aluno(3, "Kayena Almeida", Convert.ToDateTime("20/08/1997"), Convert.ToDateTime("20/02/2020"), "kay@gmail", "123", true);

        //    Usuario prof1 = new Professor(1, "Leandro", Convert.ToDateTime("01/01/2000"), "12345678911", "leandro@email", "123456", 1, true);
        //    Usuario prof2 = new Professor(2, "Rafael", Convert.ToDateTime("07/03/1988"), "98765432112", "rafael@email", "123456", 1, true);

        //    usuarios.Add(aluno1);
        //    usuarios.Add(aluno2);
        //    usuarios.Add(aluno3);


        //    usuarios.Add(prof1);
        //    usuarios.Add(prof2);

        //    return usuarios;
        //}

        // Esse método irá alterar a senha de um usuário que está logado.
        public void AlterarSenha(string senhaAtual, string novaSenha, string repeteSenha)
        {
            string query = string.Format("UPDATE {0} SET Senha = '{1}' WHERE Id = {2}", this is Aluno ? "Aluno" : "Professor", Crypto.Sha256(novaSenha), Id);
            Conexao cn = new Conexao(query);
            try
            {
                if (Senha == Crypto.Sha256(senhaAtual))
                {
                    if (novaSenha == repeteSenha)
                    {
                        cn.AbrirConexao();
                        cn.comando.ExecuteNonQuery();
                        Senha = Crypto.Sha256(novaSenha);
                    }
                    else
                    {
                        throw new Exception("Nova senha não confere!");
                    }
                }
                else
                {
                    throw new Exception("Senha atual não confere!");

                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public static List<Usuario> BuscarUsuariosA()
        {

            string query = string.Format("SELECT * FROM Aluno");
            Conexao cn = new Conexao(query);
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                cn.AbrirConexao();
                cn.dr = cn.comando.ExecuteReader();
                while (cn.dr.Read())
                {
                    usuarios.Add(new Aluno()
                    {
                        Id = Convert.ToInt32(cn.dr[0]),
                        Nome = cn.dr[1].ToString(),
                        DtNascimento = Convert.ToDateTime(cn.dr[2]),
                        DtMatricula = Convert.ToDateTime(cn.dr[3]),
                        Email = cn.dr[4].ToString(),
                        Senha = cn.dr[5].ToString(),
                        Ativo = Convert.ToBoolean(cn.dr[6])
                    });
                }
                return usuarios;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<Usuario> BuscarUsuariosP()
        {
            string query = string.Format("SELECT * FROM Professor");
            Conexao cn = new Conexao(query);
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                cn.AbrirConexao();
                cn.dr = cn.comando.ExecuteReader();
                while (cn.dr.Read())
                {
                    usuarios.Add(new Professor()
                    {
                        Id = Convert.ToInt32(cn.dr[0]),
                        Nome = cn.dr[1].ToString(),
                        DtNascimento = Convert.ToDateTime(cn.dr[2]),
                        Cpf = cn.dr[3].ToString(),
                        Email = cn.dr[4].ToString(),
                        Senha = cn.dr[5].ToString(),
                        NivelAcesso = Convert.ToInt32(cn.dr[6]),
                        Ativo = Convert.ToBoolean(cn.dr[7])
                    });
                }
                return usuarios;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
    #endregion

}

