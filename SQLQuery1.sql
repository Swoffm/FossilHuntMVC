SELECT q.Id AS questionId, q.UserId, q.Question, q.State, u.id, u.username, u.email
FROM ForumQuestion q LEFT JOIN Users u ON q.UserId = u.Id;