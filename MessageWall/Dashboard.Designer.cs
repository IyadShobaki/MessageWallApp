namespace MessageWall
{
   partial class Dashboard
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
         this.messageLabel = new System.Windows.Forms.Label();
         this.messageText = new System.Windows.Forms.TextBox();
         this.messageListBox = new System.Windows.Forms.ListBox();
         this.messageListBoxLabel = new System.Windows.Forms.Label();
         this.addMessageButton = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // messageLabel
         // 
         this.messageLabel.AutoSize = true;
         this.messageLabel.Location = new System.Drawing.Point(18, 21);
         this.messageLabel.Name = "messageLabel";
         this.messageLabel.Size = new System.Drawing.Size(112, 29);
         this.messageLabel.TabIndex = 0;
         this.messageLabel.Text = "Message";
         // 
         // messageText
         // 
         this.messageText.Location = new System.Drawing.Point(136, 18);
         this.messageText.Name = "messageText";
         this.messageText.Size = new System.Drawing.Size(373, 35);
         this.messageText.TabIndex = 1;
         // 
         // messageListBox
         // 
         this.messageListBox.FormattingEnabled = true;
         this.messageListBox.ItemHeight = 29;
         this.messageListBox.Location = new System.Drawing.Point(23, 117);
         this.messageListBox.Name = "messageListBox";
         this.messageListBox.Size = new System.Drawing.Size(486, 236);
         this.messageListBox.TabIndex = 3;
         // 
         // messageListBoxLabel
         // 
         this.messageListBoxLabel.AutoSize = true;
         this.messageListBoxLabel.Location = new System.Drawing.Point(18, 85);
         this.messageListBoxLabel.Name = "messageListBoxLabel";
         this.messageListBoxLabel.Size = new System.Drawing.Size(124, 29);
         this.messageListBoxLabel.TabIndex = 0;
         this.messageListBoxLabel.Text = "Messages";
         // 
         // addMessageButton
         // 
         this.addMessageButton.Location = new System.Drawing.Point(542, 21);
         this.addMessageButton.Name = "addMessageButton";
         this.addMessageButton.Size = new System.Drawing.Size(106, 32);
         this.addMessageButton.TabIndex = 2;
         this.addMessageButton.Text = "Add";
         this.addMessageButton.UseVisualStyleBackColor = true;
         this.addMessageButton.Click += new System.EventHandler(this.AddMessageButton_Click);
         // 
         // Dashboard
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.White;
         this.ClientSize = new System.Drawing.Size(690, 399);
         this.Controls.Add(this.addMessageButton);
         this.Controls.Add(this.messageListBox);
         this.Controls.Add(this.messageText);
         this.Controls.Add(this.messageListBoxLabel);
         this.Controls.Add(this.messageLabel);
         this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
         this.Name = "Dashboard";
         this.Text = "Dashboard";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label messageLabel;
      private System.Windows.Forms.TextBox messageText;
      private System.Windows.Forms.ListBox messageListBox;
      private System.Windows.Forms.Label messageListBoxLabel;
      private System.Windows.Forms.Button addMessageButton;
   }
}

