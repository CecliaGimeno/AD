using System;
using MySql.Data.MySqlClient;

namespace PCategoria
{
	public class App
	{

		private App ()
		{
		}

		private static App instance= new App();

		public static App Instance {
			get{return instance;}
		}

		private MySqlConnection mySqlConnection ;

		public MySqlConnection MySqlConnection{
			get{ return mySqlConnection;}
			set{ mySqlConnection = value;}
		}
	}
}

