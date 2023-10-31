
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
 
 
namespace EMS.Models;
 
public partial class Department
{
    public int Id {get;set;}
    [Display(Name = "Department Id")]
    [Required(ErrorMessage ="Department Name Cannot be Blank")]
    public string DeptName { get;set; }=null!;
    [Display(Name = "City")]
    [StringLength(25,MinimumLength =3,ErrorMessage ="City Must be 3 Chars")]
    public string Name { get; set; } = null!;
 
    public string Location { get; set; } = null!;
 
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
 