namespace Dostava.Models
{
   
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }        
        public string Email { get; set; }
        public string FirstName { get; set; }    
        public string LastName { get; set; }
        public string ?Adress { get; set; }  
        public string ?UserPicture { get; set; }
        public string UserType { get; set; }


    }
}
