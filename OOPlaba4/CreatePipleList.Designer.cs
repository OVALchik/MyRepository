namespace OOPlaba2
{
    partial class CreatePipleList
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
            this.components = new System.ComponentModel.Container();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.buttonAddPiple = new System.Windows.Forms.Button();
            this.buttonRemovePiple = new System.Windows.Forms.Button();
            this.buttonMakePipleList = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listBoxPiple = new System.Windows.Forms.ListBox();
            this.buttonInit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(13, 13);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(193, 20);
            this.textBoxFIO.TabIndex = 1;
            this.textBoxFIO.TextChanged += new System.EventHandler(this.textBoxFIO_TextChanged);
            // 
            // buttonAddPiple
            // 
            this.buttonAddPiple.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddPiple.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddPiple.Location = new System.Drawing.Point(13, 51);
            this.buttonAddPiple.Name = "buttonAddPiple";
            this.buttonAddPiple.Size = new System.Drawing.Size(75, 23);
            this.buttonAddPiple.TabIndex = 2;
            this.buttonAddPiple.Text = "Добавить";
            this.buttonAddPiple.UseVisualStyleBackColor = false;
            this.buttonAddPiple.Click += new System.EventHandler(this.buttonAddPiple_Click);
            // 
            // buttonRemovePiple
            // 
            this.buttonRemovePiple.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRemovePiple.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRemovePiple.Location = new System.Drawing.Point(94, 51);
            this.buttonRemovePiple.Name = "buttonRemovePiple";
            this.buttonRemovePiple.Size = new System.Drawing.Size(75, 23);
            this.buttonRemovePiple.TabIndex = 3;
            this.buttonRemovePiple.Text = "Удалить";
            this.buttonRemovePiple.UseVisualStyleBackColor = false;
            this.buttonRemovePiple.Click += new System.EventHandler(this.buttonRemovePiple_Click);
            // 
            // buttonMakePipleList
            // 
            this.buttonMakePipleList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMakePipleList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMakePipleList.Location = new System.Drawing.Point(163, 235);
            this.buttonMakePipleList.Name = "buttonMakePipleList";
            this.buttonMakePipleList.Size = new System.Drawing.Size(109, 23);
            this.buttonMakePipleList.TabIndex = 5;
            this.buttonMakePipleList.Text = "Готово";
            this.buttonMakePipleList.UseVisualStyleBackColor = false;
            this.buttonMakePipleList.Click += new System.EventHandler(this.buttonMakePipleList_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // listBoxPiple
            // 
            this.listBoxPiple.FormattingEnabled = true;
            this.listBoxPiple.Location = new System.Drawing.Point(13, 93);
            this.listBoxPiple.Name = "listBoxPiple";
            this.listBoxPiple.Size = new System.Drawing.Size(259, 121);
            this.listBoxPiple.TabIndex = 6;
            this.listBoxPiple.SelectedIndexChanged += new System.EventHandler(this.listBoxPiple_SelectedIndexChanged);
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(175, 51);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(97, 23);
            this.buttonInit.TabIndex = 7;
            this.buttonInit.Text = "Инициализация";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // CreatePipleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 270);
            this.Controls.Add(this.buttonInit);
            this.Controls.Add(this.listBoxPiple);
            this.Controls.Add(this.buttonMakePipleList);
            this.Controls.Add(this.buttonRemovePiple);
            this.Controls.Add(this.buttonAddPiple);
            this.Controls.Add(this.textBoxFIO);
            this.Name = "CreatePipleList";
            this.Text = "CreatePipleList";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Button buttonAddPiple;
        private System.Windows.Forms.Button buttonRemovePiple;
        private System.Windows.Forms.Button buttonMakePipleList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox listBoxPiple;
        private System.Windows.Forms.Button buttonInit;
    }
}