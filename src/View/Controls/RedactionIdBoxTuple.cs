using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls;

========
public class RedactionIdBoxTuple
    : IIdBoxTuple<ViewModel.Iterational.Redaction>, ViewModel.Iterational.IRedactionIdTuple
>>>>>>>> изменил idboxtuple:src/View/Controls/RedactionIdBoxTuple.cs
{
    private readonly TextBox _idBox;
    private readonly TextBox _modelIdBox;
    private readonly IEnumerable<TextBox> _idBoxes;

    public IEnumerable<TextBox> IdBoxes => _idBoxes;

    public TextBox IdBox => _idBox;
    public TextBox ModelIdBox => _modelIdBox;

    public int Id => Convert.ToInt32(IdBox.Text);
    public int ModelId => Convert.ToInt32(ModelIdBox.Text);

========
    public RedactionIdBoxTuple()
>>>>>>>> изменил idboxtuple:src/View/Controls/RedactionIdBoxTuple.cs
    {
        _idBox = new();
        _modelIdBox = new();
        _idBoxes = [_idBox, _modelIdBox];
    }
}
