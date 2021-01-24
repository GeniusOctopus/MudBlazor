﻿using Microsoft.AspNetCore.Components;
using MudBlazor.Utilities;

namespace MudBlazor
{
    public partial class MudNavGroup : MudComponentBase
    {
        protected string Classname =>
        new CssBuilder("mud-nav-link")
          .AddClass($"mud-ripple", !DisableRipple)
          .AddClass("mud-expanded", Expanded)
          .AddClass(Class)
        .Build();

        [Parameter] public string Title { get; set; }

        /// <summary>
        /// Icon to use if set.
        /// </summary>
        [Parameter] public string Icon { get; set; }
        [Parameter] public bool Disabled { get; set; }
        [Parameter] public bool DisableRipple { get; set; }
        [Parameter] public bool Expanded { get; set; }

        /// <summary>
        /// If true, hides expand-icon at the end of the NavGroup. Set to true by default.
        /// </summary>
        [Parameter] public bool HideExpandIcon { get; set; }

        /// <summary>
        /// Explicitly sets the height for the Collapse element to override the css default.
        /// </summary>
        [Parameter] public int? MaxHeight { get; set; }

        /// <summary>
        /// If set, overrides the default expand icon.
        /// </summary>
        [Parameter] public string ExpandIcon { get; set; } = @Icons.Filled.ArrowDropDown;
        [Parameter] public RenderFragment ChildContent { get; set; }

        protected void ExpandedToggle()
        {
            Expanded = !Expanded;
        }
    }
}
