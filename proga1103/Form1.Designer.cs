    
namespace proga1103
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameSurname = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.dataGridView10 = new System.Windows.Forms.DataGridView();
            this.dataGridView9 = new System.Windows.Forms.DataGridView();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addNewStudent = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // NameSurname
            // 
            this.NameSurname.Location = new System.Drawing.Point(588, 140);
            this.NameSurname.Name = "NameSurname";
            this.NameSurname.Size = new System.Drawing.Size(125, 27);
            this.NameSurname.TabIndex = 3;
            this.NameSurname.TextChanged += new System.EventHandler(this.NameSurname_TextChanged);
            // 
            // Sex
            // 
            this.Sex.Location = new System.Drawing.Point(588, 208);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(47, 27);
            this.Sex.TabIndex = 5;
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(666, 208);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(47, 27);
            this.Age.TabIndex = 6;
            // 
            // Photo
            // 
            this.Photo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Photo.Image = global::proga1103.Properties.Resources.шляпа_2;
            this.Photo.Location = new System.Drawing.Point(383, 140);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(125, 143);
            this.Photo.TabIndex = 7;
            this.Photo.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.addNewStudent);
            this.splitContainer1.Panel2.Controls.Add(this.Information);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView11, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView10, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(349, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView11
            // 
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView11.Location = new System.Drawing.Point(231, 228);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.RowHeadersWidth = 51;
            this.dataGridView11.RowTemplate.Height = 29;
            this.dataGridView11.Size = new System.Drawing.Size(108, 219);
            this.dataGridView11.TabIndex = 5;
            // 
            // dataGridView10
            // 
            this.dataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView10.Location = new System.Drawing.Point(117, 228);
            this.dataGridView10.Name = "dataGridView10";
            this.dataGridView10.RowHeadersWidth = 51;
            this.dataGridView10.RowTemplate.Height = 29;
            this.dataGridView10.Size = new System.Drawing.Size(108, 219);
            this.dataGridView10.TabIndex = 4;
            // 
            // dataGridView9
            // 
            this.dataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView9.Location = new System.Drawing.Point(3, 228);
            this.dataGridView9.Name = "dataGridView9";
            this.dataGridView9.RowHeadersWidth = 51;
            this.dataGridView9.RowTemplate.Height = 29;
            this.dataGridView9.Size = new System.Drawing.Size(108, 219);
            this.dataGridView9.TabIndex = 3;
            // 
            // dataGridView8
            // 
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Location = new System.Drawing.Point(231, 3);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.RowHeadersWidth = 51;
            this.dataGridView8.RowTemplate.Height = 29;
            this.dataGridView8.Size = new System.Drawing.Size(108, 219);
            this.dataGridView8.TabIndex = 2;
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(117, 3);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.RowHeadersWidth = 51;
            this.dataGridView7.RowTemplate.Height = 29;
            this.dataGridView7.Size = new System.Drawing.Size(108, 219);
            this.dataGridView7.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(108, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // addNewStudent
            // 
            this.addNewStudent.Location = new System.Drawing.Point(233, 65);
            this.addNewStudent.Name = "addNewStudent";
            this.addNewStudent.Size = new System.Drawing.Size(125, 29);
            this.addNewStudent.TabIndex = 1;
            this.addNewStudent.Text = "Добавить нового";
            this.addNewStudent.UseVisualStyleBackColor = true;
            this.addNewStudent.Click += new System.EventHandler(this.addNewStudent_Click);
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(233, 272);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(125, 29);
            this.Information.TabIndex = 0;
            this.Information.Text = "Информация";
            this.Information.UseVisualStyleBackColor = true;
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeight = 29;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeight = 29;
            this.dataGridView4.Location = new System.Drawing.Point(0, 0);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.Size = new System.Drawing.Size(240, 150);
            this.dataGridView4.TabIndex = 0;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeight = 29;
            this.dataGridView5.Location = new System.Drawing.Point(0, 0);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.Size = new System.Drawing.Size(240, 150);
            this.dataGridView5.TabIndex = 0;
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeight = 29;
            this.dataGridView6.Location = new System.Drawing.Point(0, 0);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.Size = new System.Drawing.Size(240, 150);
            this.dataGridView6.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Sex);
            this.Controls.Add(this.NameSurname);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameSurname;
        private System.Windows.Forms.TextBox Sex;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Information;
        private System.Windows.Forms.Button addNewStudent;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.DataGridView dataGridView10;
        private System.Windows.Forms.DataGridView dataGridView9;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

