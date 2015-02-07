using System;

namespace Task14.View
{
    public interface IView : IViewFirst, IViewSecond
    {
        event EventHandler<EventArgs> Synchronize;
    }
}
