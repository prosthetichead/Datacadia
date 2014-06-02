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

        public void upsertGamesDataset(GameDataItem updateData)
        {
            DataRow[] gameRow = dsGames.Tables[0].Select(String.Format(@"file_name = '{0}'", updateData.file_name.Replace("'", "''"))); //Get the current row that we are going to edit.

            if (gameRow.Count() > 0) // this row already exists in the dataset, update it to our new values
            {
                if (updateData.gamedb_id != -1)
                    gameRow[0]["gamedb_id"] = updateData.gamedb_id;
                
                if (updateData.genre_id >= 0)
                    gameRow[0]["genre_id"] = updateData.genre_id;
                
                if (updateData.crc != "NULL")
                    gameRow[0]["crc"] = updateData.genre_id;
                
                if (updateData.game_load_string != "NULL")
                    gameRow[0]["game_load_string"] = updateData.game_load_string;
                
                if (updateData.name != "NULL")
                    gameRow[0]["name"] = updateData.name;
                
                if (updateData.description != "NULL")
                    gameRow[0]["description"] = updateData.description;
                
                if (updateData.region_id != "NULL")
                    gameRow[0]["region_id"] = updateData.region_id;
                
                if (updateData.release_year >= 0)
                    gameRow[0]["release_year"] = updateData.release_year;
                
                if (updateData.rating != "NULL")
                    gameRow[0]["rating"] = updateData.rating;

                if (updateData.players != "NULL")
                {
                    if (updateData.players == "4+")
                        gameRow[0]["players"] = 4;
                    else
                        gameRow[0]["players"] = updateData.players;
                }
                
                if (updateData.co_op == 0 || updateData.co_op == 1)
                    gameRow[0]["co_op"] = updateData.co_op;
                
                if (updateData.publisher != "NULL")
                    gameRow[0]["publisher"] = updateData.publisher;
                
                if (updateData.publisher_id >= 0)
                    gameRow[0]["publisher_id"] = updateData.publisher_id;
                
                if (updateData.developer != "NULL")
                    gameRow[0]["developer"] = updateData.developer;
                
                if (updateData.developer_id >= 0)
                    gameRow[0]["developer_id"] = updateData.developer_id;

                if (updateData.users_stars >= 0)
                    gameRow[0]["users_stars"] = updateData.users_stars;

                if (updateData.gamedb_stars >= 0)
                    gameRow[0]["gamedb_stars"] = updateData.gamedb_stars;

                if (updateData.control_type != "NULL")
                    gameRow[0]["control_type"] = updateData.control_type;

                if (updateData.active == 0 || updateData.active == 1)
                    gameRow[0]["active"] = updateData.active;

                if (updateData.favourite == 0 || updateData.favourite == 1)
                    gameRow[0]["favourite"] = updateData.favourite;

                if (updateData.clone_of != "NULL")
                    gameRow[0]["clone_of"] = updateData.clone_of;
            }
            else // this is a whole new row, add it to the ds
            {
                DataRow newRow = dsGames.Tables[0].NewRow();
                
                newRow["file_name"] = updateData.file_name;
                newRow["platform_id"] = updateData.platform_id;


                if (updateData.gamedb_id != -1)
                    newRow["gamedb_id"] = updateData.gamedb_id;
                else
                    newRow["gamedb_id"] = 0;

                if (updateData.genre_id >= 0)
                    newRow["genre_id"] = updateData.genre_id;
                else
                    newRow["genre_id"] = 0;
                
                if (updateData.crc != "NULL")
                    newRow["crc"] = updateData.crc;
                else
                    newRow["crc"] = "NONE";

                if (updateData.game_load_string != "NULL")
                    newRow["game_load_string"] = updateData.game_load_string;
                else
                    newRow["game_load_string"] = "";

                if (updateData.name != "NULL")
                    newRow["name"] = updateData.name;
                else
                    newRow["name"] = "No Name Entered";

                if (updateData.description != "NULL")
                    newRow["description"] = updateData.description;
                else
                    newRow["description"] = "";

                if (updateData.region_id != "NULL")
                    newRow["region_id"] = updateData.region_id;
                else
                    newRow["region_id"] = "NONE";

                if (updateData.release_year >= 0)
                    newRow["release_year"] = updateData.release_year;
                else
                    newRow["release_year"] = 0;

                if (updateData.rating != "NULL")
                    newRow["rating"] = updateData.rating;
                else
                    newRow["rating"] = "";

                if (updateData.players != "NULL")
                    newRow["players"] = updateData.players;
                else
                    newRow["players"] = 0;


                if (updateData.publisher != "NULL")
                    newRow["publisher"] = updateData.publisher;
                else
                    newRow["publisher"] = "";

                if (updateData.publisher_id >= 0)
                    newRow["publisher_id"] = updateData.publisher_id;
                else
                    newRow["publisher_id"] = 0;

                if (updateData.developer != "NULL")
                    newRow["developer"] = updateData.developer;
                else
                    newRow["developer"] = "";

                if (updateData.developer_id >= 0)
                    newRow["developer_id"] = updateData.developer_id;
                else
                    newRow["developer_id"] = 0;

                if (updateData.users_stars >= 0)
                    newRow["users_stars"] = updateData.users_stars;
                else
                    newRow["users_stars"] = 0;

                if (updateData.gamedb_stars >= 0)
                    newRow["gamedb_stars"] = updateData.gamedb_stars;
                else
                    newRow["gamedb_stars"] = 0;

                if (updateData.control_type != "NULL")
                    newRow["control_type"] = updateData.control_type;
                else
                    newRow["control_type"] = "";

                if (updateData.active == 0 || updateData.active == 1)
                    newRow["active"] = updateData.active;
                else
                    newRow["active"] = 0;

                if (updateData.favourite == 0 || updateData.favourite == 1)
                    newRow["favourite"] = updateData.favourite;
                else
                    newRow["favourite"] = 0;

                if (updateData.co_op == 0 || updateData.co_op == 1)
                    newRow["co_op"] = updateData.co_op;
                else
                    newRow["co_op"] = 0;


                if (updateData.clone_of != "NULL")
                    newRow["clone_of"] = updateData.clone_of;
                else
                    newRow["clone_of"] = "NONE";

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

        public string getRegionID(string region)
        {
            string region_id = "NONE";

            var command = conn.CreateCommand();
            command.CommandText = "SELECT id from regions where name = @region_name or alt_names like @region_name_like";
            command.Parameters.AddWithValue("@region_name", region);
            command.Parameters.AddWithValue("@region_name_like", "%\"" + region + "\"%");

            SQLiteDataReader reader = command.ExecuteReader();

            reader.Read();
            if (reader.HasRows)
            {
                region_id = reader[0] as string;
                if (region_id == null)
                    region_id = "NONE";
            }
            else
                region_id = "NONE";
            return region_id;
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
            long? gamedb_id= 0;
            
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
                    if (gamedb_id == null)
                    {
                        gamedb_id = 0;
                    }
                }

                return gamedb_id.GetValueOrDefault();
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
