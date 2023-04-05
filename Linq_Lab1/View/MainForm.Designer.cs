
namespace Linq_Lab1.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.table = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btSave = new System.Windows.Forms.ToolStripMenuItem();
            this.btOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btExit = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btShowBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompaniesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btSortBookByAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btSortByTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.btSortByPublishing = new System.Windows.Forms.ToolStripMenuItem();
            this.btSortByYear = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btViewPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.btViewBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.btViewPublishers = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbCounterTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle1;
            this.table.Location = new System.Drawing.Point(4, 69);
            this.table.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(958, 501);
            this.table.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.selectorsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(970, 27);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSave,
            this.btOpen,
            this.toolStripSeparator1,
            this.btExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // btSave
            // 
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(112, 24);
            this.btSave.Text = "Save";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btOpen
            // 
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(112, 24);
            this.btOpen.Text = "Open";
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // btExit
            // 
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(112, 24);
            this.btExit.Text = "Exit";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btShowBooks,
            this.toolStripSeparator2,
            this.btGenerate,
            this.toolStripSeparator4,
            this.btAddBook,
            this.addCompaniesToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.dataToolStripMenuItem.Text = "&Data";
            // 
            // btShowBooks
            // 
            this.btShowBooks.Name = "btShowBooks";
            this.btShowBooks.Size = new System.Drawing.Size(180, 24);
            this.btShowBooks.Text = "Books";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // btGenerate
            // 
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(180, 24);
            this.btGenerate.Text = "Generate";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // btAddBook
            // 
            this.btAddBook.Name = "btAddBook";
            this.btAddBook.Size = new System.Drawing.Size(180, 24);
            this.btAddBook.Text = "Add Book";
            // 
            // addCompaniesToolStripMenuItem
            // 
            this.addCompaniesToolStripMenuItem.Name = "addCompaniesToolStripMenuItem";
            this.addCompaniesToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.addCompaniesToolStripMenuItem.Text = "Add Companies";
            // 
            // selectorsToolStripMenuItem
            // 
            this.selectorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolStripMenuItem});
            this.selectorsToolStripMenuItem.Name = "selectorsToolStripMenuItem";
            this.selectorsToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.selectorsToolStripMenuItem.Text = "&Selectors";
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSortBookByAuthor,
            this.toolStripSeparator5,
            this.btSortByTitle,
            this.btSortByPublishing,
            this.btSortByYear});
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.peopleToolStripMenuItem.Text = "People";
            // 
            // btSortBookByAuthor
            // 
            this.btSortBookByAuthor.Name = "btSortBookByAuthor";
            this.btSortBookByAuthor.Size = new System.Drawing.Size(189, 24);
            this.btSortBookByAuthor.Text = "Sort By Author";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(186, 6);
            // 
            // btSortByTitle
            // 
            this.btSortByTitle.Name = "btSortByTitle";
            this.btSortByTitle.Size = new System.Drawing.Size(189, 24);
            this.btSortByTitle.Text = "Sort By Title";
            // 
            // btSortByPublishing
            // 
            this.btSortByPublishing.Name = "btSortByPublishing";
            this.btSortByPublishing.Size = new System.Drawing.Size(189, 24);
            this.btSortByPublishing.Text = "Sort By Publishing";
            // 
            // btSortByYear
            // 
            this.btSortByYear.Name = "btSortByYear";
            this.btSortByYear.Size = new System.Drawing.Size(189, 24);
            this.btSortByYear.Text = "Sort By Year";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btViewPeople,
            this.btViewBooks,
            this.btViewPublishers,
            this.toolStripSeparator6,
            this.btViewAll});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // btViewPeople
            // 
            this.btViewPeople.Name = "btViewPeople";
            this.btViewPeople.Size = new System.Drawing.Size(140, 24);
            this.btViewPeople.Text = "People";
            // 
            // btViewBooks
            // 
            this.btViewBooks.Name = "btViewBooks";
            this.btViewBooks.Size = new System.Drawing.Size(140, 24);
            this.btViewBooks.Text = "Books";
            // 
            // btViewPublishers
            // 
            this.btViewPublishers.Name = "btViewPublishers";
            this.btViewPublishers.Size = new System.Drawing.Size(140, 24);
            this.btViewPublishers.Text = "Publishers";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripSeparator6.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(137, 6);
            // 
            // btViewAll
            // 
            this.btViewAll.Name = "btViewAll";
            this.btViewAll.Size = new System.Drawing.Size(140, 24);
            this.btViewAll.Text = "All";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbCounterTitle,
            this.lbCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(970, 33);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbCounterTitle
            // 
            this.lbCounterTitle.Name = "lbCounterTitle";
            this.lbCounterTitle.Padding = new System.Windows.Forms.Padding(2);
            this.lbCounterTitle.Size = new System.Drawing.Size(88, 28);
            this.lbCounterTitle.Text = "CounterTitle";
            // 
            // lbCount
            // 
            this.lbCount.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lbCount.Margin = new System.Windows.Forms.Padding(2, 4, 2, 2);
            this.lbCount.Name = "lbCount";
            this.lbCount.Padding = new System.Windows.Forms.Padding(2, 2, 6, 2);
            this.lbCount.Size = new System.Drawing.Size(59, 27);
            this.lbCount.Text = "Count";
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 638);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.table);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btSave;
        private System.Windows.Forms.ToolStripMenuItem btOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btExit;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btGenerate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem btAddBook;
        private System.Windows.Forms.ToolStripMenuItem selectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btSortBookByAuthor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem btSortByTitle;
        private System.Windows.Forms.ToolStripMenuItem btSortByPublishing;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbCounterTitle;
        private System.Windows.Forms.ToolStripStatusLabel lbCount;
        private System.Windows.Forms.ToolStripMenuItem btSortByYear;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btViewPeople;
        private System.Windows.Forms.ToolStripMenuItem btViewBooks;
        private System.Windows.Forms.ToolStripMenuItem btViewPublishers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem btViewAll;
        private System.Windows.Forms.ToolStripMenuItem btShowBooks;
        private System.Windows.Forms.ToolStripMenuItem addCompaniesToolStripMenuItem;
    }
}