using Models1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DataLayer
{
    public class ScheduleData1
    {
        private readonly string connectionString = "Data Source=ANGELICA\\SQLEXPRESS02; Initial Catalog=ClassScheduleManagementAPI; Integrated Security=True;";

        public async Task<List<Scheds>> GetSchedulesAsync()
        {
            var schedules = new List<Scheds>();
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                string selectStatement = "SELECT Class, Day, Subject, Time, Professor FROM Class";
                var selectCommand = new SqlCommand(selectStatement, sqlConnection);
                await sqlConnection.OpenAsync(); // Use OpenAsync for async method
                using (var reader = await selectCommand.ExecuteReaderAsync()) // Use ExecuteReaderAsync for async
                {
                    while (await reader.ReadAsync()) // Use ReadAsync for async
                    {
                        schedules.Add(new Scheds
                        {
                            Class = reader["Class"].ToString(),
                            Day = reader["Day"].ToString(),
                            Subject = reader["Subject"].ToString(),
                            Time = reader["Time"].ToString(),
                            Professor = reader["Professor"].ToString()
                        });
                    }
                }
            }
            return schedules;
        }

        public async Task<bool> AddScheduleAsync(Scheds schedule)
        {
            string insertStatement = "INSERT INTO Class (Class, Day, Subject, Time, Professor) VALUES (@Class, @Day, @Subject, @Time, @Professor)";
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var insertCommand = new SqlCommand(insertStatement, sqlConnection);
                insertCommand.Parameters.AddWithValue("@Class", schedule.Class);
                insertCommand.Parameters.AddWithValue("@Day", schedule.Day);
                insertCommand.Parameters.AddWithValue("@Subject", schedule.Subject);
                insertCommand.Parameters.AddWithValue("@Time", schedule.Time);
                insertCommand.Parameters.AddWithValue("@Professor", schedule.Professor);

                await sqlConnection.OpenAsync(); // Use OpenAsync for async method
                return await insertCommand.ExecuteNonQueryAsync() > 0; // Use ExecuteNonQueryAsync for async
            }
        }

        public async Task<bool> DeleteScheduleAsync(string className, string subject, string professor)
        {
            string deleteStatement = "DELETE FROM Class WHERE Class = @Class AND Subject = @Subject AND Professor = @Professor";
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                var deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
                deleteCommand.Parameters.AddWithValue("@Class", className);
                deleteCommand.Parameters.AddWithValue("@Subject", subject);
                deleteCommand.Parameters.AddWithValue("@Professor", professor);

                await sqlConnection.OpenAsync(); // Use OpenAsync for async method
                return await deleteCommand.ExecuteNonQueryAsync() > 0; // Use ExecuteNonQueryAsync for async
            }
        }
    }
}
