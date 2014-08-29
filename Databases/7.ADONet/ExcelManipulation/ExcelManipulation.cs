namespace ExcelManipulation
{
    using System;
    using System.Data.OleDb;

    class ExcelManipulation
    {
        static void Main()
        {
            OleDbConnection dbConn = new OleDbConnection(Settings.Default.ConnectionString);

            dbConn.Open();
            using (dbConn)
            {
                //  Inserting Data
                OleDbCommand insertCommand = new OleDbCommand(
                    "INSERT INTO [Students$] (Name, Score) " +
                    "VALUES (@Name , @Score)",
                    dbConn);

                insertCommand.Parameters.AddWithValue("@Name", "Gosho");
                insertCommand.Parameters.AddWithValue("@Score", "65");

                insertCommand.ExecuteNonQuery();

                // Getting the data
                OleDbCommand command = new OleDbCommand("SELECT * FROM [Students$] ", dbConn);
                OleDbDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    while (reader.Read())
                    {
                        var studentName = (string)reader["Name"];
                        var studentScore = (string)reader["Score"];
                        Console.WriteLine("Student: {0} - Score: {1}", studentName, studentScore);
                    }
                }
            }
        }
    }
}
