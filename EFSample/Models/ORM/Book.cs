﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSample.Models.ORM;
public class Book:BaseModel
{
    [MaxLength(100)]
    public string Name { get; set; }
    public DateTime PublishDate { get; set; }

    public string PublisherName { get; set; }

    public int? CategoryId { get; set; }
    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }

    public int? PublisherId { get; set; }

    [ForeignKey("PublisherId")]
    public Publisher? Publisher { get; set; }
}
