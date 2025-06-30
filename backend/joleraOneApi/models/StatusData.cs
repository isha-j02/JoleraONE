namespace JoleraOneApi.Models
{
    public class Alert
    {
        public string Type { get; set; }
        public string Status { get; set; }
    }

    public class StatusData
    {
        public string Uptime { get; set; }
        public int TicketsToday { get; set; }
        public List<Alert> Alerts { get; set; }
    }
}
