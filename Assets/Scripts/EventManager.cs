using System;

public class EventManager : Singleton<EventManager>
{
    public event Action OnGlorpEvent;

    public void OnGlorp() => OnGlorpEvent?.Invoke();
}
