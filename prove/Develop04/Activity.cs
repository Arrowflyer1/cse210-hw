using System;
using System.Threading;

public abstract class Activity
{
    protected int durationInSeconds;

    public Activity(int duration)
    {
        durationInSeconds = duration;
    }

    public abstract void Start();
}
