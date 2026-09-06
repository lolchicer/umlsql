using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls
{
    public class ViewIdBoxTuple : IIdBoxTuple
    {
        private readonly TextBox _idBox;
        private readonly TextBox _modelIdBox;
        private readonly IEnumerable<TextBox> _idBoxes;

        public IEnumerable<TextBox> IdBoxes => _idBoxes;

        public TextBox IdBox => _idBox;
        public TextBox ModelIdBox => _modelIdBox;

        public ViewIdBoxTuple()
        {
            _idBox = new();
            _modelIdBox = new();
            _idBoxes = [_idBox, _modelIdBox];
        }
    }
}
