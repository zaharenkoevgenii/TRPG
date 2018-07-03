using System.Collections.Generic;
using System.Data.SQLite;
using Library.Entities.Enumerables;
using Library.Entities.Factories;
using Library.Entities.Items.Armors;

namespace Library.DataAccess
{
    public static class DataStorage
    {
        private const string DatabaseName = "armors";
        private const string DatabaseExtension = ".sqlite";
        private const string SqliteVersion = "3";

        private static readonly string ConnectionString = $"Data Source={DatabaseName}{DatabaseExtension};Version={SqliteVersion};";

        private static SQLiteCommand command;
        private static SQLiteConnection connection;

        static DataStorage()
        {
            CreateTable();
        }

        private static void CreateTable()
        {
            using (connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = @"CREATE TABLE IF NOT EXISTS Armors (
                    Id                  INTEGER        NOT NULL
                                                       PRIMARY KEY
                                                       UNIQUE,
                    Name                NVARCHAR (100) UNIQUE
                                                       NOT NULL
                                                       DEFAULT unnamedArmor,
                    Type                INT            NOT NULL
                                                       DEFAULT (0),
                    Price               DOUBLE         NOT NULL
                                                       DEFAULT (0),
                    BaseArmor           INT            NOT NULL
                                                       DEFAULT (10),
                    MaxAgility          INT            DEFAULT (0) 
                                                       NOT NULL,
                    StrengthCap         INT            DEFAULT (20) 
                                                       NOT NULL,
                    StealthDisadvantage BOOLEAN        NOT NULL
                                                       DEFAULT (1),
                    Weight              INT            DEFAULT (100) 
                                                       NOT NULL
                );";
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void CreateItem(IArmor armor)
        {
            using (connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                command = connection.CreateCommand();
                command.CommandText = $@"
                    INSERT INTO Armors (Id, Name, Type, Price, BaseArmor, MaxAgility,StrengthCap,StealthDisadvantage,Weight)
                    VALUES ('{armor.Id}', '{armor.Name}', '{(int) armor.Type}', '{armor.Price}', '{
                        armor.BaseArmor
                    }', '{armor.MaxAgility}','{armor.StrengthCap}', '{armor.StealthDisadvantage}', '{armor.Weight}');";
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static List<IArmor> ReadItems()
        {
            using (connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var armors = new List<IArmor>();
                var myCommand = new SQLiteCommand("SELECT * FROM Armors", connection);
                var reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    var armor = ArmorFactory.CreateArmor();
                    armor.Id = (uint)reader.GetInt32(0);
                    armor.Name = reader.GetString(1);
                    armor.Type = (ArmorType) reader.GetInt32(2);
                    armor.Price = (ulong) reader.GetInt32(3);
                    armor.BaseArmor = (byte) reader.GetInt32(4);
                    armor.MaxAgility = (byte) reader.GetInt32(5);
                    armor.StrengthCap = (byte) reader.GetInt32(6);
                    armor.StealthDisadvantage = reader.GetBoolean(7);
                    armor.Weight = (byte) reader.GetInt32(8);
                    armors.Add(armor);
                }

                connection.Close();
                return armors;
            }
        }

        public static IArmor ReadItem(uint id)
        {
            using (connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                IArmor armor = null;
                var query = $@"
                    SELECT * 
                    FROM Armors 
                    WHERE Id = '{id}'";
                var myCommand = new SQLiteCommand(query, connection);
                var reader = myCommand.ExecuteReader();
                while (reader.Read())
                {
                    armor = ArmorFactory.CreateArmor();
                    armor.Id = (uint)reader.GetInt32(0);
                    armor.Name = reader.GetString(1);
                    armor.Type = (ArmorType) reader.GetInt32(2);
                    armor.Price = (ulong) reader.GetInt32(3);
                    armor.BaseArmor = (byte) reader.GetInt32(4);
                    armor.MaxAgility = (byte) reader.GetInt32(5);
                    armor.StrengthCap = (byte) reader.GetInt32(6);
                    armor.StealthDisadvantage = reader.GetBoolean(7);
                    armor.Weight = (byte) reader.GetInt32(8);
                }

                connection.Close();
                return armor;
            }
        }

        public static void UpdateItem(IArmor armor)
        {
            using (connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var query = $@"
                    UPDATE Armors 
                    SET 
                        name = '{armor.Name}', 
                        type = '{(int) armor.Type}', 
                        price = '{armor.Price}', 
                        basearmor = '{armor.BaseArmor}', 
                        maxagility='{armor.MaxAgility}', 
                        strengthcap='{armor.StrengthCap}', 
                        StealthDisadvantage='{(armor.StealthDisadvantage ? 1 : 0)}', 
                        Weight='{armor.Weight}' 
                    WHERE Id='{armor.Id}'";
                var myCommand = new SQLiteCommand(query, connection);
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }

        public static void DeleteItem(uint id)
        {
            using (connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                var query = $@"
                    DELETE FROM Armors 
                    WHERE id = '{id}'";
                var myCommand = new SQLiteCommand(query, connection);
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}