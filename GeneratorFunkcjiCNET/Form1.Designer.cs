namespace GeneratorFunkcjiCNET
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.groupBoxEnterValues = new System.Windows.Forms.GroupBox();
            this.labelSignalType = new System.Windows.Forms.Label();
            this.comboBoxSignalType = new System.Windows.Forms.ComboBox();
            this.textBoxLengthSignal = new System.Windows.Forms.TextBox();
            this.labelLengthSignal = new System.Windows.Forms.Label();
            this.labelResolutionPattern = new System.Windows.Forms.Label();
            this.textBoxResolutionPattern = new System.Windows.Forms.TextBox();
            this.saveFileDialogCSV = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.groupBoxEnterValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            this.chartMain.BackColor = System.Drawing.Color.DarkGray;
            this.chartMain.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            this.chartMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chartMain.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DarkDownwardDiagonal;
            this.chartMain.BackImageTransparentColor = System.Drawing.Color.White;
            this.chartMain.BackSecondaryColor = System.Drawing.Color.White;
            this.chartMain.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartMain.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.Center;
            this.chartMain.BorderSkin.BackSecondaryColor = System.Drawing.Color.Lime;
            this.chartMain.BorderSkin.PageColor = System.Drawing.Color.LightSeaGreen;
            chartArea3.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea3);
            this.chartMain.Cursor = System.Windows.Forms.Cursors.Cross;
            this.chartMain.ImeMode = System.Windows.Forms.ImeMode.On;
            legend3.Name = "Legend1";
            this.chartMain.Legends.Add(legend3);
            this.chartMain.Location = new System.Drawing.Point(12, 12);
            this.chartMain.Name = "chartMain";
            this.chartMain.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series3.BorderColor = System.Drawing.Color.Blue;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Punkty";
            this.chartMain.Series.Add(series3);
            this.chartMain.Size = new System.Drawing.Size(534, 368);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chartMain";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonGenerate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(577, 188);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(211, 71);
            this.buttonGenerate.TabIndex = 1;
            this.buttonGenerate.Text = "Generuj Sygnal";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonSinus_Click);
            // 
            // groupBoxEnterValues
            // 
            this.groupBoxEnterValues.Controls.Add(this.labelSignalType);
            this.groupBoxEnterValues.Controls.Add(this.comboBoxSignalType);
            this.groupBoxEnterValues.Controls.Add(this.textBoxLengthSignal);
            this.groupBoxEnterValues.Controls.Add(this.labelLengthSignal);
            this.groupBoxEnterValues.Controls.Add(this.labelResolutionPattern);
            this.groupBoxEnterValues.Controls.Add(this.textBoxResolutionPattern);
            this.groupBoxEnterValues.Location = new System.Drawing.Point(577, 21);
            this.groupBoxEnterValues.Name = "groupBoxEnterValues";
            this.groupBoxEnterValues.Size = new System.Drawing.Size(211, 161);
            this.groupBoxEnterValues.TabIndex = 2;
            this.groupBoxEnterValues.TabStop = false;
            this.groupBoxEnterValues.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelSignalType
            // 
            this.labelSignalType.AutoSize = true;
            this.labelSignalType.Location = new System.Drawing.Point(6, 92);
            this.labelSignalType.Name = "labelSignalType";
            this.labelSignalType.Size = new System.Drawing.Size(81, 13);
            this.labelSignalType.TabIndex = 5;
            this.labelSignalType.Text = "Rodzaj Sygnalu";
            // 
            // comboBoxSignalType
            // 
            this.comboBoxSignalType.DisplayMember = "1";
            this.comboBoxSignalType.FormattingEnabled = true;
            this.comboBoxSignalType.Items.AddRange(new object[] {
            "Sinusoidalny",
            "Cosinusoidalny",
            "Prostokątny",
            "Trójkątny",
            "Pikokształtny",
            "LFM"});
            this.comboBoxSignalType.Location = new System.Drawing.Point(6, 108);
            this.comboBoxSignalType.Name = "comboBoxSignalType";
            this.comboBoxSignalType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSignalType.TabIndex = 4;
            // 
            // textBoxLengthSignal
            // 
            this.textBoxLengthSignal.Location = new System.Drawing.Point(6, 69);
            this.textBoxLengthSignal.Name = "textBoxLengthSignal";
            this.textBoxLengthSignal.Size = new System.Drawing.Size(100, 20);
            this.textBoxLengthSignal.TabIndex = 3;
            // 
            // labelLengthSignal
            // 
            this.labelLengthSignal.AutoSize = true;
            this.labelLengthSignal.Location = new System.Drawing.Point(6, 53);
            this.labelLengthSignal.Name = "labelLengthSignal";
            this.labelLengthSignal.Size = new System.Drawing.Size(166, 13);
            this.labelLengthSignal.TabIndex = 2;
            this.labelLengthSignal.Text = "Długośc sygnalu (liczba okresów)";
            // 
            // labelResolutionPattern
            // 
            this.labelResolutionPattern.AutoSize = true;
            this.labelResolutionPattern.Location = new System.Drawing.Point(6, 14);
            this.labelResolutionPattern.Name = "labelResolutionPattern";
            this.labelResolutionPattern.Size = new System.Drawing.Size(178, 13);
            this.labelResolutionPattern.TabIndex = 1;
            this.labelResolutionPattern.Text = "Rozdzielczość wzorca (ilosc próbek)";
            // 
            // textBoxResolutionPattern
            // 
            this.textBoxResolutionPattern.Location = new System.Drawing.Point(6, 30);
            this.textBoxResolutionPattern.Name = "textBoxResolutionPattern";
            this.textBoxResolutionPattern.Size = new System.Drawing.Size(100, 20);
            this.textBoxResolutionPattern.TabIndex = 0;
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonSaveData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveData.Location = new System.Drawing.Point(577, 309);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(211, 71);
            this.buttonSaveData.TabIndex = 3;
            this.buttonSaveData.Text = "Zapisz do pliku";
            this.buttonSaveData.UseVisualStyleBackColor = false;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.groupBoxEnterValues);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.chartMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generator Funkcji";
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.groupBoxEnterValues.ResumeLayout(false);
            this.groupBoxEnterValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.GroupBox groupBoxEnterValues;
        private System.Windows.Forms.Label labelLengthSignal;
        private System.Windows.Forms.Label labelResolutionPattern;
        private System.Windows.Forms.TextBox textBoxResolutionPattern;
        private System.Windows.Forms.TextBox textBoxLengthSignal;
        private System.Windows.Forms.ComboBox comboBoxSignalType;
        private System.Windows.Forms.Label labelSignalType;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCSV;
        private System.Windows.Forms.Button buttonSaveData;
    }
}

