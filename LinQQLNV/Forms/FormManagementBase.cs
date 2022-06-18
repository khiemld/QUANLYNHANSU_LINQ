using QuanLyNhanSuADO.ADOManagement;

namespace QuanLyNhanSuADO.Forms
{
    public partial class FormManagementBase : Form
    {
        protected ADOEmployeeManagement management;
        public delegate void EventHandle();
        public event EventHandle HandleOnDatabaseChange;
        public FormManagementBase()
        {
            management = new ADOEmployeeManagement();
            HandleOnDatabaseChange += ReloadDataGridViewDataSource;
            InitializeComponent();
        }

        protected virtual void InitializeAdditionalComponent()
        {

        }

        protected virtual void delete_button_Click(object sender, EventArgs e)
        {

        }

        protected virtual void view_button_Click(object sender, EventArgs e)
        {

        }

        protected virtual void add_button_Click(object sender, EventArgs e)
        {

        }

        protected virtual void update_button_Click(object sender, EventArgs e)
        {

        }

        protected virtual void edit_button_Click(object sender, EventArgs e)
        {
            
        }

        private void FormManagementBase_Load(object sender, EventArgs e)
        {

        }
        
        protected virtual void ReloadDataGridViewDataSource()
        {
            
        }
    }
}
