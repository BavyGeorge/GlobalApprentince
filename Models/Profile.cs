﻿namespace Global_Intern.Models
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public string ProfileCV { get; set; }
        public string ProfileCoverLetter { get; set; }
        public virtual User User { get; set; }
    }
}
