using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace SenseNet.Diagnostics
{
    public class EntLibLoggerAdapter : IEventLogger
    {
        public void Write(object message, ICollection<string> categories, int priority, int eventId, TraceEventType severity, string title, IDictionary<string, object> properties)
        {
            var props = properties ?? new Dictionary<string, object>();

            Microsoft.Practices.EnterpriseLibrary.Logging.Logger.Write(
                message ?? string.Empty, categories, priority, eventId, severity, title ?? string.Empty, props);
        }

        public void Write<T>(object message, ICollection<string> categories, int priority, int eventId,
            TraceEventType severity, string title, Func<T, IDictionary<string, object>> getPropertiesCallback, T callbackArg)
        {
            var properties = getPropertiesCallback != null
                                 ? getPropertiesCallback(callbackArg)
                                 : callbackArg as IDictionary<string, object>;

            Write(message, categories, priority, eventId, severity, title, properties);
        }
    }
}
