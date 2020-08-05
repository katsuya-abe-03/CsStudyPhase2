using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phase2App
{
    public partial class frmMain : Form
    {
        FormChild childForm;

        public frmMain()
        {
            InitializeComponent();
            InitItemValue();

           chkIsVisibleChildWnd.Checked = true;
            childForm = new FormChild();
            SetChildWndColor();
            childForm.Show();
        }
        
        //GUIアイテムの初期値設定
        private void InitItemValue()
        {
            trbChildWndWidth.Maximum    = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            trbChildWndHeight.Maximum   = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            lblChildWndMoveVal.Text     = trbChildWndMoveVal.Value.ToString();
            lblChildWndWidth.Text       = trbChildWndWidth.Value.ToString();
            lblChildWndHeight.Text      = trbChildWndHeight.Value.ToString();

            lblRed.Text                 = trbRed.Value.ToString();
            lblGreen.Text               = trbGreen.Value.ToString();
            lblBlue.Text                = trbBlue.Value.ToString();
        }

        private void SetChildWndColor()
        {
            childForm.BackColor = Color.FromArgb(trbRed.Value, trbGreen.Value, trbBlue.Value);
        }

        //子ウインドウ位置制御のボタン操作
        private void btnUp_Click(object sender, EventArgs e)
        {
            childForm.Top -= trbChildWndMoveVal.Value;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            childForm.Left += trbChildWndMoveVal.Value;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            childForm.Top += trbChildWndMoveVal.Value;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            childForm.Left -= trbChildWndMoveVal.Value;
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
             childForm.Left = (trbChildWndWidth.Maximum  - trbChildWndWidth.Value)  / 2;
             childForm.Top  = (trbChildWndHeight.Maximum - trbChildWndHeight.Value) / 2;
        }

        //子ウインドウ表示チェックボックス
        private void chkIsVisibleChildWnd_CheckedChanged(object sender, EventArgs e)
        {
            if( childForm == null)
            {
                return;
            }

            if (chkIsVisibleChildWnd.Checked)
            {
                childForm.Show();
            }
            else
            {
                childForm.Hide();
            }
        }

        //子ウインドウ座標制御のトラックバー変更関連の関数
        private void trbChildWndMoveVal_Scroll(object sender, EventArgs e)
        {
            lblChildWndMoveVal.Text = trbChildWndMoveVal.Value.ToString();
        }

        private void trbChildWndWidth_Scroll(object sender, EventArgs e)
        {
            childForm.Width         = trbChildWndWidth.Value;
            lblChildWndWidth.Text   = trbChildWndWidth.Value.ToString();
        }

        private void trbChildWndHeight_Scroll(object sender, EventArgs e)
        {
            childForm.Height        = trbChildWndHeight.Value;
            lblChildWndHeight.Text  = trbChildWndHeight.Value.ToString();
        }

        private void trbColor_Scroll(object sender, EventArgs e)
        {
            if(sender.Equals(trbRed)) 
            {
                lblRed.Text = trbRed.Value.ToString();
            }
            else if(sender.Equals(trbGreen)) 
            {
                lblGreen.Text = trbGreen.Value.ToString();
            }
            else
            {
                lblBlue.Text = trbBlue.Value.ToString();
            }
            SetChildWndColor();
        }
    }
}
