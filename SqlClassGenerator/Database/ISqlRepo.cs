using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlClassGenerator.DataObjects;

namespace SqlClassGenerator.Database
{
    interface ISqlRepo
    {
        /// <summary>
        /// Sets the database
        /// </summary>
        /// <param name="database">The name of the database</param>
        void SetDatabase(string database);
        /// <summary>
        /// Gets the available databases
        /// </summary>
        /// <returns>List of databases</returns>
        List<string> GetDatabases();
        /// <summary>
        /// Gets the available tables
        /// </summary>
        /// <returns>List of tables</returns>
        List<string> GetTables();
        /// <summary>
        /// Gets the information for a given table
        /// </summary>
        /// <param name="tableName">The name of the table</param>
        /// <returns>List of the table columns</returns>
        List<ColumnModel> GetTableInformation(string tableName);
    }
}
