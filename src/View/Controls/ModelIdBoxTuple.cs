using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls
{
    public class ModelIdBoxTuple : IIdBoxTuple
    {
        private readonly TextBox _idBox;
        private readonly IEnumerable<TextBox> _idBoxes;

        public IEnumerable<TextBox> IdBoxes => _idBoxes;

        public TextBox IdBox => _idBox;

        public ModelIdBoxTuple()
        {
            _idBox = new();
            _idBoxes = [_idBox];
        }
    }
}
