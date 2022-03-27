namespace FallFromHeightCalculator
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
            this.groupBoxInputs = new System.Windows.Forms.GroupBox();
            this.labelKilograms = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelMetres = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBoxInputHeight = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.groupBoxUnits = new System.Windows.Forms.GroupBox();
            this.radioButtonKMH = new System.Windows.Forms.RadioButton();
            this.radioButtonMPS = new System.Windows.Forms.RadioButton();
            this.labelNewtons = new System.Windows.Forms.Label();
            this.labelImpactForce = new System.Windows.Forms.Label();
            this.textBoxImpactForce = new System.Windows.Forms.TextBox();
            this.labelImpactVelocity = new System.Windows.Forms.Label();
            this.textBoxImpactVelocity = new System.Windows.Forms.TextBox();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.labelFallTime = new System.Windows.Forms.Label();
            this.textBoxOutputFallTime = new System.Windows.Forms.TextBox();
            this.groupBoxGravitySettings = new System.Windows.Forms.GroupBox();
            this.radioButtonMars = new System.Windows.Forms.RadioButton();
            this.radioButtonMoon = new System.Windows.Forms.RadioButton();
            this.radioButtonEarth = new System.Windows.Forms.RadioButton();
            this.groupBoxInputs.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxUnits.SuspendLayout();
            this.groupBoxGravitySettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInputs
            // 
            this.groupBoxInputs.Controls.Add(this.labelKilograms);
            this.groupBoxInputs.Controls.Add(this.labelWeight);
            this.groupBoxInputs.Controls.Add(this.textBoxWeight);
            this.groupBoxInputs.Controls.Add(this.labelMetres);
            this.groupBoxInputs.Controls.Add(this.labelHeight);
            this.groupBoxInputs.Controls.Add(this.buttonCalculate);
            this.groupBoxInputs.Controls.Add(this.textBoxInputHeight);
            this.groupBoxInputs.Location = new System.Drawing.Point(335, 33);
            this.groupBoxInputs.Name = "groupBoxInputs";
            this.groupBoxInputs.Size = new System.Drawing.Size(562, 247);
            this.groupBoxInputs.TabIndex = 0;
            this.groupBoxInputs.TabStop = false;
            this.groupBoxInputs.Text = "Input:";
            // 
            // labelKilograms
            // 
            this.labelKilograms.AutoSize = true;
            this.labelKilograms.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKilograms.Location = new System.Drawing.Point(394, 109);
            this.labelKilograms.Name = "labelKilograms";
            this.labelKilograms.Size = new System.Drawing.Size(70, 25);
            this.labelKilograms.TabIndex = 6;
            this.labelKilograms.Text = "[ kgs ]";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(112, 103);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(113, 31);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Weight: ";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeight.Location = new System.Drawing.Point(231, 100);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(157, 38);
            this.textBoxWeight.TabIndex = 4;
            this.textBoxWeight.Text = "0";
            this.textBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMetres
            // 
            this.labelMetres.AutoSize = true;
            this.labelMetres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetres.Location = new System.Drawing.Point(394, 45);
            this.labelMetres.Name = "labelMetres";
            this.labelMetres.Size = new System.Drawing.Size(101, 25);
            this.labelMetres.TabIndex = 3;
            this.labelMetres.Text = "[ metres ]";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(117, 39);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(108, 31);
            this.labelHeight.TabIndex = 2;
            this.labelHeight.Text = "Height: ";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(345, 168);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(150, 50);
            this.buttonCalculate.TabIndex = 1;
            this.buttonCalculate.Text = "&Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBoxInputHeight
            // 
            this.textBoxInputHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputHeight.Location = new System.Drawing.Point(231, 36);
            this.textBoxInputHeight.Name = "textBoxInputHeight";
            this.textBoxInputHeight.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInputHeight.Size = new System.Drawing.Size(157, 38);
            this.textBoxInputHeight.TabIndex = 0;
            this.textBoxInputHeight.Text = "0";
            this.textBoxInputHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.groupBoxUnits);
            this.groupBoxOutput.Controls.Add(this.labelNewtons);
            this.groupBoxOutput.Controls.Add(this.labelImpactForce);
            this.groupBoxOutput.Controls.Add(this.textBoxImpactForce);
            this.groupBoxOutput.Controls.Add(this.labelImpactVelocity);
            this.groupBoxOutput.Controls.Add(this.textBoxImpactVelocity);
            this.groupBoxOutput.Controls.Add(this.labelSeconds);
            this.groupBoxOutput.Controls.Add(this.labelFallTime);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputFallTime);
            this.groupBoxOutput.Location = new System.Drawing.Point(335, 306);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(562, 247);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output:";
            // 
            // groupBoxUnits
            // 
            this.groupBoxUnits.Controls.Add(this.radioButtonKMH);
            this.groupBoxUnits.Controls.Add(this.radioButtonMPS);
            this.groupBoxUnits.Location = new System.Drawing.Point(399, 83);
            this.groupBoxUnits.Name = "groupBoxUnits";
            this.groupBoxUnits.Size = new System.Drawing.Size(150, 59);
            this.groupBoxUnits.TabIndex = 3;
            this.groupBoxUnits.TabStop = false;
            this.groupBoxUnits.Text = "Units:";
            // 
            // radioButtonKMH
            // 
            this.radioButtonKMH.AutoSize = true;
            this.radioButtonKMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonKMH.Location = new System.Drawing.Point(78, 23);
            this.radioButtonKMH.Name = "radioButtonKMH";
            this.radioButtonKMH.Size = new System.Drawing.Size(67, 22);
            this.radioButtonKMH.TabIndex = 1;
            this.radioButtonKMH.TabStop = true;
            this.radioButtonKMH.Text = "km / h";
            this.radioButtonKMH.UseVisualStyleBackColor = true;
            this.radioButtonKMH.CheckedChanged += new System.EventHandler(this.OnUnitsRadioButtonChanged);
            // 
            // radioButtonMPS
            // 
            this.radioButtonMPS.AutoSize = true;
            this.radioButtonMPS.Checked = true;
            this.radioButtonMPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMPS.Location = new System.Drawing.Point(8, 23);
            this.radioButtonMPS.Name = "radioButtonMPS";
            this.radioButtonMPS.Size = new System.Drawing.Size(59, 22);
            this.radioButtonMPS.TabIndex = 0;
            this.radioButtonMPS.TabStop = true;
            this.radioButtonMPS.Text = "m / s";
            this.radioButtonMPS.UseVisualStyleBackColor = true;
            this.radioButtonMPS.CheckedChanged += new System.EventHandler(this.OnUnitsRadioButtonChanged);
            // 
            // labelNewtons
            // 
            this.labelNewtons.AutoSize = true;
            this.labelNewtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewtons.Location = new System.Drawing.Point(394, 163);
            this.labelNewtons.Name = "labelNewtons";
            this.labelNewtons.Size = new System.Drawing.Size(119, 25);
            this.labelNewtons.TabIndex = 13;
            this.labelNewtons.Text = "[ Newtons ]";
            // 
            // labelImpactForce
            // 
            this.labelImpactForce.AutoSize = true;
            this.labelImpactForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImpactForce.Location = new System.Drawing.Point(44, 157);
            this.labelImpactForce.Name = "labelImpactForce";
            this.labelImpactForce.Size = new System.Drawing.Size(181, 31);
            this.labelImpactForce.TabIndex = 12;
            this.labelImpactForce.Text = "Impact Force:";
            // 
            // textBoxImpactForce
            // 
            this.textBoxImpactForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImpactForce.Location = new System.Drawing.Point(231, 154);
            this.textBoxImpactForce.Name = "textBoxImpactForce";
            this.textBoxImpactForce.ReadOnly = true;
            this.textBoxImpactForce.Size = new System.Drawing.Size(157, 38);
            this.textBoxImpactForce.TabIndex = 11;
            this.textBoxImpactForce.Text = "0";
            this.textBoxImpactForce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelImpactVelocity
            // 
            this.labelImpactVelocity.AutoSize = true;
            this.labelImpactVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImpactVelocity.Location = new System.Drawing.Point(18, 97);
            this.labelImpactVelocity.Name = "labelImpactVelocity";
            this.labelImpactVelocity.Size = new System.Drawing.Size(207, 31);
            this.labelImpactVelocity.TabIndex = 9;
            this.labelImpactVelocity.Text = "Impact Velocity:";
            // 
            // textBoxImpactVelocity
            // 
            this.textBoxImpactVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImpactVelocity.Location = new System.Drawing.Point(231, 94);
            this.textBoxImpactVelocity.Name = "textBoxImpactVelocity";
            this.textBoxImpactVelocity.ReadOnly = true;
            this.textBoxImpactVelocity.Size = new System.Drawing.Size(157, 38);
            this.textBoxImpactVelocity.TabIndex = 8;
            this.textBoxImpactVelocity.Text = "0";
            this.textBoxImpactVelocity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeconds.Location = new System.Drawing.Point(394, 43);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(117, 25);
            this.labelSeconds.TabIndex = 7;
            this.labelSeconds.Text = "[ seconds ]";
            // 
            // labelFallTime
            // 
            this.labelFallTime.AutoSize = true;
            this.labelFallTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFallTime.Location = new System.Drawing.Point(92, 37);
            this.labelFallTime.Name = "labelFallTime";
            this.labelFallTime.Size = new System.Drawing.Size(133, 31);
            this.labelFallTime.TabIndex = 6;
            this.labelFallTime.Text = "Fall Time:";
            // 
            // textBoxOutputFallTime
            // 
            this.textBoxOutputFallTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutputFallTime.Location = new System.Drawing.Point(231, 34);
            this.textBoxOutputFallTime.Name = "textBoxOutputFallTime";
            this.textBoxOutputFallTime.ReadOnly = true;
            this.textBoxOutputFallTime.Size = new System.Drawing.Size(157, 38);
            this.textBoxOutputFallTime.TabIndex = 1;
            this.textBoxOutputFallTime.Text = "0";
            this.textBoxOutputFallTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBoxGravitySettings
            // 
            this.groupBoxGravitySettings.Controls.Add(this.radioButtonMars);
            this.groupBoxGravitySettings.Controls.Add(this.radioButtonMoon);
            this.groupBoxGravitySettings.Controls.Add(this.radioButtonEarth);
            this.groupBoxGravitySettings.Location = new System.Drawing.Point(35, 33);
            this.groupBoxGravitySettings.Name = "groupBoxGravitySettings";
            this.groupBoxGravitySettings.Size = new System.Drawing.Size(200, 520);
            this.groupBoxGravitySettings.TabIndex = 2;
            this.groupBoxGravitySettings.TabStop = false;
            this.groupBoxGravitySettings.Text = "Gravity Options:";
            // 
            // radioButtonMars
            // 
            this.radioButtonMars.AutoSize = true;
            this.radioButtonMars.Location = new System.Drawing.Point(36, 143);
            this.radioButtonMars.Name = "radioButtonMars";
            this.radioButtonMars.Size = new System.Drawing.Size(121, 17);
            this.radioButtonMars.TabIndex = 2;
            this.radioButtonMars.Text = "Mars ( 3.711 m/s/s )";
            this.radioButtonMars.UseVisualStyleBackColor = true;
            this.radioButtonMars.CheckedChanged += new System.EventHandler(this.OnGravityRadioButtonChanged);
            // 
            // radioButtonMoon
            // 
            this.radioButtonMoon.AutoSize = true;
            this.radioButtonMoon.Location = new System.Drawing.Point(36, 100);
            this.radioButtonMoon.Name = "radioButtonMoon";
            this.radioButtonMoon.Size = new System.Drawing.Size(119, 17);
            this.radioButtonMoon.TabIndex = 1;
            this.radioButtonMoon.Text = "Moon ( 1.62 m/s/s )";
            this.radioButtonMoon.UseVisualStyleBackColor = true;
            this.radioButtonMoon.CheckedChanged += new System.EventHandler(this.OnGravityRadioButtonChanged);
            // 
            // radioButtonEarth
            // 
            this.radioButtonEarth.AutoSize = true;
            this.radioButtonEarth.Checked = true;
            this.radioButtonEarth.Location = new System.Drawing.Point(36, 57);
            this.radioButtonEarth.Name = "radioButtonEarth";
            this.radioButtonEarth.Size = new System.Drawing.Size(117, 17);
            this.radioButtonEarth.TabIndex = 0;
            this.radioButtonEarth.TabStop = true;
            this.radioButtonEarth.Text = "Earth ( 9.81 m/s/s )";
            this.radioButtonEarth.UseVisualStyleBackColor = true;
            this.radioButtonEarth.CheckedChanged += new System.EventHandler(this.OnGravityRadioButtonChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 650);
            this.Controls.Add(this.groupBoxGravitySettings);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.groupBoxInputs);
            this.Name = "Form1";
            this.Text = "Fall From Height - Calculator";
            this.groupBoxInputs.ResumeLayout(false);
            this.groupBoxInputs.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.groupBoxUnits.ResumeLayout(false);
            this.groupBoxUnits.PerformLayout();
            this.groupBoxGravitySettings.ResumeLayout(false);
            this.groupBoxGravitySettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInputs;
        private System.Windows.Forms.TextBox textBoxInputHeight;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxOutputFallTime;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelMetres;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelKilograms;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelImpactVelocity;
        private System.Windows.Forms.TextBox textBoxImpactVelocity;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.Label labelFallTime;
        private System.Windows.Forms.GroupBox groupBoxGravitySettings;
        private System.Windows.Forms.RadioButton radioButtonMoon;
        private System.Windows.Forms.RadioButton radioButtonEarth;
        private System.Windows.Forms.RadioButton radioButtonMars;
        private System.Windows.Forms.Label labelNewtons;
        private System.Windows.Forms.Label labelImpactForce;
        private System.Windows.Forms.TextBox textBoxImpactForce;
        private System.Windows.Forms.GroupBox groupBoxUnits;
        private System.Windows.Forms.RadioButton radioButtonKMH;
        private System.Windows.Forms.RadioButton radioButtonMPS;
    }
}

