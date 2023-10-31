

using System;
using System.Collections.Generic;
 
namespace EMS.Models;
 
public partial class Employee
{
    public int Id { get; set; }
 
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = null!;
    [Range(10000,90000,ErrorMessage = "Salary betweeen 10000 and 90000")]
    public int Salary { get; set; }
    
    [Display(Name="Department")]
    public int DeptId { get; set; }
    [Display(Name="Email")]
    [DataType(DataType.Email.Address)]
    public string Email { get; set; } = null!;
    
    [DataType(DataType.Date)]
    [DisplayFormat(ApplyFormatEditableMode=true,DataFormatString="{0:yyyy-MM-dd}")]
    public DateTime Dob { get; set; }
    
    public virtual Department Dept { get; set; } = null!;
}
 