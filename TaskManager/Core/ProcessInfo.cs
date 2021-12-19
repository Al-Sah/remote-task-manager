using System;
using System.Diagnostics;

namespace TaskManager.Core
{
    public class ProcessInfo : ProcessInfoBase
    {
        private Process _process;
        private const string Error = "- - - -";


        public ProcessInfo(Process process) => GetData(process);

        private void GetData(Process process)
        {
            _process = process;

            // ReSharper disable once PossibleNullReferenceException
            Path = (string) ValidateProperty(() => _process.MainModule.FileName, string.Empty.GetType());

            Memory = (long) ValidateProperty(() => _process.WorkingSet64 / 1024, Memory.GetType()); // TO KBytes
            Name = (string) ValidateProperty(() => _process.ProcessName, string.Empty.GetType());
            Pid = (int) ValidateProperty(() => _process.Id, Pid.GetType());
            Priority = (string) ValidateProperty(() => _process.PriorityClass, string.Empty.GetType());
            ProcessorAffinity =
                (int) ValidateProperty(() => _process.ProcessorAffinity.ToInt32(), ProcessorAffinity.GetType());
        }

        private static object ValidateProperty(Func<object> valueGetter, Type toReturn)
        {
            // Win32Exception || InvalidOperationException || NullReferenceException
            try
            {
                if (toReturn == typeof(long) || toReturn == typeof(int))
                {
                    return valueGetter();
                }

                return valueGetter().ToString();
            }
            catch (Exception)
            {
                if (toReturn == typeof(long) || toReturn == typeof(int))
                {
                    return 0;
                }

                return Error;
            }
        }
    }
}