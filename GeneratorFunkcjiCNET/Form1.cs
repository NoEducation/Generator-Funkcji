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

            foreach(var point in currentSignal.SignalValues)
            {
                chartMain.Series["Punkty"].Points.AddY(point);
            }
        }

        private void buttonSinus_Click(object sender, EventArgs e)
        {
            UpdateValues();
            switch (currentSignal.TypeSignal)
            {
                case TypeSignal.SINUS: SignalGenerator.GeneratingSignalSinus(currentSignal);
                    chartMain.Titles.Clear();
                    chartMain.Titles.Add("Sinus");
                    break;
                case TypeSignal.COSINUS: SignalGenerator.GeneratingSignalCosinus(currentSignal);
                    chartMain.Titles.Clear();
                    chartMain.Titles.Add("Cosinus");
                    break;
                case TypeSignal.RECTANGLE: SignalGenerator.GeneratingSignalRectangle(currentSignal);
                    chartMain.Titles.Clear();
                    chartMain.Titles.Add("Sygnał trójkątny");
                    break;
                case TypeSignal.TRIANGLE: SignalGenerator.GeneratingSignalTriangle(currentSignal);
                    chartMain.Titles.Clear();
                    chartMain.Titles.Add("Sygnał kwadratowy");
                    break;
                case TypeSignal.SAWTOOTH: SignalGenerator.GeneratingSignalSawtooth(currentSignal);
                    chartMain.Titles.Clear();
                    chartMain.Titles.Add("Sygnał pikokształtny");
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
    }
}
