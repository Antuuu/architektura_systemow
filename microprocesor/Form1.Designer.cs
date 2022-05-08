namespace microprocesor
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AX = new System.Windows.Forms.Label();
            this.AX_TEXT = new System.Windows.Forms.TextBox();
            this.BX = new System.Windows.Forms.Label();
            this.BX_TEXT = new System.Windows.Forms.TextBox();
            this.CX = new System.Windows.Forms.Label();
            this.CX_TEXT = new System.Windows.Forms.TextBox();
            this.DX = new System.Windows.Forms.Label();
            this.DX_TEXT = new System.Windows.Forms.TextBox();
            this.INPUT_AX = new System.Windows.Forms.Button();
            this.INPUT_BX = new System.Windows.Forms.Button();
            this.INPUT_CX = new System.Windows.Forms.Button();
            this.INPUT_DX = new System.Windows.Forms.Button();
            this.BX_TO_AX = new System.Windows.Forms.Button();
            this.CX_TO_AX = new System.Windows.Forms.Button();
            this.DX_TO_AX = new System.Windows.Forms.Button();
            this.DX_TO_BX = new System.Windows.Forms.Button();
            this.CX_TO_BX = new System.Windows.Forms.Button();
            this.AX_TO_BX = new System.Windows.Forms.Button();
            this.DX_TO_CX = new System.Windows.Forms.Button();
            this.BX_TO_CX = new System.Windows.Forms.Button();
            this.AX_TO_CX = new System.Windows.Forms.Button();
            this.CX_TO_DX = new System.Windows.Forms.Button();
            this.BX_TO_DX = new System.Windows.Forms.Button();
            this.AX_TO_DX = new System.Windows.Forms.Button();
            this.RANDOM_INPUT = new System.Windows.Forms.Button();
            this.RANDOM_REGISTRIES = new System.Windows.Forms.Button();
            this.RESET = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.inputText.Location = new System.Drawing.Point(54, 28);
            this.inputText.MaxLength = 4;
            this.inputText.Name = "inputText";
            this.inputText.PlaceholderText = "0000";
            this.inputText.Size = new System.Drawing.Size(129, 23);
            this.inputText.TabIndex = 0;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "INPUT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AX
            // 
            this.AX.AutoSize = true;
            this.AX.Location = new System.Drawing.Point(26, 151);
            this.AX.Name = "AX";
            this.AX.Size = new System.Drawing.Size(22, 15);
            this.AX.TabIndex = 3;
            this.AX.Text = "AX";
            // 
            // AX_TEXT
            // 
            this.AX_TEXT.Enabled = false;
            this.AX_TEXT.Location = new System.Drawing.Point(54, 148);
            this.AX_TEXT.Name = "AX_TEXT";
            this.AX_TEXT.Size = new System.Drawing.Size(129, 23);
            this.AX_TEXT.TabIndex = 2;
            this.AX_TEXT.TextChanged += new System.EventHandler(this.AX_TEXT_TextChanged);
            // 
            // BX
            // 
            this.BX.AutoSize = true;
            this.BX.Location = new System.Drawing.Point(26, 180);
            this.BX.Name = "BX";
            this.BX.Size = new System.Drawing.Size(21, 15);
            this.BX.TabIndex = 5;
            this.BX.Text = "BX";
            this.BX.Click += new System.EventHandler(this.label2_Click);
            // 
            // BX_TEXT
            // 
            this.BX_TEXT.Enabled = false;
            this.BX_TEXT.Location = new System.Drawing.Point(54, 177);
            this.BX_TEXT.Name = "BX_TEXT";
            this.BX_TEXT.Size = new System.Drawing.Size(129, 23);
            this.BX_TEXT.TabIndex = 4;
            this.BX_TEXT.TextChanged += new System.EventHandler(this.BX_TEXT_TextChanged);
            // 
            // CX
            // 
            this.CX.AutoSize = true;
            this.CX.Location = new System.Drawing.Point(26, 209);
            this.CX.Name = "CX";
            this.CX.Size = new System.Drawing.Size(22, 15);
            this.CX.TabIndex = 7;
            this.CX.Text = "CX";
            // 
            // CX_TEXT
            // 
            this.CX_TEXT.Enabled = false;
            this.CX_TEXT.Location = new System.Drawing.Point(54, 206);
            this.CX_TEXT.Name = "CX_TEXT";
            this.CX_TEXT.Size = new System.Drawing.Size(129, 23);
            this.CX_TEXT.TabIndex = 6;
            this.CX_TEXT.TextChanged += new System.EventHandler(this.CX_TEXT_TextChanged);
            // 
            // DX
            // 
            this.DX.AutoSize = true;
            this.DX.Location = new System.Drawing.Point(26, 238);
            this.DX.Name = "DX";
            this.DX.Size = new System.Drawing.Size(22, 15);
            this.DX.TabIndex = 9;
            this.DX.Text = "DX";
            // 
            // DX_TEXT
            // 
            this.DX_TEXT.Enabled = false;
            this.DX_TEXT.Location = new System.Drawing.Point(54, 235);
            this.DX_TEXT.Name = "DX_TEXT";
            this.DX_TEXT.Size = new System.Drawing.Size(129, 23);
            this.DX_TEXT.TabIndex = 8;
            this.DX_TEXT.TextChanged += new System.EventHandler(this.DX_TEXT_TextChanged);
            // 
            // INPUT_AX
            // 
            this.INPUT_AX.Location = new System.Drawing.Point(215, 28);
            this.INPUT_AX.Name = "INPUT_AX";
            this.INPUT_AX.Size = new System.Drawing.Size(83, 23);
            this.INPUT_AX.TabIndex = 10;
            this.INPUT_AX.Text = "INPUT TO AX";
            this.INPUT_AX.UseVisualStyleBackColor = true;
            this.INPUT_AX.Click += new System.EventHandler(this.INPUT_AX_Click);
            // 
            // INPUT_BX
            // 
            this.INPUT_BX.Location = new System.Drawing.Point(313, 28);
            this.INPUT_BX.Name = "INPUT_BX";
            this.INPUT_BX.Size = new System.Drawing.Size(83, 23);
            this.INPUT_BX.TabIndex = 11;
            this.INPUT_BX.Text = "INPUT TO BX";
            this.INPUT_BX.UseVisualStyleBackColor = true;
            this.INPUT_BX.UseWaitCursor = true;
            this.INPUT_BX.Click += new System.EventHandler(this.INPUT_BX_Click);
            // 
            // INPUT_CX
            // 
            this.INPUT_CX.Location = new System.Drawing.Point(412, 28);
            this.INPUT_CX.Name = "INPUT_CX";
            this.INPUT_CX.Size = new System.Drawing.Size(83, 23);
            this.INPUT_CX.TabIndex = 12;
            this.INPUT_CX.Text = "INPUT TO CX";
            this.INPUT_CX.UseVisualStyleBackColor = true;
            this.INPUT_CX.UseWaitCursor = true;
            this.INPUT_CX.Click += new System.EventHandler(this.INPUT_CX_Click);
            // 
            // INPUT_DX
            // 
            this.INPUT_DX.Location = new System.Drawing.Point(511, 28);
            this.INPUT_DX.Name = "INPUT_DX";
            this.INPUT_DX.Size = new System.Drawing.Size(83, 23);
            this.INPUT_DX.TabIndex = 13;
            this.INPUT_DX.Text = "INPUT TO DX";
            this.INPUT_DX.UseVisualStyleBackColor = true;
            this.INPUT_DX.UseWaitCursor = true;
            this.INPUT_DX.Click += new System.EventHandler(this.INPUT_DX_Click);
            // 
            // BX_TO_AX
            // 
            this.BX_TO_AX.Location = new System.Drawing.Point(215, 57);
            this.BX_TO_AX.Name = "BX_TO_AX";
            this.BX_TO_AX.Size = new System.Drawing.Size(83, 23);
            this.BX_TO_AX.TabIndex = 14;
            this.BX_TO_AX.Text = "BX TO AX";
            this.BX_TO_AX.UseVisualStyleBackColor = true;
            this.BX_TO_AX.UseWaitCursor = true;
            this.BX_TO_AX.Click += new System.EventHandler(this.BX_TO_AX_Click);
            // 
            // CX_TO_AX
            // 
            this.CX_TO_AX.Location = new System.Drawing.Point(215, 86);
            this.CX_TO_AX.Name = "CX_TO_AX";
            this.CX_TO_AX.Size = new System.Drawing.Size(83, 23);
            this.CX_TO_AX.TabIndex = 15;
            this.CX_TO_AX.Text = "CX TO AX";
            this.CX_TO_AX.UseVisualStyleBackColor = true;
            this.CX_TO_AX.UseWaitCursor = true;
            this.CX_TO_AX.Click += new System.EventHandler(this.CX_TO_AX_Click);
            // 
            // DX_TO_AX
            // 
            this.DX_TO_AX.Location = new System.Drawing.Point(215, 115);
            this.DX_TO_AX.Name = "DX_TO_AX";
            this.DX_TO_AX.Size = new System.Drawing.Size(83, 23);
            this.DX_TO_AX.TabIndex = 16;
            this.DX_TO_AX.Text = "DX TO AX";
            this.DX_TO_AX.UseVisualStyleBackColor = true;
            this.DX_TO_AX.UseWaitCursor = true;
            this.DX_TO_AX.Click += new System.EventHandler(this.DX_TO_AX_Click);
            // 
            // DX_TO_BX
            // 
            this.DX_TO_BX.Location = new System.Drawing.Point(313, 115);
            this.DX_TO_BX.Name = "DX_TO_BX";
            this.DX_TO_BX.Size = new System.Drawing.Size(83, 23);
            this.DX_TO_BX.TabIndex = 19;
            this.DX_TO_BX.Text = "DX TO BX";
            this.DX_TO_BX.UseVisualStyleBackColor = true;
            this.DX_TO_BX.UseWaitCursor = true;
            this.DX_TO_BX.Click += new System.EventHandler(this.DX_TO_BX_Click);
            // 
            // CX_TO_BX
            // 
            this.CX_TO_BX.Location = new System.Drawing.Point(313, 86);
            this.CX_TO_BX.Name = "CX_TO_BX";
            this.CX_TO_BX.Size = new System.Drawing.Size(83, 23);
            this.CX_TO_BX.TabIndex = 18;
            this.CX_TO_BX.Text = "CX TO BX";
            this.CX_TO_BX.UseVisualStyleBackColor = true;
            this.CX_TO_BX.UseWaitCursor = true;
            this.CX_TO_BX.Click += new System.EventHandler(this.CX_TO_BX_Click);
            // 
            // AX_TO_BX
            // 
            this.AX_TO_BX.Location = new System.Drawing.Point(313, 57);
            this.AX_TO_BX.Name = "AX_TO_BX";
            this.AX_TO_BX.Size = new System.Drawing.Size(83, 23);
            this.AX_TO_BX.TabIndex = 17;
            this.AX_TO_BX.Text = "AX TO BX";
            this.AX_TO_BX.UseVisualStyleBackColor = true;
            this.AX_TO_BX.UseWaitCursor = true;
            this.AX_TO_BX.Click += new System.EventHandler(this.AX_TO_BX_Click);
            // 
            // DX_TO_CX
            // 
            this.DX_TO_CX.Location = new System.Drawing.Point(412, 115);
            this.DX_TO_CX.Name = "DX_TO_CX";
            this.DX_TO_CX.Size = new System.Drawing.Size(83, 23);
            this.DX_TO_CX.TabIndex = 22;
            this.DX_TO_CX.Text = "DX TO CX";
            this.DX_TO_CX.UseVisualStyleBackColor = true;
            this.DX_TO_CX.UseWaitCursor = true;
            this.DX_TO_CX.Click += new System.EventHandler(this.DX_TO_CX_Click);
            // 
            // BX_TO_CX
            // 
            this.BX_TO_CX.Location = new System.Drawing.Point(412, 86);
            this.BX_TO_CX.Name = "BX_TO_CX";
            this.BX_TO_CX.Size = new System.Drawing.Size(83, 23);
            this.BX_TO_CX.TabIndex = 21;
            this.BX_TO_CX.Text = "BX TO CX";
            this.BX_TO_CX.UseVisualStyleBackColor = true;
            this.BX_TO_CX.UseWaitCursor = true;
            this.BX_TO_CX.Click += new System.EventHandler(this.BX_TO_CX_Click);
            // 
            // AX_TO_CX
            // 
            this.AX_TO_CX.Location = new System.Drawing.Point(412, 57);
            this.AX_TO_CX.Name = "AX_TO_CX";
            this.AX_TO_CX.Size = new System.Drawing.Size(83, 23);
            this.AX_TO_CX.TabIndex = 20;
            this.AX_TO_CX.Text = "AX TO CX";
            this.AX_TO_CX.UseVisualStyleBackColor = true;
            this.AX_TO_CX.UseWaitCursor = true;
            this.AX_TO_CX.Click += new System.EventHandler(this.AX_TO_CX_Click);
            // 
            // CX_TO_DX
            // 
            this.CX_TO_DX.Location = new System.Drawing.Point(511, 115);
            this.CX_TO_DX.Name = "CX_TO_DX";
            this.CX_TO_DX.Size = new System.Drawing.Size(83, 23);
            this.CX_TO_DX.TabIndex = 25;
            this.CX_TO_DX.Text = "CX TO DX";
            this.CX_TO_DX.UseVisualStyleBackColor = true;
            this.CX_TO_DX.UseWaitCursor = true;
            this.CX_TO_DX.Click += new System.EventHandler(this.CX_TO_DX_Click);
            // 
            // BX_TO_DX
            // 
            this.BX_TO_DX.Location = new System.Drawing.Point(511, 86);
            this.BX_TO_DX.Name = "BX_TO_DX";
            this.BX_TO_DX.Size = new System.Drawing.Size(83, 23);
            this.BX_TO_DX.TabIndex = 24;
            this.BX_TO_DX.Text = "BX TO DX";
            this.BX_TO_DX.UseVisualStyleBackColor = true;
            this.BX_TO_DX.UseWaitCursor = true;
            this.BX_TO_DX.Click += new System.EventHandler(this.BX_TO_DX_Click);
            // 
            // AX_TO_DX
            // 
            this.AX_TO_DX.Location = new System.Drawing.Point(511, 57);
            this.AX_TO_DX.Name = "AX_TO_DX";
            this.AX_TO_DX.Size = new System.Drawing.Size(83, 23);
            this.AX_TO_DX.TabIndex = 23;
            this.AX_TO_DX.Text = "AX TO DX";
            this.AX_TO_DX.UseVisualStyleBackColor = true;
            this.AX_TO_DX.UseWaitCursor = true;
            this.AX_TO_DX.Click += new System.EventHandler(this.AX_TO_DX_Click);
            // 
            // RANDOM_INPUT
            // 
            this.RANDOM_INPUT.Location = new System.Drawing.Point(54, 57);
            this.RANDOM_INPUT.Name = "RANDOM_INPUT";
            this.RANDOM_INPUT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RANDOM_INPUT.Size = new System.Drawing.Size(129, 23);
            this.RANDOM_INPUT.TabIndex = 26;
            this.RANDOM_INPUT.Text = "RANDOM INPUT";
            this.RANDOM_INPUT.UseVisualStyleBackColor = true;
            this.RANDOM_INPUT.Click += new System.EventHandler(this.RANDOM_INPUT_Click);
            // 
            // RANDOM_REGISTRIES
            // 
            this.RANDOM_REGISTRIES.Location = new System.Drawing.Point(54, 86);
            this.RANDOM_REGISTRIES.Name = "RANDOM_REGISTRIES";
            this.RANDOM_REGISTRIES.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RANDOM_REGISTRIES.Size = new System.Drawing.Size(129, 23);
            this.RANDOM_REGISTRIES.TabIndex = 27;
            this.RANDOM_REGISTRIES.Text = "RANDOM REGISTRIES";
            this.RANDOM_REGISTRIES.UseVisualStyleBackColor = true;
            this.RANDOM_REGISTRIES.Click += new System.EventHandler(this.RANDOM_REGISTRIES_Click);
            // 
            // RESET
            // 
            this.RESET.Location = new System.Drawing.Point(54, 115);
            this.RESET.Name = "RESET";
            this.RESET.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RESET.Size = new System.Drawing.Size(129, 23);
            this.RESET.TabIndex = 28;
            this.RESET.Text = "RESET";
            this.RESET.UseVisualStyleBackColor = true;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RESET);
            this.Controls.Add(this.RANDOM_REGISTRIES);
            this.Controls.Add(this.RANDOM_INPUT);
            this.Controls.Add(this.CX_TO_DX);
            this.Controls.Add(this.BX_TO_DX);
            this.Controls.Add(this.AX_TO_DX);
            this.Controls.Add(this.DX_TO_CX);
            this.Controls.Add(this.BX_TO_CX);
            this.Controls.Add(this.AX_TO_CX);
            this.Controls.Add(this.DX_TO_BX);
            this.Controls.Add(this.CX_TO_BX);
            this.Controls.Add(this.AX_TO_BX);
            this.Controls.Add(this.DX_TO_AX);
            this.Controls.Add(this.CX_TO_AX);
            this.Controls.Add(this.BX_TO_AX);
            this.Controls.Add(this.INPUT_DX);
            this.Controls.Add(this.INPUT_CX);
            this.Controls.Add(this.INPUT_BX);
            this.Controls.Add(this.INPUT_AX);
            this.Controls.Add(this.DX);
            this.Controls.Add(this.DX_TEXT);
            this.Controls.Add(this.CX);
            this.Controls.Add(this.CX_TEXT);
            this.Controls.Add(this.BX);
            this.Controls.Add(this.BX_TEXT);
            this.Controls.Add(this.AX);
            this.Controls.Add(this.AX_TEXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputText;
        private Label label1;
        private Label AX;
        private TextBox AX_TEXT;
        private Label BX;
        private TextBox BX_TEXT;
        private Label CX;
        private TextBox CX_TEXT;
        private Label DX;
        private TextBox DX_TEXT;
        private Button INPUT_AX;
        private Button INPUT_BX;
        private Button INPUT_CX;
        private Button INPUT_DX;
        private Button BX_TO_AX;
        private Button CX_TO_AX;
        private Button DX_TO_AX;
        private Button DX_TO_BX;
        private Button CX_TO_BX;
        private Button AX_TO_BX;
        private Button DX_TO_CX;
        private Button BX_TO_CX;
        private Button AX_TO_CX;
        private Button CX_TO_DX;
        private Button BX_TO_DX;
        private Button AX_TO_DX;
        private Button RANDOM_INPUT;
        private Button RANDOM_REGISTRIES;
        private Button RESET;
    }
}