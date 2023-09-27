﻿using Serilog.Events;
using Serilog.Formatting;

namespace Cheetah.Domain;
public class CustomLogEventFormatter : ITextFormatter
{
    public static CustomLogEventFormatter Formatter { get; } = new CustomLogEventFormatter();

    public void Format(LogEvent logEvent, TextWriter output)
    {
        logEvent.Properties.ToList()
            .ForEach(e => output.Write($"{e.Key}={e.Value} "));
    }
}