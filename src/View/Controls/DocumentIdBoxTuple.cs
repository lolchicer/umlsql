using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls;

<<<<<<<< HEAD:src/View/Controls/DocumentIdBoxTuple.cs
public class DocumentIdBoxTuple
    : IIdBoxTuple<ViewModel.Documentational.Document>, ViewModel.Documentational.IDocumentIdTuple
========
public class RedactionIdBoxTuple
    : IIdBoxTuple<ViewModel.Iterational.Redaction>, ViewModel.Iterational.IRedactionIdTuple
>>>>>>>> ae6802b1635d4719b545249cdf44436e43c0caf8:src/View/Controls/RedactionIdBoxTuple.cs
{
    private readonly TextBox _idBox;
    private readonly TextBox _modelIdBox;
    private readonly IEnumerable<TextBox> _idBoxes;

    public IEnumerable<TextBox> IdBoxes => _idBoxes;

    public TextBox IdBox => _idBox;
    public TextBox ModelIdBox => _modelIdBox;

    public int Id => Convert.ToInt32(IdBox.Text);
    public int ModelId => Convert.ToInt32(ModelIdBox.Text);

<<<<<<<< HEAD:src/View/Controls/DocumentIdBoxTuple.cs
    public DocumentIdBoxTuple()
========
    public RedactionIdBoxTuple()
>>>>>>>> ae6802b1635d4719b545249cdf44436e43c0caf8:src/View/Controls/RedactionIdBoxTuple.cs
    {
        _idBox = new();
        _modelIdBox = new();
        _idBoxes = [_idBox, _modelIdBox];
    }
}
