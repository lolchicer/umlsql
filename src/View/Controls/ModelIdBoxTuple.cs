using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls;

public class ModelIdBoxTuple
    : IIdBoxTuple<ViewModel.Core.Model>
{
    private ModelGetter _getter;

    private readonly TextBox _idBox;
    private readonly IEnumerable<TextBox> _idBoxes;

    public IEnumerable<TextBox> IdBoxes => _idBoxes;

    public async Task<ViewModel.Core.Model> GetModel()
    {
        _getter.Id = Convert.ToInt32(_idBox.Text);
        return await _getter.GetModel();
    }

    public TextBox IdBox => _idBox;

    public ModelIdBoxTuple(ModelGetter getter)
    {
        _getter = getter;
        _idBox = new();
        _idBoxes = [_idBox];
    }
}
