using ProniaAdmin.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ProniaAdmin.Models;

public class Service : BaseEntity
{
    public string Title { get; set; }
    public string? Description { get; set; }
    public string ImageUrl { get; set; }
}