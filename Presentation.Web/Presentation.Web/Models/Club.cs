using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Web.Models
{
    public class Club
    {
        public string Tag { get; set; }
        public Id Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
        public long BadgeId { get; set; }
        public Uri BadgeUrl { get; set; }
        public string Status { get; set; }
        public long MembersCount { get; set; }
        public long OnlineMembers { get; set; }
        public long Trophies { get; set; }
        public long RequiredTrophies { get; set; }
        public string Description { get; set; }
        public string Role { get; set; }
        public List<Member> Members { get; set; }
    }

    public class Member
    {
        public Id Id { get; set; }
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public long Trophies { get; set; }
        public bool OnlineLessThanOneHourAgo { get; set; }
        public long AvatarId { get; set; }
        public string NameColorCode { get; set; }
        public Uri AvatarUrl { get; set; }
    }
}
