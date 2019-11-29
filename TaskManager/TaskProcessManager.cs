using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TaskManager
{
    public static class TaskProcessManager
    {
        public static List<Process> GetListProcesses()
        {
            List<Process> processesToReturn = new List<Process>();
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                processesToReturn.Add(process);
            }

            return processesToReturn;
        }

        public static bool DeleteProcess(int Id)
        {
            try
            {
                Process.GetProcessById(Id).Kill();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
