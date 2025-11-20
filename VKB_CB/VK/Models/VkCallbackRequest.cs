namespace VK.Models
{
    public class VkCallbackRequest
    {
        public string Type { get; set; } = "";
        public VkEvent? Object { get; set; }
        public string Secret { get; set; } = "";
        public int GroupId { get; set; }
    }
}
