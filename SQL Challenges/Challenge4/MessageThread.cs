using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenges.Challenge4
{
    public class MessageThread
    {
        public int MessageThreadId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public List<User> UserId { get; set; }

    }
}
