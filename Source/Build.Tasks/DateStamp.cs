using System;
using System.Globalization;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Build.Tasks
{
    /// <summary>
    /// Returns a date stamp in the form yyMMdd.
    /// </summary>
    public class DateStamp : Task
    {
        string date;

        /// <summary>
        /// Gets a <see cref="System.String"/> represting the date stamp.
        /// </summary>
        [Output]
        public string Date
        {
            get { return date; }
            private set { date = value; }
        }

        public override bool Execute()
        {
            try
            {
                Date = DateTime.Now.ToString("yyMMdd", CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                Log.LogErrorFromException(e);
                return false;
            }
            return true;
        }
    }
}
