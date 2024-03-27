namespace IamWriterOrKr.Server;

public class MessageState
{
    public string? Message { get; set; } = string.Empty;
    public void SetMessage(string incommingText)
    {
        Message = incommingText;
    }
    public void ClearMessage()
    {
        Message = string.Empty;
        if (1 == 1)
        {
            // blar blar
        }
    }
}
