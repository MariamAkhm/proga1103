
namespace proga1103
{
    partial class Form2
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
            this.diagnosis = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.TextBox();
            this.Sex2 = new System.Windows.Forms.TextBox();
            this.surname2 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.women = new System.Windows.Forms.RadioButton();
            this.man = new System.Windows.Forms.RadioButton();
            this.photo2 = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.photo2)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnosis
            // 
            this.diagnosis.Location = new System.Drawing.Point(376, 89);
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Size = new System.Drawing.Size(125, 27);
            this.diagnosis.TabIndex = 2;
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(82, 352);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(125, 27);
            this.data.TabIndex = 3;
            // 
            // Sex2
            // 
            this.Sex2.Location = new System.Drawing.Point(82, 220);
            this.Sex2.Multiline = true;
            this.Sex2.Name = "Sex2";
            this.Sex2.ReadOnly = true;
            this.Sex2.Size = new System.Drawing.Size(125, 84);
            this.Sex2.TabIndex = 4;
            // 
            // surname2
            // 
            this.surname2.Location = new System.Drawing.Point(82, 133);
            this.surname2.Name = "surname2";
            this.surname2.Size = new System.Drawing.Size(125, 27);
            this.surname2.TabIndex = 5;
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(82, 66);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(125, 27);
            this.name2.TabIndex = 6;
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox9.Location = new System.Drawing.Point(0, 680);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(1255, 27);
            this.textBox9.TabIndex = 9;
            // 
            // women
            // 
            this.women.AutoSize = true;
            this.women.Location = new System.Drawing.Point(98, 245);
            this.women.Name = "women";
            this.women.Size = new System.Drawing.Size(43, 24);
            this.women.TabIndex = 10;
            this.women.TabStop = true;
            this.women.Text = "Ж";
            this.women.UseVisualStyleBackColor = true;
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Location = new System.Drawing.Point(98, 275);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(43, 24);
            this.man.TabIndex = 11;
            this.man.TabStop = true;
            this.man.Text = "М";
            this.man.UseVisualStyleBackColor = true;
            // 
            // photo2
            // 
            this.photo2.Image = global::proga1103.Properties.Resources.yatupayaproekt;
            this.photo2.Location = new System.Drawing.Point(376, 174);
            this.photo2.Name = "photo2";
            this.photo2.Size = new System.Drawing.Size(176, 193);
            this.photo2.TabIndex = 12;
            this.photo2.TabStop = false;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(210, 423);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(128, 29);
            this.save.TabIndex = 13;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(431, 421);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(121, 29);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 707);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.photo2);
            this.Controls.Add(this.man);
            this.Controls.Add(this.women);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.surname2);
            this.Controls.Add(this.Sex2);
            this.Controls.Add(this.data);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.textBox9);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Sex2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.RadioButton women;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.PictureBox photo2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        public System.Windows.Forms.TextBox diagnosis;
        public System.Windows.Forms.TextBox data;
        public System.Windows.Forms.TextBox surname2;
        public System.Windows.Forms.TextBox name2;
    }
}