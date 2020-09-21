using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyPainterJPTVR18.Models
{
    public class Painter
    {
        public int Id { get; set; }
        [Display(Name = "Фамилия и имя художника")]
        public string Name { get; set; }
        public string Country { get; set; }
        public string Biography { get; set; }
        [Display(Name = "Фото")]
        public byte[] Photo { get; set; }
        public string PhotoType { get; set; }
        public int? PictureId { get; set; }
        public Picture Picture { get; set; }
    }
}