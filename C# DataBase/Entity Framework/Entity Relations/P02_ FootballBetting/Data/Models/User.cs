﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02__FootballBetting.Data.Models;

public class User
{
       public int UserId { get; set; }
       public string Username { get; set; }
       public string Password { get; set; }
       public string Email { get; set; }
       public string Name { get; set; }
       public decimal Balance { get; set; }
}
