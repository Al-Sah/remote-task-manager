using System.Collections.Generic;

namespace ControlPanel.Core
{
    public interface IForbiddenProcessesManager
    {
        public string ManageForbidden(string name, ForbidAction action);

        public List<string> GetForbidden();

        public enum ForbidAction
        {
            Add,
            Delete
        }
    }
}