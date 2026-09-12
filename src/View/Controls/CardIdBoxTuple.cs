using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls;

public class CardIdBoxTuple
    : IIdBoxTuple<ViewModel.Documentational.Card>
{
    private CardGetter _getter;

    private readonly TextBox _idBox;
    private readonly TextBox _modelIdBox;
    private readonly IEnumerable<TextBox> _idBoxes;

    public IEnumerable<TextBox> IdBoxes => _idBoxes;
    
    public ViewModel.Documentational.Card Model
    {
        get
        {
            _getter.Id = Convert.ToInt32(_idBox.Text);
            _getter.ModelId = Convert.ToInt32(_modelIdBox.Text);
            return _getter.Model;
        }
    }

    public TextBox IdBox => _idBox;
    public TextBox ModelIdBox => _modelIdBox;

    public CardIdBoxTuple(CardGetter getter)
    {
        _getter = getter;
        _idBox = new();
        _modelIdBox = new();
        _idBoxes = [_idBox, _modelIdBox];
    }
}
