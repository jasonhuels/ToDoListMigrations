using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Models
{
  public class CategoryItem
    {       
        public int CategoryItemId { get; set; }
        
        public int ItemId { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}