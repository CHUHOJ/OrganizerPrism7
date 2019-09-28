﻿using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace OrganizerPrism7.Model
{
    public class Person
    {
        public Person()
        {
            PhoneNumbers = new Collection<PersonPhoneNumber>();
            Meetings = new Collection<Meeting>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        public int? FavouriteLanguageId { get; set; }

        public ProgrammingLanguage FavouriteLanguage { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        public ICollection<PersonPhoneNumber> PhoneNumbers { get; set; }

        public ICollection<Meeting> Meetings { get; set; }
    }
}
