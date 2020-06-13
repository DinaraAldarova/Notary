using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using Нотариус.Models;

namespace Нотариус
{
    public class DBNotary
    {
		public string databaseName = @"notary.db";
		private SQLiteConnection connection;
		private string[] scripts = {
			@"BEGIN TRANSACTION;",
			@"CREATE TABLE IF NOT EXISTS 'Deal_Disconts' (
				'id'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
				'idDeal'	INTEGER NOT NULL,
				'idDiscont'	INTEGER NOT NULL,
				FOREIGN KEY('idDeal') REFERENCES 'Deals'('id'),
				FOREIGN KEY('idDiscont') REFERENCES 'Disconts'('id')
			);",
			@"CREATE TABLE IF NOT EXISTS 'Deal_Services' (
				'id'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
				'idDeal'	INTEGER NOT NULL,
				'idService'	INTEGER NOT NULL,
				FOREIGN KEY('idDeal') REFERENCES 'Deals'('id'),
				FOREIGN KEY('idService') REFERENCES 'Services'('id')
			);",
			@"CREATE TABLE IF NOT EXISTS 'Disconts' (
				'id'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
				'Name'	TEXT NOT NULL,
				'Description'	TEXT NOT NULL,
				'Percent'	REAL NOT NULL
			);",
			@"CREATE TABLE IF NOT EXISTS 'Deals' (
				'id'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
				'idClient'	INTEGER NOT NULL,
				'Description'	TEXT NOT NULL,
				FOREIGN KEY('idClient') REFERENCES 'Clients'('id')
			);",
			@"CREATE TABLE IF NOT EXISTS 'Services' (
				'id'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
				'Name'	TEXT NOT NULL,
				'Description'	TEXT NOT NULL,
				'Price'	REAL NOT NULL
			);",
			@"CREATE TABLE IF NOT EXISTS 'Clients' (
				'id'	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
				'Name'	TEXT NOT NULL,
				'Activity'	TEXT NOT NULL,
				'Address'	TEXT NOT NULL,
				'Phone'	TEXT NOT NULL
			);",
			@"COMMIT;"
			};
		private string log = "";

		public DBNotary()
		{
			connection = new SQLiteConnection(string.Format("Data Source={0};", databaseName));
		}

		public string Log => log;

		public void RecreateDB()
		{
			SQLiteConnection.CreateFile(databaseName);
			log = File.Exists(databaseName) ? "База данных создана\n" : "Ошибка при создании базы данных\n";

			connection.Open();
			for (int i = 0; i < scripts.Length; i++)
			{
				SQLiteCommand command = new SQLiteCommand(scripts[i], connection);
				log += command.ExecuteNonQuery() + "\n";
			}
			connection.Close();
		}

        #region Client
        public List<int> getClientId()
		{
			connection.Open();
			SQLiteCommand command = new SQLiteCommand(Client.SQLSelectId(), connection);
			SQLiteDataReader reader = command.ExecuteReader();
			List<int> list = new List<int>();

			foreach (DbDataRecord record in reader)
			{
				list.Add(Convert.ToInt32(record["id"].ToString()));
			}
			connection.Close();
			return list;
		}

		public Client getClient(int id)
		{
			connection.Open();
			SQLiteCommand command = new SQLiteCommand( Client.SQLSelect(id), connection);
			SQLiteDataReader reader = command.ExecuteReader();
			Client client = new Client();
			foreach (DbDataRecord record in reader)
			{
				//объект на самом деле только один, потому что ищется по первичному ключу
				//но я не нашла синтаксис для взятия этой строки
				client = new Client(record);
			}
			connection.Close();
			return client;
		}

		public int setClient(Client client)
		{
			connection.Open();

			SQLiteCommand command = new SQLiteCommand(client.SQLInsertOrUpdate(), connection);
			int result = command.ExecuteNonQuery();

			connection.Close();
			return result;
		}

		public int deleteClient(Client client)
		{
			connection.Open();

			SQLiteCommand command = new SQLiteCommand(client.SQLDelete(), connection);
			int result = command.ExecuteNonQuery();

			connection.Close();
			return result;
		}
        #endregion

        #region Deal
        public List<int> getDealId()
		{
			connection.Open();
			SQLiteCommand command = new SQLiteCommand(Deal.SQLSelectId(), connection);
			SQLiteDataReader reader = command.ExecuteReader();
			List<int> list = new List<int>();

			foreach (DbDataRecord record in reader)
			{
				list.Add(Convert.ToInt32(record["id"].ToString()));
			}
			connection.Close();
			return list;
		}

		public Deal getDeal(int id)
		{
			connection.Open();
			SQLiteCommand command = new SQLiteCommand(Deal.SQLSelect(id), connection);
			SQLiteDataReader reader = command.ExecuteReader();
			Deal deal = new Deal();
			foreach (DbDataRecord record in reader)
			{
				//объект на самом деле только один, потому что ищется по первичному ключу
				//но я не нашла синтаксис для взятия этой строки
				deal = new Deal(record);
			}

			command = new SQLiteCommand(deal.SQLServiceSelect(), connection);
			reader = command.ExecuteReader();
			foreach (DbDataRecord record in reader)
			{
				deal.idServices.Add(Convert.ToInt32(record["idService"].ToString()));
			}

			command = new SQLiteCommand(deal.SQLDiscontSelect(), connection);
			reader = command.ExecuteReader();
			foreach (DbDataRecord record in reader)
			{
				deal.idDisconts.Add(Convert.ToInt32(record["idDiscont"].ToString()));
			}

			connection.Close();
			return deal;
		}

		public int setDeal(Deal deal)
		{
			connection.Open();

			SQLiteCommand command = new SQLiteCommand(deal.SQLInsertOrUpdate(), connection);
			int result = command.ExecuteNonQuery();
			
			if (deal.id == -1)
			{
				connection.Close();
				deal.id = getDealId().Max();
				connection.Open();
			}

			command = new SQLiteCommand(deal.SQLDiscontDeleteAll(), connection);
			command.ExecuteNonQuery();

			command = new SQLiteCommand(deal.SQLServiceDeleteAll(), connection);
			command.ExecuteNonQuery();

			command = new SQLiteCommand(deal.SQLServiceInsert(), connection);
			command.ExecuteNonQuery();

			command = new SQLiteCommand(deal.SQLDiscontInsert(), connection);
			command.ExecuteNonQuery();

			connection.Close();
			return result;
		}

		public int deleteDeal(Deal deal)
		{
			connection.Open();

			SQLiteCommand command = new SQLiteCommand(deal.SQLDiscontDeleteAll(), connection);
			command.ExecuteNonQuery();

			command = new SQLiteCommand(deal.SQLServiceDeleteAll(), connection);
			command.ExecuteNonQuery();

			command = new SQLiteCommand(deal.SQLDelete(), connection);
			int result = command.ExecuteNonQuery();

			connection.Close();
			return result;
		}
		#endregion

		#region Service
		public List<int> getServiceId()
		{
			connection.Open();
			SQLiteCommand command = new SQLiteCommand(Service.SQLSelectId(), connection);
			SQLiteDataReader reader = command.ExecuteReader();
			List<int> list = new List<int>();

			foreach (DbDataRecord record in reader)
			{
				list.Add(Convert.ToInt32(record["id"].ToString()));
			}
			connection.Close();
			return list;
		}

		public Service getService(int id)
		{
			connection.Open();
			SQLiteCommand command = new SQLiteCommand(Service.SQLSelect(id), connection);
			SQLiteDataReader reader = command.ExecuteReader();
			Service service = new Service();
			foreach (DbDataRecord record in reader)
			{
				//объект на самом деле только один, потому что ищется по первичному ключу
				//но я не нашла синтаксис для взятия этой строки
				service = new Service(record);
			}
			connection.Close();
			return service;
		}

		public int setService(Service service)
		{
			connection.Open();

			SQLiteCommand command = new SQLiteCommand(service.SQLInsertOrUpdate(), connection);
			int result = command.ExecuteNonQuery();

			connection.Close();
			return result;
		}

		public int deleteService(Service service)
		{
			connection.Open();

			SQLiteCommand command = new SQLiteCommand(service.SQLDelete(), connection);
			int result = command.ExecuteNonQuery();

			connection.Close();
			return result;
		}
		#endregion

		#region Discont
		public List<int> getDiscontId()
		{
			connection.Open();
			SQLiteCommand command = new SQLiteCommand(Discont.SQLSelectId(), connection);
			SQLiteDataReader reader = command.ExecuteReader();
			List<int> list = new List<int>();

			foreach (DbDataRecord record in reader)
			{
				list.Add(Convert.ToInt32(record["id"].ToString()));
			}
			connection.Close();
			return list;
		}

		public Discont getDiscont(int id)
		{
			connection.Open();
			SQLiteCommand command = new SQLiteCommand(Discont.SQLSelect(id), connection);
			SQLiteDataReader reader = command.ExecuteReader();
			Discont discont = new Discont();
			foreach (DbDataRecord record in reader)
			{
				//объект на самом деле только один, потому что ищется по первичному ключу
				//но я не нашла синтаксис для взятия этой строки
				discont = new Discont(record);
			}
			connection.Close();
			return discont;
		}

		public int setDiscont(Discont discont)
		{
			connection.Open();

			SQLiteCommand command = new SQLiteCommand(discont.SQLInsertOrUpdate(), connection);
			int result = command.ExecuteNonQuery();

			connection.Close();
			return result;
		}

		public int deleteDiscont(Discont discont)
		{
			connection.Open();

			SQLiteCommand command = new SQLiteCommand(discont.SQLDelete(), connection);
			int result = command.ExecuteNonQuery();

			connection.Close();
			return result;
		}
        #endregion
    }
}

