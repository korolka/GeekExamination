using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace huigma.Models;

public class Folder
{
    public int Id { get; set; }

    public string Name { get; set; }

    [ForeignKey("ParentFolder")]
    public ICollection<Folder> InnerFolders { get; set; }
}
