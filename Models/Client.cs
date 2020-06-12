using System;
using System.Data.Common;

namespace Нотариус.Models
{
	public class Client
    {
        public int id;
        public string Name;
        public string Activity;
        public string Address;
        public string Phone;

        public Client()
        {
            id = -1;
            Name = "";
            Activity = "";
            Address = "";
            Phone = "";
        }

		public Client(int id, string name, string activity, string address, string phone)
		{
			this.id = id;
			Name = name;
			Activity = activity;
			Address = address;
			Phone = phone;
		}

		public Client(string name, string activity, string address, string phone)
		{
			id = -1;
			Name = name;
			Activity = activity;
			Address = address;
			Phone = phone;
		}

		public Client(DbDataRecord record)
		{
			id = Convert.ToInt32(record["id"].ToString());
			Name = record["Name"].ToString();
			Activity = record["Activity"].ToString();
			Address = record["Address"].ToString();
			Phone = record["Phone"].ToString();
		}

		public static string SQLSelectId()
		{
			return string.Format(
				"SELECT {0} FROM '{1}';",
				"id",
				"Clients"
				);
		}

		public static string SQLSelect(int id)
		{
			return string.Format(
				"SELECT {0} FROM '{1}' WHERE {2}={3};",
				"*",
				"Clients",
				"id",
				id
				);
		}

		public static string SQLDelete(int id)
		{
			return string.Format(
				"DELETE FROM '{0}' WHERE {1}={2};",
				"Clients",
				"id",
				id
				);
		}

		public string SQLInsertOrUpdate()
        {
			string names = "Name";
			string values = "'" + Name + "'";

			if (Activity != "")
			{
				names += ", " + "Activity";
				values += ", '" + Activity + "'";
			}

			if (Address != "")
			{
				names += ", " + "Address";
				values += ", '" + Address + "'";
			}

			if (Phone != "")
			{
				names += ", " + "Phone";
				values += ", '" + Phone + "'";
			}

			string query = "";
			if (id == -1)
			{
				query = string.Format(
					"INSERT INTO {0} ({1}) VALUES ({2});",
					"Clients",
					names,
					values
					);
			}
			else
			{
				query = string.Format(
					"UPDATE {0} SET ({1}) = ({2}) WHERE {3}={4};",
					"Clients",
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
				"Clients",
				"id",
				id
				);
		}
	}
}
