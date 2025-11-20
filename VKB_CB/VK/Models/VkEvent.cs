namespace VK.Models
{
    public class VkEvent
    {
        public MessageItem? Message { get; set; }
        public long? UserId { get; set; }
        // другие поля при необходимости
    }

    public class MessageItem
    {
        public long FromId { get; set; }
        public long PeerId { get; set; }
        public string? Text { get; set; }
    }
}
