namespace SqlClassGenerator.DataObjects
{
    public class ComboBoxItem
    {
        /// <summary>
        /// Gets or sets the text
        /// </summary>
        public string Text { get; private set; }
        /// <summary>
        /// Gets or sets the value
        /// </summary>
        public object Value { get; private set; }

        /// <summary>
        /// Creates a new instance of the class
        /// </summary>
        /// <param name="text">The text</param>
        /// <param name="value">The value</param>
        public ComboBoxItem(string text, object value)
        {
            Text = text;
            Value = value;
        }
        /// <summary>
        /// Returns the text of the entry
        /// </summary>
        /// <returns>The text</returns>
        public override string ToString()
        {
            return Text;
        }
    }
}
