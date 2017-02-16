using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlClassGenerator.Global
{
    public static class CustomEnums
    {
        /// <summary>
        /// The different sql providers
        /// </summary>
        public enum Provider
        {
            /// <summary>
            /// MsSQL
            /// </summary>
            MsSql,
            /// <summary>
            /// MySQL
            /// </summary>
            MySql,
            /// <summary>
            /// Default value
            /// </summary>
            None
        }
    }
}
