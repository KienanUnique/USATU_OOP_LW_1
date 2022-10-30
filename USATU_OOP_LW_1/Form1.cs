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
        private int _countOfTicks = 0;
        private SortedSet<int> _selectedRollsIndexes = new SortedSet<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            labelMousePositionInfo.Text = "Mouse (" + e.X + "; " + e.Y + ")";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            labelMouseClickInfo.Text = "Mouse click (" + e.X + "; " + e.Y + ")";

            var labelOnClick = new Label();
            labelOnClick.Size = new Size(90, 23);
            labelOnClick.Text = "Click";
            labelOnClick.Location = new Point(e.X - labelOnClick.Size.Width / 2, e.Y - labelOnClick.Size.Height / 2);
            labelOnClick.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(labelOnClick);
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
            _countOfTicks++;
            labelCountOfTicks.Text = "Count of ticks: " + _countOfTicks;
        }

        private void linkLabelRickRoll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
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
    }
}