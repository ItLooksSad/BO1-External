namespace Black_Ops_1_external
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            fovScaleTextbox = new TextBox();
            fovScaleToggle = new Button();
            fovScaleTimer = new System.Windows.Forms.Timer(components);
            gameStatusLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            fovToggle = new Button();
            fovVal = new TextBox();
            fovTimer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            UAVtoggle = new Button();
            UAVVal = new TextBox();
            label4 = new Label();
            UAVTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // fovScaleTextbox
            // 
            fovScaleTextbox.Location = new Point(12, 27);
            fovScaleTextbox.Name = "fovScaleTextbox";
            fovScaleTextbox.Size = new Size(128, 23);
            fovScaleTextbox.TabIndex = 0;
            fovScaleTextbox.Text = "1.25";
            // 
            // fovScaleToggle
            // 
            fovScaleToggle.Location = new Point(146, 27);
            fovScaleToggle.Name = "fovScaleToggle";
            fovScaleToggle.Size = new Size(44, 23);
            fovScaleToggle.TabIndex = 1;
            fovScaleToggle.Text = "Off";
            fovScaleToggle.UseVisualStyleBackColor = true;
            fovScaleToggle.Click += fovScaleToggle_Click;
            // 
            // fovScaleTimer
            // 
            fovScaleTimer.Tick += fovScaleTimer_Tick;
            // 
            // gameStatusLabel
            // 
            gameStatusLabel.AutoSize = true;
            gameStatusLabel.Location = new Point(27, 141);
            gameStatusLabel.Name = "gameStatusLabel";
            gameStatusLabel.Size = new Size(61, 15);
            gameStatusLabel.TabIndex = 2;
            gameStatusLabel.Text = "NotFound";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 3;
            label1.Text = "FovScale";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 6;
            label2.Text = "Fov";
            // 
            // fovToggle
            // 
            fovToggle.Location = new Point(146, 71);
            fovToggle.Name = "fovToggle";
            fovToggle.Size = new Size(44, 23);
            fovToggle.TabIndex = 5;
            fovToggle.Text = "Off";
            fovToggle.UseVisualStyleBackColor = true;
            fovToggle.Click += fovToggle_Click;
            // 
            // fovVal
            // 
            fovVal.Location = new Point(12, 71);
            fovVal.Name = "fovVal";
            fovVal.Size = new Size(128, 23);
            fovVal.TabIndex = 4;
            fovVal.Text = "80";
            // 
            // fovTimer
            // 
            fovTimer.Tick += fovTimer_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 9;
            label3.Text = "UAV Sweep";
            // 
            // UAVtoggle
            // 
            UAVtoggle.Location = new Point(146, 115);
            UAVtoggle.Name = "UAVtoggle";
            UAVtoggle.Size = new Size(44, 23);
            UAVtoggle.TabIndex = 8;
            UAVtoggle.Text = "Off";
            UAVtoggle.UseVisualStyleBackColor = true;
            UAVtoggle.Click += UAVtoggle_Click;
            // 
            // UAVVal
            // 
            UAVVal.Location = new Point(12, 115);
            UAVVal.Name = "UAVVal";
            UAVVal.Size = new Size(128, 23);
            UAVVal.TabIndex = 7;
            UAVVal.Text = "2.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 163);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 10;
            label4.Text = "By Seppuku404";
            // 
            // UAVTimer
            // 
            UAVTimer.Tick += UAVTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 187);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(UAVtoggle);
            Controls.Add(UAVVal);
            Controls.Add(label2);
            Controls.Add(fovToggle);
            Controls.Add(fovVal);
            Controls.Add(label1);
            Controls.Add(gameStatusLabel);
            Controls.Add(fovScaleToggle);
            Controls.Add(fovScaleTextbox);
            Name = "Form1";
            Text = "BO1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fovScaleTextbox;
        private Button fovScaleToggle;
        private System.Windows.Forms.Timer fovScaleTimer;
        private Label gameStatusLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Button fovToggle;
        private TextBox fovVal;
        private System.Windows.Forms.Timer fovTimer;
        private Label label3;
        private Button UAVtoggle;
        private TextBox UAVVal;
        private Label label4;
        private System.Windows.Forms.Timer UAVTimer;
    }
}