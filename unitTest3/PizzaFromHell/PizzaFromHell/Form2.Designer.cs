namespace PizzaFromHell
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupCrust = new System.Windows.Forms.GroupBox();
            this.radioCrust2 = new System.Windows.Forms.RadioButton();
            this.radioCrust3 = new System.Windows.Forms.RadioButton();
            this.radioCrust1 = new System.Windows.Forms.RadioButton();
            this.groupSauce = new System.Windows.Forms.GroupBox();
            this.radioSauce3 = new System.Windows.Forms.RadioButton();
            this.radioSauce2 = new System.Windows.Forms.RadioButton();
            this.radioSauce1 = new System.Windows.Forms.RadioButton();
            this.groupAddons = new System.Windows.Forms.GroupBox();
            this.checkKetchup = new System.Windows.Forms.CheckBox();
            this.checkGarlic = new System.Windows.Forms.CheckBox();
            this.checkBanana = new System.Windows.Forms.CheckBox();
            this.checkPineapple = new System.Windows.Forms.CheckBox();
            this.checkMushrooms = new System.Windows.Forms.CheckBox();
            this.checkPeppers = new System.Windows.Forms.CheckBox();
            this.checkCheese = new System.Windows.Forms.CheckBox();
            this.labelDimensions = new System.Windows.Forms.Label();
            this.textDimensions = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.textCard = new System.Windows.Forms.TextBox();
            this.labelCard = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.buttonEscape = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupCrust.SuspendLayout();
            this.groupSauce.SuspendLayout();
            this.groupAddons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(-1, 526);
            this.progressBar1.MarqueeAnimationSpeed = 5000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(787, 35);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 100;
            // 
            // groupCrust
            // 
            this.groupCrust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupCrust.Controls.Add(this.radioCrust2);
            this.groupCrust.Controls.Add(this.radioCrust3);
            this.groupCrust.Controls.Add(this.radioCrust1);
            this.groupCrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCrust.Location = new System.Drawing.Point(267, 64);
            this.groupCrust.Name = "groupCrust";
            this.groupCrust.Size = new System.Drawing.Size(186, 146);
            this.groupCrust.TabIndex = 1;
            this.groupCrust.TabStop = false;
            this.groupCrust.Text = "Crust";
            // 
            // radioCrust2
            // 
            this.radioCrust2.AutoSize = true;
            this.radioCrust2.Location = new System.Drawing.Point(30, 73);
            this.radioCrust2.Name = "radioCrust2";
            this.radioCrust2.Size = new System.Drawing.Size(150, 24);
            this.radioCrust2.TabIndex = 2;
            this.radioCrust2.TabStop = true;
            this.radioCrust2.Text = "New York Thick";
            this.radioCrust2.UseVisualStyleBackColor = true;
            // 
            // radioCrust3
            // 
            this.radioCrust3.AutoSize = true;
            this.radioCrust3.Location = new System.Drawing.Point(30, 103);
            this.radioCrust3.Name = "radioCrust3";
            this.radioCrust3.Size = new System.Drawing.Size(142, 24);
            this.radioCrust3.TabIndex = 1;
            this.radioCrust3.TabStop = true;
            this.radioCrust3.Text = "California Thin";
            this.radioCrust3.UseVisualStyleBackColor = true;
            // 
            // radioCrust1
            // 
            this.radioCrust1.AutoSize = true;
            this.radioCrust1.Location = new System.Drawing.Point(28, 43);
            this.radioCrust1.Name = "radioCrust1";
            this.radioCrust1.Size = new System.Drawing.Size(152, 24);
            this.radioCrust1.TabIndex = 0;
            this.radioCrust1.TabStop = true;
            this.radioCrust1.Text = "Neapolitan Thin";
            this.radioCrust1.UseVisualStyleBackColor = true;
            // 
            // groupSauce
            // 
            this.groupSauce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupSauce.Controls.Add(this.radioSauce3);
            this.groupSauce.Controls.Add(this.radioSauce2);
            this.groupSauce.Controls.Add(this.radioSauce1);
            this.groupSauce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSauce.Location = new System.Drawing.Point(107, 147);
            this.groupSauce.Name = "groupSauce";
            this.groupSauce.Size = new System.Drawing.Size(182, 172);
            this.groupSauce.TabIndex = 2;
            this.groupSauce.TabStop = false;
            this.groupSauce.Text = "Sauce";
            // 
            // radioSauce3
            // 
            this.radioSauce3.AutoSize = true;
            this.radioSauce3.Location = new System.Drawing.Point(14, 104);
            this.radioSauce3.Name = "radioSauce3";
            this.radioSauce3.Size = new System.Drawing.Size(125, 24);
            this.radioSauce3.TabIndex = 3;
            this.radioSauce3.TabStop = true;
            this.radioSauce3.Text = "Pretty Pesto";
            this.radioSauce3.UseVisualStyleBackColor = true;
            // 
            // radioSauce2
            // 
            this.radioSauce2.AutoSize = true;
            this.radioSauce2.Location = new System.Drawing.Point(14, 74);
            this.radioSauce2.Name = "radioSauce2";
            this.radioSauce2.Size = new System.Drawing.Size(131, 24);
            this.radioSauce2.TabIndex = 2;
            this.radioSauce2.TabStop = true;
            this.radioSauce2.Text = "Garlic Ranch";
            this.radioSauce2.UseVisualStyleBackColor = true;
            // 
            // radioSauce1
            // 
            this.radioSauce1.AutoSize = true;
            this.radioSauce1.Location = new System.Drawing.Point(14, 44);
            this.radioSauce1.Name = "radioSauce1";
            this.radioSauce1.Size = new System.Drawing.Size(154, 24);
            this.radioSauce1.TabIndex = 1;
            this.radioSauce1.TabStop = true;
            this.radioSauce1.Text = "Spicy Tomatoes";
            this.radioSauce1.UseVisualStyleBackColor = true;
            // 
            // groupAddons
            // 
            this.groupAddons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupAddons.Controls.Add(this.checkKetchup);
            this.groupAddons.Controls.Add(this.checkGarlic);
            this.groupAddons.Controls.Add(this.checkBanana);
            this.groupAddons.Controls.Add(this.checkPineapple);
            this.groupAddons.Controls.Add(this.checkMushrooms);
            this.groupAddons.Controls.Add(this.checkPeppers);
            this.groupAddons.Controls.Add(this.checkCheese);
            this.groupAddons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupAddons.Location = new System.Drawing.Point(295, 225);
            this.groupAddons.Name = "groupAddons";
            this.groupAddons.Size = new System.Drawing.Size(172, 263);
            this.groupAddons.TabIndex = 3;
            this.groupAddons.TabStop = false;
            this.groupAddons.Text = "Add-ons";
            // 
            // checkKetchup
            // 
            this.checkKetchup.AutoSize = true;
            this.checkKetchup.Location = new System.Drawing.Point(72, 228);
            this.checkKetchup.Name = "checkKetchup";
            this.checkKetchup.Size = new System.Drawing.Size(94, 24);
            this.checkKetchup.TabIndex = 10;
            this.checkKetchup.Text = "Ketchup";
            this.checkKetchup.UseVisualStyleBackColor = true;
            // 
            // checkGarlic
            // 
            this.checkGarlic.AutoSize = true;
            this.checkGarlic.Location = new System.Drawing.Point(72, 200);
            this.checkGarlic.Name = "checkGarlic";
            this.checkGarlic.Size = new System.Drawing.Size(75, 24);
            this.checkGarlic.TabIndex = 9;
            this.checkGarlic.Text = "Garlic";
            this.checkGarlic.UseVisualStyleBackColor = true;
            // 
            // checkBanana
            // 
            this.checkBanana.AutoSize = true;
            this.checkBanana.Location = new System.Drawing.Point(72, 171);
            this.checkBanana.Name = "checkBanana";
            this.checkBanana.Size = new System.Drawing.Size(90, 24);
            this.checkBanana.TabIndex = 8;
            this.checkBanana.Text = "Banana";
            this.checkBanana.UseVisualStyleBackColor = true;
            // 
            // checkPineapple
            // 
            this.checkPineapple.AutoSize = true;
            this.checkPineapple.Location = new System.Drawing.Point(16, 130);
            this.checkPineapple.Name = "checkPineapple";
            this.checkPineapple.Size = new System.Drawing.Size(107, 24);
            this.checkPineapple.TabIndex = 7;
            this.checkPineapple.Text = "Pineapple";
            this.checkPineapple.UseVisualStyleBackColor = true;
            // 
            // checkMushrooms
            // 
            this.checkMushrooms.AutoSize = true;
            this.checkMushrooms.Location = new System.Drawing.Point(16, 100);
            this.checkMushrooms.Name = "checkMushrooms";
            this.checkMushrooms.Size = new System.Drawing.Size(120, 24);
            this.checkMushrooms.TabIndex = 6;
            this.checkMushrooms.Text = "Mushrooms";
            this.checkMushrooms.UseVisualStyleBackColor = true;
            // 
            // checkPeppers
            // 
            this.checkPeppers.AutoSize = true;
            this.checkPeppers.Location = new System.Drawing.Point(16, 70);
            this.checkPeppers.Name = "checkPeppers";
            this.checkPeppers.Size = new System.Drawing.Size(94, 24);
            this.checkPeppers.TabIndex = 5;
            this.checkPeppers.Text = "Peppers";
            this.checkPeppers.UseVisualStyleBackColor = true;
            // 
            // checkCheese
            // 
            this.checkCheese.AutoSize = true;
            this.checkCheese.Location = new System.Drawing.Point(17, 40);
            this.checkCheese.Name = "checkCheese";
            this.checkCheese.Size = new System.Drawing.Size(136, 24);
            this.checkCheese.TabIndex = 4;
            this.checkCheese.Text = "Extra Cheese";
            this.checkCheese.UseVisualStyleBackColor = true;
            // 
            // labelDimensions
            // 
            this.labelDimensions.AutoSize = true;
            this.labelDimensions.BackColor = System.Drawing.Color.Yellow;
            this.labelDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDimensions.Location = new System.Drawing.Point(471, 29);
            this.labelDimensions.Name = "labelDimensions";
            this.labelDimensions.Size = new System.Drawing.Size(142, 20);
            this.labelDimensions.TabIndex = 4;
            this.labelDimensions.Text = "Dimensions (cm)";
            // 
            // textDimensions
            // 
            this.textDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDimensions.Location = new System.Drawing.Point(498, 46);
            this.textDimensions.Name = "textDimensions";
            this.textDimensions.Size = new System.Drawing.Size(100, 26);
            this.textDimensions.TabIndex = 5;
            // 
            // textQuantity
            // 
            this.textQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuantity.Location = new System.Drawing.Point(636, 43);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(100, 26);
            this.textQuantity.TabIndex = 7;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.BackColor = System.Drawing.Color.Yellow;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(658, 29);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(76, 20);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "Quantity";
            // 
            // textCard
            // 
            this.textCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCard.Location = new System.Drawing.Point(535, 225);
            this.textCard.Name = "textCard";
            this.textCard.Size = new System.Drawing.Size(199, 26);
            this.textCard.TabIndex = 9;
            this.textCard.MouseEnter += new System.EventHandler(this.textCard_MouseEnter);
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.BackColor = System.Drawing.Color.Yellow;
            this.labelCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCard.Location = new System.Drawing.Point(494, 210);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(112, 20);
            this.labelCard.TabIndex = 8;
            this.labelCard.Text = "Card number";
            // 
            // textAddress
            // 
            this.textAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddress.Location = new System.Drawing.Point(498, 284);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(199, 26);
            this.textAddress.TabIndex = 11;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.BackColor = System.Drawing.Color.Yellow;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(567, 265);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(75, 20);
            this.labelAddress.TabIndex = 10;
            this.labelAddress.Text = "Address";
            // 
            // textPhone
            // 
            this.textPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPhone.Location = new System.Drawing.Point(507, 334);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(199, 26);
            this.textPhone.TabIndex = 13;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Yellow;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(632, 313);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(60, 20);
            this.labelPhone.TabIndex = 12;
            this.labelPhone.Text = "Phone";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Red;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(32, 55);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(98, 31);
            this.title.TabIndex = 14;
            this.title.Text = "Hello, ";
            // 
            // buttonEscape
            // 
            this.buttonEscape.BackColor = System.Drawing.Color.Blue;
            this.buttonEscape.BackgroundImage = global::PizzaFromHell.Properties.Resources.exit;
            this.buttonEscape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEscape.Location = new System.Drawing.Point(53, 416);
            this.buttonEscape.Name = "buttonEscape";
            this.buttonEscape.Size = new System.Drawing.Size(90, 92);
            this.buttonEscape.TabIndex = 16;
            this.buttonEscape.UseVisualStyleBackColor = false;
            this.buttonEscape.Click += new System.EventHandler(this.buttonEscape_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Lime;
            this.pictureBox6.Image = global::PizzaFromHell.Properties.Resources.giphy__1_;
            this.pictureBox6.Location = new System.Drawing.Point(636, 88);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(110, 122);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PizzaFromHell.Properties.Resources.pizza2;
            this.pictureBox5.Location = new System.Drawing.Point(475, 88);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(138, 108);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaFromHell.Properties.Resources.pizza2;
            this.pictureBox1.Location = new System.Drawing.Point(38, 288);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox4.Image = global::PizzaFromHell.Properties.Resources.giphy;
            this.pictureBox4.Location = new System.Drawing.Point(12, 120);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 131);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PizzaFromHell.Properties.Resources.pizza1;
            this.pictureBox2.Location = new System.Drawing.Point(175, 392);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(182, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PizzaFromHell.Properties.Resources.pizza3;
            this.pictureBox3.Location = new System.Drawing.Point(516, 366);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(190, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaFromHell.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupSauce);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonEscape);
            this.Controls.Add(this.title);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.textCard);
            this.Controls.Add(this.labelCard);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textDimensions);
            this.Controls.Add(this.labelDimensions);
            this.Controls.Add(this.groupAddons);
            this.Controls.Add(this.groupCrust);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupCrust.ResumeLayout(false);
            this.groupCrust.PerformLayout();
            this.groupSauce.ResumeLayout(false);
            this.groupSauce.PerformLayout();
            this.groupAddons.ResumeLayout(false);
            this.groupAddons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupCrust;
        private System.Windows.Forms.GroupBox groupSauce;
        private System.Windows.Forms.GroupBox groupAddons;
        private System.Windows.Forms.Label labelDimensions;
        private System.Windows.Forms.TextBox textDimensions;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox textCard;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button buttonEscape;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RadioButton radioCrust2;
        private System.Windows.Forms.RadioButton radioCrust3;
        private System.Windows.Forms.RadioButton radioCrust1;
        private System.Windows.Forms.RadioButton radioSauce3;
        private System.Windows.Forms.RadioButton radioSauce2;
        private System.Windows.Forms.RadioButton radioSauce1;
        private System.Windows.Forms.CheckBox checkKetchup;
        private System.Windows.Forms.CheckBox checkGarlic;
        private System.Windows.Forms.CheckBox checkBanana;
        private System.Windows.Forms.CheckBox checkPineapple;
        private System.Windows.Forms.CheckBox checkMushrooms;
        private System.Windows.Forms.CheckBox checkPeppers;
        private System.Windows.Forms.CheckBox checkCheese;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}