using CommonComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinForm.Views.UserControls
{
    public partial class EmployeeListViewUC : BaseUserControlUC, IEmployeeListViewUC
    {
        public event EventHandler DisplayAllEmployeeBtnClickEventRaised;
        public event EventHandler LoadOfAllEmployeeIntoGridCompletedEventRaised;
        public event EventHandler EmployeeListViewUCLoadEventRaised;


        public event EventHandler DepartmentListViewLoadEventRaised;
        public event EventHandler EditDepartmentMenuClickEventRaised;
        public event EventHandler AddNewDepartmentMenuClickEventRaised;
        public event EventHandler DeleteDepartmentMenuClickEventRaised;

        public EmployeeListViewUC()
        {
            InitializeComponent();
        }


        private void EmployeeListViewUC_Load(object sender, EventArgs e)
        {
            EmployeeGridView.AllowUserToAddRows = false;
            EmployeeGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //this.EmployeeGridView.AutoGenerateColumns = false;
            //EventHelpers.RaiseEvent(this,EmployeeListViewUCLoadEventRaised, e);
        }


        public void LoadAllEmployeeListToGrid(BindingSource employeeListBindingSource, Dictionary<string, string> headingsDictionary, Dictionary<string, float> gridColumnWidthsDictionary, int rowHeight)
        {
            this.EmployeeGridView.RowTemplate.Height = rowHeight;

            this.EmployeeGridView.DataSource = employeeListBindingSource;


            //this.EmployeeGridView.AutoGenerateColumns = false;

            this.EmployeeGridView.BackgroundColor = Color.Blue;

            this.EmployeeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            this.EmployeeGridView.ColumnHeadersHeight = 60;


            this.EmployeeGridView.EnableHeadersVisualStyles = false;

            this.EmployeeGridView.AllowUserToDeleteRows = false;
            this.EmployeeGridView.AllowUserToResizeColumns = false;
            this.EmployeeGridView.AllowUserToResizeRows = false;

            this.EmployeeGridView.Columns[0].Frozen = true;
            this.EmployeeGridView.Columns[0].ReadOnly = true;

            DataGridViewCellStyle column_header_cell_style = new DataGridViewCellStyle();
            column_header_cell_style.BackColor = Color.LightSalmon;
            column_header_cell_style.ForeColor = Color.Black;
            column_header_cell_style.SelectionBackColor = Color.Chocolate;
            column_header_cell_style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            column_header_cell_style.Font = new Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Pixel);
           
            //column_header_cell_style.Format = "G";

            DataGridViewCellStyle alternating_row_style = new DataGridViewCellStyle();
            alternating_row_style.BackColor = Color.LightBlue;
            alternating_row_style.ForeColor = Color.DarkBlue;
            alternating_row_style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //alternating_row_style.Font = new Font((FontFamily)FontFamily.GenericSansSerif, FontStyle.Bold);
            //alternating_row_style.Format = "G";

            DataGridViewCellStyle cell_style = new DataGridViewCellStyle();
            cell_style.BackColor = Color.LightBlue;
            cell_style.ForeColor = Color.Firebrick;
            cell_style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cell_style.SelectionBackColor = Color.Pink;
            cell_style.SelectionForeColor = Color.BlueViolet;
            cell_style.Font = new Font("Tahoma", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            //cell_style.Format = "G";

            
            this.EmployeeGridView.DefaultCellStyle = cell_style;

            this.EmployeeGridView.ColumnHeadersDefaultCellStyle = column_header_cell_style;

            //EmployeeGridView.Columns[3].DefaultCellStyle = cell_style;

            EmployeeGridView.AlternatingRowsDefaultCellStyle = alternating_row_style;

            SetGridHeaderText(headingsDictionary);

            SetGridColumnWidths(gridColumnWidthsDictionary);


            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.HeaderText = "Options";
            imageColumn.Name = "Options";
            imageColumn.Width = 100;
            imageColumn.Image = Properties.Resources.MoreOptionsBlackDotsOnWhite20x20;
            //int columnIndex = 4;
            if (EmployeeGridView.Columns["Options"] == null)
            {
                EmployeeGridView.Columns.Add(imageColumn);
            }


            //EventHelpers.RaiseEvent(this, LoadOfAllEmployeeIntoGridCompletedEventRaised, new EventArgs());
        }

        public void RaisEventDisplayAllEmployeeBtnClicked(EventArgs e)
        {
            //EventHelpers.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: DisplayAllEmployeeBtnClickEventRaised, eventArgs: e);
        }

        public void SetGridColumnWidths(Dictionary<string, float> gridColumnWidthsDictionary)
        {
            int GridWidth = (EmployeeGridView.Width - EmployeeGridView.RowHeadersWidth -
                  SystemInformation.VerticalScrollBarWidth);

            EmployeeGridView.Columns["EMPID"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["EMPID"]);
            EmployeeGridView.Columns["FirstName"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["FirstName"]);
            EmployeeGridView.Columns["LastName"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["LastName"]);
            EmployeeGridView.Columns["Email"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["EmailId"]);
            EmployeeGridView.Columns["IsMember"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["IsMember"]);
            EmployeeGridView.Columns["Status"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["Status"]);
            EmployeeGridView.Columns["DOB"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["DOB"]);
            EmployeeGridView.Columns["Role"].Width = (int)((GridWidth) * gridColumnWidthsDictionary["Role"]);




        }

        public void SetGridHeaderText(Dictionary<string, string> headingsDictionary)
        {
            EmployeeGridView.Columns["EMPID"].HeaderText = headingsDictionary["EMPID"];
            EmployeeGridView.Columns["FirstName"].HeaderText = headingsDictionary["FirstName"];
            EmployeeGridView.Columns["LastName"].HeaderText = headingsDictionary["LastName"];
            EmployeeGridView.Columns["Email"].HeaderText = headingsDictionary["EmailId"];
            EmployeeGridView.Columns["IsMember"].HeaderText = headingsDictionary["IsMember"];
            EmployeeGridView.Columns["Status"].HeaderText = headingsDictionary["Status"];
            EmployeeGridView.Columns["DOB"].HeaderText = headingsDictionary["DOB"];
            EmployeeGridView.Columns["Role"].HeaderText = headingsDictionary["Role"];

        }

      
        public void ShowView()
        {
             this.Show();
        }

        private void EmployeeGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("============" + e.ColumnIndex); 

            if((e.ColumnIndex==EmployeeGridView.Columns["Options"].Index)&&(e.RowIndex!=-1))
            {
                OptionContextMenuStrip.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >=0)
            {
                if (EmployeeGridView.Columns[e.ColumnIndex].Name == "Options")
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void EmployeeGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.ColumnIndex >=0)&& (e.RowIndex!=-1))
            {
                if (EmployeeGridView.Columns[e.ColumnIndex].Name == "Options")
                {
                    Cursor.Current = Cursors.Hand;
                }
            }
        }
    }
}
