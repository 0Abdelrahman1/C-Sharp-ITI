namespace HotelManagementSystem.UI
{
    partial class Frontend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frontend));
            resPanel = new MetroFramework.Controls.MetroTabControl();
            reservationPage = new MetroFramework.Controls.MetroTabPage();
            rightMPanel = new MetroFramework.Controls.MetroPanel();
            resEditButton = new MetroFramework.Controls.MetroComboBox();
            newButton = new MetroFramework.Controls.MetroButton();
            deleteButton = new MetroFramework.Controls.MetroButton();
            editButton = new MetroFramework.Controls.MetroButton();
            updateButton = new MetroFramework.Controls.MetroButton();
            middlePanel = new MetroFramework.Controls.MetroPanel();
            smsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            foodSupplyCheckBox = new MetroFramework.Controls.MetroCheckBox();
            checkinCheckBox = new MetroFramework.Controls.MetroCheckBox();
            foodMenuButton = new MetroFramework.Controls.MetroButton();
            qtGuestComboBox = new MetroFramework.Controls.MetroComboBox();
            finalizeButton = new MetroFramework.Controls.MetroButton();
            metroLabel12 = new MetroFramework.Controls.MetroLabel();
            submitButton = new MetroFramework.Controls.MetroButton();
            depDatePicker = new DateTimePicker();
            roomNComboBox = new MetroFramework.Controls.MetroComboBox();
            floorComboBox = new MetroFramework.Controls.MetroComboBox();
            entryDatePicker = new DateTimePicker();
            entryLabel = new MetroFramework.Controls.MetroLabel();
            roomTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            choiceLabel = new MetroFramework.Controls.MetroLabel();
            leftMPanel = new MetroFramework.Controls.MetroPanel();
            emailLabel = new MetroFramework.Controls.MetroLabel();
            nameLabel = new MetroFramework.Controls.MetroLabel();
            emailTextBox = new MetroFramework.Controls.MetroTextBox();
            yearTextBox = new MetroFramework.Controls.MetroTextBox();
            monthComboBox = new MetroFramework.Controls.MetroComboBox();
            genderComboBox = new MetroFramework.Controls.MetroComboBox();
            birthdayLabel = new MetroFramework.Controls.MetroLabel();
            dayComboBox = new MetroFramework.Controls.MetroComboBox();
            phoneNumberLabel = new MetroFramework.Controls.MetroLabel();
            firstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            genderLabel = new MetroFramework.Controls.MetroLabel();
            zipComboBox = new MetroFramework.Controls.MetroTextBox();
            phoneNumberTextBox = new MetroFramework.Controls.MetroTextBox();
            stateComboBox = new MetroFramework.Controls.MetroComboBox();
            lastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            cityTextBox = new MetroFramework.Controls.MetroTextBox();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            aptTextBox = new MetroFramework.Controls.MetroTextBox();
            addLabel = new MetroFramework.Controls.MetroTextBox();
            searchPage = new MetroFramework.Controls.MetroTabPage();
            SearchError = new MetroFramework.Controls.MetroLabel();
            searchDataGridView = new DataGridView();
            searchButton = new MetroFramework.Controls.MetroButton();
            searchTextBox = new MetroFramework.Controls.MetroTextBox();
            metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            resTotalDataGridView = new DataGridView();
            roomPage = new MetroFramework.Controls.MetroTabPage();
            metroLabel13 = new MetroFramework.Controls.MetroLabel();
            metroLabel11 = new MetroFramework.Controls.MetroLabel();
            reservedLabel = new MetroFramework.Controls.MetroLabel();
            roomReservedListBox = new ListBox();
            roomOccupiedListBox = new ListBox();
            occupiedLabel = new MetroFramework.Controls.MetroLabel();
            resPanel.SuspendLayout();
            reservationPage.SuspendLayout();
            rightMPanel.SuspendLayout();
            middlePanel.SuspendLayout();
            leftMPanel.SuspendLayout();
            searchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).BeginInit();
            metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).BeginInit();
            roomPage.SuspendLayout();
            SuspendLayout();
            // 
            // resPanel
            // 
            resPanel.Controls.Add(reservationPage);
            resPanel.Controls.Add(searchPage);
            resPanel.Controls.Add(metroTabPage2);
            resPanel.Controls.Add(roomPage);
            resPanel.Location = new Point(10, 68);
            resPanel.Margin = new Padding(4);
            resPanel.Name = "resPanel";
            resPanel.Padding = new Point(6, 8);
            resPanel.SelectedIndex = 0;
            resPanel.Size = new Size(1148, 556);
            resPanel.Style = MetroFramework.MetroColorStyle.Green;
            resPanel.TabIndex = 0;
            resPanel.Theme = MetroFramework.MetroThemeStyle.Light;
            resPanel.UseSelectable = true;
            // 
            // reservationPage
            // 
            reservationPage.Controls.Add(rightMPanel);
            reservationPage.Controls.Add(middlePanel);
            reservationPage.Controls.Add(leftMPanel);
            reservationPage.HorizontalScrollbarBarColor = true;
            reservationPage.HorizontalScrollbarHighlightOnWheel = false;
            reservationPage.HorizontalScrollbarSize = 11;
            reservationPage.Location = new Point(4, 38);
            reservationPage.Margin = new Padding(4);
            reservationPage.Name = "reservationPage";
            reservationPage.Size = new Size(1140, 514);
            reservationPage.Style = MetroFramework.MetroColorStyle.Green;
            reservationPage.TabIndex = 0;
            reservationPage.Text = "Reservation";
            reservationPage.Theme = MetroFramework.MetroThemeStyle.Light;
            reservationPage.VerticalScrollbarBarColor = true;
            reservationPage.VerticalScrollbarHighlightOnWheel = false;
            reservationPage.VerticalScrollbarSize = 11;
            // 
            // rightMPanel
            // 
            rightMPanel.BackColor = Color.FromArgb(225, 225, 225);
            rightMPanel.BackgroundImageLayout = ImageLayout.None;
            rightMPanel.Controls.Add(resEditButton);
            rightMPanel.Controls.Add(newButton);
            rightMPanel.Controls.Add(deleteButton);
            rightMPanel.Controls.Add(editButton);
            rightMPanel.Controls.Add(updateButton);
            rightMPanel.HorizontalScrollbarBarColor = true;
            rightMPanel.HorizontalScrollbarHighlightOnWheel = false;
            rightMPanel.HorizontalScrollbarSize = 11;
            rightMPanel.Location = new Point(826, 16);
            rightMPanel.Margin = new Padding(4);
            rightMPanel.Name = "rightMPanel";
            rightMPanel.Size = new Size(309, 486);
            rightMPanel.TabIndex = 34;
            rightMPanel.UseCustomBackColor = true;
            rightMPanel.UseCustomForeColor = true;
            rightMPanel.UseStyleColors = true;
            rightMPanel.VerticalScrollbarBarColor = true;
            rightMPanel.VerticalScrollbarHighlightOnWheel = false;
            rightMPanel.VerticalScrollbarSize = 11;
            // 
            // resEditButton
            // 
            resEditButton.FlatStyle = FlatStyle.Popup;
            resEditButton.ForeColor = Color.Green;
            resEditButton.FormattingEnabled = true;
            resEditButton.ItemHeight = 23;
            resEditButton.Items.AddRange(new object[] { "[ID]    [NAME]    [PHONE NUMBER]" });
            resEditButton.Location = new Point(11, 35);
            resEditButton.Margin = new Padding(4);
            resEditButton.Name = "resEditButton";
            resEditButton.PromptText = "Select reservation to edit";
            resEditButton.Size = new Size(294, 29);
            resEditButton.TabIndex = 20;
            resEditButton.UseCustomForeColor = true;
            resEditButton.UseSelectable = true;
            resEditButton.UseStyleColors = true;
            resEditButton.Visible = false;
            resEditButton.SelectedIndexChanged += resEditButton_SelectedIndexChanged;
            // 
            // newButton
            // 
            newButton.Location = new Point(11, 433);
            newButton.Margin = new Padding(4);
            newButton.Name = "newButton";
            newButton.Size = new Size(286, 37);
            newButton.Style = MetroFramework.MetroColorStyle.Green;
            newButton.TabIndex = 22;
            newButton.Text = "New reservation";
            newButton.UseSelectable = true;
            newButton.UseStyleColors = true;
            newButton.Click += newButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Highlight = true;
            deleteButton.Location = new Point(11, 332);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(286, 39);
            deleteButton.Style = MetroFramework.MetroColorStyle.Red;
            deleteButton.TabIndex = 23;
            deleteButton.Text = "Delete";
            deleteButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            deleteButton.UseSelectable = true;
            deleteButton.UseStyleColors = true;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(11, 386);
            editButton.Margin = new Padding(4);
            editButton.Name = "editButton";
            editButton.Size = new Size(286, 37);
            editButton.Style = MetroFramework.MetroColorStyle.Green;
            editButton.TabIndex = 18;
            editButton.Text = "Edit existing Reservation";
            editButton.UseSelectable = true;
            editButton.UseStyleColors = true;
            editButton.Click += editButton_Click;
            // 
            // updateButton
            // 
            updateButton.Enabled = false;
            updateButton.Highlight = true;
            updateButton.Location = new Point(11, 283);
            updateButton.Margin = new Padding(4);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(286, 39);
            updateButton.Style = MetroFramework.MetroColorStyle.Green;
            updateButton.TabIndex = 19;
            updateButton.Text = "Update";
            updateButton.Theme = MetroFramework.MetroThemeStyle.Light;
            updateButton.UseSelectable = true;
            updateButton.UseStyleColors = true;
            updateButton.Visible = false;
            updateButton.Click += updateButton_Click;
            // 
            // middlePanel
            // 
            middlePanel.BackColor = Color.FromArgb(225, 225, 225);
            middlePanel.BackgroundImageLayout = ImageLayout.None;
            middlePanel.Controls.Add(smsCheckBox);
            middlePanel.Controls.Add(foodSupplyCheckBox);
            middlePanel.Controls.Add(checkinCheckBox);
            middlePanel.Controls.Add(foodMenuButton);
            middlePanel.Controls.Add(qtGuestComboBox);
            middlePanel.Controls.Add(finalizeButton);
            middlePanel.Controls.Add(metroLabel12);
            middlePanel.Controls.Add(submitButton);
            middlePanel.Controls.Add(depDatePicker);
            middlePanel.Controls.Add(roomNComboBox);
            middlePanel.Controls.Add(floorComboBox);
            middlePanel.Controls.Add(entryDatePicker);
            middlePanel.Controls.Add(entryLabel);
            middlePanel.Controls.Add(roomTypeComboBox);
            middlePanel.Controls.Add(choiceLabel);
            middlePanel.HorizontalScrollbarBarColor = true;
            middlePanel.HorizontalScrollbarHighlightOnWheel = false;
            middlePanel.HorizontalScrollbarSize = 11;
            middlePanel.Location = new Point(414, 16);
            middlePanel.Margin = new Padding(4);
            middlePanel.Name = "middlePanel";
            middlePanel.Size = new Size(402, 486);
            middlePanel.TabIndex = 16;
            middlePanel.UseCustomBackColor = true;
            middlePanel.UseCustomForeColor = true;
            middlePanel.UseStyleColors = true;
            middlePanel.VerticalScrollbarBarColor = true;
            middlePanel.VerticalScrollbarHighlightOnWheel = false;
            middlePanel.VerticalScrollbarSize = 11;
            // 
            // smsCheckBox
            // 
            smsCheckBox.AutoSize = true;
            smsCheckBox.BackColor = Color.Transparent;
            smsCheckBox.Location = new Point(122, 336);
            smsCheckBox.Margin = new Padding(4);
            smsCheckBox.Name = "smsCheckBox";
            smsCheckBox.Size = new Size(78, 15);
            smsCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            smsCheckBox.TabIndex = 35;
            smsCheckBox.Text = "Send sms?";
            smsCheckBox.UseCustomBackColor = true;
            smsCheckBox.UseSelectable = true;
            smsCheckBox.UseVisualStyleBackColor = false;
            // 
            // foodSupplyCheckBox
            // 
            foodSupplyCheckBox.AutoSize = true;
            foodSupplyCheckBox.BackColor = Color.Transparent;
            foodSupplyCheckBox.Location = new Point(227, 335);
            foodSupplyCheckBox.Margin = new Padding(4);
            foodSupplyCheckBox.Name = "foodSupplyCheckBox";
            foodSupplyCheckBox.Size = new Size(133, 15);
            foodSupplyCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            foodSupplyCheckBox.TabIndex = 34;
            foodSupplyCheckBox.Text = "Food/Supply status ?";
            foodSupplyCheckBox.UseCustomBackColor = true;
            foodSupplyCheckBox.UseSelectable = true;
            foodSupplyCheckBox.UseVisualStyleBackColor = false;
            foodSupplyCheckBox.CheckedChanged += foodSupplyCheckBox_CheckedChanged;
            // 
            // checkinCheckBox
            // 
            checkinCheckBox.AutoSize = true;
            checkinCheckBox.BackColor = Color.Transparent;
            checkinCheckBox.Location = new Point(18, 336);
            checkinCheckBox.Margin = new Padding(4);
            checkinCheckBox.Name = "checkinCheckBox";
            checkinCheckBox.Size = new Size(77, 15);
            checkinCheckBox.Style = MetroFramework.MetroColorStyle.Green;
            checkinCheckBox.TabIndex = 33;
            checkinCheckBox.Text = "Check in ?";
            checkinCheckBox.UseCustomBackColor = true;
            checkinCheckBox.UseSelectable = true;
            checkinCheckBox.UseVisualStyleBackColor = false;
            checkinCheckBox.CheckedChanged += checkinCheckBox_CheckedChanged;
            // 
            // foodMenuButton
            // 
            foodMenuButton.Location = new Point(18, 280);
            foodMenuButton.Margin = new Padding(4);
            foodMenuButton.Name = "foodMenuButton";
            foodMenuButton.Size = new Size(367, 39);
            foodMenuButton.Style = MetroFramework.MetroColorStyle.Green;
            foodMenuButton.TabIndex = 23;
            foodMenuButton.Text = "Food and menu";
            foodMenuButton.UseSelectable = true;
            foodMenuButton.UseStyleColors = true;
            foodMenuButton.Click += foodMenuButton_Click;
            // 
            // qtGuestComboBox
            // 
            qtGuestComboBox.FormattingEnabled = true;
            qtGuestComboBox.ItemHeight = 23;
            qtGuestComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            qtGuestComboBox.Location = new Point(18, 35);
            qtGuestComboBox.Margin = new Padding(4);
            qtGuestComboBox.Name = "qtGuestComboBox";
            qtGuestComboBox.PromptText = "# of guests";
            qtGuestComboBox.Size = new Size(176, 29);
            qtGuestComboBox.TabIndex = 25;
            qtGuestComboBox.UseSelectable = true;
            // 
            // finalizeButton
            // 
            finalizeButton.Location = new Point(18, 389);
            finalizeButton.Margin = new Padding(4);
            finalizeButton.Name = "finalizeButton";
            finalizeButton.Size = new Size(367, 36);
            finalizeButton.Style = MetroFramework.MetroColorStyle.Green;
            finalizeButton.TabIndex = 22;
            finalizeButton.Text = "Finalize bill";
            finalizeButton.UseSelectable = true;
            finalizeButton.UseStyleColors = true;
            finalizeButton.Click += finalizeButton_Click;
            // 
            // metroLabel12
            // 
            metroLabel12.AutoSize = true;
            metroLabel12.BackColor = Color.Transparent;
            metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel12.Location = new Point(18, 195);
            metroLabel12.Margin = new Padding(4, 0, 4, 0);
            metroLabel12.Name = "metroLabel12";
            metroLabel12.Size = new Size(110, 19);
            metroLabel12.TabIndex = 32;
            metroLabel12.Text = "Deperture [date]";
            metroLabel12.UseCustomBackColor = true;
            metroLabel12.UseCustomForeColor = true;
            // 
            // submitButton
            // 
            submitButton.Highlight = true;
            submitButton.Location = new Point(18, 429);
            submitButton.Margin = new Padding(4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(367, 41);
            submitButton.Style = MetroFramework.MetroColorStyle.Green;
            submitButton.TabIndex = 17;
            submitButton.Text = "Submit";
            submitButton.Theme = MetroFramework.MetroThemeStyle.Light;
            submitButton.UseSelectable = true;
            submitButton.UseStyleColors = true;
            submitButton.Visible = false;
            submitButton.Click += submitButton_Click;
            // 
            // depDatePicker
            // 
            depDatePicker.CalendarFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            depDatePicker.CustomFormat = "MM-dd-yyyy";
            depDatePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            depDatePicker.Format = DateTimePickerFormat.Custom;
            depDatePicker.Location = new Point(18, 220);
            depDatePicker.Margin = new Padding(4);
            depDatePicker.MaxDate = new DateTime(2027, 4, 27, 23, 59, 0, 0);
            depDatePicker.MinDate = new DateTime(2014, 4, 27, 0, 0, 0, 0);
            depDatePicker.Name = "depDatePicker";
            depDatePicker.Size = new Size(368, 26);
            depDatePicker.TabIndex = 31;
            depDatePicker.Value = new DateTime(2014, 4, 27, 0, 0, 0, 0);
            // 
            // roomNComboBox
            // 
            roomNComboBox.FormattingEnabled = true;
            roomNComboBox.ItemHeight = 23;
            roomNComboBox.Items.AddRange(new object[] { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510" });
            roomNComboBox.Location = new Point(202, 96);
            roomNComboBox.Margin = new Padding(4);
            roomNComboBox.Name = "roomNComboBox";
            roomNComboBox.PromptText = "#";
            roomNComboBox.Size = new Size(185, 29);
            roomNComboBox.TabIndex = 24;
            roomNComboBox.UseSelectable = true;
            // 
            // floorComboBox
            // 
            floorComboBox.FormattingEnabled = true;
            floorComboBox.ItemHeight = 23;
            floorComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            floorComboBox.Location = new Point(18, 96);
            floorComboBox.Margin = new Padding(4);
            floorComboBox.Name = "floorComboBox";
            floorComboBox.PromptText = "Floor";
            floorComboBox.Size = new Size(176, 29);
            floorComboBox.TabIndex = 23;
            floorComboBox.UseSelectable = true;
            // 
            // entryDatePicker
            // 
            entryDatePicker.CalendarFont = new Font("Microsoft Sans Serif", 8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            entryDatePicker.CustomFormat = "MM-dd-yyyy";
            entryDatePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entryDatePicker.Format = DateTimePickerFormat.Custom;
            entryDatePicker.Location = new Point(18, 161);
            entryDatePicker.Margin = new Padding(4);
            entryDatePicker.MaxDate = new DateTime(2027, 4, 27, 23, 59, 0, 0);
            entryDatePicker.MinDate = new DateTime(2014, 5, 11, 0, 0, 0, 0);
            entryDatePicker.Name = "entryDatePicker";
            entryDatePicker.Size = new Size(365, 26);
            entryDatePicker.TabIndex = 26;
            entryDatePicker.Value = new DateTime(2014, 5, 11, 0, 0, 0, 0);
            // 
            // entryLabel
            // 
            entryLabel.AutoSize = true;
            entryLabel.BackColor = Color.Transparent;
            entryLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            entryLabel.Location = new Point(18, 136);
            entryLabel.Margin = new Padding(4, 0, 4, 0);
            entryLabel.Name = "entryLabel";
            entryLabel.Size = new Size(80, 19);
            entryLabel.TabIndex = 30;
            entryLabel.Text = "Entry [date]";
            entryLabel.UseCustomBackColor = true;
            entryLabel.UseCustomForeColor = true;
            // 
            // roomTypeComboBox
            // 
            roomTypeComboBox.FormattingEnabled = true;
            roomTypeComboBox.ItemHeight = 23;
            roomTypeComboBox.Items.AddRange(new object[] { "Single", "Double", "Twin", "Duplex", "Suite" });
            roomTypeComboBox.Location = new Point(202, 34);
            roomTypeComboBox.Margin = new Padding(4);
            roomTypeComboBox.Name = "roomTypeComboBox";
            roomTypeComboBox.PromptText = "Room type";
            roomTypeComboBox.Size = new Size(185, 29);
            roomTypeComboBox.TabIndex = 22;
            roomTypeComboBox.UseSelectable = true;
            roomTypeComboBox.SelectedIndexChanged += roomTypeComboBox_SelectedIndexChanged;
            // 
            // choiceLabel
            // 
            choiceLabel.AutoSize = true;
            choiceLabel.BackColor = Color.Transparent;
            choiceLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            choiceLabel.Location = new Point(18, 9);
            choiceLabel.Margin = new Padding(4, 0, 4, 0);
            choiceLabel.Name = "choiceLabel";
            choiceLabel.Size = new Size(85, 19);
            choiceLabel.TabIndex = 21;
            choiceLabel.Text = "Your choices";
            choiceLabel.UseCustomBackColor = true;
            choiceLabel.UseCustomForeColor = true;
            // 
            // leftMPanel
            // 
            leftMPanel.BackColor = Color.FromArgb(225, 225, 225);
            leftMPanel.BackgroundImageLayout = ImageLayout.None;
            leftMPanel.Controls.Add(emailLabel);
            leftMPanel.Controls.Add(nameLabel);
            leftMPanel.Controls.Add(emailTextBox);
            leftMPanel.Controls.Add(yearTextBox);
            leftMPanel.Controls.Add(monthComboBox);
            leftMPanel.Controls.Add(genderComboBox);
            leftMPanel.Controls.Add(birthdayLabel);
            leftMPanel.Controls.Add(dayComboBox);
            leftMPanel.Controls.Add(phoneNumberLabel);
            leftMPanel.Controls.Add(firstNameTextBox);
            leftMPanel.Controls.Add(genderLabel);
            leftMPanel.Controls.Add(zipComboBox);
            leftMPanel.Controls.Add(phoneNumberTextBox);
            leftMPanel.Controls.Add(stateComboBox);
            leftMPanel.Controls.Add(lastNameTextBox);
            leftMPanel.Controls.Add(cityTextBox);
            leftMPanel.Controls.Add(metroLabel6);
            leftMPanel.Controls.Add(aptTextBox);
            leftMPanel.Controls.Add(addLabel);
            leftMPanel.HorizontalScrollbarBarColor = true;
            leftMPanel.HorizontalScrollbarHighlightOnWheel = false;
            leftMPanel.HorizontalScrollbarSize = 11;
            leftMPanel.Location = new Point(4, 17);
            leftMPanel.Margin = new Padding(4);
            leftMPanel.Name = "leftMPanel";
            leftMPanel.Size = new Size(402, 486);
            leftMPanel.TabIndex = 4;
            leftMPanel.UseCustomBackColor = true;
            leftMPanel.UseCustomForeColor = true;
            leftMPanel.UseStyleColors = true;
            leftMPanel.VerticalScrollbarBarColor = true;
            leftMPanel.VerticalScrollbarHighlightOnWheel = false;
            leftMPanel.VerticalScrollbarSize = 11;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = Color.Transparent;
            emailLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            emailLabel.Location = new Point(18, 260);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(130, 19);
            emailLabel.TabIndex = 15;
            emailLabel.Text = "Your e-mail address";
            emailLabel.UseCustomBackColor = true;
            emailLabel.UseCustomForeColor = true;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = Color.Transparent;
            nameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            nameLabel.Location = new Point(17, 8);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(45, 19);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name";
            nameLabel.UseCustomBackColor = true;
            nameLabel.UseCustomForeColor = true;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.White;
            emailTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            emailTextBox.Location = new Point(18, 285);
            emailTextBox.Margin = new Padding(4);
            emailTextBox.MaxLength = 32767;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.PasswordChar = '\0';
            emailTextBox.PromptText = "first.last@example.com";
            emailTextBox.ScrollBars = ScrollBars.None;
            emailTextBox.SelectedText = "";
            emailTextBox.Size = new Size(368, 34);
            emailTextBox.Style = MetroFramework.MetroColorStyle.White;
            emailTextBox.TabIndex = 14;
            emailTextBox.UseCustomBackColor = true;
            emailTextBox.UseSelectable = true;
            // 
            // yearTextBox
            // 
            yearTextBox.BackColor = Color.White;
            yearTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            yearTextBox.Location = new Point(269, 97);
            yearTextBox.Margin = new Padding(4);
            yearTextBox.MaxLength = 32767;
            yearTextBox.Name = "yearTextBox";
            yearTextBox.PasswordChar = '\0';
            yearTextBox.PromptText = "Year";
            yearTextBox.ScrollBars = ScrollBars.None;
            yearTextBox.SelectedText = "";
            yearTextBox.Size = new Size(118, 34);
            yearTextBox.Style = MetroFramework.MetroColorStyle.White;
            yearTextBox.TabIndex = 9;
            yearTextBox.UseCustomBackColor = true;
            yearTextBox.UseSelectable = true;
            // 
            // monthComboBox
            // 
            monthComboBox.FormattingEnabled = true;
            monthComboBox.ItemHeight = 23;
            monthComboBox.Items.AddRange(new object[] { "January ", "February ", "March ", "April ", "May ", "June ", "July ", "August ", "September ", "October ", "November ", "December" });
            monthComboBox.Location = new Point(18, 97);
            monthComboBox.Margin = new Padding(4);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.PromptText = "Month";
            monthComboBox.Size = new Size(140, 29);
            monthComboBox.TabIndex = 6;
            monthComboBox.UseSelectable = true;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.ItemHeight = 23;
            genderComboBox.Items.AddRange(new object[] { "Female", "Male", "Other" });
            genderComboBox.Location = new Point(18, 161);
            genderComboBox.Margin = new Padding(4);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.PromptText = "........";
            genderComboBox.Size = new Size(367, 29);
            genderComboBox.TabIndex = 11;
            genderComboBox.UseSelectable = true;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.BackColor = Color.Transparent;
            birthdayLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            birthdayLabel.Location = new Point(14, 73);
            birthdayLabel.Margin = new Padding(4, 0, 4, 0);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new Size(60, 19);
            birthdayLabel.TabIndex = 5;
            birthdayLabel.Text = "Birthday";
            birthdayLabel.UseCustomBackColor = true;
            birthdayLabel.UseCustomForeColor = true;
            // 
            // dayComboBox
            // 
            dayComboBox.FormattingEnabled = true;
            dayComboBox.ItemHeight = 23;
            dayComboBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            dayComboBox.Location = new Point(164, 97);
            dayComboBox.Margin = new Padding(4);
            dayComboBox.Name = "dayComboBox";
            dayComboBox.PromptText = "Day";
            dayComboBox.Size = new Size(96, 29);
            dayComboBox.TabIndex = 8;
            dayComboBox.UseSelectable = true;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = Color.Transparent;
            phoneNumberLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            phoneNumberLabel.Location = new Point(17, 197);
            phoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(100, 19);
            phoneNumberLabel.TabIndex = 12;
            phoneNumberLabel.Text = "Phone number";
            phoneNumberLabel.UseCustomBackColor = true;
            phoneNumberLabel.UseCustomForeColor = true;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = Color.White;
            firstNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            firstNameTextBox.Location = new Point(18, 31);
            firstNameTextBox.Margin = new Padding(4);
            firstNameTextBox.MaxLength = 32767;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PasswordChar = '\0';
            firstNameTextBox.PromptText = "First";
            firstNameTextBox.ScrollBars = ScrollBars.None;
            firstNameTextBox.SelectedText = "";
            firstNameTextBox.Size = new Size(181, 34);
            firstNameTextBox.Style = MetroFramework.MetroColorStyle.White;
            firstNameTextBox.TabIndex = 2;
            firstNameTextBox.UseCustomBackColor = true;
            firstNameTextBox.UseSelectable = true;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = Color.Transparent;
            genderLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            genderLabel.Location = new Point(15, 136);
            genderLabel.Margin = new Padding(4, 0, 4, 0);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(54, 19);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "Gender";
            genderLabel.UseCustomBackColor = true;
            genderLabel.UseCustomForeColor = true;
            // 
            // zipComboBox
            // 
            zipComboBox.BackColor = Color.White;
            zipComboBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            zipComboBox.Location = new Point(200, 436);
            zipComboBox.Margin = new Padding(4);
            zipComboBox.MaxLength = 32767;
            zipComboBox.Name = "zipComboBox";
            zipComboBox.PasswordChar = '\0';
            zipComboBox.PromptText = "Zip code";
            zipComboBox.ScrollBars = ScrollBars.None;
            zipComboBox.SelectedText = "";
            zipComboBox.Size = new Size(186, 34);
            zipComboBox.Style = MetroFramework.MetroColorStyle.White;
            zipComboBox.TabIndex = 20;
            zipComboBox.UseCustomBackColor = true;
            zipComboBox.UseSelectable = true;
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BackColor = Color.White;
            phoneNumberTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            phoneNumberTextBox.Location = new Point(17, 223);
            phoneNumberTextBox.Margin = new Padding(4);
            phoneNumberTextBox.MaxLength = 32767;
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.PasswordChar = '\0';
            phoneNumberTextBox.PromptText = "(999) 999-999";
            phoneNumberTextBox.ScrollBars = ScrollBars.None;
            phoneNumberTextBox.SelectedText = "";
            phoneNumberTextBox.Size = new Size(368, 34);
            phoneNumberTextBox.Style = MetroFramework.MetroColorStyle.White;
            phoneNumberTextBox.TabIndex = 13;
            phoneNumberTextBox.UseCustomBackColor = true;
            phoneNumberTextBox.UseSelectable = true;
            phoneNumberTextBox.Leave += phoneNumberTextBox_Leave;
            // 
            // stateComboBox
            // 
            stateComboBox.FormattingEnabled = true;
            stateComboBox.ItemHeight = 23;
            stateComboBox.Items.AddRange(new object[] { "Alabama ", "Alaska ", "Arizona ", "Arkansas ", "California ", "Colorado ", "Connecticut ", "Delaware ", "Florida ", "Georgia ", "Hawaii ", "Idaho ", "Illinois Indiana ", "Iowa ", "Kansas ", "Kentucky ", "Louisiana ", "Maine ", "Maryland ", "Massachusetts ", "Michigan ", "Minnesota ", "Mississippi ", "Missouri ", "Montana Nebraska ", "Nevada ", "New Hampshire ", "New Jersey ", "New Mexico ", "New York ", "North Carolina ", "North Dakota ", "Ohio ", "Oklahoma ", "Oregon ", "Pennsylvania Rhode Island ", "South Carolina ", "South Dakota ", "Tennessee ", "Texas ", "Utah ", "Vermont ", "Virginia ", "Washington ", "West Virginia ", "Wisconsin ", "Wyoming" });
            stateComboBox.Location = new Point(18, 436);
            stateComboBox.Margin = new Padding(4);
            stateComboBox.Name = "stateComboBox";
            stateComboBox.PromptText = "State";
            stateComboBox.Size = new Size(175, 29);
            stateComboBox.TabIndex = 19;
            stateComboBox.UseSelectable = true;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = Color.White;
            lastNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            lastNameTextBox.Location = new Point(206, 31);
            lastNameTextBox.Margin = new Padding(4);
            lastNameTextBox.MaxLength = 32767;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PasswordChar = '\0';
            lastNameTextBox.PromptText = "Last";
            lastNameTextBox.ScrollBars = ScrollBars.None;
            lastNameTextBox.SelectedText = "";
            lastNameTextBox.Size = new Size(181, 34);
            lastNameTextBox.TabIndex = 3;
            lastNameTextBox.UseCustomBackColor = true;
            lastNameTextBox.UseSelectable = true;
            // 
            // cityTextBox
            // 
            cityTextBox.BackColor = Color.White;
            cityTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            cityTextBox.Location = new Point(200, 388);
            cityTextBox.Margin = new Padding(4);
            cityTextBox.MaxLength = 32767;
            cityTextBox.Name = "cityTextBox";
            cityTextBox.PasswordChar = '\0';
            cityTextBox.PromptText = "City";
            cityTextBox.ScrollBars = ScrollBars.None;
            cityTextBox.SelectedText = "";
            cityTextBox.Size = new Size(186, 34);
            cityTextBox.Style = MetroFramework.MetroColorStyle.White;
            cityTextBox.TabIndex = 18;
            cityTextBox.UseCustomBackColor = true;
            cityTextBox.UseSelectable = true;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.BackColor = Color.Transparent;
            metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel6.Location = new Point(17, 285);
            metroLabel6.Margin = new Padding(4, 0, 4, 0);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(88, 19);
            metroLabel6.TabIndex = 16;
            metroLabel6.Text = "Your address";
            metroLabel6.UseCustomBackColor = true;
            metroLabel6.UseCustomForeColor = true;
            // 
            // aptTextBox
            // 
            aptTextBox.BackColor = Color.White;
            aptTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            aptTextBox.Location = new Point(17, 386);
            aptTextBox.Margin = new Padding(4);
            aptTextBox.MaxLength = 32767;
            aptTextBox.Name = "aptTextBox";
            aptTextBox.PasswordChar = '\0';
            aptTextBox.PromptText = "Apt./Suite";
            aptTextBox.ScrollBars = ScrollBars.None;
            aptTextBox.SelectedText = "";
            aptTextBox.Size = new Size(176, 34);
            aptTextBox.Style = MetroFramework.MetroColorStyle.White;
            aptTextBox.TabIndex = 17;
            aptTextBox.UseCustomBackColor = true;
            aptTextBox.UseSelectable = true;
            // 
            // addLabel
            // 
            addLabel.BackColor = Color.White;
            addLabel.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            addLabel.Location = new Point(15, 335);
            addLabel.Margin = new Padding(4);
            addLabel.MaxLength = 32767;
            addLabel.Name = "addLabel";
            addLabel.PasswordChar = '\0';
            addLabel.PromptText = "Street address";
            addLabel.ScrollBars = ScrollBars.None;
            addLabel.SelectedText = "";
            addLabel.Size = new Size(368, 34);
            addLabel.Style = MetroFramework.MetroColorStyle.White;
            addLabel.TabIndex = 15;
            addLabel.UseCustomBackColor = true;
            addLabel.UseSelectable = true;
            // 
            // searchPage
            // 
            searchPage.Controls.Add(SearchError);
            searchPage.Controls.Add(searchDataGridView);
            searchPage.Controls.Add(searchButton);
            searchPage.Controls.Add(searchTextBox);
            searchPage.HorizontalScrollbarBarColor = true;
            searchPage.HorizontalScrollbarHighlightOnWheel = false;
            searchPage.HorizontalScrollbarSize = 11;
            searchPage.Location = new Point(4, 38);
            searchPage.Margin = new Padding(4);
            searchPage.Name = "searchPage";
            searchPage.Size = new Size(1140, 514);
            searchPage.TabIndex = 4;
            searchPage.Text = "Universal Search";
            searchPage.VerticalScrollbarBarColor = true;
            searchPage.VerticalScrollbarHighlightOnWheel = false;
            searchPage.VerticalScrollbarSize = 11;
            // 
            // SearchError
            // 
            SearchError.AutoSize = true;
            SearchError.FontSize = MetroFramework.MetroLabelSize.Tall;
            SearchError.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            SearchError.Location = new Point(315, 43);
            SearchError.Margin = new Padding(4, 0, 4, 0);
            SearchError.Name = "SearchError";
            SearchError.Size = new Size(313, 150);
            SearchError.Style = MetroFramework.MetroColorStyle.Green;
            SearchError.TabIndex = 19;
            SearchError.Text = "I ran out of entries :( SORRY DUDE.\r\n\r\nYou know, we can make another deal. \r\n\r\nI sure will find something.\r\n";
            SearchError.Theme = MetroFramework.MetroThemeStyle.Light;
            SearchError.Visible = false;
            // 
            // searchDataGridView
            // 
            searchDataGridView.AllowUserToAddRows = false;
            searchDataGridView.AllowUserToDeleteRows = false;
            searchDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchDataGridView.Location = new Point(80, 47);
            searchDataGridView.Margin = new Padding(4);
            searchDataGridView.Name = "searchDataGridView";
            searchDataGridView.ReadOnly = true;
            searchDataGridView.Size = new Size(851, 272);
            searchDataGridView.TabIndex = 18;
            searchDataGridView.Visible = false;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.Transparent;
            searchButton.BackgroundImage = (Image)resources.GetObject("searchButton.BackgroundImage");
            searchButton.BackgroundImageLayout = ImageLayout.Zoom;
            searchButton.Location = new Point(886, 227);
            searchButton.Margin = new Padding(4);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(53, 34);
            searchButton.TabIndex = 17;
            searchButton.UseCustomBackColor = true;
            searchButton.UseSelectable = true;
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = Color.White;
            searchTextBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            searchTextBox.Icon = (Image)resources.GetObject("searchTextBox.Icon");
            searchTextBox.IconRight = true;
            searchTextBox.Location = new Point(88, 227);
            searchTextBox.Margin = new Padding(4);
            searchTextBox.MaxLength = 32767;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PasswordChar = '\0';
            searchTextBox.PromptText = "Search";
            searchTextBox.ScrollBars = ScrollBars.None;
            searchTextBox.SelectedText = "";
            searchTextBox.Size = new Size(832, 34);
            searchTextBox.Style = MetroFramework.MetroColorStyle.White;
            searchTextBox.TabIndex = 15;
            searchTextBox.UseCustomBackColor = true;
            searchTextBox.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            metroTabPage2.AutoScroll = true;
            metroTabPage2.Controls.Add(resTotalDataGridView);
            metroTabPage2.HorizontalScrollbar = true;
            metroTabPage2.HorizontalScrollbarBarColor = true;
            metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            metroTabPage2.HorizontalScrollbarSize = 11;
            metroTabPage2.Location = new Point(4, 38);
            metroTabPage2.Margin = new Padding(4);
            metroTabPage2.Name = "metroTabPage2";
            metroTabPage2.Size = new Size(1140, 514);
            metroTabPage2.TabIndex = 3;
            metroTabPage2.Text = "Reservation Adv. view";
            metroTabPage2.VerticalScrollbar = true;
            metroTabPage2.VerticalScrollbarBarColor = true;
            metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            metroTabPage2.VerticalScrollbarSize = 11;
            // 
            // resTotalDataGridView
            // 
            resTotalDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resTotalDataGridView.Location = new Point(0, 4);
            resTotalDataGridView.Margin = new Padding(4);
            resTotalDataGridView.Name = "resTotalDataGridView";
            resTotalDataGridView.Size = new Size(1138, 501);
            resTotalDataGridView.TabIndex = 2;
            // 
            // roomPage
            // 
            roomPage.Controls.Add(metroLabel13);
            roomPage.Controls.Add(metroLabel11);
            roomPage.Controls.Add(reservedLabel);
            roomPage.Controls.Add(roomReservedListBox);
            roomPage.Controls.Add(roomOccupiedListBox);
            roomPage.Controls.Add(occupiedLabel);
            roomPage.HorizontalScrollbarBarColor = true;
            roomPage.HorizontalScrollbarHighlightOnWheel = false;
            roomPage.HorizontalScrollbarSize = 11;
            roomPage.Location = new Point(4, 38);
            roomPage.Margin = new Padding(4);
            roomPage.Name = "roomPage";
            roomPage.Size = new Size(1140, 514);
            roomPage.TabIndex = 2;
            roomPage.Text = "Room availibility";
            roomPage.VerticalScrollbarBarColor = true;
            roomPage.VerticalScrollbarHighlightOnWheel = false;
            roomPage.VerticalScrollbarSize = 11;
            // 
            // metroLabel13
            // 
            metroLabel13.AutoSize = true;
            metroLabel13.BackColor = Color.Transparent;
            metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel13.Location = new Point(536, 32);
            metroLabel13.Margin = new Padding(4, 0, 4, 0);
            metroLabel13.Name = "metroLabel13";
            metroLabel13.Size = new Size(478, 19);
            metroLabel13.TabIndex = 10;
            metroLabel13.Text = "Room#| Type  |  ID#   |       Name      |      Phone #      |     Entry       |    Depart";
            metroLabel13.UseCustomBackColor = true;
            metroLabel13.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            metroLabel11.AutoSize = true;
            metroLabel11.BackColor = Color.Transparent;
            metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel11.Location = new Point(-4, 32);
            metroLabel11.Margin = new Padding(4, 0, 4, 0);
            metroLabel11.Name = "metroLabel11";
            metroLabel11.Size = new Size(310, 19);
            metroLabel11.TabIndex = 9;
            metroLabel11.Text = "Room#| Type  |  ID#   |       Name      |      Phone #";
            metroLabel11.UseCustomBackColor = true;
            metroLabel11.UseCustomForeColor = true;
            // 
            // reservedLabel
            // 
            reservedLabel.AutoSize = true;
            reservedLabel.BackColor = Color.Transparent;
            reservedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            reservedLabel.Location = new Point(536, 5);
            reservedLabel.Margin = new Padding(4, 0, 4, 0);
            reservedLabel.Name = "reservedLabel";
            reservedLabel.Size = new Size(64, 19);
            reservedLabel.TabIndex = 8;
            reservedLabel.Text = "Reserved";
            reservedLabel.UseCustomBackColor = true;
            reservedLabel.UseCustomForeColor = true;
            // 
            // roomReservedListBox
            // 
            roomReservedListBox.BackColor = Color.FromArgb(224, 224, 224);
            //roomReservedListBox.BorderStyle = BorderStyle.None;
            roomReservedListBox.FormattingEnabled = true;
            roomReservedListBox.HorizontalScrollbar = true;
            roomReservedListBox.IntegralHeight = false;
            roomReservedListBox.Location = new Point(536, 58);
            roomReservedListBox.Margin = new Padding(4);
            roomReservedListBox.Name = "roomReservedListBox";
            roomReservedListBox.Size = new Size(602, 446);
            roomReservedListBox.TabIndex = 7;
            // 
            // roomOccupiedListBox
            // 
            roomOccupiedListBox.BackColor = Color.FromArgb(224, 224, 224);
            //roomOccupiedListBox.BorderStyle = BorderStyle.None;
            roomOccupiedListBox.Font = new Font("Segoe UI Symbol", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roomOccupiedListBox.FormattingEnabled = true;
            roomOccupiedListBox.HorizontalScrollbar = true;
            roomOccupiedListBox.IntegralHeight = false;
            roomOccupiedListBox.Location = new Point(0, 58);
            roomOccupiedListBox.Margin = new Padding(4);
            roomOccupiedListBox.Name = "roomOccupiedListBox";
            roomOccupiedListBox.Size = new Size(529, 446);
            roomOccupiedListBox.TabIndex = 6;
            // 
            // occupiedLabel
            // 
            occupiedLabel.AutoSize = true;
            occupiedLabel.BackColor = Color.Transparent;
            occupiedLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            occupiedLabel.Location = new Point(-4, 5);
            occupiedLabel.Margin = new Padding(4, 0, 4, 0);
            occupiedLabel.Name = "occupiedLabel";
            occupiedLabel.Size = new Size(66, 19);
            occupiedLabel.TabIndex = 5;
            occupiedLabel.Text = "Occupied";
            occupiedLabel.UseCustomBackColor = true;
            occupiedLabel.UseCustomForeColor = true;
            // 
            // Frontend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackImage = (Image)resources.GetObject("$this.BackImage");
            BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            ClientSize = new Size(1165, 629);
            Controls.Add(resPanel);
            Margin = new Padding(4);
            Name = "Frontend";
            Padding = new Padding(24, 69, 24, 23);
            ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            StartPosition = FormStartPosition.Manual;
            Style = MetroFramework.MetroColorStyle.Green;
            Text = "Frontend";
            FormClosing += frontend_FormClosing;
            Load += MainTab_Load;
            resPanel.ResumeLayout(false);
            reservationPage.ResumeLayout(false);
            rightMPanel.ResumeLayout(false);
            middlePanel.ResumeLayout(false);
            middlePanel.PerformLayout();
            leftMPanel.ResumeLayout(false);
            leftMPanel.PerformLayout();
            searchPage.ResumeLayout(false);
            searchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchDataGridView).EndInit();
            metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resTotalDataGridView).EndInit();
            roomPage.ResumeLayout(false);
            roomPage.PerformLayout();
            ResumeLayout(false);

        }

        #endregion



        private MetroFramework.Controls.MetroTabControl resPanel;
        private MetroFramework.Controls.MetroTabPage reservationPage;
        private MetroFramework.Controls.MetroPanel leftMPanel;
        private MetroFramework.Controls.MetroTextBox firstNameTextBox;
        private MetroFramework.Controls.MetroTextBox lastNameTextBox;
        private MetroFramework.Controls.MetroLabel birthdayLabel;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroComboBox monthComboBox;
        private MetroFramework.Controls.MetroTextBox yearTextBox;
        private MetroFramework.Controls.MetroComboBox dayComboBox;
        private MetroFramework.Controls.MetroTextBox phoneNumberTextBox;
        private MetroFramework.Controls.MetroLabel genderLabel;
        private MetroFramework.Controls.MetroLabel phoneNumberLabel;
        private MetroFramework.Controls.MetroComboBox genderComboBox;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroTextBox emailTextBox;
        private MetroFramework.Controls.MetroPanel middlePanel;
        private MetroFramework.Controls.MetroTextBox zipComboBox;
        private MetroFramework.Controls.MetroComboBox stateComboBox;
        private MetroFramework.Controls.MetroTextBox cityTextBox;
        private MetroFramework.Controls.MetroTextBox aptTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox addLabel;
        private MetroFramework.Controls.MetroComboBox roomTypeComboBox;
        private MetroFramework.Controls.MetroLabel choiceLabel;
        private MetroFramework.Controls.MetroComboBox roomNComboBox;
        private MetroFramework.Controls.MetroComboBox floorComboBox;
        private MetroFramework.Controls.MetroButton submitButton;
        private MetroFramework.Controls.MetroButton updateButton;
        private MetroFramework.Controls.MetroButton editButton;
        private MetroFramework.Controls.MetroButton finalizeButton;
        private MetroFramework.Controls.MetroButton newButton;
        private System.Windows.Forms.DateTimePicker entryDatePicker;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.DateTimePicker depDatePicker;
        private MetroFramework.Controls.MetroLabel entryLabel;
        private MetroFramework.Controls.MetroButton foodMenuButton;
        private MetroFramework.Controls.MetroButton deleteButton;
        private MetroFramework.Controls.MetroCheckBox checkinCheckBox;
        private MetroFramework.Controls.MetroComboBox resEditButton;
        private MetroFramework.Controls.MetroPanel rightMPanel;

        private MetroFramework.Controls.MetroTabPage roomPage;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
      
        private System.Windows.Forms.DataGridView resTotalDataGridView;
        private MetroFramework.Controls.MetroCheckBox foodSupplyCheckBox;
        private System.Windows.Forms.ListBox roomOccupiedListBox;
        private MetroFramework.Controls.MetroLabel occupiedLabel;
        private MetroFramework.Controls.MetroLabel reservedLabel;
        private System.Windows.Forms.ListBox roomReservedListBox;
        private MetroFramework.Controls.MetroTabPage searchPage;
        private MetroFramework.Controls.MetroTextBox searchTextBox;
        private MetroFramework.Controls.MetroComboBox qtGuestComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DataGridView searchDataGridView;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Controls.MetroLabel SearchError;
        private MetroFramework.Controls.MetroCheckBox smsCheckBox;


     
    }
}