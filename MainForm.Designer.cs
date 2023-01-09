namespace ATM_winforms
{
    partial class MainForm
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
            this.btn_balance = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_card = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_balance
            // 
            this.btn_balance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_balance.Location = new System.Drawing.Point(69, 119);
            this.btn_balance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_balance.Name = "btn_balance";
            this.btn_balance.Size = new System.Drawing.Size(230, 45);
            this.btn_balance.TabIndex = 0;
            this.btn_balance.Text = "Запросить баланс";
            this.btn_balance.UseVisualStyleBackColor = true;
            this.btn_balance.Click += new System.EventHandler(this.btn_balance_Click);
            // 
            // btn_get
            // 
            this.btn_get.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_get.Location = new System.Drawing.Point(69, 261);
            this.btn_get.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(230, 45);
            this.btn_get.TabIndex = 1;
            this.btn_get.Text = "Снять";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_set
            // 
            this.btn_set.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_set.Location = new System.Drawing.Point(69, 189);
            this.btn_set.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(230, 45);
            this.btn_set.TabIndex = 2;
            this.btn_set.Text = "Внести";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_card
            // 
            this.btn_card.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_card.Location = new System.Drawing.Point(69, 49);
            this.btn_card.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_card.Name = "btn_card";
            this.btn_card.Size = new System.Drawing.Size(230, 45);
            this.btn_card.TabIndex = 3;
            this.btn_card.Text = "Вставить карточку";
            this.btn_card.UseVisualStyleBackColor = true;
            this.btn_card.Click += new System.EventHandler(this.btn_card_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 399);
            this.Controls.Add(this.btn_card);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.btn_balance);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банкомат";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_balance;
        private Button btn_get;
        private Button btn_set;
        private Button btn_card;
    }
}