using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AAS2237A5.Data
{
    public class ActorMediaItem
    {
        public int Id { get; set; }

        // Media item
        public byte[] Content { get; set; }

        [StringLength(200)]
        public string ContentType { get; set; }

        // Brief descriptive caption
        [Required, StringLength(100)]
        public string Caption { get; set; }

        [Required]
        public Actor Actor { get; set; }
    }
}