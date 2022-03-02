namespace nmnielsen.Service.DataTransferObjects;
public class ProjectDTO
{
    /// <summary>
    /// The project id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The project image name
    /// </summary>
    public string? Imagename { get; set; }

    /// <summary>
    /// The project name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The short project description
    /// </summary>
    public string? ShortDescription { get; set; }

    /// <summary>
    /// The project description
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The project start date
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// The project end date
    /// </summary>
    public DateTime EndDate { get; set; }

    /// <summary>
    /// The project isDeleted variable
    /// </summary>
    public bool IsDeleted { get; set; }
}