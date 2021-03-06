﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ListingToDos.Models
{
    public class ToDo
    {
        [Key]
        public long ToDoId { get; set; }
        public string Title { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public string Date { get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
        public User User { get; set; }
    }
}
