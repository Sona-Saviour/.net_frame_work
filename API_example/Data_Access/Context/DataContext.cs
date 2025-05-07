﻿


using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data_Access.Context
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString;

        public DataContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("SQLConnection");
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

    }

    
}
