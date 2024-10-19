using DataLayer;
using Models1;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BusinessServices
    {
        private readonly ScheduleData1 _scheduleData;

        public BusinessServices()
        {
            _scheduleData = new ScheduleData1();
        }

        ////public async Task<List<Schedule>> GetSchedulesAsync()
        //{
        //    try
        //    {
        //        //return await _scheduleData.GetSchedulesAsync();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the exception (implement your logging mechanism here)
        //        throw new ApplicationException("An error occurred while fetching schedules.", ex);
        //    }
        //}

        ////public async Task<bool> AddScheduleAsync(Schedule schedule)
        //{
        //    try
        //    {
        //        //return await _scheduleData.AddScheduleAsync(schedule);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the exception (implement your logging mechanism here)
        //        throw new ApplicationException("An error occurred while adding the schedule.", ex);
        //    }
        //}

        //public async Task<bool> DeleteScheduleAsync(string className, string subject, string professor)
        //{
        //    try
        //    {
        //        return await _scheduleData.DeleteScheduleAsync(className, subject, professor);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Log the exception (implement your logging mechanism here)
        //        throw new ApplicationException("An error occurred while deleting the schedule.", ex);
        //    }
        //}
    }
}
