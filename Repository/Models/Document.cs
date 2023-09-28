using System.ComponentModel.DataAnnotations.Schema;

namespace AUTH.Backend.Repository.Models;

[Table(nameof(Document))]
public class Document : BaseEntity
{
    public string Name { get; set; }
    public string OriginalName { get; set; }
    public string Extension { get; set; }
    public float? Size { get; set; }
    public bool IsInUse { get; set; }
    public string TempPath { get; set; }
    public string BucketName { get; set; }
    public string ContentType { get; set; }
    public string Meta { get; set; }
    public string Url { get; set; }
    [NotMapped]
    public string FullName => Name + Extension;
}
