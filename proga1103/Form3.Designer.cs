
namespace proga1103
{
    partial class Form3
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
            this.history = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.information = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // diagnosis
            // 
            this.diagnosis.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.diagnosis.Location = new System.Drawing.Point(0, 423);
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Size = new System.Drawing.Size(800, 27);
            this.diagnosis.TabIndex = 1;
            this.diagnosis.Text = "Диагноз: ";
            // 
            // history
            // 
            this.history.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.history.Location = new System.Drawing.Point(0, 396);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(800, 27);
            this.history.TabIndex = 2;
            this.history.Text = "История:";
            this.history.TextChanged += new System.EventHandler(this.history_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // information
            // 
            this.information.Dock = System.Windows.Forms.DockStyle.Fill;
            this.information.Location = new System.Drawing.Point(0, 0);
            this.information.Multiline = true;
            this.information.Name = "information";
            this.information.Size = new System.Drawing.Size(800, 450);
            this.information.TabIndex = 3;
            this.information.Click += new System.EventHandler(this.OpenFile);
            this.information.TextChanged += new System.EventHandler(this.information_TextChanged_2);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.history);
            this.Controls.Add(this.diagnosis);
            this.Controls.Add(this.information);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox diagnosis;
        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox information;
    }
}