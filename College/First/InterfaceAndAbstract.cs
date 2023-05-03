namespace InterfaceAndAbstract
{
    abstract class IUser
    {
        public int id { get; set; }
        public string name { get; set; }
        public IUser(int i, string n)
        {
            id = i;
            name = n;
        }
        public abstract void ShowInfo();
    }

    class User : IUser
    {
        public User(int i, string s) : base(i, s)
        {

        }
        public override void ShowInfo()
        {

        }
    }
}
