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
            this.drinksImput = new System.Windows.Forms.TextBox();
            this.drinks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerCost
            // 
            this.burgerCost.Location = new System.Drawing.Point(382, 36);
            this.burgerCost.Name = "burgerCost";
            this.burgerCost.Size = new System.Drawing.Size(40, 13);
            this.burgerCost.TabIndex = 1;
            this.burgerCost.Text = "burgers";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(406, 255);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 2;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // burgerInput
            // 
            this.burgerInput.Location = new System.Drawing.Point(448, 36);
            this.burgerInput.Name = "burgerInput";
            this.burgerInput.Size = new System.Drawing.Size(33, 20);
            this.burgerInput.TabIndex = 3;
            // 
            // fries
            // 
            this.fries.AutoSize = true;
            this.fries.Location = new System.Drawing.Point(385, 82);
            this.fries.Name = "fries";
            this.fries.Size = new System.Drawing.Size(29, 13);
            this.fries.TabIndex = 4;
            this.fries.Text = "Fries";
            // 
            // friesInput
            // 
            this.friesInput.Location = new System.Drawing.Point(448, 75);
            this.friesInput.Name = "friesInput";
            this.friesInput.Size = new System.Drawing.Size(33, 20);
            this.friesInput.TabIndex = 5;
            // 
            // drinksImput
            // 
            this.drinksImput.Location = new System.Drawing.Point(448, 118);
            this.drinksImput.Name = "drinksImput";
            this.drinksImput.Size = new System.Drawing.Size(33, 20);
            this.drinksImput.TabIndex = 6;
            // 
            // drinks
            // 
            this.drinks.AutoSize = true;
            this.drinks.Location = new System.Drawing.Point(385, 118);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(37, 13);
            this.drinks.TabIndex = 7;
            this.drinks.Text = "Drinks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 366);
            this.Controls.Add(this.drinks);
            this.Controls.Add(this.drinksImput);
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
        private System.Windows.Forms.TextBox drinksImput;
        private System.Windows.Forms.Label drinks;
    }
}

