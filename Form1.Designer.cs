
namespace GoldPriceTracker
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
            this.lstBoxSatis = new System.Windows.Forms.ListBox();
            this.lstBoxAlis = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnQuarterBuying = new System.Windows.Forms.Button();
            this.btnQuarterSelling = new System.Windows.Forms.Button();
            this.btnGoldBuy = new System.Windows.Forms.Button();
            this.btnGoldSell = new System.Windows.Forms.Button();
            this.lstboxSelling = new System.Windows.Forms.ListBox();
            this.lstboxPurchase = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBoxSatis
            // 
            this.lstBoxSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstBoxSatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBoxSatis.FormattingEnabled = true;
            this.lstBoxSatis.ItemHeight = 31;
            this.lstBoxSatis.Location = new System.Drawing.Point(391, 161);
            this.lstBoxSatis.Name = "lstBoxSatis";
            this.lstBoxSatis.Size = new System.Drawing.Size(236, 66);
            this.lstBoxSatis.TabIndex = 1;
            // 
            // lstBoxAlis
            // 
            this.lstBoxAlis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstBoxAlis.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstBoxAlis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBoxAlis.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lstBoxAlis.FormattingEnabled = true;
            this.lstBoxAlis.ItemHeight = 31;
            this.lstBoxAlis.Location = new System.Drawing.Point(111, 161);
            this.lstBoxAlis.Name = "lstBoxAlis";
            this.lstBoxAlis.Size = new System.Drawing.Size(219, 66);
            this.lstBoxAlis.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(576, 506);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Click buttons for refresh prices";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnQuarterBuying
            // 
            this.btnQuarterBuying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuarterBuying.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQuarterBuying.Image = global::GoldPriceTracker.Properties.Resources.coin;
            this.btnQuarterBuying.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuarterBuying.Location = new System.Drawing.Point(391, 269);
            this.btnQuarterBuying.Name = "btnQuarterBuying";
            this.btnQuarterBuying.Size = new System.Drawing.Size(241, 85);
            this.btnQuarterBuying.TabIndex = 6;
            this.btnQuarterBuying.Text = "Quarter Gold Purchase Price";
            this.btnQuarterBuying.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuarterBuying.UseVisualStyleBackColor = false;
            this.btnQuarterBuying.Click += new System.EventHandler(this.btnQuarterBuying_Click);
            // 
            // btnQuarterSelling
            // 
            this.btnQuarterSelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuarterSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQuarterSelling.Image = global::GoldPriceTracker.Properties.Resources.coin;
            this.btnQuarterSelling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuarterSelling.Location = new System.Drawing.Point(107, 269);
            this.btnQuarterSelling.Name = "btnQuarterSelling";
            this.btnQuarterSelling.Size = new System.Drawing.Size(223, 85);
            this.btnQuarterSelling.TabIndex = 5;
            this.btnQuarterSelling.Text = "Quarter Gold Selling Price";
            this.btnQuarterSelling.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuarterSelling.UseVisualStyleBackColor = false;
            this.btnQuarterSelling.Click += new System.EventHandler(this.btnQuarterSelling_Click);
            // 
            // btnGoldBuy
            // 
            this.btnGoldBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoldBuy.Image = global::GoldPriceTracker.Properties.Resources.treasure_chest;
            this.btnGoldBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoldBuy.Location = new System.Drawing.Point(111, 63);
            this.btnGoldBuy.Name = "btnGoldBuy";
            this.btnGoldBuy.Size = new System.Drawing.Size(219, 85);
            this.btnGoldBuy.TabIndex = 2;
            this.btnGoldBuy.Text = "Gold Selling Price";
            this.btnGoldBuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoldBuy.UseVisualStyleBackColor = true;
            this.btnGoldBuy.Click += new System.EventHandler(this.btnGoldBuy_Click);
            // 
            // btnGoldSell
            // 
            this.btnGoldSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGoldSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoldSell.Image = global::GoldPriceTracker.Properties.Resources.treasure_chest;
            this.btnGoldSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoldSell.Location = new System.Drawing.Point(391, 63);
            this.btnGoldSell.Name = "btnGoldSell";
            this.btnGoldSell.Size = new System.Drawing.Size(236, 85);
            this.btnGoldSell.TabIndex = 0;
            this.btnGoldSell.Text = "Gold Purchase Price";
            this.btnGoldSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoldSell.UseVisualStyleBackColor = false;
            this.btnGoldSell.Click += new System.EventHandler(this.btnGoldSell_Click_1);
            // 
            // lstboxSelling
            // 
            this.lstboxSelling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstboxSelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstboxSelling.FormattingEnabled = true;
            this.lstboxSelling.ItemHeight = 31;
            this.lstboxSelling.Location = new System.Drawing.Point(103, 381);
            this.lstboxSelling.Name = "lstboxSelling";
            this.lstboxSelling.Size = new System.Drawing.Size(227, 66);
            this.lstboxSelling.TabIndex = 7;
            // 
            // lstboxPurchase
            // 
            this.lstboxPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lstboxPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstboxPurchase.FormattingEnabled = true;
            this.lstboxPurchase.ItemHeight = 31;
            this.lstboxPurchase.Location = new System.Drawing.Point(391, 381);
            this.lstboxPurchase.Name = "lstboxPurchase";
            this.lstboxPurchase.Size = new System.Drawing.Size(241, 66);
            this.lstboxPurchase.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(744, 540);
            this.Controls.Add(this.lstboxPurchase);
            this.Controls.Add(this.lstboxSelling);
            this.Controls.Add(this.btnQuarterBuying);
            this.Controls.Add(this.btnQuarterSelling);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstBoxAlis);
            this.Controls.Add(this.btnGoldBuy);
            this.Controls.Add(this.lstBoxSatis);
            this.Controls.Add(this.btnGoldSell);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoldSell;
        private System.Windows.Forms.ListBox lstBoxSatis;
        private System.Windows.Forms.Button btnGoldBuy;
        private System.Windows.Forms.ListBox lstBoxAlis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnQuarterSelling;
        private System.Windows.Forms.Button btnQuarterBuying;
        private System.Windows.Forms.ListBox lstboxSelling;
        private System.Windows.Forms.ListBox lstboxPurchase;
    }
}

