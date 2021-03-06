﻿using System;
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

        /// <summary>
        /// Search Method.
        /// </summary>
        public void Search();

        /// <summary>
        /// View Method.
        /// </summary>
        public void View();

        /// <summary>
        /// Count by City or State
        /// </summary>
        public void Count();

        /// <summary>
        /// sort details by name
        /// </summary>
        public void SortByName();

        /// <summary>
        /// Write data to file
        /// </summary>
        public void WriteUsingStreamWriter();

        /// <summary>
        /// Read CSV file
        /// </summary>
        public void ReadCSVFile();

        /// <summary>
        /// Write CSV file
        /// </summary>
        /// <param name="records"></param>
        public void WriteCSVFile(List<Personal_Details> records);

        /// <summary>
        /// Read/Write JSON file
        /// </summary>
        public void ReadWriteJSON();
    }
}
