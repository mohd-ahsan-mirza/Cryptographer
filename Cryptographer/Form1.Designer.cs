using System.Drawing;

namespace Cryptographer
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
            this.label1 = new System.Windows.Forms.Label();
            this.original = new System.Windows.Forms.TextBox();
            this.encryption_panel = new System.Windows.Forms.Panel();
            this.encryptedString = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.decryption_panel = new System.Windows.Forms.Panel();
            this.decryptedString = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxLength = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.encryptionChars = new System.Windows.Forms.TextBox();
            this.startEncryption = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.keys = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.values = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.resetAll = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.remove_last = new System.Windows.Forms.Button();
            this.startDecryption = new System.Windows.Forms.Button();
            this.encryption_panel.SuspendLayout();
            this.decryption_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original text";
            // 
            // original
            // 
            this.original.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.original.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.original.Location = new System.Drawing.Point(144, 6);
            this.original.Multiline = true;
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(956, 90);
            this.original.TabIndex = 1;
            this.original.TextChanged += new System.EventHandler(this.original_TextChanged);
            // 
            // encryption_panel
            // 
            this.encryption_panel.BackColor = System.Drawing.SystemColors.Info;
            this.encryption_panel.Controls.Add(this.encryptedString);
            this.encryption_panel.Controls.Add(this.label10);
            this.encryption_panel.Location = new System.Drawing.Point(0, 187);
            this.encryption_panel.Name = "encryption_panel";
            this.encryption_panel.Size = new System.Drawing.Size(1114, 161);
            this.encryption_panel.TabIndex = 2;
            // 
            // encryptedString
            // 
            this.encryptedString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptedString.Location = new System.Drawing.Point(166, 9);
            this.encryptedString.Multiline = true;
            this.encryptedString.Name = "encryptedString";
            this.encryptedString.ReadOnly = true;
            this.encryptedString.Size = new System.Drawing.Size(934, 149);
            this.encryptedString.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Encrypted Text";
            // 
            // decryption_panel
            // 
            this.decryption_panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.decryption_panel.Controls.Add(this.decryptedString);
            this.decryption_panel.Controls.Add(this.label11);
            this.decryption_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.decryption_panel.Location = new System.Drawing.Point(0, 354);
            this.decryption_panel.Name = "decryption_panel";
            this.decryption_panel.Size = new System.Drawing.Size(1114, 171);
            this.decryption_panel.TabIndex = 3;
            // 
            // decryptedString
            // 
            this.decryptedString.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decryptedString.Location = new System.Drawing.Point(166, 6);
            this.decryptedString.Multiline = true;
            this.decryptedString.Name = "decryptedString";
            this.decryptedString.ReadOnly = true;
            this.decryptedString.Size = new System.Drawing.Size(934, 162);
            this.decryptedString.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Decrypted Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Encryption: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Optional) Encryption Strength: ";
            // 
            // maxLength
            // 
            this.maxLength.Location = new System.Drawing.Point(408, 102);
            this.maxLength.Name = "maxLength";
            this.maxLength.Size = new System.Drawing.Size(58, 22);
            this.maxLength.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Encryption: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(475, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "(Optional)Encryption Chars: ";
            // 
            // encryptionChars
            // 
            this.encryptionChars.Location = new System.Drawing.Point(724, 102);
            this.encryptionChars.Name = "encryptionChars";
            this.encryptionChars.Size = new System.Drawing.Size(129, 22);
            this.encryptionChars.TabIndex = 8;
            // 
            // startEncryption
            // 
            this.startEncryption.BackColor = System.Drawing.Color.Chocolate;
            this.startEncryption.Location = new System.Drawing.Point(969, 102);
            this.startEncryption.Name = "startEncryption";
            this.startEncryption.Size = new System.Drawing.Size(133, 37);
            this.startEncryption.TabIndex = 9;
            this.startEncryption.Text = "Encrypt";
            this.startEncryption.UseVisualStyleBackColor = false;
            this.startEncryption.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Decryption: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(346, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Keys:";
            // 
            // keys
            // 
            this.keys.Location = new System.Drawing.Point(408, 143);
            this.keys.Name = "keys";
            this.keys.Size = new System.Drawing.Size(96, 22);
            this.keys.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(514, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Values:";
            // 
            // values
            // 
            this.values.Location = new System.Drawing.Point(599, 143);
            this.values.Name = "values";
            this.values.Size = new System.Drawing.Size(96, 22);
            this.values.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(131, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "(If not encrypted above)";
            // 
            // resetAll
            // 
            this.resetAll.BackColor = System.Drawing.Color.Tomato;
            this.resetAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAll.Location = new System.Drawing.Point(17, 49);
            this.resetAll.Name = "resetAll";
            this.resetAll.Size = new System.Drawing.Size(114, 32);
            this.resetAll.TabIndex = 22;
            this.resetAll.Text = "Reset";
            this.resetAll.UseVisualStyleBackColor = false;
            this.resetAll.Click += new System.EventHandler(this.resetAll_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Add.Location = new System.Drawing.Point(707, 143);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(70, 37);
            this.Add.TabIndex = 23;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // remove_last
            // 
            this.remove_last.BackColor = System.Drawing.Color.CadetBlue;
            this.remove_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove_last.Location = new System.Drawing.Point(783, 143);
            this.remove_last.Name = "remove_last";
            this.remove_last.Size = new System.Drawing.Size(70, 37);
            this.remove_last.TabIndex = 18;
            this.remove_last.Text = "Undo";
            this.remove_last.UseVisualStyleBackColor = false;
            this.remove_last.Click += new System.EventHandler(this.remove_last_Click);
            // 
            // startDecryption
            // 
            this.startDecryption.BackColor = System.Drawing.Color.LightSalmon;
            this.startDecryption.Location = new System.Drawing.Point(969, 144);
            this.startDecryption.Name = "startDecryption";
            this.startDecryption.Size = new System.Drawing.Size(133, 37);
            this.startDecryption.TabIndex = 14;
            this.startDecryption.Text = "Decrypt";
            this.startDecryption.UseVisualStyleBackColor = false;
            this.startDecryption.Click += new System.EventHandler(this.startDecryption_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1114, 525);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.resetAll);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.remove_last);
            this.Controls.Add(this.values);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.startDecryption);
            this.Controls.Add(this.keys);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startEncryption);
            this.Controls.Add(this.encryptionChars);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decryption_panel);
            this.Controls.Add(this.encryption_panel);
            this.Controls.Add(this.original);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cryptograher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.encryption_panel.ResumeLayout(false);
            this.encryption_panel.PerformLayout();
            this.decryption_panel.ResumeLayout(false);
            this.decryption_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox original;
        private System.Windows.Forms.Panel encryption_panel;
        private System.Windows.Forms.Panel decryption_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox encryptionChars;
        private System.Windows.Forms.Button startEncryption;
        private System.Windows.Forms.TextBox encryptedString;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox decryptedString;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox keys;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox values;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button resetAll;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button remove_last;
        private System.Windows.Forms.Button startDecryption;
    }
}

