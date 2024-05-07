using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Track_Meet.Models;

public partial class Runner
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [DisplayName("First Name")]
    [Required(ErrorMessage = "First name is required.")]
    [StringLength(50, ErrorMessage = "First name must be between {2} and {1} characters.", MinimumLength = 2)]
    public string FirstName { get; set; } = null!;

    [DisplayName("Last Name")]
    [Required(ErrorMessage = "Last name is required.")]
    [StringLength(50, ErrorMessage = "Last name must be between {2} and {1} characters.", MinimumLength = 2)]
    public string LastName { get; set; } = null!;

    [Required(ErrorMessage = "Gender is required.")]
    [StringLength(10, ErrorMessage = "Gender must be either 'Male' or 'Female'.")]
    public string Gender { get; set; } = null!;

    public string Event { get; set; } = null!;

    [DisplayName("Result (Time)")]
    [Required(ErrorMessage = "Result is required.")]
    [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Result must be a number with up to two decimal places.")]
    public string Result { get; set; } = null!;
}
