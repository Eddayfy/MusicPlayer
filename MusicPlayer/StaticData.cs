using MusicPlayer.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MusicPlayer
{
    public static class StaticData
    {
        public class LogException
        {
            public string Type;
            public string Message;
            public string Source;
            public string File;
            public string Caller;
            public string Linenumber;
            public string MyMessage;
            public string Time;
            public string Stacktrace;
            public string Tostring;

            public static string FileLog;
        }

        public static void ShowException(Exception exception, string message = "", [CallerLineNumber] int lineNumber = 0, [CallerMemberName] string caller = null, [CallerFilePath] string file = null)
        {
            bool ShowError = true;
            string ExceptionType = exception.GetType().FullName.Replace(Environment.NewLine, "");
            string ExceptionMessage = exception.Message.Replace(Environment.NewLine, "");
            string ExceptionSource = exception.Source.Replace(Environment.NewLine, "");
            string ExceptionStackTrace = exception.StackTrace.Replace(Environment.NewLine, "");
            string ExceptionToString = exception.ToString().Replace(Environment.NewLine, "");

            if (ShowError)
            {
                MessageBox.Show(
                        "type: ==>" + ExceptionType + "\n\n" +
                        "message: ==>" + ExceptionMessage + "\n\n" +
                        "source: ==>" + ExceptionSource + "\n\n" +
                        "file: ==>" + file + "\n\n" +
                        "caller: ==>" + caller + "\n\n" +
                        "lineNumber: ==>" + lineNumber.ToString() + "\n\n" +
                        "MyMessage: ==>" + message + "\n\n" +
                        "time: ==>" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n\n" + "\n\n" +
                        "stackTrace: ==>" + ExceptionStackTrace + "\n\n" +
                        "toString: ==>" + ExceptionToString
                        );
            }
            else
            {
                MessageBox.Show("Oups\nC'est de ma faute, quelque chose s'est mal passé. Je travaille à régler ce problème dès que possible. Si cela vous empêche d'accéder à une fonction importante, veuillez appeler le développeur.\n\n" + ExceptionMessage, "L'application a rencontré une erreur inconnue.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                try
                {
                    if (File.Exists(StaticData.LogException.FileLog))
                    {
                        // Read existing json data
                        var jsonData = File.ReadAllText(StaticData.LogException.FileLog);

                        // De-serialize to object or create new list
                        var LogExceptionList = JsonConvert.DeserializeObject<List<LogException>>(jsonData) ?? new List<LogException>();

                        LogExceptionList.Add(new LogException()
                        {
                            Type = ExceptionType,
                            Message = ExceptionMessage,
                            Source = ExceptionSource,
                            File = file,
                            Caller = caller,
                            Linenumber = lineNumber.ToString(),
                            MyMessage = message,
                            Time = DateTime.Now.ToString(),
                            Stacktrace = ExceptionStackTrace,
                            Tostring = ExceptionToString
                        });

                        // Update json data string
                        jsonData = JsonConvert.SerializeObject(LogExceptionList, Formatting.Indented);
                        File.WriteAllText(StaticData.LogException.FileLog, jsonData);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }

    }

}
