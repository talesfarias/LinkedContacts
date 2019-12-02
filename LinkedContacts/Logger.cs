using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using LinkedContacts.Properties;
using System.Threading.Tasks;

namespace LinkedContacts
{
    public class Logger
    {
        private static Logger instance = null;
        private Logger() { }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }
                return instance;    
            }
        }

        public void CreateLog(string logData, bool overwrite)
        {
            try
            {
                // If the files does not exist, it creates a file to write to.
                if (overwrite)
                    File.WriteAllText(Settings.Default["LogsLocation"].ToString() + @"\log.txt", DateTime.Now.ToString("HH:mm:ss tt") + logData + Environment.NewLine, Encoding.UTF8);
                else
                    File.AppendAllText(Settings.Default["LogsLocation"].ToString() + @"\log.txt", DateTime.Now.ToString("HH:mm:ss tt") + logData + Environment.NewLine, Encoding.UTF8);
            }
            catch (ArgumentException)
            {
                //Path is a zero-length string, contains only white space, or contains one or more invalid characters
            }
            catch (PathTooLongException)
            {
                //The specified path, file name, or both exceed the system-defined maximum length.
            }
            catch (DirectoryNotFoundException)
            {
                //The specified path is invalid (for example, the directory doesn't exist or it is on an unmapped drive).
            }
            catch (IOException)
            {
                //An I/O error occurred while opening the file.
            }
            catch (UnauthorizedAccessException)
            {
                //No permission. 
            }
        }
    }
}
