using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace USATU_OOP_LW_1
{
    public partial class Form1 : Form
    {
        private const string RickRollLink = "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        private int _countOfSeconds = 0;
        private SortedSet<int> _selectedRollsIndexes = new SortedSet<int>();

        private const int MovingTextDownOffset = 60;
        private const int MovingTextStep = 10;
        private Point _currentMovingTextPosition;
        private bool _isMovingDown = false;

        public Form1()
        {
            InitializeComponent();

            buttonForEventsTestMain.MouseClick += buttonForEventsTest1_MouseClick;
            buttonForEventsTestMain.MouseClick += buttonForEventsTest2_MouseClick;
            buttonForEventsTestMain.MouseClick += buttonForEventsTest3_MouseClick;
            buttonForEventsTestMain.MouseClick += buttonForEventsTest4_MouseClick;
            buttonForEventsTestMain.MouseClick += buttonForEventsTest5_MouseClick;

            _currentMovingTextPosition = new Point(panelForMovingText.Size.Width / 2, 0);
            panelForMovingText.Paint += DrawMovingText;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            labelMousePositionInfo.Text = "Mouse (" + e.X + "; " + e.Y + ")";
        }

        private void ButtonSelfDelete(object sender, MouseEventArgs e)
        {
            var buttonToDelete = sender as Button;
            if (buttonToDelete != null)
            {
                Controls.Remove(buttonToDelete);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            labelMouseClickInfo.Text = "Mouse click (" + e.X + "; " + e.Y + ")";

            var buttonOnClick = new Button();
            buttonOnClick.Size = new Size(90, 23);
            buttonOnClick.Text = "Click";
            buttonOnClick.Location = new Point(e.X - buttonOnClick.Size.Width / 2, e.Y - buttonOnClick.Size.Height / 2);
            buttonOnClick.TextAlign = ContentAlignment.MiddleCenter;
            buttonOnClick.MouseClick += ButtonSelfDelete;
            Controls.Add(buttonOnClick);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            labelKeyPressInfo.Text = "Key pressed: <" + e.KeyChar + ">";
        }

        private void labelToColor_ChangeColor(Color colorToSet)
        {
            labelToColor.ForeColor = colorToSet;
        }

        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            labelToColor_ChangeColor(Color.Red);
        }

        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            labelToColor_ChangeColor(Color.Green);
        }

        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            labelToColor_ChangeColor(Color.Blue);
        }

        private void timerSecondsFromStart_Elapsed(object sender, ElapsedEventArgs e)
        {
            _countOfSeconds++;
            labelCountOfTicks.Text = "Seconds from start: " + _countOfSeconds;
        }

        private void timerMovingTextPanelUpdate_Elapsed(object sender, ElapsedEventArgs e)
        {
            panelForMovingText.Invalidate();
        }

        private void UpdateMovingTextLocation()
        {
            if (_isMovingDown)
            {
                _currentMovingTextPosition.Y += MovingTextStep;
            }
            else
            {
                _currentMovingTextPosition.Y -= MovingTextStep;
            }

            if (_currentMovingTextPosition.Y >= panelForMovingText.Size.Height - MovingTextDownOffset)
            {
                _isMovingDown = false;
            }
            else if (_currentMovingTextPosition.Y <= 0)
            {
                _isMovingDown = true;
            }
        }

        private void DrawMovingText(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            UpdateMovingTextLocation();
            g.DrawString("@\n |\n |\n@", Font, Brushes.Black, _currentMovingTextPosition);
        }

        private void linkLabelRickRoll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(RickRollLink);
        }

        private void UpdateSelectedRollsText()
        {
            if (_selectedRollsIndexes.Count == 0)
            {
                labelSelectedRolls.Text = "Nothing is selected";
            }
            else
            {
                var newSelectedRollsText = new StringBuilder("Selected Rolls:\n");
                foreach (var index in _selectedRollsIndexes)
                {
                    newSelectedRollsText.Append("* ");
                    newSelectedRollsText.Append(checkedListBoxRolls.Items[index]);
                    newSelectedRollsText.Append("\n");
                }

                labelSelectedRolls.Text = newSelectedRollsText.ToString();
            }
        }

        private void checkedListBoxRolls_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                _selectedRollsIndexes.Add(e.Index);
            }
            else
            {
                _selectedRollsIndexes.Remove(e.Index);
            }

            UpdateSelectedRollsText();
        }

        private void buttonMinusTen_MouseClick(object sender, MouseEventArgs e)
        {
            progressBar.Increment(-10);
        }

        private void buttonPlusTen_MouseClick(object sender, MouseEventArgs e)
        {
            progressBar.PerformStep();
        }

        private void checkBoxAgreement_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxAgreement.Text = "I agree (";
            if (checkBoxAgreement.Checked)
            {
                checkBoxAgreement.Text += "True)";
            }
            else
            {
                checkBoxAgreement.Text += "False)";
            }
        }

        private void treeViewNumbers_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Node.GetNodeCount(false) != 0)
            {
                for (var i = 0; i < e.Node.GetNodeCount(false); i++)
                {
                    e.Node.Nodes[i].Checked = e.Node.Checked;
                }
            }
        }

        private void buttonForEventsTest_MouseClick(object sender, MouseEventArgs e)
        {
            var button = sender as Button;
            if (button != null) button.Text = "Clicked";
        }

        private void buttonForEventsTest1_MouseClick(object sender, MouseEventArgs e)
        {
            buttonForEventsTest_MouseClick(buttonForEventsTest1, e);
        }

        private void buttonForEventsTest2_MouseClick(object sender, MouseEventArgs e)
        {
            buttonForEventsTest_MouseClick(buttonForEventsTest2, e);
        }

        private void buttonForEventsTest3_MouseClick(object sender, MouseEventArgs e)
        {
            buttonForEventsTest_MouseClick(buttonForEventsTest3, e);
        }

        private void buttonForEventsTest4_MouseClick(object sender, MouseEventArgs e)
        {
            buttonForEventsTest_MouseClick(buttonForEventsTest4, e);
        }

        private void buttonForEventsTest5_MouseClick(object sender, MouseEventArgs e)
        {
            buttonForEventsTest_MouseClick(buttonForEventsTest5, e);
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSelectedComboBoxItem.Text = "Selected: " + comboBox.SelectedItem;
        }

        private void buttonAddItemToComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxForNewComboBoxItem.Text != string.Empty)
            {
                comboBox.Items.Add(textBoxForNewComboBoxItem.Text);
                textBoxForNewComboBoxItem.Clear();
            }
        }
    }
}