using BookApp.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class EventModel
    {
       
        public int EventId { get; set; }
        public string UserId { get; set; }

        [Required(ErrorMessage = " Please Enter title of the book")]
        [Display(Name = "Title of the Book")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter the Event Date")]
        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        [DateValidator]
        public DateTime Date { get; set; }

        [Display(Name = "Start Time")]
        [Required(ErrorMessage = "Please Enter the start time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "Please Enter the venue")]
        [Display(Name = "Venue")]
        public string Location { get; set; }

        [MaxLength(50)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [MaxLength(500)]
        [Display(Name = "OtherDetails")]
        public string OtherDetails { get; set; }

        [Range(1, 4, ErrorMessage = " Duration should be 1-4 hours only")]
        public int? Duration { get; set; }


        [Display(Name = "Is Private")]
        public bool IsPrivate { get; set; }


        [Display(Name = "Invite People")]
        public string InviteByEmail { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }
    }
}
