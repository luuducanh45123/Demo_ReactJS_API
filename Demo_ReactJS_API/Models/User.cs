﻿using System;
using System.Collections.Generic;

namespace Demo_ReactJS_API.Models;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }
}
