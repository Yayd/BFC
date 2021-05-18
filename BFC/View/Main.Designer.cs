
namespace BFC
{
    partial class Main
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
            this.AllTabs = new System.Windows.Forms.TabControl();
            this.Calculator = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultAfterLabel = new System.Windows.Forms.Label();
            this.resutlOutput = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.formulaGroupBox = new System.Windows.Forms.GroupBox();
            this.secondFormulaRB = new System.Windows.Forms.RadioButton();
            this.firstFormulaRB = new System.Windows.Forms.RadioButton();
            this.formuaLabel = new System.Windows.Forms.Label();
            this.planCombobox = new System.Windows.Forms.ComboBox();
            this.planLabel = new System.Windows.Forms.Label();
            this.activityCombobox = new System.Windows.Forms.ComboBox();
            this.activityLabel = new System.Windows.Forms.Label();
            this.heightAfterLabel = new System.Windows.Forms.Label();
            this.heightInput = new System.Windows.Forms.TextBox();
            this.hightLabel = new System.Windows.Forms.Label();
            this.weightAfterLabel = new System.Windows.Forms.Label();
            this.weightInput = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.sexBox = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.Products = new System.Windows.Forms.TabPage();
            this.AllTabs.SuspendLayout();
            this.Calculator.SuspendLayout();
            this.formulaGroupBox.SuspendLayout();
            this.sexBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllTabs
            // 
            this.AllTabs.Controls.Add(this.Calculator);
            this.AllTabs.Controls.Add(this.Products);
            this.AllTabs.Location = new System.Drawing.Point(12, 12);
            this.AllTabs.Name = "AllTabs";
            this.AllTabs.SelectedIndex = 0;
            this.AllTabs.Size = new System.Drawing.Size(514, 517);
            this.AllTabs.TabIndex = 0;
            // 
            // Calculator
            // 
            this.Calculator.Controls.Add(this.exitButton);
            this.Calculator.Controls.Add(this.calculateButton);
            this.Calculator.Controls.Add(this.resultAfterLabel);
            this.Calculator.Controls.Add(this.resutlOutput);
            this.Calculator.Controls.Add(this.resultLabel);
            this.Calculator.Controls.Add(this.formulaGroupBox);
            this.Calculator.Controls.Add(this.formuaLabel);
            this.Calculator.Controls.Add(this.planCombobox);
            this.Calculator.Controls.Add(this.planLabel);
            this.Calculator.Controls.Add(this.activityCombobox);
            this.Calculator.Controls.Add(this.activityLabel);
            this.Calculator.Controls.Add(this.heightAfterLabel);
            this.Calculator.Controls.Add(this.heightInput);
            this.Calculator.Controls.Add(this.hightLabel);
            this.Calculator.Controls.Add(this.weightAfterLabel);
            this.Calculator.Controls.Add(this.weightInput);
            this.Calculator.Controls.Add(this.weightLabel);
            this.Calculator.Controls.Add(this.yearLabel);
            this.Calculator.Controls.Add(this.ageInput);
            this.Calculator.Controls.Add(this.ageLabel);
            this.Calculator.Controls.Add(this.sexLabel);
            this.Calculator.Controls.Add(this.sexBox);
            this.Calculator.Location = new System.Drawing.Point(4, 24);
            this.Calculator.Name = "Calculator";
            this.Calculator.Padding = new System.Windows.Forms.Padding(3);
            this.Calculator.Size = new System.Drawing.Size(506, 489);
            this.Calculator.TabIndex = 0;
            this.Calculator.Text = "Калькулятор";
            this.Calculator.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(305, 426);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(155, 37);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(36, 426);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(155, 37);
            this.calculateButton.TabIndex = 21;
            this.calculateButton.Text = "Рассчитать";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // resultAfterLabel
            // 
            this.resultAfterLabel.AutoSize = true;
            this.resultAfterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultAfterLabel.Location = new System.Drawing.Point(317, 376);
            this.resultAfterLabel.Name = "resultAfterLabel";
            this.resultAfterLabel.Size = new System.Drawing.Size(31, 21);
            this.resultAfterLabel.TabIndex = 20;
            this.resultAfterLabel.Text = "см.";
            // 
            // resutlOutput
            // 
            this.resutlOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.resutlOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resutlOutput.Enabled = false;
            this.resutlOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resutlOutput.Location = new System.Drawing.Point(156, 373);
            this.resutlOutput.Name = "resutlOutput";
            this.resutlOutput.Size = new System.Drawing.Size(155, 29);
            this.resutlOutput.TabIndex = 19;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(67, 376);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(83, 21);
            this.resultLabel.TabIndex = 18;
            this.resultLabel.Text = "Результат:";
            // 
            // formulaGroupBox
            // 
            this.formulaGroupBox.Controls.Add(this.secondFormulaRB);
            this.formulaGroupBox.Controls.Add(this.firstFormulaRB);
            this.formulaGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formulaGroupBox.Location = new System.Drawing.Point(224, 262);
            this.formulaGroupBox.Name = "formulaGroupBox";
            this.formulaGroupBox.Size = new System.Drawing.Size(236, 66);
            this.formulaGroupBox.TabIndex = 17;
            this.formulaGroupBox.TabStop = false;
            // 
            // secondFormulaRB
            // 
            this.secondFormulaRB.AutoSize = true;
            this.secondFormulaRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondFormulaRB.Location = new System.Drawing.Point(6, 38);
            this.secondFormulaRB.Name = "secondFormulaRB";
            this.secondFormulaRB.Size = new System.Drawing.Size(106, 25);
            this.secondFormulaRB.TabIndex = 1;
            this.secondFormulaRB.TabStop = true;
            this.secondFormulaRB.Text = "Формула 2";
            this.secondFormulaRB.UseVisualStyleBackColor = true;
            // 
            // firstFormulaRB
            // 
            this.firstFormulaRB.AutoSize = true;
            this.firstFormulaRB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstFormulaRB.Location = new System.Drawing.Point(6, 7);
            this.firstFormulaRB.Name = "firstFormulaRB";
            this.firstFormulaRB.Size = new System.Drawing.Size(106, 25);
            this.firstFormulaRB.TabIndex = 0;
            this.firstFormulaRB.TabStop = true;
            this.firstFormulaRB.Text = "Формула 1";
            this.firstFormulaRB.UseVisualStyleBackColor = true;
            // 
            // formuaLabel
            // 
            this.formuaLabel.AutoSize = true;
            this.formuaLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formuaLabel.Location = new System.Drawing.Point(80, 271);
            this.formuaLabel.Name = "formuaLabel";
            this.formuaLabel.Size = new System.Drawing.Size(138, 21);
            this.formuaLabel.TabIndex = 16;
            this.formuaLabel.Text = "Формула расчета:";
            // 
            // planCombobox
            // 
            this.planCombobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.planCombobox.FormattingEnabled = true;
            this.planCombobox.Location = new System.Drawing.Point(224, 227);
            this.planCombobox.Name = "planCombobox";
            this.planCombobox.Size = new System.Drawing.Size(236, 29);
            this.planCombobox.TabIndex = 15;
            // 
            // planLabel
            // 
            this.planLabel.AutoSize = true;
            this.planLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.planLabel.Location = new System.Drawing.Point(169, 235);
            this.planLabel.Name = "planLabel";
            this.planLabel.Size = new System.Drawing.Size(49, 21);
            this.planLabel.TabIndex = 14;
            this.planLabel.Text = "План:";
            // 
            // activityCombobox
            // 
            this.activityCombobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activityCombobox.FormattingEnabled = true;
            this.activityCombobox.Location = new System.Drawing.Point(224, 192);
            this.activityCombobox.Name = "activityCombobox";
            this.activityCombobox.Size = new System.Drawing.Size(236, 29);
            this.activityCombobox.TabIndex = 13;
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activityLabel.Location = new System.Drawing.Point(36, 200);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(182, 21);
            this.activityLabel.TabIndex = 12;
            this.activityLabel.Text = "Физическая активность:";
            // 
            // heightAfterLabel
            // 
            this.heightAfterLabel.AutoSize = true;
            this.heightAfterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heightAfterLabel.Location = new System.Drawing.Point(263, 153);
            this.heightAfterLabel.Name = "heightAfterLabel";
            this.heightAfterLabel.Size = new System.Drawing.Size(31, 21);
            this.heightAfterLabel.TabIndex = 11;
            this.heightAfterLabel.Text = "см.";
            // 
            // heightInput
            // 
            this.heightInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heightInput.Location = new System.Drawing.Point(156, 150);
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(101, 29);
            this.heightInput.TabIndex = 10;
            // 
            // hightLabel
            // 
            this.hightLabel.AutoSize = true;
            this.hightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hightLabel.Location = new System.Drawing.Point(105, 153);
            this.hightLabel.Name = "hightLabel";
            this.hightLabel.Size = new System.Drawing.Size(45, 21);
            this.hightLabel.TabIndex = 9;
            this.hightLabel.Text = "Рост:";
            // 
            // weightAfterLabel
            // 
            this.weightAfterLabel.AutoSize = true;
            this.weightAfterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weightAfterLabel.Location = new System.Drawing.Point(263, 117);
            this.weightAfterLabel.Name = "weightAfterLabel";
            this.weightAfterLabel.Size = new System.Drawing.Size(27, 21);
            this.weightAfterLabel.TabIndex = 8;
            this.weightAfterLabel.Text = "кг.";
            // 
            // weightInput
            // 
            this.weightInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weightInput.Location = new System.Drawing.Point(156, 114);
            this.weightInput.Name = "weightInput";
            this.weightInput.Size = new System.Drawing.Size(101, 29);
            this.weightInput.TabIndex = 7;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.weightLabel.Location = new System.Drawing.Point(113, 117);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(37, 21);
            this.weightLabel.TabIndex = 6;
            this.weightLabel.Text = "Вес:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.Location = new System.Drawing.Point(263, 80);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(33, 21);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "лет";
            // 
            // ageInput
            // 
            this.ageInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageInput.Location = new System.Drawing.Point(156, 77);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(101, 29);
            this.ageInput.TabIndex = 4;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageLabel.Location = new System.Drawing.Point(81, 85);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(69, 21);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Возраст:";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sexLabel.Location = new System.Drawing.Point(109, 45);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(41, 21);
            this.sexLabel.TabIndex = 2;
            this.sexLabel.Text = "Пол:";
            // 
            // sexBox
            // 
            this.sexBox.Controls.Add(this.female);
            this.sexBox.Controls.Add(this.male);
            this.sexBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sexBox.Location = new System.Drawing.Point(156, 20);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(203, 46);
            this.sexBox.TabIndex = 0;
            this.sexBox.TabStop = false;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.female.Location = new System.Drawing.Point(107, 15);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(92, 25);
            this.female.TabIndex = 1;
            this.female.TabStop = true;
            this.female.Text = "Женский";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.male.Location = new System.Drawing.Point(6, 15);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(95, 25);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "Мужской";
            this.male.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.Products.Location = new System.Drawing.Point(4, 24);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(506, 489);
            this.Products.TabIndex = 1;
            this.Products.Text = "Продукты";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 541);
            this.Controls.Add(this.AllTabs);
            this.Name = "Main";
            this.Text = "Калькулятор БЖУ";
            this.AllTabs.ResumeLayout(false);
            this.Calculator.ResumeLayout(false);
            this.Calculator.PerformLayout();
            this.formulaGroupBox.ResumeLayout(false);
            this.formulaGroupBox.PerformLayout();
            this.sexBox.ResumeLayout(false);
            this.sexBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AllTabs;
        private System.Windows.Forms.TabPage Calculator;
        private System.Windows.Forms.GroupBox sexBox;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.ComboBox activityCombobox;
        private System.Windows.Forms.Label activityLabel;
        private System.Windows.Forms.Label heightAfterLabel;
        private System.Windows.Forms.TextBox heightInput;
        private System.Windows.Forms.Label hightLabel;
        private System.Windows.Forms.Label weightAfterLabel;
        private System.Windows.Forms.TextBox weightInput;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.GroupBox formulaGroupBox;
        private System.Windows.Forms.RadioButton secondFormulaRB;
        private System.Windows.Forms.RadioButton firstFormulaRB;
        private System.Windows.Forms.Label formuaLabel;
        private System.Windows.Forms.ComboBox planCombobox;
        private System.Windows.Forms.Label planLabel;
        private System.Windows.Forms.Label resultAfterLabel;
        private System.Windows.Forms.TextBox resutlOutput;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculateButton;
    }
}

