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
        public DataSet dsGames;
        SQLiteDataAdapter daGames;
        public struct gameData{
           public long platform_id;
           public string file_name;
           public string gamedb_id;
           public long genre_id;
           public string crc;
           public string game_load_string;
           public string name;
           public string description;
           public string region_id;
           public long release_year;
           public string rating;
           public string players;
           public bool? co_op;
           public string publisher;
           public string developer;
           public double users_stars;
           public double gamedb_stars;
           public string control_type;
           public bool? active;
           public bool? favourite;
           public string clone_of;
        }


        public dbHandle()
        {
            dsGames = new DataSet();

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

        public void refreshGameDataset(long platform_id)
        {
            dsGames.Clear();
            try
            {
                string sql = "select * from games where platform_id = " + platform_id;
                daGames = new SQLiteDataAdapter(sql, conn);
                daGames.Fill(dsGames);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                throw;
            }
        }

        public void saveGamesDataset()
        {
            try
            {
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(daGames);
                daGames.Update(dsGames.Tables[0]);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public void upsertGamesDataset(gameData updateData)
        {
            DataRow[] gameRow = dsGames.Tables[0].Select(String.Format(@"file_name = '{0}'", updateData.file_name.Replace("'", "''"))); //Get the current row that we are going to edit.

            if (gameRow.Count() > 0) // this row already exists in the dataset, update it to our new values
            {
                if (updateData.gamedb_id != null)
                    gameRow[0]["gamedb_id"] = updateData.gamedb_id;
                if (updateData.genre_id >= 0)
                    gameRow[0]["genre_id"] = updateData.genre_id;
                if (updateData.crc != null)
                    gameRow[0]["crc"] = updateData.genre_id;
                if (updateData.game_load_string != null)
                    gameRow[0]["game_load_string"] = updateData.game_load_string;
                if (updateData.name != null)
                    gameRow[0]["name"] = updateData.name;
                if (updateData.description != null)
                    gameRow[0]["description"] = updateData.description;
                if (updateData.region_id != null)
                    gameRow[0]["region_id"] = updateData.region_id;
                if (updateData.release_year >= 0)
                    gameRow[0]["release_year"] = updateData.release_year;
                if (updateData.rating != null)
                    gameRow[0]["rating"] = updateData.rating;
                if (updateData.players != null)
                    gameRow[0]["players"] = updateData.players;
                if (updateData.co_op != null)
                    gameRow[0]["co_op"] = updateData.co_op;
                if (updateData.publisher != null)
                    gameRow[0]["publisher"] = updateData.publisher;
                if (updateData.developer != null)
                    gameRow[0]["developer"] = updateData.developer;
                if (updateData.users_stars >= 0)
                    gameRow[0]["users_stars"] = updateData.users_stars;
                if (updateData.gamedb_stars >= 0)
                    gameRow[0]["gamedb_stars"] = updateData.gamedb_stars;
                if (updateData.control_type != null)
                    gameRow[0]["control_type"] = updateData.control_type;
                if (updateData.active != null)
                    gameRow[0]["active"] = updateData.active;
                if (updateData.favourite != null)
                    gameRow[0]["favourite"] = updateData.favourite;
                if (updateData.clone_of != null)
                    gameRow[0]["clone_of"] = updateData.clone_of;
            }
            else // this is a whole new row, add it to the ds
            {
                DataRow newRow = dsGames.Tables[0].NewRow();
                
                newRow["file_name"] = updateData.file_name;
                newRow["platform_id"] = updateData.platform_id;


                if (updateData.gamedb_id != null)
                    newRow["gamedb_id"] = updateData.gamedb_id;
                else
                    newRow["gamedb_id"] = 0;

                if (updateData.genre_id > 0)
                    newRow["genre_id"] = updateData.genre_id;
                else
                    newRow["genre_id"] = 0;
                
                if (updateData.crc != null)
                    newRow["crc"] = updateData.crc;
                else
                    newRow["crc"] = "";

                if (updateData.game_load_string != null)
                    newRow["game_load_string"] = updateData.game_load_string;
                else
                    newRow["game_load_string"] = "";

                if (updateData.name != null)
                    newRow["name"] = updateData.name;
                else
                    newRow["name"] = "";

                if (updateData.description != null)
                    newRow["description"] = updateData.description;
                else
                    newRow["description"] = "";

                if (updateData.region_id != null)
                    newRow["region_id"] = updateData.region_id;
                else
                    newRow["region_id"] = "NONE";

                if (updateData.release_year > 0)
                    newRow["release_year"] = updateData.release_year;
                else
                    newRow["release_year"] = 0;

                if (updateData.rating != null)
                    newRow["rating"] = updateData.rating;
                else
                    newRow["rating"] = "";

                if (updateData.players != null)
                    newRow["players"] = updateData.players;
                else
                    newRow["players"] = "";
                
                if (updateData.publisher != null)
                    newRow["publisher"] = updateData.publisher;
                else
                    newRow["publisher"] = "";

                if (updateData.developer != null)
                    newRow["developer"] = updateData.developer;
                else
                    newRow["developer"] = "";

                if (updateData.users_stars >= 0)
                    newRow["users_stars"] = updateData.users_stars;
                else
                    newRow["users_stars"] = 0;

                if (updateData.gamedb_stars >= 0)
                    newRow["gamedb_stars"] = updateData.gamedb_stars;
                else
                    newRow["gamedb_stars"] = 0;

                if (updateData.control_type != null)
                    newRow["control_type"] = updateData.control_type;
                else
                    newRow["control_type"] = "";

                if (updateData.active != null)
                    newRow["active"] = updateData.active;
                else
                    newRow["active"] = 0;

                if (updateData.favourite != null)
                    newRow["favourite"] = updateData.favourite;
                else
                    newRow["favourite"] = 0;

                if (updateData.co_op != null)
                    newRow["co_op"] = updateData.co_op;
                else
                    newRow["co_op"] = 0;


                if (updateData.clone_of != null)
                    newRow["clone_of"] = updateData.clone_of;
                else
                    newRow["clone_of"] = "none";

                dsGames.Tables[0].Rows.Add(newRow);
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

        public long getRegionID(string region)
        {
            long? region_id = 0;

            var command = conn.CreateCommand();
            command.CommandText = "SELECT id from regions where name = @region_name or alt_names like @region_name_like";
            command.Parameters.AddWithValue("@region_name", region);
            command.Parameters.AddWithValue("@region_name_like", "%\"" + region + "\"%");

            SQLiteDataReader reader = command.ExecuteReader();

            reader.Read();
            if (reader.HasRows)
            {
                region_id = reader[0] as long?;
                if (region_id == null)
                    region_id = 0;
            }
            else
                region_id = 0;
            return region_id.GetValueOrDefault();
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

        public string getGameDB_ID(long? platform_id, string file_name)
        {
            string gamedb_id= "0";
            
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
                    gamedb_id = reader[0] as string;
                    if (gamedb_id == "" || gamedb_id == null)
                    {
                        gamedb_id = "0";
                    }
                }

                return gamedb_id;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "\n\nplatform ID = " + platform_id + "\nGame File Name = " + file_name);
                throw;
            }
            
        }

        public void SaveDataTable(DataSet DS, string sql)
        {
            try
            {
                conn.Close();
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = string.Format(sql);
                var adapter = new SQLiteDataAdapter(command);
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(adapter);
                adapter.Update(DS);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            
        }


    }


}
