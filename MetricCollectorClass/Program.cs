using System.Diagnostics.Metrics;
using System.Diagnostics;

MeterOptions options = new MeterOptions("name")
{
    Version = "version",
    // Attach these tags to the created meter
    Tags = new TagList() { { "MeterKey1", "MeterValue1" }, { "MeterKey2", "MeterValue2" } }
};

Meter meter = meterFactory.Create(options);

Instrument instrument = meter.CreateCounter<int>("counter", null, null, new TagList() { { "counterKey1", "counterValue1" } });
instrument.Add(1);