namespace Phase2App
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxMove = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.gbxMoveValueAndSize = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblChildWndHeight = new System.Windows.Forms.Label();
            this.lblChildWndWidth = new System.Windows.Forms.Label();
            this.lblChildWndMoveVal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trbChildWndHeight = new System.Windows.Forms.TrackBar();
            this.trbChildWndWidth = new System.Windows.Forms.TrackBar();
            this.trbChildWndMoveVal = new System.Windows.Forms.TrackBar();
            this.gbxWindowColor = new System.Windows.Forms.GroupBox();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsVisibleChildWnd = new System.Windows.Forms.CheckBox();
            this.gbxMove.SuspendLayout();
            this.gbxMoveValueAndSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbChildWndHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbChildWndWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbChildWndMoveVal)).BeginInit();
            this.gbxWindowColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxMove
            // 
            this.gbxMove.Controls.Add(this.btnDown);
            this.gbxMove.Controls.Add(this.btnUp);
            this.gbxMove.Controls.Add(this.btnLeft);
            this.gbxMove.Controls.Add(this.btnRight);
            this.gbxMove.Controls.Add(this.btnCenter);
            this.gbxMove.Location = new System.Drawing.Point(42, 42);
            this.gbxMove.Name = "gbxMove";
            this.gbxMove.Size = new System.Drawing.Size(164, 159);
            this.gbxMove.TabIndex = 0;
            this.gbxMove.TabStop = false;
            this.gbxMove.Text = "子ウィンドウ位置制御";
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(59, 105);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(30, 23);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(59, 37);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(30, 23);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(20, 71);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(30, 23);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(98, 71);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(30, 23);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.Location = new System.Drawing.Point(59, 71);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(30, 23);
            this.btnCenter.TabIndex = 2;
            this.btnCenter.Text = "・";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // gbxMoveValueAndSize
            // 
            this.gbxMoveValueAndSize.Controls.Add(this.label7);
            this.gbxMoveValueAndSize.Controls.Add(this.lblChildWndHeight);
            this.gbxMoveValueAndSize.Controls.Add(this.lblChildWndWidth);
            this.gbxMoveValueAndSize.Controls.Add(this.lblChildWndMoveVal);
            this.gbxMoveValueAndSize.Controls.Add(this.label3);
            this.gbxMoveValueAndSize.Controls.Add(this.label2);
            this.gbxMoveValueAndSize.Controls.Add(this.label1);
            this.gbxMoveValueAndSize.Controls.Add(this.trbChildWndHeight);
            this.gbxMoveValueAndSize.Controls.Add(this.trbChildWndWidth);
            this.gbxMoveValueAndSize.Controls.Add(this.trbChildWndMoveVal);
            this.gbxMoveValueAndSize.Location = new System.Drawing.Point(253, 88);
            this.gbxMoveValueAndSize.Name = "gbxMoveValueAndSize";
            this.gbxMoveValueAndSize.Size = new System.Drawing.Size(237, 169);
            this.gbxMoveValueAndSize.TabIndex = 1;
            this.gbxMoveValueAndSize.TabStop = false;
            this.gbxMoveValueAndSize.Text = "子ウィンドウ座標制御";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "100";
            // 
            // lblChildWndHeight
            // 
            this.lblChildWndHeight.AutoSize = true;
            this.lblChildWndHeight.Location = new System.Drawing.Point(73, 95);
            this.lblChildWndHeight.Name = "lblChildWndHeight";
            this.lblChildWndHeight.Size = new System.Drawing.Size(31, 15);
            this.lblChildWndHeight.TabIndex = 12;
            this.lblChildWndHeight.Text = "100";
            // 
            // lblChildWndWidth
            // 
            this.lblChildWndWidth.AutoSize = true;
            this.lblChildWndWidth.Location = new System.Drawing.Point(73, 62);
            this.lblChildWndWidth.Name = "lblChildWndWidth";
            this.lblChildWndWidth.Size = new System.Drawing.Size(31, 15);
            this.lblChildWndWidth.TabIndex = 11;
            this.lblChildWndWidth.Text = "100";
            // 
            // lblChildWndMoveVal
            // 
            this.lblChildWndMoveVal.AutoSize = true;
            this.lblChildWndMoveVal.Location = new System.Drawing.Point(73, 29);
            this.lblChildWndMoveVal.Name = "lblChildWndMoveVal";
            this.lblChildWndMoveVal.Size = new System.Drawing.Size(31, 15);
            this.lblChildWndMoveVal.TabIndex = 10;
            this.lblChildWndMoveVal.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "高さ：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "幅：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "移動量：";
            // 
            // trbChildWndHeight
            // 
            this.trbChildWndHeight.Location = new System.Drawing.Point(123, 95);
            this.trbChildWndHeight.Margin = new System.Windows.Forms.Padding(0);
            this.trbChildWndHeight.Maximum = 10000;
            this.trbChildWndHeight.Minimum = 1;
            this.trbChildWndHeight.Name = "trbChildWndHeight";
            this.trbChildWndHeight.Size = new System.Drawing.Size(104, 56);
            this.trbChildWndHeight.TabIndex = 6;
            this.trbChildWndHeight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbChildWndHeight.Value = 100;
            this.trbChildWndHeight.Scroll += new System.EventHandler(this.trbChildWndHeight_Scroll);
            // 
            // trbChildWndWidth
            // 
            this.trbChildWndWidth.Location = new System.Drawing.Point(123, 62);
            this.trbChildWndWidth.Margin = new System.Windows.Forms.Padding(0);
            this.trbChildWndWidth.Maximum = 10000;
            this.trbChildWndWidth.Minimum = 1;
            this.trbChildWndWidth.Name = "trbChildWndWidth";
            this.trbChildWndWidth.Size = new System.Drawing.Size(104, 56);
            this.trbChildWndWidth.TabIndex = 5;
            this.trbChildWndWidth.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbChildWndWidth.Value = 100;
            this.trbChildWndWidth.Scroll += new System.EventHandler(this.trbChildWndWidth_Scroll);
            // 
            // trbChildWndMoveVal
            // 
            this.trbChildWndMoveVal.Location = new System.Drawing.Point(123, 29);
            this.trbChildWndMoveVal.Margin = new System.Windows.Forms.Padding(0);
            this.trbChildWndMoveVal.Maximum = 100;
            this.trbChildWndMoveVal.Minimum = 1;
            this.trbChildWndMoveVal.Name = "trbChildWndMoveVal";
            this.trbChildWndMoveVal.Size = new System.Drawing.Size(104, 56);
            this.trbChildWndMoveVal.TabIndex = 4;
            this.trbChildWndMoveVal.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbChildWndMoveVal.Value = 100;
            this.trbChildWndMoveVal.Scroll += new System.EventHandler(this.trbChildWndMoveVal_Scroll);
            // 
            // gbxWindowColor
            // 
            this.gbxWindowColor.Controls.Add(this.trbBlue);
            this.gbxWindowColor.Controls.Add(this.trbGreen);
            this.gbxWindowColor.Controls.Add(this.trbRed);
            this.gbxWindowColor.Controls.Add(this.lblBlue);
            this.gbxWindowColor.Controls.Add(this.lblGreen);
            this.gbxWindowColor.Controls.Add(this.lblRed);
            this.gbxWindowColor.Controls.Add(this.label6);
            this.gbxWindowColor.Controls.Add(this.label5);
            this.gbxWindowColor.Controls.Add(this.label4);
            this.gbxWindowColor.Location = new System.Drawing.Point(256, 273);
            this.gbxWindowColor.Name = "gbxWindowColor";
            this.gbxWindowColor.Size = new System.Drawing.Size(234, 166);
            this.gbxWindowColor.TabIndex = 1;
            this.gbxWindowColor.TabStop = false;
            this.gbxWindowColor.Text = "子ウインドウ背景色制御";
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(120, 110);
            this.trbBlue.Margin = new System.Windows.Forms.Padding(0);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(104, 56);
            this.trbBlue.TabIndex = 16;
            this.trbBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbBlue.Scroll += new System.EventHandler(this.trbColor_Scroll);
            // 
            // trbGreen
            // 
            this.trbGreen.Location = new System.Drawing.Point(120, 76);
            this.trbGreen.Margin = new System.Windows.Forms.Padding(0);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(104, 56);
            this.trbGreen.TabIndex = 15;
            this.trbGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbGreen.Value = 255;
            this.trbGreen.Scroll += new System.EventHandler(this.trbColor_Scroll);
            // 
            // trbRed
            // 
            this.trbRed.Location = new System.Drawing.Point(120, 42);
            this.trbRed.Margin = new System.Windows.Forms.Padding(0);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(104, 56);
            this.trbRed.TabIndex = 14;
            this.trbRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbRed.Scroll += new System.EventHandler(this.trbColor_Scroll);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(70, 110);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(15, 15);
            this.lblBlue.TabIndex = 13;
            this.lblBlue.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(70, 76);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(31, 15);
            this.lblGreen.TabIndex = 12;
            this.lblGreen.Text = "255";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(70, 42);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(15, 15);
            this.lblRed.TabIndex = 11;
            this.lblRed.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "色(B)：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "色(G)：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "色(R)：";
            // 
            // chkIsVisibleChildWnd
            // 
            this.chkIsVisibleChildWnd.AutoSize = true;
            this.chkIsVisibleChildWnd.Checked = true;
            this.chkIsVisibleChildWnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsVisibleChildWnd.Location = new System.Drawing.Point(253, 42);
            this.chkIsVisibleChildWnd.Name = "chkIsVisibleChildWnd";
            this.chkIsVisibleChildWnd.Size = new System.Drawing.Size(129, 19);
            this.chkIsVisibleChildWnd.TabIndex = 2;
            this.chkIsVisibleChildWnd.Text = "子ウインドウ表示";
            this.chkIsVisibleChildWnd.UseVisualStyleBackColor = true;
            this.chkIsVisibleChildWnd.CheckedChanged += new System.EventHandler(this.chkIsVisibleChildWnd_CheckedChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 500);
            this.Controls.Add(this.chkIsVisibleChildWnd);
            this.Controls.Add(this.gbxMoveValueAndSize);
            this.Controls.Add(this.gbxWindowColor);
            this.Controls.Add(this.gbxMove);
            this.Name = "frmMain";
            this.Text = "入門課題";
            this.gbxMove.ResumeLayout(false);
            this.gbxMoveValueAndSize.ResumeLayout(false);
            this.gbxMoveValueAndSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbChildWndHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbChildWndWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbChildWndMoveVal)).EndInit();
            this.gbxWindowColor.ResumeLayout(false);
            this.gbxWindowColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMove;
        private System.Windows.Forms.GroupBox gbxMoveValueAndSize;
        private System.Windows.Forms.GroupBox gbxWindowColor;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.CheckBox chkIsVisibleChildWnd;
        private System.Windows.Forms.TrackBar trbChildWndHeight;
        private System.Windows.Forms.TrackBar trbChildWndWidth;
        private System.Windows.Forms.TrackBar trbChildWndMoveVal;
        private System.Windows.Forms.Label lblChildWndMoveVal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblChildWndHeight;
        private System.Windows.Forms.Label lblChildWndWidth;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.TrackBar trbRed;
    }
}

