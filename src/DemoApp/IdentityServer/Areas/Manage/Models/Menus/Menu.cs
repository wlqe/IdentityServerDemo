﻿using CoreDX.Domain.Entity.App.Management;
using System.Collections.Generic;

namespace IdentityServer.Areas.Manage.Models.Menus
{
    public class MenuItemViewModel
    {
        public string Index { get; set; }
        public MenuItemIcon Icon { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public short Order { get; set; }
    }

    public class MenuViewModel
    {
        public string Index { get; set; }
        public MenuIcon Icon { get; set; }
        public string Title { get; set; }
        public short Order { get; set; }
        public List<MenuItemViewModel> Items { get; set; }
        public List<MenuViewModel> Children { get; set; }
    }
}
