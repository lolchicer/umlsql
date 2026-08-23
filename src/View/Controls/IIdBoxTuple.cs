using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Lolchicer.Umlsql.View.Controls
{
    public interface IIdBoxTuple
    {
        public IEnumerable<TextBox> IdBoxes { get; }
    }
}
