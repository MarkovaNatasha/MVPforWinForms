using System;

namespace Task14.View
{
    public class EventFileNameArgs :EventArgs
    {
        public string FileName { get; private set; }
        public EventFileNameArgs(string name)
        {
            FileName = name;
        }
    }
}
