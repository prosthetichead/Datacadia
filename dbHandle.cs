using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Diagnostics;

namespace Datacadia
{


    class dbHandle
    {
        private string dbLocation;
        SQLiteConnection conn;

        public dbHandle()
        {

        }

        public bool connect(string path)
        {
            dbLocation = path;
            conn = new SQLiteConnection("Data Source=" + dbLocation + ";Version=3;");
            try
            {
                if (File.Exists(dbLocation))
                {
                    conn.Open();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return false;
            }
        }

        public DataSet getDataSet(string sql)
        {
            DataSet ds = new DataSet();

            try
            {
                //conn.Open();
                var da = new SQLiteDataAdapter(sql, conn);
                da.Fill(ds);
                //conn.Close();
                return ds;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                //conn.Close();
                return ds;
            }
        }

        public bool gameExists(long? platform_id, string file_name)
        {
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = "SELECT count(*) from games where platform_id = @platform_id and file_name = @file_name";
                command.Parameters.AddWithValue("@platform_id", platform_id);
                command.Parameters.AddWithValue("@file_name", file_name);

                SQLiteDataReader reader = command.ExecuteReader();

                reader.Read();
                long? count = reader[0] as long?;
                               
                if (count > 0)
                {
                    return true;
                }
                else
                    return false;
                
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "\n" + file_name);
                throw;
            }
        }

        public long getGenreID(string genre)
        {
            long? genre_id = 0;

            var command = conn.CreateCommand();
            command.CommandText = "SELECT id from genres where genre_name = @genre_name or alt_names like @genre_name_like";
            command.Parameters.AddWithValue("@genre_name", genre);
            command.Parameters.AddWithValue("@genre_name_like", "%\"" + genre + "\"%");

            SQLiteDataReader reader = command.ExecuteReader();

            reader.Read();
            if (reader.HasRows)
            {
                genre_id = reader[0] as long?;
                if (genre_id == null)
                    genre_id = 0;
            }
            else
                genre_id = 0;
            return genre_id.GetValueOrDefault();
        }

        public void sqlExecute(SQLiteCommand command)
        {
            try
            {
                command.Connection = conn;
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "\n" + command.CommandText);
                throw;
            }
        }

        public long getGameDB_ID(long? platform_id, string file_name)
        {
            long? gamedb_id = 0;
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = "SELECT gamedb_id from games where platform_id = @platform_id and file_name = @file_name";
                command.Parameters.AddWithValue("@platform_id", platform_id);
                command.Parameters.AddWithValue("@file_name", file_name);

                SQLiteDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    gamedb_id = reader[0] as long?;
                }

                return gamedb_id.GetValueOrDefault(); 
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "\n\nplatform ID = " + platform_id + "\nGame File Name = " + file_name);
                throw;
            }
            
        }

        public void SaveDataTable(DataSet DS, string table_name)
        {
            try
            {
                var command = conn.CreateCommand();
                command.CommandText = string.Format("SELECT * FROM {0}", table_name);
                var adapter = new SQLiteDataAdapter(command);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
                adapter.Update(DS.GetChanges());
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }


    }


}
