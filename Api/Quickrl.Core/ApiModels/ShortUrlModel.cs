using System;
using System.ComponentModel.DataAnnotations;
using Quickrl.Core.Models;

namespace Quickrl.Core.ApiModels
{
    public class ShortUrlModel
    {
        public int Id { get; set; }
        [Required]
        public string RedirectUrl { get; set; }
        public DateTime? ActiveUntil { get; set; }
        public DateTime CreateDate { get; set; }
        public int HitCount { get; set; }

        public ShortUrl ToDomainModel()
        {
            return new ShortUrl
            {
                RedirectUrl = RedirectUrl,
                ActiveUntil = ActiveUntil,
            };
        }
        
    }
}