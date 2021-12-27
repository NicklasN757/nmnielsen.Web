using System.ComponentModel.DataAnnotations;

namespace nmnielsen.Repository.Entities
{
    public class UserInformation
    {
        /// <summary>
        /// The user id
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// The user first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The user last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The user created date
        /// </summary>
        [Required]
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// The user isAdmin variable
        /// </summary>
        [Required]
        public bool IsAdmin { get; set; }

        //Navigations Properties
        public User User { get; set; }
    }
}
