using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Нотариус
{
	public class Deal
	{
		public int Id;
		public int IdClient;
		//посчитать сумму и комиссионные
		public double Total;
		public double Commission;
		public string Description;
		public List<int> idServices;
		//убрать скидку на конкретную услугу
		public List<int> idDisconts;

		public Deal()
		{
			Id = -1;
			IdClient = 0;
			Total = 0;
			Commission = 0;
			Description = "";

			idServices = new List<int>();
			idDisconts = new List<int>();
		}

		public Deal(int id, int idClient, double total, double commission, string description)
		{
			Id = id;
			IdClient = idClient;
			Total = total;
			Commission = commission;
			Description = description;

			idServices = new List<int>();
			idDisconts = new List<int>();
		}

		public Deal(int idClient, double total, double commission, string description)
		{
			Id = -1;
			IdClient = idClient;
			Total = total;
			Commission = commission;
			Description = description;

			idServices = new List<int>();
			idDisconts = new List<int>();
		}

		public Deal(DbDataRecord record)
		{
			Id = Convert.ToInt32(record["id"].ToString());
			IdClient = Convert.ToInt32(record["idClient"].ToString());
			Total = Convert.ToDouble(record["Total"].ToString());
			Commission = Convert.ToDouble(record["Commission"].ToString());
			Description = record["Description"].ToString();

			idServices = new List<int>();
			idDisconts = new List<int>();
		}

		#region SQLDeal
		public static string SQLSelectId()
		{
			return string.Format(
				"SELECT {0} FROM '{1}';",
				"id",
				"Deals"
				);
		}

		public static string SQLSelect(int id)
		{
			return string.Format(
				"SELECT {0} FROM '{1}' WHERE {2}={3};",
				"*",
				"Deals",
				"id",
				id
				);
		}

		public static string SQLDelete(int id)
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE {1}={2};",
				"Deals",
				"id",
				id
				);
		}

		public string SQLInsertOrUpdate()
		{
			string names = "idClient";
			string values = "'" + IdClient + "'";

			if (Total != 0)
			{
				names += ", " + "Total";
				values += ", '" + Total + "'";
			}

			if (Commission != 0)
			{
				names += ", " + "Commission";
				values += ", '" + Commission + "'";
			}

			if (Description != "")
			{
				names += ", " + "Description";
				values += ", '" + Description + "'";
			}

			string query = "";
			if (Id == -1)
			{
				query = string.Format(
					"INSERT INTO {0} ({1}) VALUES ({2});",
					"Deals",
					names,
					values
					);
			}
			else
			{
				query = string.Format(
					"UPDATE {0} SET ({1}) = ({2}) WHERE {3}={4};",
					"Deals",
					names,
					values,
					"id",
					Id
					);
			}
			return query;
		}

		public string SQLDelete()
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE {1}={2};",
				"Deals",
				"id",
				Id
				);
		}
		#endregion

		#region SQLDealService
		public static string SQLServiceDelete(int id, int idService)
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE ({1}, {2}) = ({3}, {4});",
				"Deal_Services",
				"idDeal",
				"idService",
				id,
				idService
				);
		}

		public string SQLServiceSelect()
		{
			return string.Format(
				"SELECT {0} FROM '{1}' WHERE {2}={3};",
				"*",
				"Deal_Services",
				"idDeal",
				Id
				);
		}

		public string SQLServiceInsert()
		{
			string names = "idDeal, idService";
			string values = "";

			foreach (int idService in idServices)
			{
				values += ",(" + Id + "," + idService + ")";
			}

			values = values.Remove(0, 1);

			string query = "";
			if (idServices.Count > 0)
			{
				query = string.Format(
					"INSERT INTO {0} ({1}) VALUES {2};",
					"Deal_Services",
					names,
					values
					);
			}
			return query;
		}

		public string SQLServiceDelete(int idService)
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE ({1}, {2}) = ({3}, {4});",
				"Deal_Services",
				"idDeal",
				"idService",
				Id,
				idService
				);
		}

		public string SQLServiceDeleteAll()
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE {1} = {2};",
				"Deal_Services",
				"idDeal",
				Id
				);
		}
		#endregion

		#region SQLDealDiscont
		public static string SQLDiscontDelete(int id, int idDiscont)
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE ({1}, {2}) = ({3}, {4});",
				"Deal_Disconts",
				"idDeal",
				"idDiscont",
				id,
				idDiscont
				);
		}

		public string SQLDiscontSelect()
		{
			return string.Format(
				"SELECT {0} FROM '{1}' WHERE {2}={3};",
				"*",
				"Deal_Disconts",
				"idDeal",
				Id
				);
		}

		public string SQLDiscontInsert()
		{
			string names = "idDeal, idDiscont";
			string values = "";

			foreach(int idDiscont in idDisconts)
			{
				values += ",(" + Id + "," + idDiscont + ")";
			}

			values = values.Remove(0, 1);

			string query = "";
			if (idDisconts.Count > 0)
			{
				query = string.Format(
					"INSERT INTO {0} ({1}) VALUES {2};",
					"Deal_Disconts",
					names,
					values
					);
			}
			return query;
		}

		public string SQLDiscontDelete(int idDiscont)
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE ({1}, {2}) = ({3}, {4});",
				"Deal_Disconts",
				"idDeal",
				"idDiscont",
				Id,
				idDiscont
				);
		}

		public string SQLDiscontDeleteAll()
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE {1} = {2};",
				"Deal_Disconts",
				"idDeal",
				Id
				);
		}
        #endregion
    }
}