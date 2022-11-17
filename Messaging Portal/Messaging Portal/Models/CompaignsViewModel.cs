namespace Messaging_Portal.Models
{
    public class CompaignsViewModel
    {
        public string CompaignName { get; set; }
        public int Type { get; set; }
        public string Message { get; set; }
        public string OptOutMessage { get; set; }
        public string FallBackMessage { get; set; }
        public string FallBackOptOutMessage { get; set; }
        public string Subject { get; set; }
    }
}
