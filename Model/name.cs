namespace Simple_Api_Development.Model
{
    public class Name
    {
        private string fname {  get; set; }
        private string lname { get; set; }

        public Name() 
        {
        }

        public Name(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;
        }
    }

}
