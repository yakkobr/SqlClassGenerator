using SqlClassGenerator.Global;

namespace SqlClassGenerator.DataObjects
{
    public class MappingModel
    {
        /// <summary>
        /// Gets or sets the provider
        /// </summary>
        public CustomEnums.Provider Provider { get; set; } = CustomEnums.Provider.None;

        /// <summary>
        /// Gets or sets the sql type
        /// </summary>
        public string SqlType { get; set; } = "";

        /// <summary>
        /// Gets or sets the c# type
        /// </summary>
        public string CSharpType { get; set; } = "";
    }
}
