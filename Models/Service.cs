using System;
using System.Data.Common;

namespace Нотариус
{
	public class Service
	{
		public int id;
		public string Name;
		public string Description;
		public double Price;


		public Service()
		{
			id = -1;
			Name = "";
			Description = "";
			Price = 0;
		}

		public Service(int id, string name, string description, double price)
		{
			this.id = id;
			Name = name;
			Description = description;
			Price = price;
		}

		public Service(string name, string description, double price)
		{
			id = -1;
			Name = name;
			Description = description;
			Price = price;
		}

		public Service(DbDataRecord record)
		{
			id = Convert.ToInt32(record["id"].ToString());
			Name = record["Name"].ToString();
			Description = record["Description"].ToString();
			Price = Convert.ToInt32(record["Price"].ToString());
		}

		public static string SQLSelectId()
		{
			return string.Format(
				"SELECT {0} FROM '{1}';",
				"id",
				"Services"
				);
		}

		public static string SQLSelect(int id)
		{
			return string.Format(
				"SELECT {0} FROM '{1}' WHERE {2}={3};",
				"*",
				"Services",
				"id",
				id
				);
		}

		public static string SQLDelete(int id)
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE {1}={2};",
				"Services",
				"id",
				id
				);
		}

		public string SQLInsertOrUpdate()
		{
			string names = "Name";
			string values = "'" + Name + "'";

			if (Description != "")
			{
				names += ", " + "Description";
				values += ", '" + Description + "'";
			}

			if (Price != 0)
			{
				names += ", " + "Price";
				values += ", '" + Price + "'";
			}

			string query = "";
			if (id == -1)
			{
				query = string.Format(
					"INSERT INTO {0} ({1}) VALUES ({2});",
					"Services",
					names,
					values
					);
			}
			else
			{
				query = string.Format(
					"UPDATE {0} SET ({1}) = ({2}) WHERE {3}={4};",
					"Services",
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
				"Services",
				"id",
				id
				);
		}
	}
}