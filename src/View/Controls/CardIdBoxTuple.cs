using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls;

public class CardIdBoxTuple : IIdBoxTuple<ViewModel.Documentational.Card>
{
    private readonly TextBox _idBox;
    private readonly TextBox _modelIdBox;
    private readonly IEnumerable<TextBox> _idBoxes;

    public IEnumerable<TextBox> IdBoxes => _idBoxes;
    
    public ViewModel.Documentational.Card Model

    public TextBox IdBox => _idBox;
    public TextBox ModelIdBox => _modelIdBox;

    public CardIdBoxTuple()
    {
        _idBox = new();
        _modelIdBox = new();
        _idBoxes = [_idBox, _modelIdBox];
    }
}
