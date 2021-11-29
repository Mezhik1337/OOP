
namespace XML
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Speciality = new System.Windows.Forms.CheckBox();
            this.Group = new System.Windows.Forms.CheckBox();
            this.Room = new System.Windows.Forms.CheckBox();
            this.Surname = new System.Windows.Forms.CheckBox();
            this.Name = new System.Windows.Forms.CheckBox();
            this.PhoneNumber = new System.Windows.Forms.CheckBox();
            this.SpecialityBox = new System.Windows.Forms.ComboBox();
            this.GroupBox = new System.Windows.Forms.ComboBox();
            this.RoomBox = new System.Windows.Forms.ComboBox();
            this.SurnameBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.PhoneBox = new System.Windows.Forms.ComboBox();
            this.LINQ = new System.Windows.Forms.RadioButton();
            this.DOM = new System.Windows.Forms.RadioButton();
            this.SAX = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Transfer = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Speciality
            // 
            this.Speciality.AutoSize = true;
            this.Speciality.Location = new System.Drawing.Point(45, 45);
            this.Speciality.Name = "Speciality";
            this.Speciality.Size = new System.Drawing.Size(102, 24);
            this.Speciality.TabIndex = 0;
            this.Speciality.Text = "Speciality";
            this.Speciality.UseVisualStyleBackColor = true;
            // 
            // Group
            // 
            this.Group.AutoSize = true;
            this.Group.Location = new System.Drawing.Point(45, 94);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(80, 24);
            this.Group.TabIndex = 1;
            this.Group.Text = "Group";
            this.Group.UseVisualStyleBackColor = true;
            // 
            // Room
            // 
            this.Room.AutoSize = true;
            this.Room.Location = new System.Drawing.Point(45, 155);
            this.Room.Name = "Room";
            this.Room.Size = new System.Drawing.Size(78, 24);
            this.Room.TabIndex = 2;
            this.Room.Text = "Room";
            this.Room.UseVisualStyleBackColor = true;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(45, 218);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(100, 24);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Surname";
            this.Surname.UseVisualStyleBackColor = true;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(45, 275);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(77, 24);
            this.Name.TabIndex = 4;
            this.Name.Text = "Name";
            this.Name.UseVisualStyleBackColor = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(45, 343);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(141, 24);
            this.PhoneNumber.TabIndex = 5;
            this.PhoneNumber.Text = "Phone Number";
            this.PhoneNumber.UseVisualStyleBackColor = true;
            // 
            // SpecialityBox
            // 
            this.SpecialityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecialityBox.FormattingEnabled = true;
            this.SpecialityBox.Location = new System.Drawing.Point(245, 45);
            this.SpecialityBox.Name = "SpecialityBox";
            this.SpecialityBox.Size = new System.Drawing.Size(162, 28);
            this.SpecialityBox.TabIndex = 6;
            // 
            // GroupBox
            // 
            this.GroupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupBox.FormattingEnabled = true;
            this.GroupBox.Location = new System.Drawing.Point(245, 92);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(162, 28);
            this.GroupBox.TabIndex = 7;
            // 
            // RoomBox
            // 
            this.RoomBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomBox.FormattingEnabled = true;
            this.RoomBox.Location = new System.Drawing.Point(245, 164);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(162, 28);
            this.RoomBox.TabIndex = 8;
            // 
            // SurnameBox
            // 
            this.SurnameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SurnameBox.FormattingEnabled = true;
            this.SurnameBox.Location = new System.Drawing.Point(245, 218);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(162, 28);
            this.SurnameBox.TabIndex = 9;
            // 
            // NameBox
            // 
            this.NameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Location = new System.Drawing.Point(245, 271);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(162, 28);
            this.NameBox.TabIndex = 10;
            // 
            // PhoneBox
            // 
            this.PhoneBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PhoneBox.FormattingEnabled = true;
            this.PhoneBox.Location = new System.Drawing.Point(245, 339);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(162, 28);
            this.PhoneBox.TabIndex = 11;
            // 
            // LINQ
            // 
            this.LINQ.AutoSize = true;
            this.LINQ.Location = new System.Drawing.Point(57, 449);
            this.LINQ.Name = "LINQ";
            this.LINQ.Size = new System.Drawing.Size(71, 24);
            this.LINQ.TabIndex = 12;
            this.LINQ.TabStop = true;
            this.LINQ.Text = "LINQ";
            this.LINQ.UseVisualStyleBackColor = true;
            // 
            // DOM
            // 
            this.DOM.AutoSize = true;
            this.DOM.Location = new System.Drawing.Point(257, 449);
            this.DOM.Name = "DOM";
            this.DOM.Size = new System.Drawing.Size(71, 24);
            this.DOM.TabIndex = 13;
            this.DOM.TabStop = true;
            this.DOM.Text = "DOM";
            this.DOM.UseVisualStyleBackColor = true;
            // 
            // SAX
            // 
            this.SAX.AutoSize = true;
            this.SAX.Location = new System.Drawing.Point(465, 449);
            this.SAX.Name = "SAX";
            this.SAX.Size = new System.Drawing.Size(67, 24);
            this.SAX.TabIndex = 14;
            this.SAX.TabStop = true;
            this.SAX.Text = "SAX";
            this.SAX.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(682, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(435, 510);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // Transfer
            // 
            this.Transfer.Location = new System.Drawing.Point(480, 50);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(182, 44);
            this.Transfer.TabIndex = 16;
            this.Transfer.Text = "Transfer to HTML";
            this.Transfer.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(480, 135);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(182, 44);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(480, 218);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(182, 44);
            this.Search.TabIndex = 18;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 565);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SAX);
            this.Controls.Add(this.DOM);
            this.Controls.Add(this.LINQ);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.SpecialityBox);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Room);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.Speciality);
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Speciality;
        private System.Windows.Forms.CheckBox Group;
        private System.Windows.Forms.CheckBox Room;
        private System.Windows.Forms.CheckBox Surname;
        private System.Windows.Forms.CheckBox Name;
        private System.Windows.Forms.CheckBox PhoneNumber;
        private System.Windows.Forms.ComboBox SpecialityBox;
        private System.Windows.Forms.ComboBox GroupBox;
        private System.Windows.Forms.ComboBox RoomBox;
        private System.Windows.Forms.ComboBox SurnameBox;
        private System.Windows.Forms.ComboBox NameBox;
        private System.Windows.Forms.ComboBox PhoneBox;
        private System.Windows.Forms.RadioButton LINQ;
        private System.Windows.Forms.RadioButton DOM;
        private System.Windows.Forms.RadioButton SAX;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Search;
    }
}

