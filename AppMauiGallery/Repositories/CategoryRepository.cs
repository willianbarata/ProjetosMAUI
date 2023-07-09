﻿using AppMauiGallery.Models;
using AppMauiGallery.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMauiGallery.Repositories
{
    public class CategoryRepository
    {
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component> {
                    new Component {
                        Title = "StackLayout" ,
                        Description = "Organização sequencial dos elementos.",
                        Page = new StackLayoutPage()
                    }
                }
            });

            return categories;
        }
    }
}
