﻿using MoodSync.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodSync.Models
{
    public class PlaylistEdit
    {
        [Key]
        public int PlaylistId { get; set; }
        [Required]
        public string PlaylistName { get; set; }
        [Required]
        public string SongList { get; set; }
    }
}
