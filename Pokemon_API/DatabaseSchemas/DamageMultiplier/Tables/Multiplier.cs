﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

using Pokemon_API.Extensions;

namespace Pokemon_API.DatabaseSchemas.DamageMultiplier.Tables
{
    public class Multiplier : TableQueries<Models.Multiplier>
    {
        public override string Database => "DamageMultipliers";
        public override string TableName => "Multipliers";

        public Multiplier() { }

        public override DatabaseConnector GetDatabaseConnector()
        {
            connection.SetDatabase(Database);
            return base.GetDatabaseConnector();
        }

        public async Task<Models.Multiplier> Get(string name)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"name", name }
            };

            List<Models.Multiplier> result = await Get(dict);
            return result.FirstOrDefault();
        }

        public async Task<int?> Insert(Models.Multiplier obj) {
            int? result = await Insert(obj.ToDict());
            return result;
        }

        public async Task<int?> Delete(string name)
        {
            Dictionary<string, object> dict = new Dictionary<string, object>()
            {
                {"name", name }
            };

            int? result = await Delete(dict);
            return result;
        }

        public override Models.Multiplier DataReaderConverter(MySqlDataReader reader)
        {
            int id = int.Parse(reader["id"].ToString());
            string name = reader["name"].ToString();
            float normal = float.Parse(reader["normal"].ToString());
            float fighting = float.Parse(reader["fighting"].ToString());
            float flying = float.Parse(reader["flying"].ToString());
            float poison = float.Parse(reader["poison"].ToString());
            float ground = float.Parse(reader["ground"].ToString());
            float rock = float.Parse(reader["rock"].ToString());
            float bug = float.Parse(reader["bug"].ToString());
            float ghost = float.Parse(reader["ghost"].ToString());
            float steel = float.Parse(reader["steel"].ToString());
            float fire = float.Parse(reader["fire"].ToString());
            float water = float.Parse(reader["water"].ToString());
            float grass = float.Parse(reader["grass"].ToString());
            float electric = float.Parse(reader["electric"].ToString());
            float psychic = float.Parse(reader["psychic"].ToString());
            float ice = float.Parse(reader["ice"].ToString());
            float dragon = float.Parse(reader["dragon"].ToString());
            float dark = float.Parse(reader["dark"].ToString());
            float fairy = float.Parse(reader["fairy"].ToString());


            return new Models.Multiplier(
                Id: id,
                Name: name,
                Normal: normal,
                Fighting: fighting,
                Flying: flying,
                Poison: poison,
                Ground: ground,
                Rock: rock,
                Bug: bug,
                Ghost: ghost,
                Steel: steel,
                Fire: fire,
                Water: water,
                Grass: grass,
                Electric: electric,
                Psychic: psychic,
                Ice: ice,
                Dragon: dragon,
                Dark: dark,
                Fairy: fairy
            );
        }
    }
}