using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Quickrl.Core.ApiModels;
using Quickrl.Core.Interfaces;

namespace Quickrl.Core.Models
{
    public class ShortUrl : IEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string RedirectUrl { get; set; }
        public string ShortUrlId { get; set; }
        public string UserId { get; set; }
        public int HitCount { get; set; }
        public DateTime? ActiveUntil {get; set;}
        public DateTime CreateDate { get; set; }

        public User User { get; set; }

        public ShortUrlModel ToApiModel()
        {
            return new ShortUrlModel
            {
                Id = Id,
                RedirectUrl = RedirectUrl,
                ActiveUntil = ActiveUntil,
                CreateDate = CreateDate,
                HitCount = HitCount
            };
        }
    }
}