using System;

namespace TaskManager
{
    [Serializable]
    public class ProcessInfoBase
    {
        public string Priority { get; set; }
        public string Name { get; set; }
        public int ProcessorAffinity { get; set; }
        public long Memory { get; set; }
        public string Path { get; set; }
        public int Pid { get; set; }
    }
}