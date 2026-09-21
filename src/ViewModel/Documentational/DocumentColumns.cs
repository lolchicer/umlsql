using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lolchicer.Umlsql.ViewModel.Documentational;

[Table("documents")]
public partial class Document
{
    private int _id;

    [Column("id")]
    public int Id
    {
        get => _id;
        set
        {
            _id = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PropertyChanged)));
        }
    }

    [Column("model")]
    public required int ModelId
    {
        get;
        set;
    }

    [Column("additionalterms_type")]
    public required int AdditionalTermsTypeId
    {
        get;
        set;
    }

    [Column("views_type")]
    public required int ViewsTypeId
    {
        get;
        set;
    }

    [Column("name_type")]
    public required int NameTypeId
    {
        get;
        set;
    }

    [Column("links_type")]
    public required int LinksTypeId
    {
        get;
        set;
    }

    [Column("date_type")]
    public required int DateTypeId
    {
        get;
        set;
    }

    [Column("document_type")]
    public required int DocumentTypeId
    {
        get;
        set;
    }

    [Column("additionalterms_content")]
    public required string AdditionalTermsContent
    {
        get;
        set;
    }

    [Column("views_content")]
    public required string ViewsContent
    {
        get;
        set;
    }

    [Column("name_content")]
    public required string NameContent
    {
        get;
        set;
    }

    [Column("links_content")]
    public required string LinksContent
    {
        get;
        set;
    }

    [Column("date_content")]
    public required DateTime DateContent
    {
        get;
        set;
    }
}
