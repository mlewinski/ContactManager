namespace ContactManager.Model
{
    public class Phone : Communicator
    {
        public string Number { get; set; }
        public string Network { get; set; } //autodetection of operator's network
    }
}
