namespace OOPlaba2
{
    partial class CreateProduction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTypeProduct = new System.Windows.Forms.TextBox();
            this.buttonInit = new System.Windows.Forms.Button();
            this.listBoxProduction = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemoveProduction = new System.Windows.Forms.Button();
            this.buttonAddProduction = new System.Windows.Forms.Button();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxHight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNameProduction = new System.Windows.Forms.TextBox();
            this.labelNameProduction = new System.Windows.Forms.Label();
            this.comboBoxTypeProduction = new System.Windows.Forms.ComboBox();
            this.labelTypeProduction = new System.Windows.Forms.Label();
            this.labelTypeMaterial = new System.Windows.Forms.Label();
            this.comboBoxTypeMaterial = new System.Windows.Forms.ComboBox();
            this.storageDepartmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storageDepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.industryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageDepartmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.industryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxTypeProduct);
            this.panel1.Controls.Add(this.buttonInit);
            this.panel1.Controls.Add(this.listBoxProduction);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonRemoveProduction);
            this.panel1.Controls.Add(this.buttonAddProduction);
            this.panel1.Controls.Add(this.textBoxCount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxWeight);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBoxHight);
            this.panel1.Controls.Add(this.textBoxWidth);
            this.panel1.Controls.Add(this.textBoxLength);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxNameProduction);
            this.panel1.Controls.Add(this.labelNameProduction);
            this.panel1.Controls.Add(this.comboBoxTypeProduction);
            this.panel1.Controls.Add(this.labelTypeProduction);
            this.panel1.Controls.Add(this.labelTypeMaterial);
            this.panel1.Controls.Add(this.comboBoxTypeMaterial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 239);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Тип продукции";
            // 
            // textBoxTypeProduct
            // 
            this.textBoxTypeProduct.Enabled = false;
            this.textBoxTypeProduct.Location = new System.Drawing.Point(114, 12);
            this.textBoxTypeProduct.Name = "textBoxTypeProduct";
            this.textBoxTypeProduct.Size = new System.Drawing.Size(133, 20);
            this.textBoxTypeProduct.TabIndex = 28;
            // 
            // buttonInit
            // 
            this.buttonInit.Location = new System.Drawing.Point(276, 176);
            this.buttonInit.Name = "buttonInit";
            this.buttonInit.Size = new System.Drawing.Size(100, 26);
            this.buttonInit.TabIndex = 27;
            this.buttonInit.Text = "Инициализация";
            this.buttonInit.UseVisualStyleBackColor = true;
            this.buttonInit.Click += new System.EventHandler(this.buttonInit_Click);
            // 
            // listBoxProduction
            // 
            this.listBoxProduction.FormattingEnabled = true;
            this.listBoxProduction.Location = new System.Drawing.Point(276, 75);
            this.listBoxProduction.Name = "listBoxProduction";
            this.listBoxProduction.Size = new System.Drawing.Size(342, 95);
            this.listBoxProduction.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 31);
            this.panel2.TabIndex = 21;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSave.FlatAppearance.BorderSize = 2;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSave.Location = new System.Drawing.Point(0, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(156, 31);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Применить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemoveProduction
            // 
            this.buttonRemoveProduction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRemoveProduction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRemoveProduction.Location = new System.Drawing.Point(503, 176);
            this.buttonRemoveProduction.Name = "buttonRemoveProduction";
            this.buttonRemoveProduction.Size = new System.Drawing.Size(115, 26);
            this.buttonRemoveProduction.TabIndex = 19;
            this.buttonRemoveProduction.Text = "Удалить";
            this.buttonRemoveProduction.UseVisualStyleBackColor = false;
            this.buttonRemoveProduction.Click += new System.EventHandler(this.buttonRemoveProduction_Click);
            // 
            // buttonAddProduction
            // 
            this.buttonAddProduction.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddProduction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddProduction.Location = new System.Drawing.Point(382, 176);
            this.buttonAddProduction.Name = "buttonAddProduction";
            this.buttonAddProduction.Size = new System.Drawing.Size(115, 26);
            this.buttonAddProduction.TabIndex = 16;
            this.buttonAddProduction.Text = "Добавить";
            this.buttonAddProduction.UseVisualStyleBackColor = false;
            this.buttonAddProduction.Click += new System.EventHandler(this.buttonAddProduction_Click);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(498, 49);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(61, 20);
            this.textBoxCount.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(444, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Кол-во";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(335, 49);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(87, 20);
            this.textBoxWeight.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Вес";
            // 
            // textBoxHight
            // 
            this.textBoxHight.Location = new System.Drawing.Point(491, 16);
            this.textBoxHight.Name = "textBoxHight";
            this.textBoxHight.Size = new System.Drawing.Size(68, 20);
            this.textBoxHight.TabIndex = 9;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(417, 16);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(68, 20);
            this.textBoxWidth.TabIndex = 8;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(335, 16);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(76, 20);
            this.textBoxLength.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Габариты";
            // 
            // textBoxNameProduction
            // 
            this.textBoxNameProduction.Location = new System.Drawing.Point(114, 102);
            this.textBoxNameProduction.Name = "textBoxNameProduction";
            this.textBoxNameProduction.Size = new System.Drawing.Size(133, 20);
            this.textBoxNameProduction.TabIndex = 5;
            // 
            // labelNameProduction
            // 
            this.labelNameProduction.AutoSize = true;
            this.labelNameProduction.Location = new System.Drawing.Point(6, 102);
            this.labelNameProduction.Name = "labelNameProduction";
            this.labelNameProduction.Size = new System.Drawing.Size(57, 13);
            this.labelNameProduction.TabIndex = 4;
            this.labelNameProduction.Text = "Название";
            // 
            // comboBoxTypeProduction
            // 
            this.comboBoxTypeProduction.FormattingEnabled = true;
            this.comboBoxTypeProduction.Location = new System.Drawing.Point(114, 73);
            this.comboBoxTypeProduction.Name = "comboBoxTypeProduction";
            this.comboBoxTypeProduction.Size = new System.Drawing.Size(133, 21);
            this.comboBoxTypeProduction.TabIndex = 3;
            // 
            // labelTypeProduction
            // 
            this.labelTypeProduction.AutoSize = true;
            this.labelTypeProduction.Location = new System.Drawing.Point(6, 73);
            this.labelTypeProduction.Name = "labelTypeProduction";
            this.labelTypeProduction.Size = new System.Drawing.Size(82, 13);
            this.labelTypeProduction.TabIndex = 2;
            this.labelTypeProduction.Text = "Тип продукции";
            // 
            // labelTypeMaterial
            // 
            this.labelTypeMaterial.AutoSize = true;
            this.labelTypeMaterial.Location = new System.Drawing.Point(9, 43);
            this.labelTypeMaterial.Name = "labelTypeMaterial";
            this.labelTypeMaterial.Size = new System.Drawing.Size(84, 13);
            this.labelTypeMaterial.TabIndex = 1;
            this.labelTypeMaterial.Text = "Тип материала";
            // 
            // comboBoxTypeMaterial
            // 
            this.comboBoxTypeMaterial.FormattingEnabled = true;
            this.comboBoxTypeMaterial.Location = new System.Drawing.Point(114, 40);
            this.comboBoxTypeMaterial.Name = "comboBoxTypeMaterial";
            this.comboBoxTypeMaterial.Size = new System.Drawing.Size(133, 21);
            this.comboBoxTypeMaterial.TabIndex = 0;
            // 
            // storageDepartmentBindingSource1
            // 
            this.storageDepartmentBindingSource1.DataSource = typeof(OOPlaba2.StorageDepartment);
            // 
            // storageDepartmentBindingSource
            // 
            this.storageDepartmentBindingSource.DataSource = typeof(OOPlaba2.StorageDepartment);
            // 
            // industryBindingSource
            // 
            this.industryBindingSource.DataSource = typeof(OOPlaba2.Industry);
            // 
            // CreateProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 239);
            this.Controls.Add(this.panel1);
            this.Name = "CreateProduction";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storageDepartmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageDepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.industryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource storageDepartmentBindingSource;
        private System.Windows.Forms.BindingSource industryBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddProduction;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxHight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNameProduction;
        private System.Windows.Forms.Label labelNameProduction;
        private System.Windows.Forms.ComboBox comboBoxTypeProduction;
        private System.Windows.Forms.Label labelTypeProduction;
        private System.Windows.Forms.Label labelTypeMaterial;
        private System.Windows.Forms.ComboBox comboBoxTypeMaterial;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.BindingSource storageDepartmentBindingSource1;
        private System.Windows.Forms.Button buttonRemoveProduction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonInit;
        private System.Windows.Forms.ListBox listBoxProduction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTypeProduct;
    }
}