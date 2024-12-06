namespace Iam.Client.Pages
{
    public partial class Chat
    {
        private string title;
        public string? Name { get; set; }
        public int Age { get; set; }

        public List<Chat> chatList = [];
        public Chat()
        {
            title = "Chat";
        }

        protected override void OnInitialized()
        {
            for (int i = 0; i < 10; i++)
            {
                chatList.Add(new Chat { Name = "User " + i, Age = i });
            }
        }

        public void SetTitle()
        {
            title = "Hello World";
        }
    }
}
