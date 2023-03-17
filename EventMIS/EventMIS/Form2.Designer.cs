namespace EventMIS
{
    partial class homePage
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
            loginBtn=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 48F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(173, 83);
            label1.Name="label1";
            label1.Size=new Size(389, 73);
            label1.TabIndex=0;
            label1.Text="WELCOME !";
            // 
            // loginBtn
            // 
            loginBtn.Location=new Point(304, 240);
            loginBtn.Name="loginBtn";
            loginBtn.Size=new Size(105, 53);
            loginBtn.TabIndex=1;
            loginBtn.Text="Login";
            loginBtn.UseVisualStyleBackColor=true;
            loginBtn.Click+=loginBtn_Click;
            // 
            // homePage
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(loginBtn);
            Controls.Add(label1);
            Font=new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name="homePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button loginBtn;
    }
}