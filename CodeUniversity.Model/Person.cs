﻿using System.Collections.Generic;

namespace CodeUniversity.Model
{
    public class Person
    {
        public Person()
        {
            Gender = " ";
            ImageSource = string.Empty;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Blog { get; set; }
        public string Twitter { get; set; }
        public string Gender { get; set; }
        public string ImageSource { get; set; }
        public string Bio { get; set; }


        public virtual ICollection<Session> SpeakerSession { get; set; }
        public virtual ICollection<Attendance> AttendanceList { get; set; }
    }
}