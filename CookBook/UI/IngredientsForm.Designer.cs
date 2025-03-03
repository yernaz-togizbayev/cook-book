namespace CookBook.UI
{
    partial class IngredientsForm
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
            labelName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TypeTxt = new TextBox();
            NameTxt = new TextBox();
            WeightNum = new NumericUpDown();
            KcalPer100gNum = new NumericUpDown();
            PricePer100gNum = new NumericUpDown();
            AddToFridgeBtn = new Button();
            IngredientsGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)WeightNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsGrid).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(1032, 43);
            labelName.Name = "labelName";
            labelName.Size = new Size(78, 32);
            labelName.TabIndex = 0;
            labelName.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1032, 105);
            label2.Name = "label2";
            label2.Size = new Size(65, 32);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1032, 167);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 2;
            label3.Text = "Weight (g)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1032, 229);
            label4.Name = "label4";
            label4.Size = new Size(131, 32);
            label4.TabIndex = 3;
            label4.Text = "Kcal (100g)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1032, 291);
            label5.Name = "label5";
            label5.Size = new Size(139, 32);
            label5.TabIndex = 4;
            label5.Text = "Price (100g)";
            // 
            // TypeTxt
            // 
            TypeTxt.Location = new Point(1240, 105);
            TypeTxt.Name = "TypeTxt";
            TypeTxt.Size = new Size(276, 39);
            TypeTxt.TabIndex = 5;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(1240, 43);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(276, 39);
            NameTxt.TabIndex = 9;
            // 
            // WeightNum
            // 
            WeightNum.Location = new Point(1240, 167);
            WeightNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            WeightNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WeightNum.Name = "WeightNum";
            WeightNum.Size = new Size(276, 39);
            WeightNum.TabIndex = 10;
            WeightNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // KcalPer100gNum
            // 
            KcalPer100gNum.Location = new Point(1240, 229);
            KcalPer100gNum.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            KcalPer100gNum.Name = "KcalPer100gNum";
            KcalPer100gNum.Size = new Size(276, 39);
            KcalPer100gNum.TabIndex = 11;
            // 
            // PricePer100gNum
            // 
            PricePer100gNum.DecimalPlaces = 2;
            PricePer100gNum.Location = new Point(1240, 291);
            PricePer100gNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            PricePer100gNum.Name = "PricePer100gNum";
            PricePer100gNum.Size = new Size(276, 39);
            PricePer100gNum.TabIndex = 12;
            // 
            // AddToFridgeBtn
            // 
            AddToFridgeBtn.Location = new Point(1240, 371);
            AddToFridgeBtn.Name = "AddToFridgeBtn";
            AddToFridgeBtn.Size = new Size(276, 63);
            AddToFridgeBtn.TabIndex = 13;
            AddToFridgeBtn.Text = "Add to fridge";
            AddToFridgeBtn.UseVisualStyleBackColor = true;
            AddToFridgeBtn.Click += AddToFridgeBtn_Click;
            // 
            // IngredientsGrid
            // 
            IngredientsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientsGrid.Location = new Point(12, 43);
            IngredientsGrid.Name = "IngredientsGrid";
            IngredientsGrid.RowHeadersWidth = 51;
            IngredientsGrid.Size = new Size(995, 391);
            IngredientsGrid.TabIndex = 14;
            // 
            // IngredientsForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1528, 500);
            Controls.Add(IngredientsGrid);
            Controls.Add(AddToFridgeBtn);
            Controls.Add(PricePer100gNum);
            Controls.Add(KcalPer100gNum);
            Controls.Add(WeightNum);
            Controls.Add(NameTxt);
            Controls.Add(TypeTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelName);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "IngredientsForm";
            Text = "My fridge";
            Load += IngredientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)WeightNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)IngredientsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TypeTxt;
        private TextBox NameTxt;
        private NumericUpDown WeightNum;
        private NumericUpDown KcalPer100gNum;
        private NumericUpDown PricePer100gNum;
        private Button AddToFridgeBtn;
        private DataGridView IngredientsGrid;
    }
}