namespace Azure.Monitor.OpenTelemetry.Exporter
{
    public static partial class AzureMonitorExporterHelperExtensions
    {
        public static OpenTelemetry.Trace.TracerProviderBuilder AddAzureMonitorTraceExporter(this OpenTelemetry.Trace.TracerProviderBuilder builder, System.Action<Azure.Monitor.OpenTelemetry.Exporter.AzureMonitorExporterOptions> configure = null) { throw null; }
    }
    public static partial class AzureMonitorExporterLoggingExtensions
    {
        public static OpenTelemetry.Logs.OpenTelemetryLoggerOptions AddAzureMonitorLogExporter(this OpenTelemetry.Logs.OpenTelemetryLoggerOptions loggerOptions, System.Action<Azure.Monitor.OpenTelemetry.Exporter.AzureMonitorExporterOptions> configure = null) { throw null; }
    }
    public static partial class AzureMonitorExporterMetricExtensions
    {
        public static OpenTelemetry.Metrics.MeterProviderBuilder AddAzureMonitorMetricExporter(this OpenTelemetry.Metrics.MeterProviderBuilder builder, System.Action<Azure.Monitor.OpenTelemetry.Exporter.AzureMonitorExporterOptions> configure = null) { throw null; }
    }
    public partial class AzureMonitorExporterOptions : Azure.Core.ClientOptions
    {
        public AzureMonitorExporterOptions(Azure.Monitor.OpenTelemetry.Exporter.AzureMonitorExporterOptions.ServiceVersion version = Azure.Monitor.OpenTelemetry.Exporter.AzureMonitorExporterOptions.ServiceVersion.V2020_09_15_Preview) { }
        public string ConnectionString { get { throw null; } set { } }
        public bool DisableOfflineStorage { get { throw null; } set { } }
        public string StorageDirectory { get { throw null; } set { } }
        public Azure.Monitor.OpenTelemetry.Exporter.AzureMonitorExporterOptions.ServiceVersion Version { get { throw null; } set { } }
        public enum ServiceVersion
        {
            V2020_09_15_Preview = 1,
        }
    }
    public partial class AzureMonitorTraceExporter : OpenTelemetry.BaseExporter<System.Diagnostics.Activity>
    {
        public AzureMonitorTraceExporter(Azure.Monitor.OpenTelemetry.Exporter.AzureMonitorExporterOptions options) { }
        public override OpenTelemetry.ExportResult Export(in OpenTelemetry.Batch<System.Diagnostics.Activity> batch) { throw null; }
    }
}
