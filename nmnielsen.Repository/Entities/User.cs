using System.ComponentModel.DataAnnotations;

namespace nmnielsen.Repository.Entities
{
    public class User
    {
        /// <summary>
        /// The user id
        /// </summary>
        [Required]
        public int Id { get; set; }

        /// <summary>
        /// The user username
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// The user password
        /// </summary>
        [Required]
        public string Password { get; set; }

        //Navigations Properties
        public UserInformation UserInformation { get; set; }
    }
}
