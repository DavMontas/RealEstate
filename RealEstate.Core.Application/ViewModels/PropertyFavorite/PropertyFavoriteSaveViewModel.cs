﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Core.Application.ViewModels.PropertyFavorite
{
    public class PropertyFavoriteSaveViewModel
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public int PropertyId { get; set; }
    }
}
