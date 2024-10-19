using Models1;

namespace BusinessLayer
{
    public class Schedule
    {
        public string Class { get; set; }
        public string Day { get; set; }
        public string Subject { get; set; }
        public string Time { get; set; }
        public string Professor { get; set; }


        public bool AddSchedule(string? classInput, string? dayInput, string? subjectInput, string? timeInput, string? professorInput)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSchedule(string? classInputs, string? dayInputs, string? subjectInputs, string? professorInputs)
        {
            throw new NotImplementedException();
        }

        public List<Scheds> GetSchedules()
        {
            throw new NotImplementedException();
        }
    }
}