
namespace CashRegister
{
    partial class cashRegister
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
            this.title = new System.Windows.Forms.Label();
            this.burgerNumber = new System.Windows.Forms.Label();
            this.fryNumber = new System.Windows.Forms.Label();
            this.drinkNumber = new System.Windows.Forms.Label();
            this.burgerBox = new System.Windows.Forms.TextBox();
            this.totalButton = new System.Windows.Forms.Button();
            this.taxOwed = new System.Windows.Forms.Label();
            this.subTotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.subTotalAmount = new System.Windows.Forms.Label();
            this.taxAmount = new System.Windows.Forms.Label();
            this.totalAmount = new System.Windows.Forms.Label();
            this.tendered = new System.Windows.Forms.Label();
            this.tenderedAmount = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.reciptButton = new System.Windows.Forms.Button();
            this.fryBox = new System.Windows.Forms.TextBox();
            this.drinkBox = new System.Windows.Forms.TextBox();
            this.warningLabel = new System.Windows.Forms.Label();
            this.changeAmount = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.DarkRed;
            this.title.Font = new System.Drawing.Font("ISOCTEUR", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(540, 39);
            this.title.TabIndex = 0;
            this.title.Text = "The Burger Shop";
            // 
            // burgerNumber
            // 
            this.burgerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerNumber.Location = new System.Drawing.Point(12, 83);
            this.burgerNumber.Name = "burgerNumber";
            this.burgerNumber.Size = new System.Drawing.Size(171, 39);
            this.burgerNumber.TabIndex = 1;
            this.burgerNumber.Text = "Number of Burgers";
            // 
            // fryNumber
            // 
            this.fryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fryNumber.Location = new System.Drawing.Point(12, 122);
            this.fryNumber.Name = "fryNumber";
            this.fryNumber.Size = new System.Drawing.Size(171, 39);
            this.fryNumber.TabIndex = 2;
            this.fryNumber.Text = "Number of Fries";
            // 
            // drinkNumber
            // 
            this.drinkNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkNumber.Location = new System.Drawing.Point(12, 161);
            this.drinkNumber.Name = "drinkNumber";
            this.drinkNumber.Size = new System.Drawing.Size(171, 39);
            this.drinkNumber.TabIndex = 3;
            this.drinkNumber.Text = "Number of Drinks";
            // 
            // burgerBox
            // 
            this.burgerBox.Location = new System.Drawing.Point(189, 83);
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(28, 20);
            this.burgerBox.TabIndex = 4;
            this.burgerBox.Text = "0";
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(12, 203);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(205, 38);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "Caculate Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // taxOwed
            // 
            this.taxOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOwed.Location = new System.Drawing.Point(14, 316);
            this.taxOwed.Name = "taxOwed";
            this.taxOwed.Size = new System.Drawing.Size(97, 39);
            this.taxOwed.TabIndex = 8;
            this.taxOwed.Text = "Tax";
            // 
            // subTotal
            // 
            this.subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotal.Location = new System.Drawing.Point(14, 277);
            this.subTotal.Name = "subTotal";
            this.subTotal.Size = new System.Drawing.Size(97, 39);
            this.subTotal.TabIndex = 9;
            this.subTotal.Text = "Sub Total";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(14, 355);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(171, 39);
            this.total.TabIndex = 10;
            this.total.Text = "Total ";
            // 
            // subTotalAmount
            // 
            this.subTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.subTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalAmount.Location = new System.Drawing.Point(182, 277);
            this.subTotalAmount.Name = "subTotalAmount";
            this.subTotalAmount.Size = new System.Drawing.Size(63, 23);
            this.subTotalAmount.TabIndex = 11;
            // 
            // taxAmount
            // 
            this.taxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxAmount.Location = new System.Drawing.Point(182, 316);
            this.taxAmount.Name = "taxAmount";
            this.taxAmount.Size = new System.Drawing.Size(63, 25);
            this.taxAmount.TabIndex = 12;
            // 
            // totalAmount
            // 
            this.totalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAmount.Location = new System.Drawing.Point(182, 355);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(63, 24);
            this.totalAmount.TabIndex = 13;
            // 
            // tendered
            // 
            this.tendered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tendered.Location = new System.Drawing.Point(14, 394);
            this.tendered.Name = "tendered";
            this.tendered.Size = new System.Drawing.Size(171, 39);
            this.tendered.TabIndex = 14;
            this.tendered.Text = "Tendered";
            // 
            // tenderedAmount
            // 
            this.tenderedAmount.Location = new System.Drawing.Point(189, 394);
            this.tenderedAmount.Name = "tenderedAmount";
            this.tenderedAmount.Size = new System.Drawing.Size(28, 20);
            this.tenderedAmount.TabIndex = 15;
            this.tenderedAmount.Text = "0";
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(12, 436);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(205, 38);
            this.changeButton.TabIndex = 16;
            this.changeButton.Text = "Caculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // change
            // 
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.Location = new System.Drawing.Point(14, 497);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(97, 39);
            this.change.TabIndex = 17;
            this.change.Text = "Change";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(238, 83);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(314, 453);
            this.outputLabel.TabIndex = 19;
            // 
            // reciptButton
            // 
            this.reciptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptButton.Location = new System.Drawing.Point(12, 567);
            this.reciptButton.Name = "reciptButton";
            this.reciptButton.Size = new System.Drawing.Size(205, 38);
            this.reciptButton.TabIndex = 20;
            this.reciptButton.Text = "Print Recipt";
            this.reciptButton.UseVisualStyleBackColor = true;
            this.reciptButton.Click += new System.EventHandler(this.reciptButton_Click);
            // 
            // fryBox
            // 
            this.fryBox.Location = new System.Drawing.Point(189, 122);
            this.fryBox.Name = "fryBox";
            this.fryBox.Size = new System.Drawing.Size(28, 20);
            this.fryBox.TabIndex = 21;
            this.fryBox.Text = "0";
            // 
            // drinkBox
            // 
            this.drinkBox.Location = new System.Drawing.Point(189, 161);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(28, 20);
            this.drinkBox.TabIndex = 22;
            this.drinkBox.Text = "0";
            // 
            // warningLabel
            // 
            this.warningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLabel.ForeColor = System.Drawing.Color.Red;
            this.warningLabel.Location = new System.Drawing.Point(12, 48);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(540, 23);
            this.warningLabel.TabIndex = 23;
            // 
            // changeAmount
            // 
            this.changeAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAmount.Location = new System.Drawing.Point(182, 497);
            this.changeAmount.Name = "changeAmount";
            this.changeAmount.Size = new System.Drawing.Size(63, 24);
            this.changeAmount.TabIndex = 24;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(242, 567);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(310, 38);
            this.resetButton.TabIndex = 25;
            this.resetButton.Text = "New Order ";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // cashRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(564, 629);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.changeAmount);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.fryBox);
            this.Controls.Add(this.reciptButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.change);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedAmount);
            this.Controls.Add(this.tendered);
            this.Controls.Add(this.totalAmount);
            this.Controls.Add(this.taxAmount);
            this.Controls.Add(this.subTotalAmount);
            this.Controls.Add(this.total);
            this.Controls.Add(this.subTotal);
            this.Controls.Add(this.taxOwed);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.burgerBox);
            this.Controls.Add(this.drinkNumber);
            this.Controls.Add(this.fryNumber);
            this.Controls.Add(this.burgerNumber);
            this.Controls.Add(this.title);
            this.Name = "cashRegister";
            this.Text = "Cash Register ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label burgerNumber;
        private System.Windows.Forms.Label fryNumber;
        private System.Windows.Forms.Label drinkNumber;
        private System.Windows.Forms.TextBox burgerBox;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label taxOwed;
        private System.Windows.Forms.Label subTotal;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label subTotalAmount;
        private System.Windows.Forms.Label taxAmount;
        private System.Windows.Forms.Label totalAmount;
        private System.Windows.Forms.Label tendered;
        private System.Windows.Forms.TextBox tenderedAmount;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button reciptButton;
        private System.Windows.Forms.TextBox fryBox;
        private System.Windows.Forms.TextBox drinkBox;
        private System.Windows.Forms.Label warningLabel;
        private System.Windows.Forms.Label changeAmount;
        private System.Windows.Forms.Button resetButton;
    }
}

