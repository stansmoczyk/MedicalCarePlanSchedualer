using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCarePlanSchedualer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Close program when close button is clicked 
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FirstFeedDisplayLabel.Text = " ";
            SecondFeedDisplayLabel.Text = " ";
            ThirdFeedDisplayLabel.Text = " ";
            FourthFeedDisplayLabel.Text = " ";
            FirstExerciseDisplayLabel.Text = " ";
            SecondExerciseDisplayLabel.Text = " ";
            ArtDisplayLabel.Text = " ";
            MusicDisplayLabel.Text = " ";
            GameDisplayLabel.Text = " ";
            TVDisplayLabel.Text = " ";
            FirstMedicationDisplayLabel.Text = " ";
            SecondMedicationDisplayLabel.Text = " ";
            TimePicker.ResetText();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            DateTime TimeStamp = TimePicker.Value;
            FirstFeedDisplayLabel.Text = Convert.ToString(TimeStamp.ToShortTimeString());
            SecondFeedDisplayLabel.Text = Convert.ToString(TimeStamp.AddHours(3).ToShortTimeString());
            ThirdFeedDisplayLabel.Text = Convert.ToString(TimeStamp.AddHours(6).ToShortTimeString());
            FourthFeedDisplayLabel.Text = Convert.ToString(TimeStamp.AddHours(9).ToShortTimeString());
            FirstExerciseDisplayLabel.Text = Convert.ToString(TimeStamp.AddHours(1.5).ToShortTimeString());
            SecondExerciseDisplayLabel.Text = Convert.ToString(TimeStamp.AddHours(7.5 ).ToShortTimeString());
            ArtDisplayLabel.Text = Convert.ToString(TimeStamp.AddHours(0.5).ToShortTimeString());
            MusicDisplayLabel.Text = Convert.ToString(TimeStamp.AddHours(3.5).ToShortTimeString());
            GameDisplayLabel.Text = Convert.ToString(TimeStamp.AddHours(4.5).ToShortTimeString());
            TVDisplayLabel.Text = Convert.ToString(TimeStamp.AddHours(6.5).ToShortTimeString());
            FirstMedicationDisplayLabel.Text = Convert.ToString(TimeStamp.AddHours(0.5).ToShortTimeString());
            SecondMedicationDisplayLabel.Text = Convert.ToString(TimeStamp.AddHours(9.5).ToShortTimeString());
        }
    }
}
