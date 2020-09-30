using FossilHuntMVC.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabloidMVC.Repositories;

namespace FossilHuntMVC.Repositories
{
    public class QuestionRepo : BaseRepo, IQuestionRepo
    {
        public QuestionRepo(IConfiguration config) : base(config) { }

        public List<Question> GetAll()
        {

            using(var conn = Connection)
            {

                conn.Open();
                using(var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT q.Id AS questionId, q.UserId, q.Question, q.State, u.id, u.username, u.email FROM ForumQuestion q LEFT JOIN Users u ON q.UserId = u.Id";

                    var reader = cmd.ExecuteReader();

                    var QuestionList = new List<Question>();

                    while(reader.Read())
                    {
                        QuestionList.Add(new Question()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("questionId")),
                            userId = reader.GetInt32(reader.GetOrdinal("UserId")),
                            StateId = reader.GetInt32(reader.GetOrdinal("StateId")),
                            question = reader.GetString(reader.GetOrdinal("Question")),
                            user = new User
                            {
                                Username = reader.GetString(reader.GetOrdinal("username"))
                            }

                        });


                    }

                    reader.Close();
                    return QuestionList
                }
            }
        }
    }
}
