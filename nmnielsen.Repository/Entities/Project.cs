using System.ComponentModel.DataAnnotations;

namespace nmnielsen.Repository.Entities;
public class Project
{
    /// <summary>
    /// The project id
    /// </summary>
    [Required]
    public int Id { get; set; }

    /// <summary>
    /// The project image name
    /// </summary>
    [Required]
    public string? Imagename { get; set; }

    /// <summary>
    /// The project name
    /// </summary>
    [Required]
    public string? Name { get; set; }

    /// <summary>
    /// The short project description
    /// </summary>
    [MaxLength(50)]
    public string? ShortDescription { get; set; }

    /// <summary>
    /// The project description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The project status message
    /// </summary>
    [Required]
    public string? StatusMessage { get; set; }

    /// <summary>
    /// The project start date
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// The project end date
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// The project isHidden variable
    /// </summary>
    [Required]
    public bool IsHidden { get; set; }

    /// <summary>
    /// The project isDeleted variable
    /// </summary>
    [Required]
    public bool IsDeleted { get; set; }
}