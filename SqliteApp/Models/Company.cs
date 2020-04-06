using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqliteApp.Models
{
    public class Company
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
    }
}
