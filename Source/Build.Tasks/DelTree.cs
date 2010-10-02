using System;
using System.Globalization;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Build.Tasks
{
    /// <summary>
    /// Deletes directory and all of its contents.
    /// Replaces RemoveDir task which exhibits different behavior
    /// on xbuild compared to msbuild: the first requires an empty
    /// directory, while the latter does not.
    /// </summary>
    public class DelTree : Task
    {
        string path;

        /// <summary>
        /// The filesystem path to delete.
        /// </summary>
        [Required]
        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public override bool Execute()
        {
            try
            {
                if (String.IsNullOrEmpty(Path) ||
                    System.IO.Directory.Exists(Path))
                {
                    return false;
                }
                else
                {
                    System.IO.Directory.Delete(Path, true);
                }
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
