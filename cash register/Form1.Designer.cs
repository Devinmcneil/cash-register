namespace cash_register
{
    partial class Form1
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
            this.burgerCost = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.burgerInput = new System.Windows.Forms.TextBox();
            this.fries = new System.Windows.Forms.Label();
            this.friesInput = new System.Windows.Forms.TextBox();
            this.drinksInput = new System.Windows.Forms.TextBox();
            this.drinks = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.SubLabel = new System.Windows.Forms.Label();
            this.withTax = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLable = new System.Windows.Forms.Label();
            this.taxTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTag = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.memeInput = new System.Windows.Forms.TextBox();
            this.lable4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.Print = new System.Windows.Forms.Button();
            this.changeTotal = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.tenderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // burgerCost
            // 
            this.burgerCost.Location = new System.Drawing.Point(12, 48);
            this.burgerCost.Name = "burgerCost";
            this.burgerCost.Size = new System.Drawing.Size(73, 20);
            this.burgerCost.TabIndex = 1;
            this.burgerCost.Text = "burgers $2.49";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(15, 145);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // burgerInput
            // 
            this.burgerInput.Location = new System.Drawing.Point(100, 45);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(33, 20);
            this.burgerInput.TabIndex = 2;
            // 
            // fries
            // 
            this.fries.AutoSize = true;
            this.fries.Location = new System.Drawing.Point(12, 82);
            this.fries.Name = "fries";
            this.fries.Size = new System.Drawing.Size(59, 13);
            this.fries.TabIndex = 4;
            this.fries.Text = "Fries $1.89";
            // 
            // friesInput
            // 
            this.friesInput.Location = new System.Drawing.Point(100, 82);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(33, 20);
            this.friesInput.TabIndex = 3;
            // 
            // drinksInput
            // 
            this.drinksInput.Location = new System.Drawing.Point(100, 114);
            this.drinksInput.Name = "drinksInput";
            this.drinksInput.Size = new System.Drawing.Size(33, 20);
            this.drinksInput.TabIndex = 4;
            // 
            // drinks
            // 
            this.drinks.AutoSize = true;
            this.drinks.Location = new System.Drawing.Point(12, 114);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(67, 13);
            this.drinks.TabIndex = 7;
            this.drinks.Text = "Drinks $0.99";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Location = new System.Drawing.Point(92, 215);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(74, 14);
            this.subTotalLabel.TabIndex = 9;
            // 
            // SubLabel
            // 
            this.SubLabel.AutoSize = true;
            this.SubLabel.Location = new System.Drawing.Point(11, 213);
            this.SubLabel.Name = "SubLabel";
            this.SubLabel.Size = new System.Drawing.Size(46, 13);
            this.SubLabel.TabIndex = 10;
            this.SubLabel.Text = "Subtotal";
            // 
            // withTax
            // 
            this.withTax.AutoSize = true;
            this.withTax.Location = new System.Drawing.Point(11, 270);
            this.withTax.Name = "withTax";
            this.withTax.Size = new System.Drawing.Size(70, 13);
            this.withTax.TabIndex = 11;
            this.withTax.Text = "Total with tax";
            // 
            // totalLabel
            // 
            this.totalLabel.Location = new System.Drawing.Point(97, 270);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(69, 18);
            this.totalLabel.TabIndex = 12;
            // 
            // taxLable
            // 
            this.taxLable.AutoSize = true;
            this.taxLable.Location = new System.Drawing.Point(11, 238);
            this.taxLable.Name = "taxLable";
            this.taxLable.Size = new System.Drawing.Size(52, 13);
            this.taxLable.TabIndex = 13;
            this.taxLable.Text = "Tax Total";
            // 
            // taxTotal
            // 
            this.taxTotal.Location = new System.Drawing.Point(97, 238);
            this.taxTotal.Name = "taxTotal";
            this.taxTotal.Size = new System.Drawing.Size(58, 13);
            this.taxTotal.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 15);
            this.label1.TabIndex = 15;
            // 
            // nameTag
            // 
            this.nameTag.BackColor = System.Drawing.Color.Blue;
            this.nameTag.Font = new System.Drawing.Font("Hobo Std", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTag.Location = new System.Drawing.Point(413, 0);
            this.nameTag.Name = "nameTag";
            this.nameTag.Size = new System.Drawing.Size(196, 168);
            this.nameTag.TabIndex = 1;
            this.nameTag.Text = "HARAMBE\'S BURGERS, FRIES AND MEMES";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(228, -8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 374);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Memes $2.00";
            // 
            // memeInput
            // 
            this.memeInput.Location = new System.Drawing.Point(100, 21);
            this.memeInput.Name = "memeInput";
            this.memeInput.Size = new System.Drawing.Size(33, 20);
            this.memeInput.TabIndex = 19;
            // 
            // lable4
            // 
            this.lable4.BackColor = System.Drawing.Color.Black;
            this.lable4.Location = new System.Drawing.Point(394, 0);
            this.lable4.Name = "lable4";
            this.lable4.Size = new System.Drawing.Size(19, 183);
            this.lable4.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(406, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 15);
            this.label4.TabIndex = 21;
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(15, 303);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(50, 20);
            this.tenderedInput.TabIndex = 22;
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(250, 12);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(54, 20);
            this.Print.TabIndex = 24;
            this.Print.Text = "print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // changeTotal
            // 
            this.changeTotal.Location = new System.Drawing.Point(118, 340);
            this.changeTotal.Name = "changeTotal";
            this.changeTotal.Size = new System.Drawing.Size(48, 17);
            this.changeTotal.TabIndex = 25;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Location = new System.Drawing.Point(11, 344);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(44, 13);
            this.changeLabel.TabIndex = 26;
            this.changeLabel.Text = "Change";
            // 
            // tenderButton
            // 
            this.tenderButton.Location = new System.Drawing.Point(110, 300);
            this.tenderButton.Name = "tenderButton";
            this.tenderButton.Size = new System.Drawing.Size(75, 23);
            this.tenderButton.TabIndex = 27;
            this.tenderButton.Text = "Tendered";
            this.tenderButton.UseVisualStyleBackColor = true;
            this.tenderButton.Click += new System.EventHandler(this.tenderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(609, 366);
            this.Controls.Add(this.tenderButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeTotal);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lable4);
            this.Controls.Add(this.memeInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.taxTotal);
            this.Controls.Add(this.taxLable);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.withTax);
            this.Controls.Add(this.SubLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.drinks);
            this.Controls.Add(this.drinksInput);
            this.Controls.Add(this.friesInput);
            this.Controls.Add(this.fries);
            this.Controls.Add(this.burgerInput);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.burgerCost);
            this.Name = "Form1";
            this.Text = "cash register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label burgerCost;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox burgerInput;
        private System.Windows.Forms.Label fries;
        private System.Windows.Forms.TextBox friesInput;
        private System.Windows.Forms.TextBox drinksInput;
        private System.Windows.Forms.Label drinks;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label SubLabel;
        private System.Windows.Forms.Label withTax;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLable;
        private System.Windows.Forms.Label taxTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameTag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox memeInput;
        private System.Windows.Forms.Label lable4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.Label changeTotal;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button tenderButton;
    }
}

