using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCNorthwind.Models
{
    public class OrderIDViewModel
    {
        public int ID { get; set; }
        public readonly List<SelectListItem> selectListItems;

        public OrderIDViewModel(List<int> orderIds)
        {
            selectListItems = new List<SelectListItem>(); 
            foreach(var obj in orderIds) {
                selectListItems.Add(new SelectListItem { Text = $"{obj}", Value = $"{obj}" });
         
            }
        }
    }
}
