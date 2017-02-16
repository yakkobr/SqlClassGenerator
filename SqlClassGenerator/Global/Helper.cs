using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using SqlClassGenerator.DataObjects;

namespace SqlClassGenerator.Global
{
    public static class Helper
    {
        /// <summary>
        /// Converts a string into a secure string
        /// </summary>
        /// <param name="value">The value</param>
        /// <returns>The converted string</returns>
        public static SecureString ToSecureString(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            var secureString = new SecureString();
            foreach (var s in value)
            {
                secureString.AppendChar(s);
            }

            return secureString;
        }
        /// <summary>
        /// Converts a secure string into a string
        /// </summary>
        /// <param name="value">The value</param>
        /// <returns>The converted string</returns>
        public static string ToUnsecureString(this SecureString value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(value);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
        /// <summary>
        /// Gets the path of the base folder
        /// </summary>
        /// <returns>The path of the base folder</returns>
        public static string GetBaseFolder()
        {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
        /// <summary>
        /// Gets the according c sharp data type
        /// </summary>
        /// <param name="provider">The provider</param>
        /// <param name="type">The sql data type</param>
        /// <returns>The c# type</returns>
        private static string GetType(CustomEnums.Provider provider, string type)
        {
            const string defaultMappingType = "TypeMissing";

            var mappingList = ConfigManager.GetData();
            if (mappingList == null || mappingList.Count == 0)
                return defaultMappingType;

            var entry =
                mappingList.FirstOrDefault(w => w.Provider == provider && w.SqlType.ToLower().Contains(type));

            return entry == null ? defaultMappingType : entry.CSharpType;
        }
        /// <summary>
        /// Converts the first char of a string to a upper case
        /// </summary>
        /// <param name="input">The string</param>
        /// <returns>The converted string</returns>
        public static string FirstCharToUpper(this string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException(nameof(input));
            return input.First().ToString().ToUpper() + input.Substring(1);
        }
        /// <summary>
        /// Converts the first char of a string to a upper case
        /// </summary>
        /// <param name="input">The string</param>
        /// <returns>The converted string</returns>
        public static string FirstCharToLower(this string input)
        {
            if (string.IsNullOrEmpty(input))
                throw new ArgumentNullException(nameof(input));
            return input.First().ToString().ToLower() + input.Substring(1);
        }

        /// <summary>
        /// Generates the class
        /// </summary>
        /// <param name="provider">The provider</param>
        /// <param name="table">The name of the table</param>
        /// <param name="autoProperty">true if only auto properties are needed, otherwise false</param>
        /// <param name="tableModel">The list of the columns</param>
        /// <returns>The generated class</returns>
        public static string CreateClass(CustomEnums.Provider provider, string table, bool autoProperty, List<TableModel> tableModel)
        {
            if (tableModel == null)
                throw new ArgumentNullException(nameof(tableModel));

            var result = $"public class {table.Replace("_", "").FirstCharToUpper()}Class\r\n{{";
            result += "{";

            foreach (var column in tableModel)
            {
                if (autoProperty)
                {
                    result += $"\tpublic {GetType(provider, column.Type)} {column.Field.FirstCharToUpper()} {{ get; set; }}\r\n";
                }
                else
                {
                    result += $"\tprivate {GetType(provider, column.Type)} _{column.Field.FirstCharToLower()};\r\n";
                    result += $"\tpublic {GetType(provider, column.Type)}\r\n{{" +
                              $"\t\tget {{ return _{column.Field.FirstCharToLower()}; }}\r\n" +
                              $"\t\tset {{ _{column.Field.FirstCharToLower()} = value; }}\r\n" +
                              "}\r\n";

                }
            }

            return result;

        }
    }
}
