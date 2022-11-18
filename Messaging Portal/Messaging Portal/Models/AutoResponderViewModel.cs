using Microsoft.AspNetCore.Mvc;

namespace Messaging_Portal.Models
{
    public class AutoResponderViewModel
    {
        public string Name { get; set; }
        public string Message { get; set; }
        public bool isScheduled { get; set; }
        public int TimeType { get; set; }
        public int Time { get; set; }
    }
}
