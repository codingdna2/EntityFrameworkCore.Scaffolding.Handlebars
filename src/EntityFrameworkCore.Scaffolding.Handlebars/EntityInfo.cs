namespace EntityFrameworkCore.Scaffolding.Handlebars
{
    /// <summary>
    /// Entity info.
    /// </summary>
    public class EntityInfo
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public EntityInfo() { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="entityName">Entity name.</param>
        /// <param name="entitySchema">Entity schema.</param>
        public EntityInfo(string entityName, string entitySchema)
        {
            EntitySchema = entitySchema;
            EntityName = entityName;
        }

        /// <summary>
        /// Property name.
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// Property type.
        /// </summary>
        public string EntitySchema { get; set; }
    }
}
