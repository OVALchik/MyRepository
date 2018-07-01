namespace OOPlaba2
{
    partial class CreateIndustry
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNameIndustry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddDepartment = new System.Windows.Forms.Button();
            this.buttonRemoveDepartment = new System.Windows.Forms.Button();
            this.buttonMakeIndustry = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonInit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAssembly = new System.Windows.Forms.RadioButton();
            this.radioButtonProcessing = new System.Windows.Forms.RadioButton();
            this.radioButtonStorage = new System.Windows.Forms.RadioButton();
            this.listBoxDepartments = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // textBoxNameIndustry
            // 
            this.textBoxNameIndustry.Location = new System.Drawing.Point(77, 13);
            this.textBoxNameIndustry.Name = "textBoxNameIndustry";
            this.textBoxNameIndustry.Size = new System.Drawing.Size(195, 20);
            this.textBoxNameIndustry.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Список цехов:";
            // 
            // buttonAddDepartment
            // 
            this.buttonAddDepartment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddDepartment.Location = new System.Drawing.Point(197, 254);
            this.buttonAddDepartment.Name = "buttonAddDepartment";
            this.buttonAddDepartment.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDepartment.TabIndex = 4;
            this.buttonAddDepartment.Text = "Добавить";
            this.buttonAddDepartment.UseVisualStyleBackColor = false;
            this.buttonAddDepartment.Click += new System.EventHandler(this.buttonAddDepartment_Click);
            // 
            // buttonRemoveDepartment
            // 
            this.buttonRemoveDepartment.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRemoveDepartment.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRemoveDepartment.Location = new System.Drawing.Point(197, 127);
            this.buttonRemoveDepartment.Name = "buttonRemoveDepartment";
            this.buttonRemoveDepartment.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveDepartment.TabIndex = 5;
            this.buttonRemoveDepartment.Text = "Удалить";
            this.buttonRemoveDepartment.UseVisualStyleBackColor = false;
            this.buttonRemoveDepartment.Click += new System.EventHandler(this.buttonRemoveDepartment_Click);
            // 
            // buttonMakeIndustry
            // 
            this.buttonMakeIndustry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonMakeIndustry.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonMakeIndustry.Location = new System.Drawing.Point(197, 283);
            this.buttonMakeIndustry.Name = "buttonMakeIndustry";
            this.buttonMakeIndustry.Size = new System.Drawing.Size(75, 23);
            this.buttonMakeIndustry.TabIndex = 7;
            this.buttonMakeIndustry.Text = "Готово";
            this.buttonMakeIndustry.UseVisualStyleBackColor = false;
            this.buttonMakeIndustry.Click += new System.EventHandler(this.buttonMakeIndustry_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(16, 283);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(129, 23);
            this.buttonInfo.TabIndex = 8;
            this.buttonInfo.Text = "Отчет о предприятии";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(173, 37);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(99, 23);
            this.buttonInit.TabIndex = 10;
            this.buttonInit.Text = "Инициализация";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAssembly);
            this.groupBox1.Controls.Add(this.radioButtonProcessing);
            this.groupBox1.Controls.Add(this.radioButtonStorage);
            this.groupBox1.Location = new System.Drawing.Point(19, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 92);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип цеха";
            // 
            // radioButtonAssembly
            // 
            this.radioButtonAssembly.AutoSize = true;
            this.radioButtonAssembly.Location = new System.Drawing.Point(7, 67);
            this.radioButtonAssembly.Name = "radioButtonAssembly";
            this.radioButtonAssembly.Size = new System.Drawing.Size(155, 17);
            this.radioButtonAssembly.TabIndex = 2;
            this.radioButtonAssembly.TabStop = true;
            this.radioButtonAssembly.Text = "Сборочно-монтажный цех";
            this.radioButtonAssembly.UseVisualStyleBackColor = true;
            // 
            // radioButtonProcessing
            // 
            this.radioButtonProcessing.AutoSize = true;
            this.radioButtonProcessing.Location = new System.Drawing.Point(7, 44);
            this.radioButtonProcessing.Name = "radioButtonProcessing";
            this.radioButtonProcessing.Size = new System.Drawing.Size(137, 17);
            this.radioButtonProcessing.TabIndex = 1;
            this.radioButtonProcessing.TabStop = true;
            this.radioButtonProcessing.Text = "Обрабатывающий цех";
            this.radioButtonProcessing.UseVisualStyleBackColor = true;
            // 
            // radioButtonStorage
            // 
            this.radioButtonStorage.AutoSize = true;
            this.radioButtonStorage.Location = new System.Drawing.Point(7, 20);
            this.radioButtonStorage.Name = "radioButtonStorage";
            this.radioButtonStorage.Size = new System.Drawing.Size(135, 17);
            this.radioButtonStorage.TabIndex = 0;
            this.radioButtonStorage.TabStop = true;
            this.radioButtonStorage.Text = "Заготовительный цех";
            this.radioButtonStorage.UseVisualStyleBackColor = true;
            // 
            // listBoxDepartments
            // 
            this.listBoxDepartments.FormattingEnabled = true;
            this.listBoxDepartments.Location = new System.Drawing.Point(16, 63);
            this.listBoxDepartments.Name = "listBoxDepartments";
            this.listBoxDepartments.Size = new System.Drawing.Size(256, 56);
            this.listBoxDepartments.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreateIndustry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(290, 318);
            this.Controls.Add(this.listBoxDepartments);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonInit);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonMakeIndustry);
            this.Controls.Add(this.buttonRemoveDepartment);
            this.Controls.Add(this.buttonAddDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNameIndustry);
            this.Controls.Add(this.label1);
            this.Name = "CreateIndustry";
            this.Text = "Создание производства";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNameIndustry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddDepartment;
        private System.Windows.Forms.Button buttonRemoveDepartment;
        private System.Windows.Forms.Button buttonMakeIndustry;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAssembly;
        private System.Windows.Forms.RadioButton radioButtonProcessing;
        private System.Windows.Forms.RadioButton radioButtonStorage;
        private System.Windows.Forms.ListBox listBoxDepartments;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}