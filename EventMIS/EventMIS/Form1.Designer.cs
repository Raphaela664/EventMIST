namespace EventMIS
{
    partial class eventForm
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
            eventGridView=new DataGridView();
            eventId=new Label();
            createEvent=new Button();
            eventIdText=new TextBox();
            updateEvent=new Button();
            viewAll=new Button();
            deleteEvent=new Button();
            searchBtn=new Button();
            eventLocationTxt=new TextBox();
            label1=new Label();
            eventNameTxt=new TextBox();
            eventName=new Label();
            textBox4=new TextBox();
            label2=new Label();
            eventdate=new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)eventGridView).BeginInit();
            SuspendLayout();
            // 
            // eventGridView
            // 
            eventGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            eventGridView.Location=new Point(106, 304);
            eventGridView.Name="eventGridView";
            eventGridView.RowTemplate.Height=25;
            eventGridView.Size=new Size(578, 134);
            eventGridView.TabIndex=0;
            // 
            // eventId
            // 
            eventId.AutoSize=true;
            eventId.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            eventId.Location=new Point(122, 38);
            eventId.Name="eventId";
            eventId.Size=new Size(85, 21);
            eventId.TabIndex=1;
            eventId.Text="Event ID: ";
            eventId.Click+=eventId_Click;
            // 
            // createEvent
            // 
            createEvent.BackColor=Color.Transparent;
            createEvent.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            createEvent.Location=new Point(535, 58);
            createEvent.Name="createEvent";
            createEvent.Size=new Size(143, 34);
            createEvent.TabIndex=2;
            createEvent.Text="Create  Event";
            createEvent.UseVisualStyleBackColor=false;
            createEvent.Click+=createEvent_Click;
            // 
            // eventIdText
            // 
            eventIdText.Enabled=false;
            eventIdText.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            eventIdText.Location=new Point(264, 30);
            eventIdText.Name="eventIdText";
            eventIdText.Size=new Size(214, 29);
            eventIdText.TabIndex=3;
            // 
            // updateEvent
            // 
            updateEvent.BackColor=Color.Transparent;
            updateEvent.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            updateEvent.Location=new Point(535, 112);
            updateEvent.Name="updateEvent";
            updateEvent.Size=new Size(143, 34);
            updateEvent.TabIndex=4;
            updateEvent.Text="Update Event";
            updateEvent.UseVisualStyleBackColor=false;
            updateEvent.Click+=updateEvent_Click;
            // 
            // viewAll
            // 
            viewAll.BackColor=Color.Transparent;
            viewAll.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            viewAll.Location=new Point(535, 216);
            viewAll.Name="viewAll";
            viewAll.Size=new Size(143, 34);
            viewAll.TabIndex=5;
            viewAll.Text="View All";
            viewAll.UseVisualStyleBackColor=false;
            viewAll.Click+=viewAll_Click;
            // 
            // deleteEvent
            // 
            deleteEvent.BackColor=Color.Transparent;
            deleteEvent.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteEvent.Location=new Point(535, 163);
            deleteEvent.Name="deleteEvent";
            deleteEvent.Size=new Size(143, 34);
            deleteEvent.TabIndex=6;
            deleteEvent.Text="Delete Event";
            deleteEvent.UseVisualStyleBackColor=false;
            deleteEvent.Click+=deleteEvent_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor=Color.Transparent;
            searchBtn.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchBtn.Location=new Point(350, 235);
            searchBtn.Name="searchBtn";
            searchBtn.Size=new Size(75, 34);
            searchBtn.TabIndex=7;
            searchBtn.Text="Search";
            searchBtn.UseVisualStyleBackColor=false;
            // 
            // eventLocationTxt
            // 
            eventLocationTxt.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            eventLocationTxt.Location=new Point(264, 117);
            eventLocationTxt.Name="eventLocationTxt";
            eventLocationTxt.Size=new Size(214, 29);
            eventLocationTxt.TabIndex=9;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(122, 125);
            label1.Name="label1";
            label1.Size=new Size(132, 21);
            label1.TabIndex=8;
            label1.Text="Event Location: ";
            // 
            // eventNameTxt
            // 
            eventNameTxt.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            eventNameTxt.Location=new Point(264, 71);
            eventNameTxt.Name="eventNameTxt";
            eventNameTxt.Size=new Size(214, 29);
            eventNameTxt.TabIndex=11;
            eventNameTxt.TextChanged+=textBox3_TextChanged;
            // 
            // eventName
            // 
            eventName.AutoSize=true;
            eventName.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            eventName.Location=new Point(122, 79);
            eventName.Name="eventName";
            eventName.Size=new Size(109, 21);
            eventName.TabIndex=10;
            eventName.Text="Event Name: ";
            eventName.Click+=label2_Click;
            // 
            // textBox4
            // 
            textBox4.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location=new Point(91, 240);
            textBox4.Name="textBox4";
            textBox4.Size=new Size(214, 29);
            textBox4.TabIndex=12;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(122, 170);
            label2.Name="label2";
            label2.Size=new Size(100, 21);
            label2.TabIndex=13;
            label2.Text="Event Date: ";
            // 
            // eventdate
            // 
            eventdate.Format=DateTimePickerFormat.Short;
            eventdate.Location=new Point(264, 163);
            eventdate.Name="eventdate";
            eventdate.Size=new Size(214, 23);
            eventdate.TabIndex=14;
            eventdate.ValueChanged+=dateTimePicker1_ValueChanged;
            // 
            // eventForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(eventdate);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(eventNameTxt);
            Controls.Add(eventName);
            Controls.Add(eventLocationTxt);
            Controls.Add(label1);
            Controls.Add(searchBtn);
            Controls.Add(deleteEvent);
            Controls.Add(viewAll);
            Controls.Add(updateEvent);
            Controls.Add(eventIdText);
            Controls.Add(createEvent);
            Controls.Add(eventId);
            Controls.Add(eventGridView);
            Name="eventForm";
            Text="Event Form";
            Load+=eventForm_Load;
            ((System.ComponentModel.ISupportInitialize)eventGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView eventGridView;
        private Label eventId;
        private Button createEvent;
        private TextBox eventIdText;
        private Button updateEvent;
        private Button viewAll;
        private Button deleteEvent;
        private Button searchBtn;
        private TextBox eventLocationTxt;
        private Label label1;
        private TextBox eventNameTxt;
        private Label eventName;
        private TextBox textBox4;
        private Label label2;
        private DateTimePicker eventdate;
    }
}