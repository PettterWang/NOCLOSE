
namespace NOCLOSE
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_ListOfWindows = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_NC_Transperent = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_NC_H = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_NC_W = new System.Windows.Forms.TextBox();
            this.button_NOCLOSE = new System.Windows.Forms.Button();
            this.button_RefreshList = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip_NotifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip_NotifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 311);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_ListOfWindows);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(119, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 305);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Window";
            // 
            // listBox_ListOfWindows
            // 
            this.listBox_ListOfWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_ListOfWindows.FormattingEnabled = true;
            this.listBox_ListOfWindows.ItemHeight = 12;
            this.listBox_ListOfWindows.Location = new System.Drawing.Point(3, 17);
            this.listBox_ListOfWindows.Name = "listBox_ListOfWindows";
            this.listBox_ListOfWindows.Size = new System.Drawing.Size(452, 285);
            this.listBox_ListOfWindows.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_NC_Transperent);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_NC_H);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_NC_W);
            this.groupBox2.Controls.Add(this.button_NOCLOSE);
            this.groupBox2.Controls.Add(this.button_RefreshList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 305);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // checkBox_NC_Transperent
            // 
            this.checkBox_NC_Transperent.AutoSize = true;
            this.checkBox_NC_Transperent.Location = new System.Drawing.Point(9, 115);
            this.checkBox_NC_Transperent.Name = "checkBox_NC_Transperent";
            this.checkBox_NC_Transperent.Size = new System.Drawing.Size(90, 16);
            this.checkBox_NC_Transperent.TabIndex = 40;
            this.checkBox_NC_Transperent.Text = "Transperent";
            this.checkBox_NC_Transperent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 39;
            this.label1.Text = "Height:";
            // 
            // textBox_NC_H
            // 
            this.textBox_NC_H.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NC_H.Location = new System.Drawing.Point(51, 47);
            this.textBox_NC_H.Name = "textBox_NC_H";
            this.textBox_NC_H.Size = new System.Drawing.Size(53, 21);
            this.textBox_NC_H.TabIndex = 38;
            this.textBox_NC_H.Text = "40";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 37;
            this.label6.Text = "Width:";
            // 
            // textBox_NC_W
            // 
            this.textBox_NC_W.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_NC_W.Location = new System.Drawing.Point(51, 20);
            this.textBox_NC_W.Name = "textBox_NC_W";
            this.textBox_NC_W.Size = new System.Drawing.Size(53, 21);
            this.textBox_NC_W.TabIndex = 36;
            this.textBox_NC_W.Text = "60";
            // 
            // button_NOCLOSE
            // 
            this.button_NOCLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NOCLOSE.Font = new System.Drawing.Font("Viner Hand ITC", 11F);
            this.button_NOCLOSE.Location = new System.Drawing.Point(6, 74);
            this.button_NOCLOSE.Name = "button_NOCLOSE";
            this.button_NOCLOSE.Size = new System.Drawing.Size(98, 35);
            this.button_NOCLOSE.TabIndex = 35;
            this.button_NOCLOSE.Text = "NOCLOSE";
            this.button_NOCLOSE.UseVisualStyleBackColor = true;
            this.button_NOCLOSE.Click += new System.EventHandler(this.button_NOCLOSE_Click);
            // 
            // button_RefreshList
            // 
            this.button_RefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RefreshList.Location = new System.Drawing.Point(6, 258);
            this.button_RefreshList.Name = "button_RefreshList";
            this.button_RefreshList.Size = new System.Drawing.Size(98, 41);
            this.button_RefreshList.TabIndex = 34;
            this.button_RefreshList.Text = "Refresh List";
            this.button_RefreshList.UseVisualStyleBackColor = true;
            this.button_RefreshList.Click += new System.EventHandler(this.button_RefreshList_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip_NotifyMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "NOCLOSE";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip_NotifyMenu
            // 
            this.contextMenuStrip_NotifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.contextMenuStrip_NotifyMenu.Name = "contextMenuStrip_托盘菜单";
            this.contextMenuStrip_NotifyMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "Exit";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 311);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOCLOSE";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip_NotifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_ListOfWindows;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox_NC_Transperent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_NC_H;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_NC_W;
        private System.Windows.Forms.Button button_NOCLOSE;
        private System.Windows.Forms.Button button_RefreshList;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_NotifyMenu;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

