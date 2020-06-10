using System;
using System.Data.Common;

namespace Нотариус
{
	public class Discont
	{
		public int id;
		public string Name;
		public string Description;
		public double Percent;
		public double Value;

		public Discont()
		{
			id = -1;
			Name = "";
			Description = "";
			Percent = 0;
			Value = 0;
		}

		public Discont(int id, string name)
		{
			this.id = id;
			Name = name;
			Description = "";
			Percent = 0;
			Value = 0;
		}

		public Discont(string name)
		{
			id = -1;
			Name = name;
			Description = "";
			Percent = 0;
			Value = 0;
		}

		public Discont(DbDataRecord record)
		{
			id = Convert.ToInt32(record["id"].ToString());
			Name = record["Name"].ToString();
			Description = record["Description"].ToString();
			Percent = string.IsNullOrEmpty(record["Percent"].ToString()) ? 0 : Convert.ToDouble(record["Percent"].ToString());
			Value = string.IsNullOrEmpty(record["Value"].ToString()) ? 0 : Convert.ToDouble(record["Value"].ToString());
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

			if (Percent != 0)
			{
				names += ", " + "Percent";
				values += ", '" + Percent + "'";
			}
			else
			{
				names += ", " + "Value";
				values += ", '" + Value + "'";
			}

			string query = "";
			if (id == -1)
			{
				query = string.Format(
					"INSERT INTO {0} ({1}) VALUES ({2});",
					"Disconts",
					names,
					values
					);
			}
			else
			{
				query = string.Format(
					"UPDATE {0} SET ({1}) = ({2}) WHERE {3}={4};",
					"Disconts",
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
				"Disconts",
				"id",
				id
				);
		}

		public static string SQLSelectId()
		{
			return string.Format(
				"SELECT {0} FROM '{1}';",
				"id",
				"Disconts"
				);
		}

		public static string SQLDelete(int id)
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE {1}={2};",
				"Disconts",
				"id",
				id
				);
		}

		public string SQLDelete()
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE {1}={2};",
				"Disconts",
				"id",
				id
				);
		}
	}
}