namespace DnDApp.register
{
    partial class Register
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
            this.registerText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username_Field = new System.Windows.Forms.TextBox();
            this.password_Field = new System.Windows.Forms.TextBox();
            this.password_Confim_Field = new System.Windows.Forms.TextBox();
            this.confirm_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerText
            // 
            this.registerText.AutoSize = true;
            this.registerText.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerText.Location = new System.Drawing.Point(92, 40);
            this.registerText.Name = "registerText";
            this.registerText.Size = new System.Drawing.Size(303, 16);
            this.registerText.TabIndex = 0;
            this.registerText.Text = "Please use this form to Register your account. ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Re-Enter Password";
            // 
            // username_Field
            // 
            this.username_Field.Location = new System.Drawing.Point(232, 117);
            this.username_Field.Name = "username_Field";
            this.username_Field.Size = new System.Drawing.Size(133, 20);
            this.username_Field.TabIndex = 4;
            // 
            // password_Field
            // 
            this.password_Field.Location = new System.Drawing.Point(232, 157);
            this.password_Field.Name = "password_Field";
            this.password_Field.Size = new System.Drawing.Size(133, 20);
            this.password_Field.TabIndex = 5;
            // 
            // password_Confim_Field
            // 
            this.password_Confim_Field.Location = new System.Drawing.Point(232, 200);
            this.password_Confim_Field.Name = "password_Confim_Field";
            this.password_Confim_Field.Size = new System.Drawing.Size(133, 20);
            this.password_Confim_Field.TabIndex = 6;
            // 
            // confirm_Button
            // 
            this.confirm_Button.Location = new System.Drawing.Point(205, 301);
            this.confirm_Button.Name = "confirm_Button";
            this.confirm_Button.Size = new System.Drawing.Size(75, 23);
            this.confirm_Button.TabIndex = 7;
            this.confirm_Button.Text = "Confirm";
            this.confirm_Button.UseVisualStyleBackColor = true;
            this.confirm_Button.Click += new System.EventHandler(this.confirm_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 411);
            this.Controls.Add(this.confirm_Button);
            this.Controls.Add(this.password_Confim_Field);
            this.Controls.Add(this.password_Field);
            this.Controls.Add(this.username_Field);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registerText);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username_Field;
        private System.Windows.Forms.TextBox password_Field;
        private System.Windows.Forms.TextBox password_Confim_Field;
        private System.Windows.Forms.Button confirm_Button;
    }
}