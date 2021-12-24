namespace nmnielsen.Service.Services
{
    /// <summary>
    /// The MappingService. Used for Automapper so only 1 mapper is needed.
    /// </summary>
    public class MappingService : BaseService
    {
        public readonly AutoMapper.IMapper _mapper;
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingService"/> class.
        /// </summary>
        public MappingService()
        {
            AutoMapper.MapperConfiguration mapperConfig = new AutoMapper.MapperConfiguration(cfg =>
            {
                #region Class Mappings
                
                #endregion
            });

            try
            {
                _mapper = mapperConfig.CreateMapper();
            }
            catch (Exception ex)
            {
                LogError("Failed to create mappings", ex);
            }

        }
    }
}
