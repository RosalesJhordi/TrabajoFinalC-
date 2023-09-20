using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Login
{
	public class Database
	{
		private readonly SQLiteAsyncConnection _database;

		public Database(string dbPath)
		{
			_database = new SQLiteAsyncConnection(dbPath);
			_database.CreateTableAsync<Estudiantes>();
		}

		public Task<List<Estudiantes>> GetPeopleAsync()
		{
			return _database.Table<Estudiantes>().ToListAsync();
		}

		public Task<int> SavePersonAsync(Estudiantes person)
		{
			return _database.InsertAsync(person);
		}
	}
}
