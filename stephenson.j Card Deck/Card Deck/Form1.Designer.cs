namespace Card_Deck
{
    partial class CardDeck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDeck));
            this.lstbxItems = new System.Windows.Forms.ListBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnDrawCard = new System.Windows.Forms.Button();
            this.lblDiscarded = new System.Windows.Forms.Label();
            this.lblCardList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstbxItems
            // 
            this.lstbxItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(191)))), ((int)(((byte)(204)))));
            this.lstbxItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbxItems.CausesValidation = false;
            this.lstbxItems.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstbxItems.FormattingEnabled = true;
            this.lstbxItems.Location = new System.Drawing.Point(12, 26);
            this.lstbxItems.Name = "lstbxItems";
            this.lstbxItems.Size = new System.Drawing.Size(218, 377);
            this.lstbxItems.TabIndex = 0;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(248, 26);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(154, 36);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "Shuffle Deck";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnDrawCard
            // 
            this.btnDrawCard.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDrawCard.Location = new System.Drawing.Point(248, 68);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(154, 36);
            this.btnDrawCard.TabIndex = 2;
            this.btnDrawCard.Text = "Draw Card";
            this.btnDrawCard.UseVisualStyleBackColor = true;
            this.btnDrawCard.Click += new System.EventHandler(this.btnDrawCard_Click);
            // 
            // lblDiscarded
            // 
            this.lblDiscarded.AutoSize = true;
            this.lblDiscarded.Location = new System.Drawing.Point(245, 407);
            this.lblDiscarded.Name = "lblDiscarded";
            this.lblDiscarded.Size = new System.Drawing.Size(0, 13);
            this.lblDiscarded.TabIndex = 3;
            // 
            // lblCardList
            // 
            this.lblCardList.AutoSize = true;
            this.lblCardList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCardList.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardList.Location = new System.Drawing.Point(8, 3);
            this.lblCardList.Name = "lblCardList";
            this.lblCardList.Size = new System.Drawing.Size(81, 20);
            this.lblCardList.TabIndex = 4;
            this.lblCardList.Text = "Card List:";
            // 
            // CardDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(140)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(414, 426);
            this.Controls.Add(this.lblCardList);
            this.Controls.Add(this.lblDiscarded);
            this.Controls.Add(this.btnDrawCard);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.lstbxItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "CardDeck";
            this.Text = "Card Deck";
            this.Load += new System.EventHandler(this.CardDeck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbxItems;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnDrawCard;
        private System.Windows.Forms.Label lblDiscarded;
        private System.Windows.Forms.Label lblCardList;
    }
}

