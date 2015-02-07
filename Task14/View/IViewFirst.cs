using System;

namespace Task14.View
{
    public interface IViewFirst
    {
        event EventHandler<EventFileNameArgs> SetFirst;
        event EventHandler<EventFileNameArgs> AddToFirst;
        event EventHandler<EventFileNameArgs> DeleteToFirst;
        event EventHandler<EventFileNameArgs> ChangeToFirst;
    }
}
