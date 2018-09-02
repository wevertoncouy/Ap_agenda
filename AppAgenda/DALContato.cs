﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AppAgenda
{
    class DALContato
    {
        private Conexao objConexao;

        public DALContato(Conexao conexao)
        {
            objConexao = conexao;
        }

        public void Incluir(Contato contato)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = objConexao.ObjetoConexao;
            comando.CommandText = "insert into Contato(nome, email, telefone, rua, bairro, cidade, estado, cep  ) " +
                "values (@nome, @email, @telefone, @rua, @bairro, @cidade, @estado, @cep); select @@IDENTITY;";
            comando.Parameters.AddWithValue("@nome", contato.Nome);
            comando.Parameters.AddWithValue("@email", contato.Email);
            comando.Parameters.AddWithValue("@telefone", contato.Telefone);
            comando.Parameters.AddWithValue("@rua", contato.Rua);
            comando.Parameters.AddWithValue("@bairro", contato.Bairro);
            comando.Parameters.AddWithValue("@cidade", contato.Cidade);
            comando.Parameters.AddWithValue("@estado", contato.Estado);
            comando.Parameters.AddWithValue("@cep", contato.Cep);
            objConexao.Conectar();
            contato.ContatoId = Convert.ToInt32(comando.ExecuteScalar());
            objConexao.Desconectar();
        }

        public void Alterar(Contato contato)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = objConexao.ObjetoConexao;
            comando.CommandText = "update Contato set nome = @nome, email = @email, telefone = @telefone," +
                " rua = @rua  bairro = @bairro, cidade = @cidade, estado = @estado, cep = @cep" +
                  "where contatoId = @contatoId";
            comando.Parameters.AddWithValue("@nome", contato.Nome);
            comando.Parameters.AddWithValue("@email", contato.Email);
            comando.Parameters.AddWithValue("@telefone", contato.Telefone);
            comando.Parameters.AddWithValue("@rua", contato.Rua);
            comando.Parameters.AddWithValue("@bairro", contato.Bairro);
            comando.Parameters.AddWithValue("@cidade", contato.Cidade);
            comando.Parameters.AddWithValue("@estado", contato.Estado);
            comando.Parameters.AddWithValue("@cep", contato.Cep);
            objConexao.Conectar();
            comando.ExecuteNonQuery();
            objConexao.Desconectar();
        }
        public void Excluir(int contatoId)
        {
            SqlCommand comado = new SqlCommand();
            comado.Connection = objConexao.ObjetoConexao;
            comado.CommandText = "delete from contato where contatoId = contatoId";
            comado.Parameters.AddWithValue("@contatoId", contatoId);
            objConexao.Conectar();
            comado.ExecuteNonQuery();
            objConexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Contato where  nome like '%" +
               valor + "%'", objConexao.StringConexao);
            da.Fill(tabela);
            return tabela;

        }


    }
}
