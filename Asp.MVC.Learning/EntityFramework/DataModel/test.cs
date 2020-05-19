using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Asp.MVC.Learning.Models{
public class Test{
    [Key]
    public int TestId { get; set; }
    public string Name { get; set; }
    public string Content { get; set; }
}
}
