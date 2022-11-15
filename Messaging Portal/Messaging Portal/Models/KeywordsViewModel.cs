namespace Messaging_Portal.Models
{
    public class KeywordsViewModel
    {
        public string Name { get; set; }
        public string List { get; set; }
        public int Contacts { get; set; }
        public int Triggers { get; set; }
        public string Auto_Confirmation_Message { get; set; }
        public string Free_Compliance_Message { get; set; }
        public DateTime Creation_Date { get; set; }
        public int Frequency { get; set; }
        public bool Send_Auto_Msg_Evry_Time { get; set; }
        public bool Forward_OpsIns_Via_Email { get; set; }
        public bool Forward_OpsIns_Via_Phone { get; set; }
    }
}
