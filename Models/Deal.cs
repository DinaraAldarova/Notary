using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Нотариус
{
	public class Deal
	{
		public const int ComissionPercent = 5;

		public int id;
		public int idClient;
		//посчитать сумму и комиссионные
		public double Total = 0;
		public double DiscontPercent = 0;
		public double Commission = 0;
		public string Description;
		public List<int> idServices;
		//убрать скидку на конкретную услугу
		public List<int> idDisconts;

		public Deal()
		{
			id = -1;
			idClient = 0;
			Description = "";

			idServices = new List<int>();
			idDisconts = new List<int>();
		}

		public Deal(int id, int idClient, string description)
		{
			this.id = id;
			this.idClient = idClient;
			Description = description;

			idServices = new List<int>();
			idDisconts = new List<int>();
		}

		public Deal(int idClient, string description)
		{
			id = -1;
			this.idClient = idClient;
			Description = description;

			idServices = new List<int>();
			idDisconts = new List<int>();
		}

		public Deal(DbDataRecord record)
		{
			id = Convert.ToInt32(record["id"].ToString());
			idClient = Convert.ToInt32(record["idClient"].ToString());
			Description = record["Description"].ToString();

			idServices = new List<int>();
			idDisconts = new List<int>();
		}

		public void AddService(int idService)
		{
			idServices.Add(idService);
		}

		public void AddDiscont(int idDiscont)
		{
			idDisconts.Add(idDiscont);
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
			string values = "'" + idClient + "'";

			if (Description != "")
			{
				names += ", " + "Description";
				values += ", '" + Description + "'";
			}

			string query = "";
			if (id == -1)
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
					id
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
				id
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
				id
				);
		}

		public string SQLServiceInsert()
		{
			string names = "idDeal, idService";
			string values = "";

			foreach (int idService in idServices)
			{
				values += ",(" + id + "," + idService + ")";
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
				id,
				idService
				);
		}

		public string SQLServiceDeleteAll()
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE {1} = {2};",
				"Deal_Services",
				"idDeal",
				id
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
				id
				);
		}

		public string SQLDiscontInsert()
		{
			if (idDisconts.Count == 0)
				return "";

			string names = "idDeal, idDiscont";
			string values = "";

			foreach(int idDiscont in idDisconts)
			{
				values += ",(" + id + "," + idDiscont + ")";
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
				id,
				idDiscont
				);
		}

		public string SQLDiscontDeleteAll()
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE {1} = {2};",
				"Deal_Disconts",
				"idDeal",
				id
				);
		}
        #endregion
    }
}