namespace USATU_OOP_LW_1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("100");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("200");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("300");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("400");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("500");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Hundreds", new System.Windows.Forms.TreeNode[] {treeNode1, treeNode2, treeNode3, treeNode4, treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("10");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("20");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("30");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("40");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("50");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Tens", new System.Windows.Forms.TreeNode[] {treeNode7, treeNode8, treeNode9, treeNode10, treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Numbers", new System.Windows.Forms.TreeNode[] {treeNode6, treeNode12});
            this.labelMousePositionInfo = new System.Windows.Forms.Label();
            this.labelKeyPressInfo = new System.Windows.Forms.Label();
            this.labelMouseClickInfo = new System.Windows.Forms.Label();
            this.groupBoxColorText = new System.Windows.Forms.GroupBox();
            this.labelToColor = new System.Windows.Forms.Label();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBoxPressKeyCheck = new System.Windows.Forms.GroupBox();
            this.textBoxKeyPressChecker = new System.Windows.Forms.TextBox();
            this.timerSecondsFromStart = new System.Timers.Timer();
            this.labelCountOfTicks = new System.Windows.Forms.Label();
            this.checkedListBoxRolls = new System.Windows.Forms.CheckedListBox();
            this.groupBoxRolls = new System.Windows.Forms.GroupBox();
            this.labelSelectedRolls = new System.Windows.Forms.Label();
            this.linkLabelRickRoll = new System.Windows.Forms.LinkLabel();
            this.groupBoxChangeProgressBar = new System.Windows.Forms.GroupBox();
            this.buttonPlusTen = new System.Windows.Forms.Button();
            this.buttonMinusTen = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.checkBoxAgreement = new System.Windows.Forms.CheckBox();
            this.treeViewNumbers = new System.Windows.Forms.TreeView();
            this.groupBoxButtonsEvents = new System.Windows.Forms.GroupBox();
            this.buttonForEventsTestMain = new System.Windows.Forms.Button();
            this.buttonForEventsTest5 = new System.Windows.Forms.Button();
            this.buttonForEventsTest4 = new System.Windows.Forms.Button();
            this.buttonForEventsTest3 = new System.Windows.Forms.Button();
            this.buttonForEventsTest2 = new System.Windows.Forms.Button();
            this.buttonForEventsTest1 = new System.Windows.Forms.Button();
            this.groupBoxDropDownList = new System.Windows.Forms.GroupBox();
            this.labelSelectedComboBoxItem = new System.Windows.Forms.Label();
            this.labelAddNewElementText = new System.Windows.Forms.Label();
            this.buttonAddItemToComboBox = new System.Windows.Forms.Button();
            this.textBoxForNewComboBoxItem = new System.Windows.Forms.TextBox();
            this.labelSelectedInComboBox = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.groupBoxColorText.SuspendLayout();
            this.groupBoxPressKeyCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timerSecondsFromStart)).BeginInit();
            this.groupBoxRolls.SuspendLayout();
            this.groupBoxChangeProgressBar.SuspendLayout();
            this.groupBoxButtonsEvents.SuspendLayout();
            this.groupBoxDropDownList.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMousePositionInfo
            // 
            this.labelMousePositionInfo.Location = new System.Drawing.Point(9, 9);
            this.labelMousePositionInfo.Name = "labelMousePositionInfo";
            this.labelMousePositionInfo.Size = new System.Drawing.Size(157, 23);
            this.labelMousePositionInfo.TabIndex = 1;
            this.labelMousePositionInfo.Text = "Wating for mouse position";
            // 
            // labelKeyPressInfo
            // 
            this.labelKeyPressInfo.Location = new System.Drawing.Point(6, 42);
            this.labelKeyPressInfo.Name = "labelKeyPressInfo";
            this.labelKeyPressInfo.Size = new System.Drawing.Size(180, 23);
            this.labelKeyPressInfo.TabIndex = 1;
            this.labelKeyPressInfo.Text = "Wating for key press";
            this.labelKeyPressInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMouseClickInfo
            // 
            this.labelMouseClickInfo.Location = new System.Drawing.Point(9, 32);
            this.labelMouseClickInfo.Name = "labelMouseClickInfo";
            this.labelMouseClickInfo.Size = new System.Drawing.Size(157, 23);
            this.labelMouseClickInfo.TabIndex = 1;
            this.labelMouseClickInfo.Text = "Wating for mouse clicks";
            // 
            // groupBoxColorText
            // 
            this.groupBoxColorText.Controls.Add(this.labelToColor);
            this.groupBoxColorText.Controls.Add(this.radioButtonBlue);
            this.groupBoxColorText.Controls.Add(this.radioButtonGreen);
            this.groupBoxColorText.Controls.Add(this.radioButtonRed);
            this.groupBoxColorText.Location = new System.Drawing.Point(172, 99);
            this.groupBoxColorText.Name = "groupBoxColorText";
            this.groupBoxColorText.Size = new System.Drawing.Size(157, 114);
            this.groupBoxColorText.TabIndex = 2;
            this.groupBoxColorText.TabStop = false;
            this.groupBoxColorText.Text = "Select color";
            // 
            // labelToColor
            // 
            this.labelToColor.Location = new System.Drawing.Point(77, 18);
            this.labelToColor.Name = "labelToColor";
            this.labelToColor.Size = new System.Drawing.Size(66, 87);
            this.labelToColor.TabIndex = 1;
            this.labelToColor.Text = "Hello";
            this.labelToColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.ForeColor = System.Drawing.Color.Blue;
            this.radioButtonBlue.Location = new System.Drawing.Point(6, 79);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(65, 24);
            this.radioButtonBlue.TabIndex = 0;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.ForeColor = System.Drawing.Color.Lime;
            this.radioButtonGreen.Location = new System.Drawing.Point(6, 49);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(65, 24);
            this.radioButtonGreen.TabIndex = 0;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.ForeColor = System.Drawing.Color.Red;
            this.radioButtonRed.Location = new System.Drawing.Point(6, 19);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(65, 24);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(0, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(0, 0);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 0;
            // 
            // groupBoxPressKeyCheck
            // 
            this.groupBoxPressKeyCheck.Controls.Add(this.textBoxKeyPressChecker);
            this.groupBoxPressKeyCheck.Controls.Add(this.labelKeyPressInfo);
            this.groupBoxPressKeyCheck.Location = new System.Drawing.Point(172, 12);
            this.groupBoxPressKeyCheck.Name = "groupBoxPressKeyCheck";
            this.groupBoxPressKeyCheck.Size = new System.Drawing.Size(192, 81);
            this.groupBoxPressKeyCheck.TabIndex = 3;
            this.groupBoxPressKeyCheck.TabStop = false;
            this.groupBoxPressKeyCheck.Text = "Press Key Check";
            // 
            // textBoxKeyPressChecker
            // 
            this.textBoxKeyPressChecker.Location = new System.Drawing.Point(6, 19);
            this.textBoxKeyPressChecker.Name = "textBoxKeyPressChecker";
            this.textBoxKeyPressChecker.Size = new System.Drawing.Size(180, 20);
            this.textBoxKeyPressChecker.TabIndex = 2;
            this.textBoxKeyPressChecker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // timerSecondsFromStart
            // 
            this.timerSecondsFromStart.Enabled = true;
            this.timerSecondsFromStart.Interval = 1000D;
            this.timerSecondsFromStart.SynchronizingObject = this;
            this.timerSecondsFromStart.Elapsed += new System.Timers.ElapsedEventHandler(this.timerSecondsFromStart_Elapsed);
            // 
            // labelCountOfTicks
            // 
            this.labelCountOfTicks.Location = new System.Drawing.Point(9, 54);
            this.labelCountOfTicks.Name = "labelCountOfTicks";
            this.labelCountOfTicks.Size = new System.Drawing.Size(157, 23);
            this.labelCountOfTicks.TabIndex = 1;
            this.labelCountOfTicks.Text = "Count of ticks: 0";
            // 
            // checkedListBoxRolls
            // 
            this.checkedListBoxRolls.CheckOnClick = true;
            this.checkedListBoxRolls.FormattingEnabled = true;
            this.checkedListBoxRolls.Items.AddRange(new object[] {"Ёбоши", "ЁбиМокуёби", "ЁбиСуёби", "Куни Ли", "Бич"});
            this.checkedListBoxRolls.Location = new System.Drawing.Point(6, 19);
            this.checkedListBoxRolls.Name = "checkedListBoxRolls";
            this.checkedListBoxRolls.Size = new System.Drawing.Size(120, 94);
            this.checkedListBoxRolls.TabIndex = 4;
            this.checkedListBoxRolls.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxRolls_ItemCheck);
            // 
            // groupBoxRolls
            // 
            this.groupBoxRolls.Controls.Add(this.labelSelectedRolls);
            this.groupBoxRolls.Controls.Add(this.checkedListBoxRolls);
            this.groupBoxRolls.Location = new System.Drawing.Point(9, 130);
            this.groupBoxRolls.Name = "groupBoxRolls";
            this.groupBoxRolls.Size = new System.Drawing.Size(136, 210);
            this.groupBoxRolls.TabIndex = 5;
            this.groupBoxRolls.TabStop = false;
            this.groupBoxRolls.Text = "Choose rolls";
            // 
            // labelSelectedRolls
            // 
            this.labelSelectedRolls.Location = new System.Drawing.Point(6, 116);
            this.labelSelectedRolls.Name = "labelSelectedRolls";
            this.labelSelectedRolls.Size = new System.Drawing.Size(120, 91);
            this.labelSelectedRolls.TabIndex = 5;
            this.labelSelectedRolls.Text = "Nothing is selected";
            // 
            // linkLabelRickRoll
            // 
            this.linkLabelRickRoll.LinkArea = new System.Windows.Forms.LinkArea(10, 4);
            this.linkLabelRickRoll.Location = new System.Drawing.Point(9, 107);
            this.linkLabelRickRoll.Name = "linkLabelRickRoll";
            this.linkLabelRickRoll.Size = new System.Drawing.Size(123, 20);
            this.linkLabelRickRoll.TabIndex = 6;
            this.linkLabelRickRoll.TabStop = true;
            this.linkLabelRickRoll.Text = "Important link";
            this.linkLabelRickRoll.UseCompatibleTextRendering = true;
            this.linkLabelRickRoll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRickRoll_LinkClicked);
            // 
            // groupBoxChangeProgressBar
            // 
            this.groupBoxChangeProgressBar.Controls.Add(this.buttonPlusTen);
            this.groupBoxChangeProgressBar.Controls.Add(this.buttonMinusTen);
            this.groupBoxChangeProgressBar.Controls.Add(this.progressBar);
            this.groupBoxChangeProgressBar.Location = new System.Drawing.Point(172, 353);
            this.groupBoxChangeProgressBar.Name = "groupBoxChangeProgressBar";
            this.groupBoxChangeProgressBar.Size = new System.Drawing.Size(190, 87);
            this.groupBoxChangeProgressBar.TabIndex = 7;
            this.groupBoxChangeProgressBar.TabStop = false;
            this.groupBoxChangeProgressBar.Text = "Change progress bar";
            // 
            // buttonPlusTen
            // 
            this.buttonPlusTen.Location = new System.Drawing.Point(109, 19);
            this.buttonPlusTen.Name = "buttonPlusTen";
            this.buttonPlusTen.Size = new System.Drawing.Size(75, 23);
            this.buttonPlusTen.TabIndex = 1;
            this.buttonPlusTen.Text = "+10";
            this.buttonPlusTen.UseVisualStyleBackColor = true;
            this.buttonPlusTen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonPlusTen_MouseClick);
            // 
            // buttonMinusTen
            // 
            this.buttonMinusTen.Location = new System.Drawing.Point(6, 19);
            this.buttonMinusTen.Name = "buttonMinusTen";
            this.buttonMinusTen.Size = new System.Drawing.Size(75, 23);
            this.buttonMinusTen.TabIndex = 1;
            this.buttonMinusTen.Text = "-10";
            this.buttonMinusTen.UseVisualStyleBackColor = true;
            this.buttonMinusTen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonMinusTen_MouseClick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 48);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(178, 23);
            this.progressBar.TabIndex = 0;
            // 
            // checkBoxAgreement
            // 
            this.checkBoxAgreement.Location = new System.Drawing.Point(9, 80);
            this.checkBoxAgreement.Name = "checkBoxAgreement";
            this.checkBoxAgreement.Size = new System.Drawing.Size(104, 24);
            this.checkBoxAgreement.TabIndex = 8;
            this.checkBoxAgreement.Text = "I agree (False)";
            this.checkBoxAgreement.UseVisualStyleBackColor = true;
            this.checkBoxAgreement.CheckedChanged += new System.EventHandler(this.checkBoxAgreement_CheckedChanged);
            // 
            // treeViewNumbers
            // 
            this.treeViewNumbers.CheckBoxes = true;
            this.treeViewNumbers.Location = new System.Drawing.Point(370, 12);
            this.treeViewNumbers.Name = "treeViewNumbers";
            treeNode1.Name = "oneHundred";
            treeNode1.Text = "100";
            treeNode2.Name = "twoHundred";
            treeNode2.Text = "200";
            treeNode3.Name = "threeHundred";
            treeNode3.Text = "300";
            treeNode4.Name = "fourHundred";
            treeNode4.Text = "400";
            treeNode5.Name = "fiveHundred";
            treeNode5.Text = "500";
            treeNode6.Name = "hundreds";
            treeNode6.Text = "Hundreds";
            treeNode7.Name = "ten";
            treeNode7.Text = "10";
            treeNode8.Name = "twenty";
            treeNode8.Text = "20";
            treeNode9.Name = "thirty";
            treeNode9.Text = "30";
            treeNode10.Name = "forty";
            treeNode10.Text = "40";
            treeNode11.Name = "fifty";
            treeNode11.Text = "50";
            treeNode12.Name = "tens";
            treeNode12.Text = "Tens";
            treeNode13.Name = "numbers";
            treeNode13.Text = "Numbers";
            this.treeViewNumbers.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {treeNode13});
            this.treeViewNumbers.Size = new System.Drawing.Size(199, 163);
            this.treeViewNumbers.TabIndex = 1;
            this.treeViewNumbers.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeViewNumbers_AfterCheck);
            // 
            // groupBoxButtonsEvents
            // 
            this.groupBoxButtonsEvents.Controls.Add(this.buttonForEventsTestMain);
            this.groupBoxButtonsEvents.Controls.Add(this.buttonForEventsTest5);
            this.groupBoxButtonsEvents.Controls.Add(this.buttonForEventsTest4);
            this.groupBoxButtonsEvents.Controls.Add(this.buttonForEventsTest3);
            this.groupBoxButtonsEvents.Controls.Add(this.buttonForEventsTest2);
            this.groupBoxButtonsEvents.Controls.Add(this.buttonForEventsTest1);
            this.groupBoxButtonsEvents.Location = new System.Drawing.Point(376, 189);
            this.groupBoxButtonsEvents.Name = "groupBoxButtonsEvents";
            this.groupBoxButtonsEvents.Size = new System.Drawing.Size(200, 171);
            this.groupBoxButtonsEvents.TabIndex = 9;
            this.groupBoxButtonsEvents.TabStop = false;
            this.groupBoxButtonsEvents.Text = "Buttons events";
            // 
            // buttonForEventsTestMain
            // 
            this.buttonForEventsTestMain.Location = new System.Drawing.Point(98, 19);
            this.buttonForEventsTestMain.Name = "buttonForEventsTestMain";
            this.buttonForEventsTestMain.Size = new System.Drawing.Size(96, 139);
            this.buttonForEventsTestMain.TabIndex = 1;
            this.buttonForEventsTestMain.Text = "Click all";
            this.buttonForEventsTestMain.UseVisualStyleBackColor = true;
            // 
            // buttonForEventsTest5
            // 
            this.buttonForEventsTest5.Location = new System.Drawing.Point(6, 135);
            this.buttonForEventsTest5.Name = "buttonForEventsTest5";
            this.buttonForEventsTest5.Size = new System.Drawing.Size(76, 23);
            this.buttonForEventsTest5.TabIndex = 0;
            this.buttonForEventsTest5.Text = "Not clicked";
            this.buttonForEventsTest5.UseVisualStyleBackColor = true;
            this.buttonForEventsTest5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonForEventsTest_MouseClick);
            // 
            // buttonForEventsTest4
            // 
            this.buttonForEventsTest4.Location = new System.Drawing.Point(6, 106);
            this.buttonForEventsTest4.Name = "buttonForEventsTest4";
            this.buttonForEventsTest4.Size = new System.Drawing.Size(76, 23);
            this.buttonForEventsTest4.TabIndex = 0;
            this.buttonForEventsTest4.Text = "Not clicked";
            this.buttonForEventsTest4.UseVisualStyleBackColor = true;
            this.buttonForEventsTest4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonForEventsTest_MouseClick);
            // 
            // buttonForEventsTest3
            // 
            this.buttonForEventsTest3.Location = new System.Drawing.Point(6, 77);
            this.buttonForEventsTest3.Name = "buttonForEventsTest3";
            this.buttonForEventsTest3.Size = new System.Drawing.Size(76, 23);
            this.buttonForEventsTest3.TabIndex = 0;
            this.buttonForEventsTest3.Text = "Not clicked";
            this.buttonForEventsTest3.UseVisualStyleBackColor = true;
            this.buttonForEventsTest3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonForEventsTest_MouseClick);
            // 
            // buttonForEventsTest2
            // 
            this.buttonForEventsTest2.Location = new System.Drawing.Point(6, 48);
            this.buttonForEventsTest2.Name = "buttonForEventsTest2";
            this.buttonForEventsTest2.Size = new System.Drawing.Size(76, 23);
            this.buttonForEventsTest2.TabIndex = 0;
            this.buttonForEventsTest2.Text = "Not clicked";
            this.buttonForEventsTest2.UseVisualStyleBackColor = true;
            this.buttonForEventsTest2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonForEventsTest_MouseClick);
            // 
            // buttonForEventsTest1
            // 
            this.buttonForEventsTest1.Location = new System.Drawing.Point(6, 19);
            this.buttonForEventsTest1.Name = "buttonForEventsTest1";
            this.buttonForEventsTest1.Size = new System.Drawing.Size(76, 23);
            this.buttonForEventsTest1.TabIndex = 0;
            this.buttonForEventsTest1.Text = "Not clicked";
            this.buttonForEventsTest1.UseVisualStyleBackColor = true;
            this.buttonForEventsTest1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonForEventsTest_MouseClick);
            // 
            // groupBoxDropDownList
            // 
            this.groupBoxDropDownList.Controls.Add(this.labelSelectedComboBoxItem);
            this.groupBoxDropDownList.Controls.Add(this.labelAddNewElementText);
            this.groupBoxDropDownList.Controls.Add(this.buttonAddItemToComboBox);
            this.groupBoxDropDownList.Controls.Add(this.textBoxForNewComboBoxItem);
            this.groupBoxDropDownList.Controls.Add(this.labelSelectedInComboBox);
            this.groupBoxDropDownList.Controls.Add(this.comboBox);
            this.groupBoxDropDownList.Location = new System.Drawing.Point(172, 219);
            this.groupBoxDropDownList.Name = "groupBoxDropDownList";
            this.groupBoxDropDownList.Size = new System.Drawing.Size(192, 128);
            this.groupBoxDropDownList.TabIndex = 10;
            this.groupBoxDropDownList.TabStop = false;
            this.groupBoxDropDownList.Text = "Drop down list";
            // 
            // labelSelectedComboBoxItem
            // 
            this.labelSelectedComboBoxItem.Location = new System.Drawing.Point(6, 65);
            this.labelSelectedComboBoxItem.Name = "labelSelectedComboBoxItem";
            this.labelSelectedComboBoxItem.Size = new System.Drawing.Size(100, 23);
            this.labelSelectedComboBoxItem.TabIndex = 5;
            this.labelSelectedComboBoxItem.Text = "Nothing is selected";
            // 
            // labelAddNewElementText
            // 
            this.labelAddNewElementText.Location = new System.Drawing.Point(6, 16);
            this.labelAddNewElementText.Name = "labelAddNewElementText";
            this.labelAddNewElementText.Size = new System.Drawing.Size(100, 23);
            this.labelAddNewElementText.TabIndex = 4;
            this.labelAddNewElementText.Text = "Add new element:";
            // 
            // buttonAddItemToComboBox
            // 
            this.buttonAddItemToComboBox.Location = new System.Drawing.Point(131, 42);
            this.buttonAddItemToComboBox.Name = "buttonAddItemToComboBox";
            this.buttonAddItemToComboBox.Size = new System.Drawing.Size(55, 23);
            this.buttonAddItemToComboBox.TabIndex = 3;
            this.buttonAddItemToComboBox.Text = "Add";
            this.buttonAddItemToComboBox.UseVisualStyleBackColor = true;
            this.buttonAddItemToComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAddItemToComboBox_MouseClick);
            // 
            // textBoxForNewComboBoxItem
            // 
            this.textBoxForNewComboBoxItem.Location = new System.Drawing.Point(6, 42);
            this.textBoxForNewComboBoxItem.Name = "textBoxForNewComboBoxItem";
            this.textBoxForNewComboBoxItem.Size = new System.Drawing.Size(119, 20);
            this.textBoxForNewComboBoxItem.TabIndex = 2;
            // 
            // labelSelectedInComboBox
            // 
            this.labelSelectedInComboBox.Location = new System.Drawing.Point(6, 16);
            this.labelSelectedInComboBox.Name = "labelSelectedInComboBox";
            this.labelSelectedInComboBox.Size = new System.Drawing.Size(178, 23);
            this.labelSelectedInComboBox.TabIndex = 1;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {"-_-", ":(", ":)", "0_0", "OwO", "UwU", "ы"});
            this.comboBox.Location = new System.Drawing.Point(6, 91);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(178, 21);
            this.comboBox.TabIndex = 0;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(602, 472);
            this.Controls.Add(this.groupBoxDropDownList);
            this.Controls.Add(this.groupBoxButtonsEvents);
            this.Controls.Add(this.linkLabelRickRoll);
            this.Controls.Add(this.treeViewNumbers);
            this.Controls.Add(this.checkBoxAgreement);
            this.Controls.Add(this.groupBoxChangeProgressBar);
            this.Controls.Add(this.groupBoxRolls);
            this.Controls.Add(this.groupBoxPressKeyCheck);
            this.Controls.Add(this.groupBoxColorText);
            this.Controls.Add(this.labelCountOfTicks);
            this.Controls.Add(this.labelMouseClickInfo);
            this.Controls.Add(this.labelMousePositionInfo);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "LW 1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBoxColorText.ResumeLayout(false);
            this.groupBoxPressKeyCheck.ResumeLayout(false);
            this.groupBoxPressKeyCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.timerSecondsFromStart)).EndInit();
            this.groupBoxRolls.ResumeLayout(false);
            this.groupBoxChangeProgressBar.ResumeLayout(false);
            this.groupBoxButtonsEvents.ResumeLayout(false);
            this.groupBoxDropDownList.ResumeLayout(false);
            this.groupBoxDropDownList.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox textBoxForNewComboBoxItem;
        private System.Windows.Forms.Button buttonAddItemToComboBox;
        private System.Windows.Forms.Label labelAddNewElementText;
        private System.Windows.Forms.Label labelSelectedComboBoxItem;

        private System.Windows.Forms.GroupBox groupBoxDropDownList;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label labelSelectedInComboBox;

        private System.Windows.Forms.GroupBox groupBoxButtonsEvents;
        private System.Windows.Forms.Button buttonForEventsTest1;
        private System.Windows.Forms.Button buttonForEventsTest2;
        private System.Windows.Forms.Button buttonForEventsTest3;
        private System.Windows.Forms.Button buttonForEventsTestMain;
        private System.Windows.Forms.Button buttonForEventsTest4;
        private System.Windows.Forms.Button buttonForEventsTest5;

        private System.Windows.Forms.TreeView treeViewNumbers;

        private System.Windows.Forms.CheckBox checkBoxAgreement;

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.GroupBox groupBoxChangeProgressBar;
        private System.Windows.Forms.Button buttonMinusTen;
        private System.Windows.Forms.Button buttonPlusTen;

        private System.Windows.Forms.LinkLabel linkLabelRickRoll;

        private System.Windows.Forms.Label labelSelectedRolls;

        private System.Windows.Forms.GroupBox groupBoxRolls;

        private System.Windows.Forms.CheckedListBox checkedListBoxRolls;

        private System.Timers.Timer timerSecondsFromStart;
        private System.Windows.Forms.Label labelCountOfTicks;

        private System.Windows.Forms.TextBox textBoxKeyPressChecker;

        private System.Windows.Forms.GroupBox groupBoxPressKeyCheck;

        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.Label labelToColor;

        private System.Windows.Forms.GroupBox groupBoxColorText;

        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;

        private System.Windows.Forms.Label labelMouseClickInfo;

        private System.Windows.Forms.Label labelMousePositionInfo;

        private System.Windows.Forms.Label labelKeyPressInfo;

        private System.Windows.Forms.TextBox textBoxMousePositionInfo;
        private System.Windows.Forms.TextBox textBoxMouseClickInfo;
        private System.Windows.Forms.TextBox textBoxKeyPressInfo;

        #endregion
    }
}