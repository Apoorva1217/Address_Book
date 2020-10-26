using System;
using System.Collections.Generic;
using System.Text;

namespace Address_Book
{
    public interface Details
    {
        /// <summary>
        /// Add method.
        /// </summary>
        public void Add();

        /// <summary>
        /// Display method.
        /// </summary>
        public void Display();

        /// <summary>
        /// Edit method.
        /// </summary>
        /// <param name="firstName">first name.</param>
        public void Edit(string firstName);

        /// <summary>
        /// Delete method.
        /// </summary>
        /// <param name="firstName">first name.</param>
        public void Delete(string firstName);
    }
}