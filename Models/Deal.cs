using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Нотариус
{
	public class Deal
	{
		public int id;
		public int idClient;
		public double Total;
		public double Commission;
		public string Description;
		public List<int> idServices;
		//public Service[] services;
		//убрать скидку на конкретную услугу
		public List<int> idDisconts;
		//public Discont[] disconts;

		public Deal()
		{
			id = -1;
			idClient = 0;
			Total = 0;
			Commission = 0;
			Description = "";
		}

		public Deal(int id, int IdClient)
		{
			this.id = id;
			idClient = IdClient;
			Total = 0;
			Commission = 0;
			Description = "";
		}

		public Deal(int IdClient)
		{
			id = -1;
			idClient = IdClient;
			Total = 0;
			Commission = 0;
			Description = "";
		}

		public Deal(DbDataRecord record)
		{
			id = Convert.ToInt32(record["id"].ToString());
			idClient = Convert.ToInt32(record["idClient"].ToString());
			Total = Convert.ToDouble(record["Total"].ToString());
			Commission = Convert.ToDouble(record["Commission"].ToString());
			Description = record["Description"].ToString();

			this.idServices = idServices;
			this.idDisconts = idDisconts;
		}

		public string SQLInsertOrUpdate()
		{
			string names = "idClient";
			string values = "'" + idClient + "'";

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

		public static string SQLSelectId()
		{
			return string.Format(
				"SELECT {0} FROM '{1}';",
				"id",
				"Deals"
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

		public string SQLDelete()
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE {1}={2};",
				"Deals",
				"id",
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

		public string SQLDiscontInsert()
		{
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
	}
}