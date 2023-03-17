namespace EventMIS
{
    partial class loginForm
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
            components=new System.ComponentModel.Container();
            label1=new Label();
            contextMenuStrip1=new ContextMenuStrip(components);
            UsernameTextbox=new MaskedTextBox();
            PasswordTextBox=new MaskedTextBox();
            label2=new Label();
            button1=new Button();
            login=new Label();
            RegisterUser=new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(216, 132);
            label1.Name="label1";
            label1.Size=new Size(88, 21);
            label1.TabIndex=0;
            label1.Text="Username:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name="contextMenuStrip1";
            contextMenuStrip1.Size=new Size(61, 4);
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTextbox.Location=new Point(365, 124);
            UsernameTextbox.Name="UsernameTextbox";
            UsernameTextbox.Size=new Size(214, 29);
            UsernameTextbox.TabIndex=2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location=new Point(365, 191);
            PasswordTextBox.Name="PasswordTextBox";
            PasswordTextBox.Size=new Size(214, 29);
            PasswordTextBox.TabIndex=4;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(216, 199);
            label2.Name="label2";
            label2.Size=new Size(88, 21);
            label2.TabIndex=3;
            label2.Text="Password:";
            // 
            // button1
            // 
            button1.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(399, 242);
            button1.Name="button1";
            button1.Size=new Size(123, 40);
            button1.TabIndex=5;
            button1.Text="Login";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // login
            // 
            login.AutoSize=true;
            login.Font=new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            login.Location=new Point(387, 23);
            login.Name="login";
            login.Size=new Size(135, 55);
            login.TabIndex=6;
            login.Text="Login";
            // 
            // RegisterUser
            // 
            RegisterUser.AutoSize=true;
            RegisterUser.Font=new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterUser.Location=new Point(168, 334);
            RegisterUser.Name="RegisterUser";
            RegisterUser.Size=new Size(92, 19);
            RegisterUser.TabIndex=7;
            RegisterUser.TabStop=true;
            RegisterUser.Text="Register Here";
            RegisterUser.LinkClicked+=RegisterUser_LinkClicked;
            // 
            // loginForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(RegisterUser);
            Controls.Add(login);
            Controls.Add(button1);
            Controls.Add(PasswordTextBox);
            Controls.Add(label2);
            Controls.Add(UsernameTextbox);
            Controls.Add(label1);
            Name="loginForm";
            Text="Login Form";
            Load+=loginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private MaskedTextBox UsernameTextbox;
        private MaskedTextBox PasswordTextBox;
        private Label label2;
        private Button button1;
        private Label login;
        private LinkLabel RegisterUser;
    }
}