﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Domain
{
    [Serializable]
    public class KeteringMeni : IDomainObject
    {
        public int KeteringMeniID { get; set; }
        public string Predjelo { get; set; }
        public string GlavnoJelo { get; set; }
        public string Dezert { get; set; }
        public double CenaHranePoOsobi { get; set; }

        public KeteringFirma KeteringFirma { get; set; }

        public List<Rezervacija> Rezervacije { get; set; }

        public string TableName => "KeteringMeni";

        public string InsertValues => $"'{Predjelo}', '{GlavnoJelo}', '{Dezert}', {CenaHranePoOsobi}, {KeteringFirma.KeteringFirmaID}";

        public string IdCondition => $"KeteringMeniID = {KeteringMeniID}";

        public string UpdateValues => $"Predjelo = '{Predjelo}', GlavnoJelo = '{GlavnoJelo}', Dezert = '{Dezert}', CenaHranePoOsobi = {CenaHranePoOsobi}, KeteringFirmaID = {KeteringFirma.KeteringFirmaID}";

        public string SearchCondition => "CAST(KeteringFirmaID AS VARCHAR(100)) = @Kriterijum";

		public string Join => "join KeteringFirma on KeteringMeni.KeteringFirmaID=KeteringFirma.KeteringFirmaID";

        public string Id => $"KeteringMeniID";
		public string InsertUpdateDeleteCondition => "";


		public IDomainObject ReadObjectRow(SqlDataReader reader)
        {
            KeteringMeni km = new KeteringMeni();
            km.KeteringMeniID = (int)reader["KeteringMeniID"];
            km.Predjelo = (string)reader["Predjelo"];
            km.GlavnoJelo = (string)reader["GlavnoJelo"];
            km.Dezert = (string)reader["Dezert"];
            km.CenaHranePoOsobi = (double)reader["CenaHranePoOsobi"];
            km.KeteringFirma = new KeteringFirma
            {
                KeteringFirmaID = (int)reader["KeteringFirmaID"]
            };
            return km;
        }

        public IDomainObject ReadObjectRowJoin(SqlDataReader reader)
        {
            KeteringMeni km = new KeteringMeni();
            km.KeteringMeniID = (int)reader["KeteringMeniID"];
            km.Predjelo = (string)reader["Predjelo"];
            km.GlavnoJelo = (string)reader["GlavnoJelo"];
            km.Dezert = (string)reader["Dezert"];
            km.CenaHranePoOsobi = (double)reader["CenaHranePoOsobi"];
            km.KeteringFirma = new KeteringFirma
            {
                KeteringFirmaID = reader.GetInt32(5),
                NazivFirme = (string)reader["NazivFirme"],
                Telefon = (string)reader["Telefon"]
            };
            return km;
        }

		public override bool Equals(object obj)
		{
			if (obj is KeteringMeni km)
			{
				return km.KeteringMeniID == KeteringMeniID;
			}
			return false;
		}
		public override string ToString()
		{
			return $"{Predjelo}, {GlavnoJelo}, {Dezert}";
		}
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public void SetId(object id)
		{
            KeteringMeniID = (int)id;
		}
	}
}
