// Get system time.
using System;

DateTimeOffset utcNow = TimeProvider.System.GetUtcNow();
DateTimeOffset localNow = TimeProvider.System.GetLocalNow();

var timeSpan = TimeSpan.FromSeconds(1);

var timeProvider = new ZonedTimeProvider(TimeZoneInfo.Utc);
// Create a timer using a time provider.
ITimer timer = timeProvider.CreateTimer(() => Console.WriteLine("Timer Finished"), null, timeSpan, timeSpan);

// Measure a period using the system time provider.
long providerTimestamp1 = TimeProvider.System.GetTimestamp();
long providerTimestamp2 = TimeProvider.System.GetTimestamp();

var period = GetElapsedTime(providerTimestamp1, providerTimestamp2);

// Create a time provider that works with a
// time zone that's different than the local time zone.
internal class ZonedTimeProvider : TimeProvider
{
    private TimeZoneInfo _zoneInfo;

    public ZonedTimeProvider(TimeZoneInfo zoneInfo) : base()
    {
        _zoneInfo = zoneInfo ?? TimeZoneInfo.Local;
    }

    public override TimeZoneInfo LocalTimeZone => _zoneInfo;

    public static TimeProvider FromLocalTimeZone(TimeZoneInfo zoneInfo) =>
        new ZonedTimeProvider(zoneInfo);
}

