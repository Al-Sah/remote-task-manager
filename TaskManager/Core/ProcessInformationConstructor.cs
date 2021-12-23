using System;
using System.Diagnostics;

namespace TaskManager.Core
{
    public static class ProcessInformationConstructor
    {
        private const string Error = "- - - -";

        public static ProcessInformation FromProcess(Process process)
        {
            return new ProcessInformation
            {
                Path = (string) ValidateProperty(() => process.MainModule?.FileName, typeof(string)),
                Memory = (long) ValidateProperty(() => process.WorkingSet64, typeof(long)),
                Name = (string) ValidateProperty(() => process.ProcessName, typeof(string)),
                Id = (int) ValidateProperty(() => process.Id, typeof(int)),
                Priority = (string) ValidateProperty(() => process.PriorityClass, typeof(string)),
                Affinity = (int) ValidateProperty(() => process.ProcessorAffinity.ToInt32(), typeof(int))
            };
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