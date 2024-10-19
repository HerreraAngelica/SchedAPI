using Models1;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataLayer
{
    public class SqlDbData1
    {
        static string connectionString = "Data Source=ANGELICA\\SQLEXPRESS02; Initial Catalog=ClassScheduleManagementAPI; Integrated Security=True;";

       static SqlConnection sqlConnection = new SqlConnection(connectionString);

        public static void Connect()
        {
            sqlConnection.Open();
        }

        //public List<Scheds> GetSchedules()
        //{
        //    var schedules = new List<Scheds>();
        //    using (var sqlConnection = new SqlConnection(connectionString))
        //    {
        //        string selectStatement = "SELECT Class, Day, Subject, Time, Professor FROM Class";
        //        var selectCommand = new SqlCommand(selectStatement, sqlConnection);
        //        sqlConnection.Open();
        //        using (var reader = selectCommand.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                schedules.Add(new Scheds
        //                {
        //                    Class = reader["Class"].ToString(),
        //                    Day = reader["Day"].ToString(),
        //                    Subject = reader["Subject"].ToString(),
        //                    Time = reader["Time"].ToString(),
        //                    Professor = reader["Professor"].ToString()
        //                });
        //            }
        //        }
        //    }
        //    return schedules;
        //}

        //public int AddSchedule(Scheds schedule)
        //{
        //    string insertStatement = "INSERT INTO Class (Class, Day, Subject, Time, Professor) VALUES (@Class, @Day, @Subject, @Time, @Professor)";
        //    using (var sqlConnection = new SqlConnection(connectionString))
        //    {
        //        var insertCommand = new SqlCommand(insertStatement, sqlConnection);
        //        insertCommand.Parameters.AddWithValue("@Class", schedule.Class);
        //        insertCommand.Parameters.AddWithValue("@Day", schedule.Day);
        //        insertCommand.Parameters.AddWithValue("@Subject", schedule.Subject);
        //        insertCommand.Parameters.AddWithValue("@Time", schedule.Time);
        //        insertCommand.Parameters.AddWithValue("@Professor", schedule.Professor);

        //        sqlConnection.Open();
        //        return insertCommand.ExecuteNonQuery();
        //    }
        //}

        //public int DeleteSchedule(string className, string subject, string professor)
        //{
        //    string deleteStatement = "DELETE FROM Class WHERE Class = @Class AND Subject = @Subject AND Professor = @Professor";
        //    using (var sqlConnection = new SqlConnection(connectionString))
        //    {
        //        var deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
        //        deleteCommand.Parameters.AddWithValue("@Class", className);
        //        deleteCommand.Parameters.AddWithValue("@Subject", subject);
        //        deleteCommand.Parameters.AddWithValue("@Professor", professor);

        //        sqlConnection.Open();
        //        return deleteCommand.ExecuteNonQuery();
        //    }
        //}

        //public List<Scheds> GetSchedulesForDay(string day, string subject, string professor)
        //{
        //    var schedules = new List<Scheds>();
        //    using (var sqlConnection = new SqlConnection(connectionString))
        //    {
        //        string selectStatement = "SELECT Class, Day, Subject, Time, Professor FROM Class WHERE Day = @Day AND Subject = @Subject AND Professor = @Professor";
        //        var selectCommand = new SqlCommand(selectStatement, sqlConnection);
        //        selectCommand.Parameters.AddWithValue("@Day", day);
        //        selectCommand.Parameters.AddWithValue("@Subject", subject);
        //        selectCommand.Parameters.AddWithValue("@Professor", professor);

        //        sqlConnection.Open();
        //        using (var reader = selectCommand.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                schedules.Add(new Scheds
        //                {
        //                    Class = reader["Class"].ToString(),
        //                    Day = reader["Day"].ToString(),
        //                    Subject = reader["Subject"].ToString(),
        //                    Time = reader["Time"].ToString(),
        //                    Professor = reader["Professor"].ToString()
        //                });
        //            }
        //        }
        //    }
        //    return schedules;
        //}
    }
}
