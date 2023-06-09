﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    public class Mesto : IDomainObject
    {
        public int MestoID { get; set; }
        public string Grad { get; set; }
        public int PostanskiBroj { get; set; }
        public string Adresa { get; set; }

        public List<Rezervacija> Rezervacije { get; set; }

        public string TableName => "Mesto";

        public string InsertValues => $"'{Grad}', {PostanskiBroj}, '{Adresa}'";

        public string UpdateValues => $"Grad = '{Grad}', PostanskiBroj = {PostanskiBroj}, Adresa = '{Adresa}'";

        public string SearchCondition { get; set; }

        public string IdCondition => $"MestoID = {MestoID}";

        public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            Mesto m = new Mesto();
            m.MestoID = (int)reader["MestoID"];
            m.Grad = (string)reader["Grad"];
            m.PostanskiBroj = (int)reader["PostanskiBroj"];
            m.Adresa = (string)reader["Adresa"];
            return m;
        }
    }
}
