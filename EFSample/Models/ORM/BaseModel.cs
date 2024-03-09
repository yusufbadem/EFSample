﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EFSample.Models.ORM;
public class BaseModel
{
    public int Id { get; set; }
    public DateTime AddDate { get; set; } = DateTime.Now;

    public bool IsActive { get; set; }
}
