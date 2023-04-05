using System.Windows.Forms;

namespace Linq_Lab1.View
{
    public partial class SelectionView : Form
    {
        public readonly BindingSource Binding;
        public SelectionView()
        {
            InitializeComponent();
            Binding = new BindingSource();
            tableSelect.DataSource = Binding;
        }
    }
}
