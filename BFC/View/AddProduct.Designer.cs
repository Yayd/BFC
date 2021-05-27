
namespace BFC.View
{
    partial class AddProduct
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
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.CaloriesLabel = new System.Windows.Forms.Label();
            this.CaloriesInput = new System.Windows.Forms.TextBox();
            this.ProteinsInput = new System.Windows.Forms.TextBox();
            this.FatInput = new System.Windows.Forms.TextBox();
            this.CarboInput = new System.Windows.Forms.TextBox();
            this.ProteinsLabel = new System.Windows.Forms.Label();
            this.FatLabel = new System.Windows.Forms.Label();
            this.CarboLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryLabel.Location = new System.Drawing.Point(104, 30);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(86, 21);
            this.CategoryLabel.TabIndex = 0;
            this.CategoryLabel.Text = "Категория:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(196, 27);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(188, 29);
            this.CategoryComboBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(38, 74);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(152, 21);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Название продукта:";
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameInput.Location = new System.Drawing.Point(196, 71);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(188, 29);
            this.NameInput.TabIndex = 3;
            // 
            // CaloriesLabel
            // 
            this.CaloriesLabel.AutoSize = true;
            this.CaloriesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaloriesLabel.Location = new System.Drawing.Point(116, 119);
            this.CaloriesLabel.Name = "CaloriesLabel";
            this.CaloriesLabel.Size = new System.Drawing.Size(74, 21);
            this.CaloriesLabel.TabIndex = 4;
            this.CaloriesLabel.Text = "Калории:";
            // 
            // CaloriesInput
            // 
            this.CaloriesInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaloriesInput.Location = new System.Drawing.Point(196, 116);
            this.CaloriesInput.Name = "CaloriesInput";
            this.CaloriesInput.Size = new System.Drawing.Size(86, 29);
            this.CaloriesInput.TabIndex = 5;
            this.CaloriesInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CaloriesInput_KeyPress);
            // 
            // ProteinsInput
            // 
            this.ProteinsInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProteinsInput.Location = new System.Drawing.Point(196, 160);
            this.ProteinsInput.Name = "ProteinsInput";
            this.ProteinsInput.Size = new System.Drawing.Size(86, 29);
            this.ProteinsInput.TabIndex = 6;
            this.ProteinsInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProteinsInput_KeyPress);
            // 
            // FatInput
            // 
            this.FatInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FatInput.Location = new System.Drawing.Point(196, 204);
            this.FatInput.Name = "FatInput";
            this.FatInput.Size = new System.Drawing.Size(86, 29);
            this.FatInput.TabIndex = 7;
            this.FatInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FatInput_KeyPress);
            // 
            // CarboInput
            // 
            this.CarboInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarboInput.Location = new System.Drawing.Point(196, 248);
            this.CarboInput.Name = "CarboInput";
            this.CarboInput.Size = new System.Drawing.Size(86, 29);
            this.CarboInput.TabIndex = 8;
            this.CarboInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CarboInput_KeyPress);
            // 
            // ProteinsLabel
            // 
            this.ProteinsLabel.AutoSize = true;
            this.ProteinsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProteinsLabel.Location = new System.Drawing.Point(135, 163);
            this.ProteinsLabel.Name = "ProteinsLabel";
            this.ProteinsLabel.Size = new System.Drawing.Size(55, 21);
            this.ProteinsLabel.TabIndex = 9;
            this.ProteinsLabel.Text = "Белки:";
            // 
            // FatLabel
            // 
            this.FatLabel.AutoSize = true;
            this.FatLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FatLabel.Location = new System.Drawing.Point(134, 207);
            this.FatLabel.Name = "FatLabel";
            this.FatLabel.Size = new System.Drawing.Size(56, 21);
            this.FatLabel.TabIndex = 10;
            this.FatLabel.Text = "Жиры:";
            // 
            // CarboLabel
            // 
            this.CarboLabel.AutoSize = true;
            this.CarboLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarboLabel.Location = new System.Drawing.Point(109, 251);
            this.CarboLabel.Name = "CarboLabel";
            this.CarboLabel.Size = new System.Drawing.Size(81, 21);
            this.CarboLabel.TabIndex = 11;
            this.CarboLabel.Text = "Углеводы:";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.Location = new System.Drawing.Point(38, 305);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(134, 33);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(250, 305);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(134, 33);
            this.ExitButton.TabIndex = 13;
            this.ExitButton.Text = "Назад";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 362);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CarboLabel);
            this.Controls.Add(this.FatLabel);
            this.Controls.Add(this.ProteinsLabel);
            this.Controls.Add(this.CarboInput);
            this.Controls.Add(this.FatInput);
            this.Controls.Add(this.ProteinsInput);
            this.Controls.Add(this.CaloriesInput);
            this.Controls.Add(this.CaloriesLabel);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Name = "AddProduct";
            this.Text = "Добавть продукт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label CaloriesLabel;
        private System.Windows.Forms.TextBox CaloriesInput;
        private System.Windows.Forms.TextBox ProteinsInput;
        private System.Windows.Forms.TextBox FatInput;
        private System.Windows.Forms.TextBox CarboInput;
        private System.Windows.Forms.Label ProteinsLabel;
        private System.Windows.Forms.Label FatLabel;
        private System.Windows.Forms.Label CarboLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ExitButton;
    }
}