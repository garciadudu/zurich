using Dapper;
using Microsoft.Extensions.Configuration;
using Oracle.ManagedDataAccess.Client;
using Seguros.Zurich.Domain.Core.Interface.Repository;
using Seguros.Zurich.Domain.Entities.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Seguros.Zurich.Infraestrutura.Repository.Repositorio
{
    public class RepositorioSeguro : IRepositorySeguro
    {
        private IConfiguration configuration;

        public RepositorioSeguro(IConfiguration _configuration)
        {
            OracleConfiguration.TraceFileLocation = @"C:\oraclexe\traces";
            OracleConfiguration.TraceLevel = 7;

            if (string.IsNullOrEmpty(OracleConfiguration.TnsAdmin))
            {
                OracleConfiguration.TnsAdmin = @"C:\oraclexe\app\oracle\product\11.2.0\server\network\ADMIN";
            }

            configuration = _configuration;
        }
        public virtual void Add(Seguro obj)
        {
            try
            {

                string queryString = @"INSERT INTO Seguros(Id,valorVeiculo,taxaRisco,premioRisco,premioPuro,premioComercial,valorSeguro,marcaVeiculo,modeloVeiculo,Nome,CPF,Idade) 
                                       SELECT SEGURO_seq.nextval,:valorVeiculo,:taxaRisco,:premioRisco,:premioPuro,:premioComercial,:valorSeguro,:marcaVeiculo,:modeloVeiculo,:Nome,:CPF,:Idade
                                       FROM DUAL";


                using (OracleConnection connection = new OracleConnection(configuration["OracleConnection:ConnectionString"]))
                {
                    OracleCommand command = new OracleCommand(queryString);
                    command.Connection = connection;
                    try
                    {
                        connection.Open();
                        command.Parameters.Add("valorVeiculo", obj.valorVeiculo);
                        command.Parameters.Add("taxaRisco", obj.taxaRisco);
                        command.Parameters.Add("premioRisco", obj.premioRisco);
                        command.Parameters.Add("premioPuro", obj.premioPuro);
                        command.Parameters.Add("premioComercial", obj.premioComercial);
                        command.Parameters.Add("valorSeguro", obj.valorSeguro);

                        command.Parameters.Add("marcaVeiculo", obj.marcaVeiculo);
                        command.Parameters.Add("modeloVeiculo", obj.modeloVeiculo);
                        command.Parameters.Add("Nome", obj.Nome);
                        command.Parameters.Add("CPF", obj.CPF);
                        command.Parameters.Add("Idade", obj.Idade);


                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task AddAsync(Seguro obj)
        {
            try
            {
                string queryString = @"INSERT INTO Seguros(Id,valorVeiculo,taxaRisco,premioRisco,premioPuro,premioComercial,valorSeguro,marcaVeiculo,modeloVeiculo,Nome,CPF,Idade) 
                                       SELECT SEGURO_seq.nextval,:valorVeiculo,:taxaRisco,:premioRisco,:premioPuro,:premioComercial,:valorSeguro,:marcaVeiculo,:modeloVeiculo,:Nome,:CPF,:Idade
                                       FROM DUAL";


                using (OracleConnection connection = new OracleConnection(configuration["OracleConnection:ConnectionString"]))
                {
                    OracleCommand command = new OracleCommand(queryString);
                    command.Connection = connection;
                    try
                    {
                        connection.Open();
                        command.Parameters.Add("valorVeiculo", obj.valorVeiculo);
                        command.Parameters.Add("taxaRisco", obj.taxaRisco);
                        command.Parameters.Add("premioRisco", obj.premioRisco);
                        command.Parameters.Add("premioPuro", obj.premioPuro);
                        command.Parameters.Add("premioComercial", obj.premioComercial);
                        command.Parameters.Add("valorSeguro", obj.valorSeguro);

                        command.Parameters.Add("marcaVeiculo", obj.marcaVeiculo);
                        command.Parameters.Add("modeloVeiculo", obj.modeloVeiculo);
                        command.Parameters.Add("Nome", obj.Nome);
                        command.Parameters.Add("CPF", obj.CPF);
                        command.Parameters.Add("Idade", obj.Idade);

                        await command.ExecuteNonQueryAsync();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual Seguro GetById(int id)
        {
            try
            {
                string queryString = @"SELECT Id,valorVeiculo,taxaRisco,premioRisco,premioPuro,premioComercial 
                                       FROM Seguros 
                                       WHERE Id=:Id";
                using (OracleConnection connection = new OracleConnection(configuration["OracleConnection:ConnectionString"]))
                {
                    OracleCommand command = new OracleCommand(queryString);
                    command.Connection = connection;
                    try
                    {
                        connection.Open();
                        command.Parameters.Add("Id", id);


                        return connection.Query<Seguro>(queryString).FirstOrDefault();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task<Seguro> GetByIdAsync(int id)
        {
            try
            {
                string queryString = @$"SELECT Id,valorVeiculo,taxaRisco,premioRisco,premioPuro,premioComercial 
                                       FROM Seguros 
                                       WHERE Id={id}";
                using (OracleConnection connection = new OracleConnection(configuration["OracleConnection:ConnectionString"]))
                {
                    OracleCommand command = new OracleCommand(queryString);
                    command.Connection = connection;
                    try
                    {
                        connection.Open();

                        return connection.Query<Seguro>(queryString).FirstOrDefault();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task<Seguro> GetByCPFAsync(string cpf)
        {
            try
            {
                    string queryString = @$"SELECT Id,valorVeiculo,taxaRisco,premioRisco,premioPuro,premioComercial,valorSeguro,marcaVeiculo,modeloVeiculo,Nome,CPF,Idade
                                           FROM Seguros 
                                           WHERE cpf='{cpf}'";
                using (OracleConnection connection = new OracleConnection(configuration["OracleConnection:ConnectionString"]))
                {
                    OracleCommand command = new OracleCommand(queryString);
                    command.Connection = connection;
                    try
                    {
                        connection.Open();

                        return connection.Query<Seguro>(queryString).FirstOrDefault();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public virtual IEnumerable<Seguro> GetAll()
        {
            try
            {
                string queryString = @"SELECT Id,valorVeiculo,taxaRisco,premioRisco,premioPuro,premioComercial 
                                       FROM Seguros";
                using (OracleConnection connection = new OracleConnection(configuration["OracleConnection:ConnectionString"]))
                {
                    OracleCommand command = new OracleCommand(queryString);
                    command.Connection = connection;
                    try
                    {
                        connection.Open();


                        return connection.Query<Seguro>(queryString);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual void Update(Seguro obj)
        {
            try
            {
                string queryString = @"UPDATE Seguros
                                       SET valorVeiculo=:valorVeiculo,taxaRisco=:taxaRisco,premioRisco=:premioRisco,premioPuro=:premioPuro,
                                           premioComercial=:premioComercial,valorSeguro=:valorSeguro 
                                       where Id=:Id";
                using (OracleConnection connection = new OracleConnection(configuration["OracleConnection:ConnectionString"]))
                {
                    OracleCommand command = new OracleCommand(queryString);
                    command.Connection = connection;
                    try
                    {
                        connection.Open();

                        command.Parameters.Add("Id", obj.Id);
                        command.Parameters.Add("valorVeiculo", obj.valorVeiculo);
                        command.Parameters.Add("taxaRisco", obj.taxaRisco);
                        command.Parameters.Add("premioRisco", obj.premioRisco);
                        command.Parameters.Add("premioPuro", obj.premioPuro);
                        command.Parameters.Add("premioComercial", obj.premioComercial);
                        command.Parameters.Add("valorSeguro", obj.valorSeguro);


                        command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public virtual void Remove(Seguro obj)
        {
            try
            {
                string queryString = @"DELETE Seguros 
                                       WHERE Id=:Id";
                using (OracleConnection connection = new OracleConnection(configuration["OracleConnection:ConnectionString"]))
                {
                    OracleCommand command = new OracleCommand(queryString);
                    command.Connection = connection;
                    try
                    {
                        connection.Open();

                        command.Parameters.Add("Id", obj.Id);

                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void Dispose()
        {
            //_context.Dispose();
            GC.SuppressFinalize(this);
        }
        public async Task<IEnumerable<Seguro>> GetAllAsync()
        {
            try
            {
                string queryString = @"SELECT Id,valorVeiculo,taxaRisco,premioRisco,premioPuro,premioComercial,marcaVeiculo,modeloVeiculo,Nome,CPF,Idade
                                       FROM Seguros";
                using (OracleConnection connection = new OracleConnection(configuration["OracleConnection:ConnectionString"]))
                {
                    OracleCommand command = new OracleCommand(queryString);
                    command.Connection = connection;
                    try
                    {
                        connection.Open();


                        return await connection.QueryAsync<Seguro>(queryString);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw ex;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
