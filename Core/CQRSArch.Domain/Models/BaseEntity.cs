using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

public abstract class BaseEntity
{
    public int Id { get; set; }

    //[DefaultValue(typeof(DateTime),DateTime.Now.ToString("yyyy-MM-dd"))]

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime LastModified { get; set; }
}