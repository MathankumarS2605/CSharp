using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;

namespace MVCNorthwind.Models
{
    public class OrderSelected
    {
        public List<SelectListItem> ids { get; } = new List<SelectListItem>
        {
            
            new SelectListItem { Value = "CS", Text = "C#" },
            new SelectListItem { Value = "JS", Text = "JavaScript" },
            new SelectListItem { Value = "TS", Text = "TypeScript"  },
        };
    }
}
