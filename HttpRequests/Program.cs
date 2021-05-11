using HttpRequests;

namespace T
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sender sender = new ();
            sender.SendAsync().GetAwaiter().GetResult();
        }
    }
}
