using System;

namespace WebApplication12.BL.helper
{
    //this class compare dates and ensure that startdate before finish date
    public static class DateValidator
    {
        public static bool validate(DateTime start, DateTime end)
        {
            if (start.Date >= end.Date)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
