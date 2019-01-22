namespace GoLWF
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerPlayer = new System.Windows.Forms.Timer(this.components);
            this.buttonStop = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChaos = new System.Windows.Forms.Button();
            this.groupBoxSimulation = new System.Windows.Forms.GroupBox();
            this.buttonStep = new System.Windows.Forms.Button();
            this.groupBoxGenesis = new System.Windows.Forms.GroupBox();
            this.labelMoreChaos = new System.Windows.Forms.Label();
            this.labelLessChaos = new System.Windows.Forms.Label();
            this.trackBarChaos = new System.Windows.Forms.TrackBar();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.labelVary = new System.Windows.Forms.Label();
            this.labelPopulation = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.timerInfo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.groupBoxSimulation.SuspendLayout();
            this.groupBoxGenesis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChaos)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 792);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(6, 30);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(160, 60);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerPlayer
            // 
            this.timerPlayer.Tick += new System.EventHandler(this.timerPlayer_Tick);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(6, 163);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(160, 60);
            this.buttonStop.TabIndex = 3;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.trackBarSpeed.LargeChange = 1;
            this.trackBarSpeed.Location = new System.Drawing.Point(6, 229);
            this.trackBarSpeed.Maximum = 2;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(160, 90);
            this.trackBarSpeed.TabIndex = 4;
            this.trackBarSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarSpeed.Value = 1;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Slow";
            // 
            // buttonChaos
            // 
            this.buttonChaos.Location = new System.Drawing.Point(6, 30);
            this.buttonChaos.Name = "buttonChaos";
            this.buttonChaos.Size = new System.Drawing.Size(160, 60);
            this.buttonChaos.TabIndex = 7;
            this.buttonChaos.Text = "Chaos";
            this.buttonChaos.UseVisualStyleBackColor = true;
            this.buttonChaos.Click += new System.EventHandler(this.buttonChaos_Click);
            // 
            // groupBoxSimulation
            // 
            this.groupBoxSimulation.Controls.Add(this.buttonStep);
            this.groupBoxSimulation.Controls.Add(this.buttonStart);
            this.groupBoxSimulation.Controls.Add(this.label2);
            this.groupBoxSimulation.Controls.Add(this.buttonStop);
            this.groupBoxSimulation.Controls.Add(this.label1);
            this.groupBoxSimulation.Controls.Add(this.trackBarSpeed);
            this.groupBoxSimulation.Location = new System.Drawing.Point(825, 12);
            this.groupBoxSimulation.Name = "groupBoxSimulation";
            this.groupBoxSimulation.Size = new System.Drawing.Size(172, 334);
            this.groupBoxSimulation.TabIndex = 8;
            this.groupBoxSimulation.TabStop = false;
            this.groupBoxSimulation.Text = "Simulation";
            // 
            // buttonStep
            // 
            this.buttonStep.Location = new System.Drawing.Point(6, 97);
            this.buttonStep.Name = "buttonStep";
            this.buttonStep.Size = new System.Drawing.Size(160, 60);
            this.buttonStep.TabIndex = 4;
            this.buttonStep.Text = "Step";
            this.buttonStep.UseVisualStyleBackColor = true;
            this.buttonStep.Click += new System.EventHandler(this.buttonStep_Click);
            // 
            // groupBoxGenesis
            // 
            this.groupBoxGenesis.Controls.Add(this.labelMoreChaos);
            this.groupBoxGenesis.Controls.Add(this.labelLessChaos);
            this.groupBoxGenesis.Controls.Add(this.trackBarChaos);
            this.groupBoxGenesis.Controls.Add(this.buttonChaos);
            this.groupBoxGenesis.Location = new System.Drawing.Point(825, 352);
            this.groupBoxGenesis.Name = "groupBoxGenesis";
            this.groupBoxGenesis.Size = new System.Drawing.Size(172, 204);
            this.groupBoxGenesis.TabIndex = 9;
            this.groupBoxGenesis.TabStop = false;
            this.groupBoxGenesis.Text = "Genesis";
            // 
            // labelMoreChaos
            // 
            this.labelMoreChaos.AutoSize = true;
            this.labelMoreChaos.Location = new System.Drawing.Point(105, 161);
            this.labelMoreChaos.Name = "labelMoreChaos";
            this.labelMoreChaos.Size = new System.Drawing.Size(61, 25);
            this.labelMoreChaos.TabIndex = 10;
            this.labelMoreChaos.Text = "More";
            // 
            // labelLessChaos
            // 
            this.labelLessChaos.AutoSize = true;
            this.labelLessChaos.Location = new System.Drawing.Point(6, 161);
            this.labelLessChaos.Name = "labelLessChaos";
            this.labelLessChaos.Size = new System.Drawing.Size(58, 25);
            this.labelLessChaos.TabIndex = 9;
            this.labelLessChaos.Text = "Less";
            // 
            // trackBarChaos
            // 
            this.trackBarChaos.Location = new System.Drawing.Point(6, 106);
            this.trackBarChaos.Maximum = 100;
            this.trackBarChaos.Name = "trackBarChaos";
            this.trackBarChaos.Size = new System.Drawing.Size(160, 90);
            this.trackBarChaos.TabIndex = 8;
            this.trackBarChaos.TickFrequency = 10;
            this.trackBarChaos.Value = 42;
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.labelVary);
            this.groupBoxInfo.Controls.Add(this.labelPopulation);
            this.groupBoxInfo.Controls.Add(this.labelAge);
            this.groupBoxInfo.Location = new System.Drawing.Point(825, 563);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(172, 141);
            this.groupBoxInfo.TabIndex = 10;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Universe";
            // 
            // labelVary
            // 
            this.labelVary.AutoSize = true;
            this.labelVary.Location = new System.Drawing.Point(8, 99);
            this.labelVary.Name = "labelVary";
            this.labelVary.Size = new System.Drawing.Size(62, 25);
            this.labelVary.TabIndex = 2;
            this.labelVary.Text = "Vary:";
            // 
            // labelPopulation
            // 
            this.labelPopulation.AutoSize = true;
            this.labelPopulation.Location = new System.Drawing.Point(7, 65);
            this.labelPopulation.Name = "labelPopulation";
            this.labelPopulation.Size = new System.Drawing.Size(66, 25);
            this.labelPopulation.TabIndex = 1;
            this.labelPopulation.Text = "Cells:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(7, 31);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(56, 25);
            this.labelAge.TabIndex = 0;
            this.labelAge.Text = "Age:";
            // 
            // timerInfo
            // 
            this.timerInfo.Tick += new System.EventHandler(this.timerInfo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 820);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxGenesis);
            this.Controls.Add(this.groupBoxSimulation);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOfLifeWF";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.groupBoxSimulation.ResumeLayout(false);
            this.groupBoxSimulation.PerformLayout();
            this.groupBoxGenesis.ResumeLayout(false);
            this.groupBoxGenesis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChaos)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Timer timerPlayer;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChaos;
        private System.Windows.Forms.GroupBox groupBoxSimulation;
        private System.Windows.Forms.GroupBox groupBoxGenesis;
        private System.Windows.Forms.Button buttonStep;
        private System.Windows.Forms.TrackBar trackBarChaos;
        private System.Windows.Forms.Label labelMoreChaos;
        private System.Windows.Forms.Label labelLessChaos;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Timer timerInfo;
        private System.Windows.Forms.Label labelVary;
        private System.Windows.Forms.Label labelPopulation;
    }
}

