
namespace Linq_Lab1.View
{
    partial class AddingForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxAuthor = new System.Windows.Forms.TextBox();
            this.boxTitle = new System.Windows.Forms.TextBox();
            this.boxPublishing = new System.Windows.Forms.TextBox();
            this.datePublYear = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(162, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Publication year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(187, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Publishing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(194, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Title";
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(465, 445);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(144, 80);
            this.btCancel.TabIndex = 28;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAdd.Location = new System.Drawing.Point(145, 445);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(144, 80);
            this.btAdd.TabIndex = 27;
            this.btAdd.Text = "Apply";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(187, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Author";
            // 
            // boxAuthor
            // 
            this.boxAuthor.Location = new System.Drawing.Point(338, 111);
            this.boxAuthor.Name = "boxAuthor";
            this.boxAuthor.Size = new System.Drawing.Size(183, 20);
            this.boxAuthor.TabIndex = 38;
            // 
            // boxTitle
            // 
            this.boxTitle.Location = new System.Drawing.Point(338, 166);
            this.boxTitle.Name = "boxTitle";
            this.boxTitle.Size = new System.Drawing.Size(183, 20);
            this.boxTitle.TabIndex = 39;
            // 
            // boxPublishing
            // 
            this.boxPublishing.Location = new System.Drawing.Point(338, 235);
            this.boxPublishing.Name = "boxPublishing";
            this.boxPublishing.Size = new System.Drawing.Size(183, 20);
            this.boxPublishing.TabIndex = 40;
            // 
            // datePublYear
            // 
            this.datePublYear.CustomFormat = "yyyy";
            this.datePublYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePublYear.Location = new System.Drawing.Point(338, 307);
            this.datePublYear.Name = "datePublYear";
            this.datePublYear.ShowUpDown = true;
            this.datePublYear.Size = new System.Drawing.Size(200, 20);
            this.datePublYear.TabIndex = 41;
            // 
            // AddingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.datePublYear);
            this.Controls.Add(this.boxPublishing);
            this.Controls.Add(this.boxTitle);
            this.Controls.Add(this.boxAuthor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.Name = "AddingForm";
            this.Text = "AddingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxAuthor;
        private System.Windows.Forms.TextBox boxTitle;
        private System.Windows.Forms.TextBox boxPublishing;
        private System.Windows.Forms.DateTimePicker datePublYear;
    }
}