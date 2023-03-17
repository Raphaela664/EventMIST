namespace EventMIS
{
    partial class clientRegistrationForm
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
            label1=new Label();
            label2=new Label();
            namestxtbox=new TextBox();
            addresstxt=new TextBox();
            label3=new Label();
            emailtxt=new TextBox();
            label4=new Label();
            contactTxt=new TextBox();
            label5=new Label();
            button1=new Button();
            passwordtxt=new TextBox();
            label6=new Label();
            usernametxt=new TextBox();
            label7=new Label();
            cofirmtxt=new TextBox();
            label8=new Label();
            label9=new Label();
            PaymentChoiceCombo=new ComboBox();
            label10=new Label();
            cardInfo=new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(295, 9);
            label1.Name="label1";
            label1.Size=new Size(156, 42);
            label1.TabIndex=0;
            label1.Text="User Info";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(149, 64);
            label2.Name="label2";
            label2.Size=new Size(90, 21);
            label2.TabIndex=6;
            label2.Text="Full Name:";
            label2.Click+=label2_Click;
            // 
            // namestxtbox
            // 
            namestxtbox.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            namestxtbox.Location=new Point(295, 52);
            namestxtbox.Name="namestxtbox";
            namestxtbox.Size=new Size(215, 33);
            namestxtbox.TabIndex=7;
            // 
            // addresstxt
            // 
            addresstxt.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addresstxt.Location=new Point(295, 215);
            addresstxt.Name="addresstxt";
            addresstxt.Size=new Size(215, 33);
            addresstxt.TabIndex=9;
            addresstxt.TextChanged+=textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(149, 227);
            label3.Name="label3";
            label3.Size=new Size(77, 21);
            label3.TabIndex=8;
            label3.Text="Address:";
            label3.Click+=label3_Click;
            // 
            // emailtxt
            // 
            emailtxt.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxt.Location=new Point(295, 254);
            emailtxt.Name="emailtxt";
            emailtxt.Size=new Size(215, 33);
            emailtxt.TabIndex=11;
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location=new Point(149, 266);
            label4.Name="label4";
            label4.Size=new Size(55, 21);
            label4.TabIndex=10;
            label4.Text="Email:";
            // 
            // contactTxt
            // 
            contactTxt.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            contactTxt.Location=new Point(295, 293);
            contactTxt.Name="contactTxt";
            contactTxt.Size=new Size(215, 33);
            contactTxt.TabIndex=13;
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location=new Point(149, 305);
            label5.Name="label5";
            label5.Size=new Size(126, 21);
            label5.TabIndex=12;
            label5.Text="Phone Number:";
            // 
            // button1
            // 
            button1.Location=new Point(295, 415);
            button1.Name="button1";
            button1.Size=new Size(187, 23);
            button1.TabIndex=14;
            button1.Text="Save and Confirm";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // passwordtxt
            // 
            passwordtxt.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordtxt.Location=new Point(295, 135);
            passwordtxt.Name="passwordtxt";
            passwordtxt.Size=new Size(215, 33);
            passwordtxt.TabIndex=16;
            passwordtxt.TextChanged+=textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize=true;
            label6.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location=new Point(149, 147);
            label6.Name="label6";
            label6.Size=new Size(88, 21);
            label6.TabIndex=15;
            label6.Text="Password:";
            // 
            // usernametxt
            // 
            usernametxt.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usernametxt.Location=new Point(295, 92);
            usernametxt.Name="usernametxt";
            usernametxt.Size=new Size(215, 33);
            usernametxt.TabIndex=18;
            usernametxt.TextChanged+=usernametxt_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize=true;
            label7.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location=new Point(149, 104);
            label7.Name="label7";
            label7.Size=new Size(88, 21);
            label7.TabIndex=17;
            label7.Text="Username:";
            // 
            // cofirmtxt
            // 
            cofirmtxt.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cofirmtxt.Location=new Point(295, 175);
            cofirmtxt.Name="cofirmtxt";
            cofirmtxt.Size=new Size(215, 33);
            cofirmtxt.TabIndex=20;
            // 
            // label8
            // 
            label8.AutoSize=true;
            label8.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location=new Point(149, 187);
            label8.Name="label8";
            label8.Size=new Size(72, 21);
            label8.TabIndex=19;
            label8.Text="Confirm";
            // 
            // label9
            // 
            label9.AutoSize=true;
            label9.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location=new Point(149, 344);
            label9.Name="label9";
            label9.Size=new Size(136, 21);
            label9.TabIndex=21;
            label9.Text="Payment Choice:";
            // 
            // PaymentChoiceCombo
            // 
            PaymentChoiceCombo.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PaymentChoiceCombo.FormattingEnabled=true;
            PaymentChoiceCombo.Items.AddRange(new object[] { "Credit card", "Debit card", "Paypal" });
            PaymentChoiceCombo.Location=new Point(295, 336);
            PaymentChoiceCombo.Name="PaymentChoiceCombo";
            PaymentChoiceCombo.Size=new Size(215, 29);
            PaymentChoiceCombo.TabIndex=22;
            PaymentChoiceCombo.SelectedIndexChanged+=PaymentChoiceCombo_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize=true;
            label10.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location=new Point(149, 383);
            label10.Name="label10";
            label10.Size=new Size(79, 21);
            label10.TabIndex=23;
            label10.Text="Card No:";
            // 
            // cardInfo
            // 
            cardInfo.Font=new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cardInfo.Location=new Point(295, 371);
            cardInfo.Name="cardInfo";
            cardInfo.Size=new Size(215, 33);
            cardInfo.TabIndex=24;
            // 
            // clientRegistrationForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(795, 464);
            Controls.Add(cardInfo);
            Controls.Add(label10);
            Controls.Add(PaymentChoiceCombo);
            Controls.Add(label9);
            Controls.Add(cofirmtxt);
            Controls.Add(label8);
            Controls.Add(usernametxt);
            Controls.Add(label7);
            Controls.Add(passwordtxt);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(contactTxt);
            Controls.Add(label5);
            Controls.Add(emailtxt);
            Controls.Add(label4);
            Controls.Add(addresstxt);
            Controls.Add(label3);
            Controls.Add(namestxtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="clientRegistrationForm";
            Text="User Registration";
            Load+=Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox namestxtbox;
        private TextBox addresstxt;
        private Label label3;
        private TextBox emailtxt;
        private Label label4;
        private TextBox contactTxt;
        private Label label5;
        private Button button1;
        private TextBox passwordtxt;
        private Label label6;
        private TextBox usernametxt;
        private Label label7;
        private TextBox cofirmtxt;
        private Label label8;
        private Label label9;
        private ComboBox PaymentChoiceCombo;
        private Label label10;
        private TextBox cardInfo;
    }
}