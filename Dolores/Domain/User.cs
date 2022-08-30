namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class User : Entity
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<UserUseCase> UseCases { get; set; } = new HashSet<UserUseCase>();
        public virtual ICollection<Orderline> Orderlines { get; set; } = new HashSet<Orderline>();
        public virtual ICollection<Log> Logs { get; set; } = new HashSet<Log>();
    }
}
