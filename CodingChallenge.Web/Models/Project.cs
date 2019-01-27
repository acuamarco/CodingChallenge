using System;

namespace CodingChallenge.Web.Models
{
    public class Project
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime AssignedDate { get; set; }
        public string TimeToStart
        {
            get
            {
                if (StartDate.Date >= AssignedDate.Date) {
                    return StartDate.Subtract(AssignedDate).Days.ToString();
                }
                else
                {
                    return "Started";
                }
            }
        }
        public DateTime EndDate { get; set; }
        public int Credits { get; set; }
        public bool IsActive { get; set; }
        public string Status
        {
            get
            {
                return IsActive ? "Active" : "Inactive";
            }
        }
    }
}
