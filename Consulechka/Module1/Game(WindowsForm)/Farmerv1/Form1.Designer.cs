namespace Farmerv1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Farmer = new System.Windows.Forms.PictureBox();
            this.Goat = new System.Windows.Forms.PictureBox();
            this.Wolf = new System.Windows.Forms.PictureBox();
            this.Cabbage = new System.Windows.Forms.PictureBox();
            this.River = new System.Windows.Forms.PictureBox();
            this.BoatBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFarmerBack = new System.Windows.Forms.Button();
            this.btnGoatBack = new System.Windows.Forms.Button();
            this.btnWolfBack = new System.Windows.Forms.Button();
            this.btnCabbageBack = new System.Windows.Forms.Button();
            this.btnClearBoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Farmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wolf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cabbage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.River)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoatBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Farmer
            // 
            this.Farmer.BackgroundImage = global::Farmerv1.Properties.Resources.Farmer;
            this.Farmer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Farmer.Location = new System.Drawing.Point(33, 31);
            this.Farmer.Name = "Farmer";
            this.Farmer.Size = new System.Drawing.Size(50, 50);
            this.Farmer.TabIndex = 0;
            this.Farmer.TabStop = false;
            // 
            // Goat
            // 
            this.Goat.BackgroundImage = global::Farmerv1.Properties.Resources.Goat;
            this.Goat.Location = new System.Drawing.Point(33, 87);
            this.Goat.Name = "Goat";
            this.Goat.Size = new System.Drawing.Size(50, 50);
            this.Goat.TabIndex = 1;
            this.Goat.TabStop = false;
            // 
            // Wolf
            // 
            this.Wolf.BackgroundImage = global::Farmerv1.Properties.Resources.Wolf;
            this.Wolf.Location = new System.Drawing.Point(33, 144);
            this.Wolf.Name = "Wolf";
            this.Wolf.Size = new System.Drawing.Size(50, 50);
            this.Wolf.TabIndex = 2;
            this.Wolf.TabStop = false;
            // 
            // Cabbage
            // 
            this.Cabbage.BackgroundImage = global::Farmerv1.Properties.Resources.Cabbage;
            this.Cabbage.Location = new System.Drawing.Point(33, 200);
            this.Cabbage.Name = "Cabbage";
            this.Cabbage.Size = new System.Drawing.Size(50, 50);
            this.Cabbage.TabIndex = 3;
            this.Cabbage.TabStop = false;
            // 
            // River
            // 
            this.River.BackgroundImage = global::Farmerv1.Properties.Resources.River1;
            this.River.Location = new System.Drawing.Point(248, 0);
            this.River.Name = "River";
            this.River.Size = new System.Drawing.Size(400, 462);
            this.River.TabIndex = 4;
            this.River.TabStop = false;
            // 
            // BoatBox
            // 
            this.BoatBox.BackgroundImage = global::Farmerv1.Properties.Resources.Boat;
            this.BoatBox.Location = new System.Drawing.Point(248, 157);
            this.BoatBox.Name = "BoatBox";
            this.BoatBox.Size = new System.Drawing.Size(83, 50);
            this.BoatBox.TabIndex = 5;
            this.BoatBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Location = new System.Drawing.Point(89, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Location = new System.Drawing.Point(89, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GrayText;
            this.button3.Location = new System.Drawing.Point(89, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GrayText;
            this.button4.Location = new System.Drawing.Point(89, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(89, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 55);
            this.button5.TabIndex = 10;
            this.button5.Text = "!Go!";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(89, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 35);
            this.button6.TabIndex = 11;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Boat: ";
            // 
            // btnFarmerBack
            // 
            this.btnFarmerBack.Location = new System.Drawing.Point(165, 31);
            this.btnFarmerBack.Name = "btnFarmerBack";
            this.btnFarmerBack.Size = new System.Drawing.Size(50, 50);
            this.btnFarmerBack.TabIndex = 13;
            this.btnFarmerBack.Text = "Back";
            this.btnFarmerBack.UseVisualStyleBackColor = true;
            this.btnFarmerBack.Click += new System.EventHandler(this.btnFarmerBack_Click);
            // 
            // btnGoatBack
            // 
            this.btnGoatBack.Location = new System.Drawing.Point(165, 87);
            this.btnGoatBack.Name = "btnGoatBack";
            this.btnGoatBack.Size = new System.Drawing.Size(50, 50);
            this.btnGoatBack.TabIndex = 14;
            this.btnGoatBack.Text = "Back";
            this.btnGoatBack.UseVisualStyleBackColor = true;
            this.btnGoatBack.Click += new System.EventHandler(this.btnGoatBack_Click);
            // 
            // btnWolfBack
            // 
            this.btnWolfBack.Location = new System.Drawing.Point(165, 144);
            this.btnWolfBack.Name = "btnWolfBack";
            this.btnWolfBack.Size = new System.Drawing.Size(50, 50);
            this.btnWolfBack.TabIndex = 15;
            this.btnWolfBack.Text = "Back";
            this.btnWolfBack.UseVisualStyleBackColor = true;
            this.btnWolfBack.Click += new System.EventHandler(this.btnWolfBack_Click);
            // 
            // btnCabbageBack
            // 
            this.btnCabbageBack.Location = new System.Drawing.Point(165, 200);
            this.btnCabbageBack.Name = "btnCabbageBack";
            this.btnCabbageBack.Size = new System.Drawing.Size(50, 47);
            this.btnCabbageBack.TabIndex = 16;
            this.btnCabbageBack.Text = "Back";
            this.btnCabbageBack.UseVisualStyleBackColor = true;
            this.btnCabbageBack.Click += new System.EventHandler(this.btnCabbageBack_Click);
            // 
            // btnClearBoat
            // 
            this.btnClearBoat.Location = new System.Drawing.Point(89, 253);
            this.btnClearBoat.Name = "btnClearBoat";
            this.btnClearBoat.Size = new System.Drawing.Size(126, 41);
            this.btnClearBoat.TabIndex = 17;
            this.btnClearBoat.Text = "ClearBoat";
            this.btnClearBoat.UseVisualStyleBackColor = true;
            this.btnClearBoat.Click += new System.EventHandler(this.btnClearBoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Farmerv1.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnClearBoat);
            this.Controls.Add(this.btnCabbageBack);
            this.Controls.Add(this.btnWolfBack);
            this.Controls.Add(this.btnGoatBack);
            this.Controls.Add(this.btnFarmerBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoatBox);
            this.Controls.Add(this.River);
            this.Controls.Add(this.Cabbage);
            this.Controls.Add(this.Wolf);
            this.Controls.Add(this.Goat);
            this.Controls.Add(this.Farmer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Farmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Goat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wolf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cabbage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.River)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoatBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Farmer;
        private System.Windows.Forms.PictureBox Goat;
        private System.Windows.Forms.PictureBox Wolf;
        private System.Windows.Forms.PictureBox Cabbage;
        private System.Windows.Forms.PictureBox River;
        private System.Windows.Forms.PictureBox BoatBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFarmerBack;
        private System.Windows.Forms.Button btnGoatBack;
        private System.Windows.Forms.Button btnWolfBack;
        private System.Windows.Forms.Button btnCabbageBack;
        private System.Windows.Forms.Button btnClearBoat;
    }
}

