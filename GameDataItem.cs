using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datacadia
{
    class GameDataItem
    {
        public long platform_id;
        public string file_name;
        public long gamedb_id = -1;
        public long genre_id = -1;
        public string crc = "NULL";
        public string game_load_string = "NULL";
        public string name = "NULL";
        public string description = "NULL";
        public string region_id = "NULL";
        public long release_year = -1;
        public string rating = "NULL";
        public string players = "NULL";
        public long co_op = -1;  // 1 true 0 false or -1 for not set
        public string publisher = "NULL";
        public long publisher_id = -1;
        public string developer = "NULL";
        public long developer_id = -1;
        public double users_stars = -1;
        public double gamedb_stars = -1;
        public string control_type = "NULL";
        public long active = -1; // 1 true 0 false or -1 for not set
        public long favourite = -1; // 1 true 0 false or -1 for not set
        public string clone_of = "NULL";

        public GameDataItem(long platform_id, string file_name)
        {
            this.platform_id = platform_id;
            this.file_name = file_name;
        }
    }
}
