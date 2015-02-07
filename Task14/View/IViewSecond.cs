using System;

namespace Task14.View
{
    public interface IViewSecond
    {
        event EventHandler<EventFileNameArgs> SetSecond;
        event EventHandler<EventFileNameArgs> AddToSecond;
        event EventHandler<EventFileNameArgs> DeleteToSecond;
        event EventHandler<EventFileNameArgs> ChangeToSecond;
    }
}
