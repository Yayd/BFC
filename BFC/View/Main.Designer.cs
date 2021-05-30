
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultAfterLabel = new System.Windows.Forms.Label();
            this.ResutlOutput = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.PlanCombobox = new System.Windows.Forms.ComboBox();
            this.PlanLabel = new System.Windows.Forms.Label();
            this.ActivityCombobox = new System.Windows.Forms.ComboBox();
            this.ActivityLabel = new System.Windows.Forms.Label();
            this.HeightAfterLabel = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.HightLabel = new System.Windows.Forms.Label();
            this.WeightAfterLabel = new System.Windows.Forms.Label();
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.AgeInput = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.SexBox = new System.Windows.Forms.GroupBox();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.Products = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductResultUnitsLabel = new System.Windows.Forms.Label();
            this.ProductResultOutput = new System.Windows.Forms.TextBox();
            this.ProductResultLabel = new System.Windows.Forms.Label();
            this.WeightUnitsLabel = new System.Windows.Forms.Label();
            this.ProductWeightInput = new System.Windows.Forms.TextBox();
            this.ProductWeightLabel = new System.Windows.Forms.Label();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.CarboOutput = new System.Windows.Forms.TextBox();
            this.CarboLabel = new System.Windows.Forms.Label();
            this.ProteinsOutput = new System.Windows.Forms.TextBox();
            this.ProteinsLabel = new System.Windows.Forms.Label();
            this.CaloriesOutput = new System.Windows.Forms.TextBox();
            this.CaloriesLabel = new System.Windows.Forms.Label();
            this.FatsOutput = new System.Windows.Forms.TextBox();
            this.FatsLabel = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ProductsCombobox = new System.Windows.Forms.ComboBox();
            this.AllTabs.SuspendLayout();
            this.Calculator.SuspendLayout();
            this.SexBox.SuspendLayout();
            this.Products.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
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
            this.Calculator.Controls.Add(this.CalculateButton);
            this.Calculator.Controls.Add(this.ResultAfterLabel);
            this.Calculator.Controls.Add(this.ResutlOutput);
            this.Calculator.Controls.Add(this.ResultLabel);
            this.Calculator.Controls.Add(this.PlanCombobox);
            this.Calculator.Controls.Add(this.PlanLabel);
            this.Calculator.Controls.Add(this.ActivityCombobox);
            this.Calculator.Controls.Add(this.ActivityLabel);
            this.Calculator.Controls.Add(this.HeightAfterLabel);
            this.Calculator.Controls.Add(this.HeightInput);
            this.Calculator.Controls.Add(this.HightLabel);
            this.Calculator.Controls.Add(this.WeightAfterLabel);
            this.Calculator.Controls.Add(this.WeightInput);
            this.Calculator.Controls.Add(this.WeightLabel);
            this.Calculator.Controls.Add(this.YearLabel);
            this.Calculator.Controls.Add(this.AgeInput);
            this.Calculator.Controls.Add(this.AgeLabel);
            this.Calculator.Controls.Add(this.SexLabel);
            this.Calculator.Controls.Add(this.SexBox);
            this.Calculator.Location = new System.Drawing.Point(4, 24);
            this.Calculator.Name = "Calculator";
            this.Calculator.Padding = new System.Windows.Forms.Padding(3);
            this.Calculator.Size = new System.Drawing.Size(506, 489);
            this.Calculator.TabIndex = 0;
            this.Calculator.Text = "Калькулятор";
            this.Calculator.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculateButton.Location = new System.Drawing.Point(156, 429);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(155, 37);
            this.CalculateButton.TabIndex = 21;
            this.CalculateButton.Text = "Рассчитать";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultAfterLabel
            // 
            this.ResultAfterLabel.AutoSize = true;
            this.ResultAfterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultAfterLabel.Location = new System.Drawing.Point(317, 376);
            this.ResultAfterLabel.Name = "ResultAfterLabel";
            this.ResultAfterLabel.Size = new System.Drawing.Size(70, 21);
            this.ResultAfterLabel.TabIndex = 20;
            this.ResultAfterLabel.Text = "ккал/сут";
            // 
            // ResutlOutput
            // 
            this.ResutlOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ResutlOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResutlOutput.Enabled = false;
            this.ResutlOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResutlOutput.Location = new System.Drawing.Point(156, 373);
            this.ResutlOutput.Name = "ResutlOutput";
            this.ResutlOutput.Size = new System.Drawing.Size(155, 29);
            this.ResutlOutput.TabIndex = 19;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResultLabel.Location = new System.Drawing.Point(67, 376);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(83, 21);
            this.ResultLabel.TabIndex = 18;
            this.ResultLabel.Text = "Результат:";
            // 
            // PlanCombobox
            // 
            this.PlanCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlanCombobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlanCombobox.FormattingEnabled = true;
            this.PlanCombobox.Location = new System.Drawing.Point(224, 227);
            this.PlanCombobox.Name = "PlanCombobox";
            this.PlanCombobox.Size = new System.Drawing.Size(236, 29);
            this.PlanCombobox.TabIndex = 15;
            // 
            // PlanLabel
            // 
            this.PlanLabel.AutoSize = true;
            this.PlanLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlanLabel.Location = new System.Drawing.Point(169, 235);
            this.PlanLabel.Name = "PlanLabel";
            this.PlanLabel.Size = new System.Drawing.Size(49, 21);
            this.PlanLabel.TabIndex = 14;
            this.PlanLabel.Text = "План:";
            // 
            // ActivityCombobox
            // 
            this.ActivityCombobox.AllowDrop = true;
            this.ActivityCombobox.CausesValidation = false;
            this.ActivityCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActivityCombobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActivityCombobox.FormattingEnabled = true;
            this.ActivityCombobox.Items.AddRange(new object[] {
            "Физическая нагрузка отсутствует или минимальная",
            "Тренировки средней тяжести 3 раза в неделю"});
            this.ActivityCombobox.Location = new System.Drawing.Point(224, 192);
            this.ActivityCombobox.Name = "ActivityCombobox";
            this.ActivityCombobox.Size = new System.Drawing.Size(236, 29);
            this.ActivityCombobox.TabIndex = 13;
            // 
            // ActivityLabel
            // 
            this.ActivityLabel.AutoSize = true;
            this.ActivityLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActivityLabel.Location = new System.Drawing.Point(36, 200);
            this.ActivityLabel.Name = "ActivityLabel";
            this.ActivityLabel.Size = new System.Drawing.Size(182, 21);
            this.ActivityLabel.TabIndex = 12;
            this.ActivityLabel.Text = "Физическая активность:";
            // 
            // HeightAfterLabel
            // 
            this.HeightAfterLabel.AutoSize = true;
            this.HeightAfterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightAfterLabel.Location = new System.Drawing.Point(263, 153);
            this.HeightAfterLabel.Name = "HeightAfterLabel";
            this.HeightAfterLabel.Size = new System.Drawing.Size(31, 21);
            this.HeightAfterLabel.TabIndex = 11;
            this.HeightAfterLabel.Text = "см.";
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightInput.Location = new System.Drawing.Point(156, 150);
            this.HeightInput.MaxLength = 8;
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(101, 29);
            this.HeightInput.TabIndex = 10;
            this.HeightInput.Text = "150";
            this.HeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeightInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightInput_KeyPress);
            // 
            // HightLabel
            // 
            this.HightLabel.AutoSize = true;
            this.HightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HightLabel.Location = new System.Drawing.Point(105, 153);
            this.HightLabel.Name = "HightLabel";
            this.HightLabel.Size = new System.Drawing.Size(45, 21);
            this.HightLabel.TabIndex = 9;
            this.HightLabel.Text = "Рост:";
            // 
            // WeightAfterLabel
            // 
            this.WeightAfterLabel.AutoSize = true;
            this.WeightAfterLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightAfterLabel.Location = new System.Drawing.Point(263, 117);
            this.WeightAfterLabel.Name = "WeightAfterLabel";
            this.WeightAfterLabel.Size = new System.Drawing.Size(27, 21);
            this.WeightAfterLabel.TabIndex = 8;
            this.WeightAfterLabel.Text = "кг.";
            // 
            // WeightInput
            // 
            this.WeightInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightInput.Location = new System.Drawing.Point(156, 114);
            this.WeightInput.MaxLength = 8;
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(101, 29);
            this.WeightInput.TabIndex = 7;
            this.WeightInput.Text = "60";
            this.WeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WeightInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightInput_KeyPress);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightLabel.Location = new System.Drawing.Point(113, 117);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(37, 21);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "Вес:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YearLabel.Location = new System.Drawing.Point(263, 80);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(33, 21);
            this.YearLabel.TabIndex = 5;
            this.YearLabel.Text = "лет";
            // 
            // AgeInput
            // 
            this.AgeInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeInput.Location = new System.Drawing.Point(156, 77);
            this.AgeInput.MaxLength = 8;
            this.AgeInput.Name = "AgeInput";
            this.AgeInput.Size = new System.Drawing.Size(101, 29);
            this.AgeInput.TabIndex = 4;
            this.AgeInput.Text = "13";
            this.AgeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AgeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgeInput_KeyPress);
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeLabel.Location = new System.Drawing.Point(81, 85);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(69, 21);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "Возраст:";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SexLabel.Location = new System.Drawing.Point(109, 45);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(41, 21);
            this.SexLabel.TabIndex = 2;
            this.SexLabel.Text = "Пол:";
            // 
            // SexBox
            // 
            this.SexBox.Controls.Add(this.FemaleRadioButton);
            this.SexBox.Controls.Add(this.MaleRadioButton);
            this.SexBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SexBox.Location = new System.Drawing.Point(156, 20);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(203, 46);
            this.SexBox.TabIndex = 0;
            this.SexBox.TabStop = false;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FemaleRadioButton.Location = new System.Drawing.Point(107, 15);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(92, 25);
            this.FemaleRadioButton.TabIndex = 1;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Женский";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Checked = true;
            this.MaleRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaleRadioButton.Location = new System.Drawing.Point(6, 15);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(95, 25);
            this.MaleRadioButton.TabIndex = 0;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Мужской";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            this.Products.Controls.Add(this.label1);
            this.Products.Controls.Add(this.ProductResultUnitsLabel);
            this.Products.Controls.Add(this.ProductResultOutput);
            this.Products.Controls.Add(this.ProductResultLabel);
            this.Products.Controls.Add(this.WeightUnitsLabel);
            this.Products.Controls.Add(this.ProductWeightInput);
            this.Products.Controls.Add(this.ProductWeightLabel);
            this.Products.Controls.Add(this.InfoGroupBox);
            this.Products.Controls.Add(this.AddProductButton);
            this.Products.Controls.Add(this.ProductsCombobox);
            this.Products.Location = new System.Drawing.Point(4, 24);
            this.Products.Name = "Products";
            this.Products.Padding = new System.Windows.Forms.Padding(3);
            this.Products.Size = new System.Drawing.Size(506, 489);
            this.Products.TabIndex = 1;
            this.Products.Text = "Продукты";
            this.Products.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(136, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Выберите продукт из списка:";
            // 
            // ProductResultUnitsLabel
            // 
            this.ProductResultUnitsLabel.AutoSize = true;
            this.ProductResultUnitsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductResultUnitsLabel.Location = new System.Drawing.Point(319, 376);
            this.ProductResultUnitsLabel.Name = "ProductResultUnitsLabel";
            this.ProductResultUnitsLabel.Size = new System.Drawing.Size(45, 21);
            this.ProductResultUnitsLabel.TabIndex = 13;
            this.ProductResultUnitsLabel.Text = "ккал.";
            // 
            // ProductResultOutput
            // 
            this.ProductResultOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.ProductResultOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProductResultOutput.Enabled = false;
            this.ProductResultOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductResultOutput.Location = new System.Drawing.Point(156, 373);
            this.ProductResultOutput.Name = "ProductResultOutput";
            this.ProductResultOutput.Size = new System.Drawing.Size(155, 29);
            this.ProductResultOutput.TabIndex = 12;
            this.ProductResultOutput.TextChanged += new System.EventHandler(this.ProductResultOutput_TextChanged);
            // 
            // ProductResultLabel
            // 
            this.ProductResultLabel.AutoSize = true;
            this.ProductResultLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductResultLabel.Location = new System.Drawing.Point(67, 376);
            this.ProductResultLabel.Name = "ProductResultLabel";
            this.ProductResultLabel.Size = new System.Drawing.Size(83, 21);
            this.ProductResultLabel.TabIndex = 11;
            this.ProductResultLabel.Text = "Результат:";
            // 
            // WeightUnitsLabel
            // 
            this.WeightUnitsLabel.AutoSize = true;
            this.WeightUnitsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightUnitsLabel.Location = new System.Drawing.Point(317, 328);
            this.WeightUnitsLabel.Name = "WeightUnitsLabel";
            this.WeightUnitsLabel.Size = new System.Drawing.Size(72, 21);
            this.WeightUnitsLabel.TabIndex = 10;
            this.WeightUnitsLabel.Text = "граммов";
            // 
            // ProductWeightInput
            // 
            this.ProductWeightInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductWeightInput.Location = new System.Drawing.Point(156, 325);
            this.ProductWeightInput.MaxLength = 10;
            this.ProductWeightInput.Name = "ProductWeightInput";
            this.ProductWeightInput.Size = new System.Drawing.Size(155, 29);
            this.ProductWeightInput.TabIndex = 9;
            this.ProductWeightInput.Text = "0";
            this.ProductWeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ProductWeightInput.TextChanged += new System.EventHandler(this.ProductWeightInput_TextChanged);
            this.ProductWeightInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProductWeightInput_KeyPress);
            // 
            // ProductWeightLabel
            // 
            this.ProductWeightLabel.AutoSize = true;
            this.ProductWeightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductWeightLabel.Location = new System.Drawing.Point(42, 328);
            this.ProductWeightLabel.Name = "ProductWeightLabel";
            this.ProductWeightLabel.Size = new System.Drawing.Size(108, 21);
            this.ProductWeightLabel.TabIndex = 8;
            this.ProductWeightLabel.Text = "Вес продукта:";
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.CarboOutput);
            this.InfoGroupBox.Controls.Add(this.CarboLabel);
            this.InfoGroupBox.Controls.Add(this.ProteinsOutput);
            this.InfoGroupBox.Controls.Add(this.ProteinsLabel);
            this.InfoGroupBox.Controls.Add(this.CaloriesOutput);
            this.InfoGroupBox.Controls.Add(this.CaloriesLabel);
            this.InfoGroupBox.Controls.Add(this.FatsOutput);
            this.InfoGroupBox.Controls.Add(this.FatsLabel);
            this.InfoGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoGroupBox.Location = new System.Drawing.Point(75, 118);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(323, 190);
            this.InfoGroupBox.TabIndex = 6;
            this.InfoGroupBox.TabStop = false;
            // 
            // CarboOutput
            // 
            this.CarboOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CarboOutput.Enabled = false;
            this.CarboOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarboOutput.Location = new System.Drawing.Point(133, 148);
            this.CarboOutput.Name = "CarboOutput";
            this.CarboOutput.Size = new System.Drawing.Size(100, 29);
            this.CarboOutput.TabIndex = 7;
            // 
            // CarboLabel
            // 
            this.CarboLabel.AutoSize = true;
            this.CarboLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CarboLabel.Location = new System.Drawing.Point(46, 151);
            this.CarboLabel.Name = "CarboLabel";
            this.CarboLabel.Size = new System.Drawing.Size(81, 21);
            this.CarboLabel.TabIndex = 6;
            this.CarboLabel.Text = "Углеводы:";
            // 
            // ProteinsOutput
            // 
            this.ProteinsOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ProteinsOutput.Enabled = false;
            this.ProteinsOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProteinsOutput.Location = new System.Drawing.Point(132, 60);
            this.ProteinsOutput.Name = "ProteinsOutput";
            this.ProteinsOutput.Size = new System.Drawing.Size(100, 29);
            this.ProteinsOutput.TabIndex = 3;
            // 
            // ProteinsLabel
            // 
            this.ProteinsLabel.AutoSize = true;
            this.ProteinsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProteinsLabel.Location = new System.Drawing.Point(72, 63);
            this.ProteinsLabel.Name = "ProteinsLabel";
            this.ProteinsLabel.Size = new System.Drawing.Size(55, 21);
            this.ProteinsLabel.TabIndex = 2;
            this.ProteinsLabel.Text = "Белки:";
            // 
            // CaloriesOutput
            // 
            this.CaloriesOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CaloriesOutput.Enabled = false;
            this.CaloriesOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaloriesOutput.Location = new System.Drawing.Point(132, 16);
            this.CaloriesOutput.Name = "CaloriesOutput";
            this.CaloriesOutput.Size = new System.Drawing.Size(100, 29);
            this.CaloriesOutput.TabIndex = 1;
            // 
            // CaloriesLabel
            // 
            this.CaloriesLabel.AutoSize = true;
            this.CaloriesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaloriesLabel.Location = new System.Drawing.Point(53, 19);
            this.CaloriesLabel.Name = "CaloriesLabel";
            this.CaloriesLabel.Size = new System.Drawing.Size(74, 21);
            this.CaloriesLabel.TabIndex = 0;
            this.CaloriesLabel.Text = "Калории:";
            // 
            // FatsOutput
            // 
            this.FatsOutput.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.FatsOutput.Enabled = false;
            this.FatsOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FatsOutput.Location = new System.Drawing.Point(133, 104);
            this.FatsOutput.Name = "FatsOutput";
            this.FatsOutput.Size = new System.Drawing.Size(100, 29);
            this.FatsOutput.TabIndex = 5;
            // 
            // FatsLabel
            // 
            this.FatsLabel.AutoSize = true;
            this.FatsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FatsLabel.Location = new System.Drawing.Point(71, 107);
            this.FatsLabel.Name = "FatsLabel";
            this.FatsLabel.Size = new System.Drawing.Size(56, 21);
            this.FatsLabel.TabIndex = 4;
            this.FatsLabel.Text = "Жиры:";
            // 
            // AddProductButton
            // 
            this.AddProductButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddProductButton.Location = new System.Drawing.Point(369, 83);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(29, 29);
            this.AddProductButton.TabIndex = 5;
            this.AddProductButton.Text = "+";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductsCombobox
            // 
            this.ProductsCombobox.DisplayMember = "Name";
            this.ProductsCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductsCombobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProductsCombobox.FormattingEnabled = true;
            this.ProductsCombobox.Location = new System.Drawing.Point(136, 83);
            this.ProductsCombobox.Name = "ProductsCombobox";
            this.ProductsCombobox.Size = new System.Drawing.Size(210, 29);
            this.ProductsCombobox.TabIndex = 3;
            this.ProductsCombobox.SelectedIndexChanged += new System.EventHandler(this.ProductsCombobox_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 535);
            this.Controls.Add(this.AllTabs);
            this.Name = "Main";
            this.Text = "Калькулятор БЖУ";
            this.AllTabs.ResumeLayout(false);
            this.Calculator.ResumeLayout(false);
            this.Calculator.PerformLayout();
            this.SexBox.ResumeLayout(false);
            this.SexBox.PerformLayout();
            this.Products.ResumeLayout(false);
            this.Products.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AllTabs;
        private System.Windows.Forms.TabPage Calculator;
        private System.Windows.Forms.GroupBox SexBox;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.TabPage Products;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.ComboBox ActivityCombobox;
        private System.Windows.Forms.Label ActivityLabel;
        private System.Windows.Forms.Label HeightAfterLabel;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.Label HightLabel;
        private System.Windows.Forms.Label WeightAfterLabel;
        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox AgeInput;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.ComboBox PlanCombobox;
        private System.Windows.Forms.Label PlanLabel;
        private System.Windows.Forms.Label ResultAfterLabel;
        private System.Windows.Forms.TextBox ResutlOutput;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.ComboBox ProductsCombobox;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.TextBox CaloriesOutput;
        private System.Windows.Forms.Label CaloriesLabel;
        private System.Windows.Forms.TextBox CarboOutput;
        private System.Windows.Forms.Label ProductWeightLabel;
        private System.Windows.Forms.TextBox productResult;
        private System.Windows.Forms.Label CarboLabel;
        private System.Windows.Forms.TextBox ProteinsOutput;
        private System.Windows.Forms.Label ProteinsLabel;
        private System.Windows.Forms.TextBox FatsOutput;
        private System.Windows.Forms.Label FatsLabel;
        private System.Windows.Forms.Label be;
        private System.Windows.Forms.Label ProductResultUnitsLabel;
        private System.Windows.Forms.TextBox product;
        private System.Windows.Forms.Label ProductResultLabel;
        private System.Windows.Forms.Label WeightUnitsLabel;
        private System.Windows.Forms.TextBox ProductWeightInput;
        private System.Windows.Forms.TextBox ProductResultOutput;
        private System.Windows.Forms.Label label1;
    }
}

