using GeneratorFunkcjiCNET.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GeneratorFunkcjiCNET
{
    public partial class Form1 : Form
    {
        Signal currentSignal = new Signal();
        public Form1()
        {
            InitializeComponent();


            comboBoxSignalType.SelectedIndex = 0;
            textBoxLengthSignal.Text = "1";
            textBoxResolutionPattern.Text = "8192";
            SignalGenerator.GeneratingSignalSinus(currentSignal);
            UpdateChart();
            chartMain.Titles.Clear();
            chartMain.Titles.Add("Sinus");
        }

        public void UpdateChart()
        {
            chartMain.Series["Punkty"].Points.Clear();
            
            if(currentSignal.TypeSignal == TypeSignal.LFM)
               for(int i =0;i< currentSignal.ResolutionPattern / Signal._resolutionPatternLFM; i++)
                   chartMain.Series["Punkty"].Points.AddY(currentSignal.SignalValues[i]);
             else
                foreach (var point in currentSignal.SignalValues)
                    chartMain.Series["Punkty"].Points.AddY(point);
               

        }

        private void buttonSinus_Click(object sender, EventArgs e)
        {
            UpdateValues();
            switch (currentSignal.TypeSignal)
            {
                case TypeSignal.SINUS: SignalGenerator.GeneratingSignalSinus(currentSignal);
                    chartMain.Titles.Clear();
                    chartMain.Titles.Add("Sygnał sinusoidalny");
                    break;
                case TypeSignal.COSINUS: SignalGenerator.GeneratingSignalCosinus(currentSignal);
                    chartMain.Titles.Clear();
                    chartMain.Titles.Add("Sygnał cosinusoidalny");
                    break;
                case TypeSignal.RECTANGLE: SignalGenerator.GeneratingSignalRectangle(currentSignal);
                    chartMain.Titles.Clear();
                    chartMain.Titles.Add("Sygnał trójkątny");
                    break;
                case TypeSignal.TRIANGLE: SignalGenerator.GeneratingSignalTriangle(currentSignal);
                    chartMain.Titles.Clear();
                    chartMain.Titles.Add("Sygnał prostokątny");
                    break;
                case TypeSignal.SAWTOOTH: SignalGenerator.GeneratingSignalSawtooth(currentSignal);
                    chartMain.Titles.Clear();
                    chartMain.Titles.Add("Sygnał pikokształtny");
                    break;
                case TypeSignal.LFM:
                    SignalGenerator.GeneratingSignalLFM(currentSignal);
                    chartMain.Titles.Clear();
                    chartMain.Titles.Add("Sygnał LFM");
                    break;

            }
            UpdateChart();
        }
        private void UpdateValues()
        {

            try
            {   
                currentSignal.TypeSignal = (TypeSignal)comboBoxSignalType.SelectedIndex;
                currentSignal.LenghtSignal = int.Parse(textBoxLengthSignal.Text);
                currentSignal.ResolutionPattern = int.Parse(textBoxResolutionPattern.Text);
                if(currentSignal.ResolutionPattern <= 0)
                {
                    MessageBox.Show("Podałeś błędne wartości dla ilości próbek, ustawiam domyślne", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxResolutionPattern.Text = "8192";
                    currentSignal.ResolutionPattern = 8192;
                }
                
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Podałeś błędne wartości, ustawiam domyślne", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                comboBoxSignalType.SelectedIndex = 0;
                textBoxLengthSignal.Text = "1";
                textBoxResolutionPattern.Text = "8192";
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            var csv = new StringBuilder();
            if(currentSignal.TypeSignal == TypeSignal.LFM)
                for(int i=0;i < currentSignal.ResolutionPattern/ Signal._resolutionPatternLFM; i++)
                    csv.AppendLine(currentSignal.SignalValues[i].ToString());
            else
                foreach(var point in currentSignal.SignalValues)
                    csv.AppendLine(point.ToString());
           


            saveFileDialogCSV.Filter = "CSV file(*.csv) | *.csv | All files(*.*) | *.* ";
            DialogResult response = saveFileDialogCSV.ShowDialog();
            if (response == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogCSV.FileName, csv.ToString());
                MessageBox.Show($"Zapisano wartości sygnału do pliku",
                    "Zapisano Plik", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBoxSignalType_DropDownClosed(object sender, EventArgs e)
        {
            if ((TypeSignal)comboBoxSignalType.SelectedIndex == TypeSignal.LFM)
            {
                textBoxLengthSignal.Enabled = false;
                textBoxLengthSignal.Text = "1";
            }
            else
                textBoxLengthSignal.Enabled = true;
        }
    }
}
