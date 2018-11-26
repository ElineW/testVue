using System;

namespace ACM.BL
{
    public class Customer
    {
        private string _lastName { get; set; }
        public string Lastname; 
        public string FirstName { get; set; }
        public string EmailAddess { get; set; }
        public int CustomerId { get; set; }
        public string FullName
        {
            get
            {
                return Lastname + ", " + FirstName;
            }
        }
    }       
}
