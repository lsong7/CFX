﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Structures
{
    public class Recipe
    {
        public Recipe()
        {
        }

        /// <summary>
        /// The name of the recipe
        /// </summary>
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Version number, e.g. “2.0”
        /// </summary>
        public string Revision
        {
            get;
            set;
        }

        /// <summary>
        /// The MIME type of the binary data contained by the RecipeData property.
        /// </summary>
        public string MimeType
        {
            get;
            set;
        }

        /// <summary>
        /// A binary representation of the recipe data.
        /// </summary>
        public byte [] RecipeData
        {
            get;
            set;
        }
    }
}
