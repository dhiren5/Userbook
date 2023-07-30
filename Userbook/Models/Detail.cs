using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Userbook.Models;

public partial class Detail
{
    [Key]
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Mobile { get; set; } = null!;

    public int Age { get; set; }

    public string Birthday { get; set; } = null!;

    public string Fblink { get; set; } = null!;

    public string Linkedinlink { get; set; } = null!;

    public string Gmail { get; set; } = null!;

    public string Instaid { get; set; } = null!;

    public string Password { get; set; } = null!;
}
