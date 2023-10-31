using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;
namespace EMS_Codefirst.Models;


[Table("Department")]
public class Dept
{
    
    public int Id{get;set;}
    [Required(ErrorMessage="Name Cannot Be Blank")]
    [MaxLength(30)]
    [Column("DeptName")]    
    public string Name{get;set;}
    [MaxLength(30)]
    public string Location{get;set;}

    public ICollection<Employee> Employees{get;set;}


}