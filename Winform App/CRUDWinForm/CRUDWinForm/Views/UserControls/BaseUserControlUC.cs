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
    public partial class BaseUserControlUC : UserControl
    {
        public BaseUserControlUC()
        {
            this.SuspendLayout();
            InitializeComponent();
            this.ResumeLayout(false);
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // BaseUserControUC
        //    // 
        //    this.Name = "BaseUserControUC";
        //    this.ResumeLayout(false);

        //}
        public AnchorStyles SetAnchorStylesTopBottomLeftRight()
    {
      return ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
    }
    public void SetParentSizeLocationAnchor(Panel parentPanel)
    {
      Parent = parentPanel;
      Height = parentPanel.Height;
      Width = parentPanel.Width;
      Location = new Point(0, 0);
      Anchor = SetAnchorStylesTopBottomLeftRight();
    }
      
    }
}
