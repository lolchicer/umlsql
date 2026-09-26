using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls;

public class DocumentIdBoxTuple
    : IIdBoxTuple<ViewModel.Documentational.Document>, ViewModel.Documentational.INewDocumentIdTuple
{
    private readonly TextBox _idBox;
    private readonly TextBox _modelIdBox;
    private readonly TextBox _additionalTermsTypeIdBox;
    private readonly TextBox _viewsTypeIdBox;
    private readonly TextBox _nameTypeIdBox;
    private readonly TextBox _linksTypeIdBox;
    private readonly TextBox _dateTypeIdBox;
    private readonly TextBox _documentTypeIdBox;
    private readonly IEnumerable<TextBox> _idBoxes;

    public IEnumerable<TextBox> IdBoxes => _idBoxes;

    public TextBox IdBox => _idBox;
    public TextBox ModelIdBox => _modelIdBox;
    public TextBox AdditionalTermsTypeIdBox => _additionalTermsTypeIdBox;
    public TextBox ViewsTypeIdBox => _viewsTypeIdBox;
    public TextBox NameTypeIdBox => _nameTypeIdBox;
    public TextBox LinksTypeIdBox => _linksTypeIdBox;
    public TextBox DateTypeIdBox => _dateTypeIdBox;
    public TextBox DocumentTypeIdBox => _documentTypeIdBox;

    public int Id => Convert.ToInt32(IdBox.Text);
    public int ModelId => Convert.ToInt32(ModelIdBox.Text);
    public int AdditionalTermsTypeId => Convert.ToInt32(AdditionalTermsTypeIdBox.Text);
    public int ViewsTypeId => Convert.ToInt32(ViewsTypeIdBox.Text);
    public int NameTypeId => Convert.ToInt32(NameTypeIdBox.Text);
    public int LinksTypeId => Convert.ToInt32(LinksTypeIdBox.Text);
    public int DateTypeId => Convert.ToInt32(DateTypeIdBox.Text);
    public int DocumentTypeId => Convert.ToInt32(DocumentTypeIdBox.Text);

    public DocumentIdBoxTuple()
    {
        _idBox = new();
        _modelIdBox = new();
        _additionalTermsTypeIdBox = new();
        _viewsTypeIdBox = new();
        _nameTypeIdBox = new();
        _linksTypeIdBox = new();
        _dateTypeIdBox = new();
        _documentTypeIdBox = new();
        _idBoxes = [
            _idBox,
            _modelIdBox,
            _additionalTermsTypeIdBox,
            _viewsTypeIdBox,
            _nameTypeIdBox,
            _linksTypeIdBox,
            _dateTypeIdBox,
            _documentTypeIdBox];
    }
    int INewDocumentIdTuple.AdditionalTermsTypeId => AdditionalTermsTypeId;
    int INewDocumentIdTuple.ViewsTypeId => ViewsTypeId;
    int INewDocumentIdTuple.NameTypeId => NameTypeId;
    int INewDocumentIdTuple.LinksTypeId => LinksTypeId;
    int INewDocumentIdTuple.DateTypeId => DateTypeId;
    int INewDocumentIdTuple.DocumentTypeId => DocumentTypeId;
}
