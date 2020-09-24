using FossilHuntMVC.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using TabloidMVC.Repositories;

namespace FossilHuntMVC.Repositories
{
    public class UserProfileRepo : BaseRepo, IUserProfileRepository
    {
        public UserProfileRepo(IConfiguration config) : base(config)  { }


        public User GetByEmail(string email, string username)
        {

            using (var conn = Connection)
            {
                conn.Open();
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT id, username, email FROM Users WHERE email = @email AND username = @username";

                    User user = null;
                    var reader = cmd.ExecuteReader();

                    if(reader.Read())
                    {
                        user = new User()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Username = reader.GetString(reader.GetOrdinal("Username")),
                            Email = reader.GetString(reader.GetOrdinal("Email"))
                        };
                    }


                    reader.Close();

                    return user;
                }

                

            }
        }

    }
}
