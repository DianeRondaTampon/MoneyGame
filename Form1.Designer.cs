namespace WinFormsApp6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBuyHotel = new System.Windows.Forms.Button();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblQuantityOfHotel = new System.Windows.Forms.Label();
            this.btnBuyHouse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuantityOfHouse = new System.Windows.Forms.Label();
            this.lblCorporation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuyCorporation = new System.Windows.Forms.Button();
            this.lblQuantityOfSkyScraper = new System.Windows.Forms.Label();
            this.lblSkyScraper = new System.Windows.Forms.Label();
            this.btnSkyScraper = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblQuantityOfBank = new System.Windows.Forms.Label();
            this.lblBank = new System.Windows.Forms.Label();
            this.btnBuyBank = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Money";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(293, 43);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(13, 15);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBuyHotel
            // 
            this.btnBuyHotel.Location = new System.Drawing.Point(366, 186);
            this.btnBuyHotel.Name = "btnBuyHotel";
            this.btnBuyHotel.Size = new System.Drawing.Size(121, 53);
            this.btnBuyHotel.TabIndex = 2;
            this.btnBuyHotel.Text = "Buy Hotel 50$";
            this.btnBuyHotel.UseVisualStyleBackColor = true;
            this.btnBuyHotel.Click += new System.EventHandler(this.btnBuyHotel_Click);
            // 
            // lblHotel
            // 
            this.lblHotel.AutoSize = true;
            this.lblHotel.Location = new System.Drawing.Point(195, 205);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(36, 15);
            this.lblHotel.TabIndex = 3;
            this.lblHotel.Text = "Hotel";
            // 
            // lblQuantityOfHotel
            // 
            this.lblQuantityOfHotel.AutoSize = true;
            this.lblQuantityOfHotel.Location = new System.Drawing.Point(293, 205);
            this.lblQuantityOfHotel.Name = "lblQuantityOfHotel";
            this.lblQuantityOfHotel.Size = new System.Drawing.Size(13, 15);
            this.lblQuantityOfHotel.TabIndex = 4;
            this.lblQuantityOfHotel.Text = "0";
            // 
            // btnBuyHouse
            // 
            this.btnBuyHouse.Location = new System.Drawing.Point(366, 103);
            this.btnBuyHouse.Name = "btnBuyHouse";
            this.btnBuyHouse.Size = new System.Drawing.Size(121, 53);
            this.btnBuyHouse.TabIndex = 5;
            this.btnBuyHouse.Text = "Buy House 10$";
            this.btnBuyHouse.UseVisualStyleBackColor = true;
            this.btnBuyHouse.Click += new System.EventHandler(this.btnBuyHouse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "House";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblQuantityOfHouse
            // 
            this.lblQuantityOfHouse.AutoSize = true;
            this.lblQuantityOfHouse.Location = new System.Drawing.Point(293, 122);
            this.lblQuantityOfHouse.Name = "lblQuantityOfHouse";
            this.lblQuantityOfHouse.Size = new System.Drawing.Size(13, 15);
            this.lblQuantityOfHouse.TabIndex = 7;
            this.lblQuantityOfHouse.Text = "0";
            // 
            // lblCorporation
            // 
            this.lblCorporation.AutoSize = true;
            this.lblCorporation.Location = new System.Drawing.Point(293, 287);
            this.lblCorporation.Name = "lblCorporation";
            this.lblCorporation.Size = new System.Drawing.Size(13, 15);
            this.lblCorporation.TabIndex = 10;
            this.lblCorporation.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Corporation";
            // 
            // btnBuyCorporation
            // 
            this.btnBuyCorporation.Location = new System.Drawing.Point(366, 268);
            this.btnBuyCorporation.Name = "btnBuyCorporation";
            this.btnBuyCorporation.Size = new System.Drawing.Size(121, 58);
            this.btnBuyCorporation.TabIndex = 8;
            this.btnBuyCorporation.Text = "Buy Corporation 1000$";
            this.btnBuyCorporation.UseVisualStyleBackColor = true;
            this.btnBuyCorporation.Click += new System.EventHandler(this.btnBuyCorporation_Click);
            // 
            // lblQuantityOfSkyScraper
            // 
            this.lblQuantityOfSkyScraper.AutoSize = true;
            this.lblQuantityOfSkyScraper.Location = new System.Drawing.Point(293, 370);
            this.lblQuantityOfSkyScraper.Name = "lblQuantityOfSkyScraper";
            this.lblQuantityOfSkyScraper.Size = new System.Drawing.Size(13, 15);
            this.lblQuantityOfSkyScraper.TabIndex = 16;
            this.lblQuantityOfSkyScraper.Text = "0";
            // 
            // lblSkyScraper
            // 
            this.lblSkyScraper.AutoSize = true;
            this.lblSkyScraper.Location = new System.Drawing.Point(195, 370);
            this.lblSkyScraper.Name = "lblSkyScraper";
            this.lblSkyScraper.Size = new System.Drawing.Size(67, 15);
            this.lblSkyScraper.TabIndex = 15;
            this.lblSkyScraper.Text = "Sky Scraper";
            // 
            // btnSkyScraper
            // 
            this.btnSkyScraper.Location = new System.Drawing.Point(366, 351);
            this.btnSkyScraper.Name = "btnSkyScraper";
            this.btnSkyScraper.Size = new System.Drawing.Size(121, 58);
            this.btnSkyScraper.TabIndex = 14;
            this.btnSkyScraper.Text = "Buy Sky Scraper 50,000$";
            this.btnSkyScraper.UseVisualStyleBackColor = true;
            this.btnSkyScraper.Click += new System.EventHandler(this.btnSkyScraper_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(420, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(535, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(535, 189);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(535, 276);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(535, 359);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(535, 447);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // lblQuantityOfBank
            // 
            this.lblQuantityOfBank.AutoSize = true;
            this.lblQuantityOfBank.Location = new System.Drawing.Point(293, 458);
            this.lblQuantityOfBank.Name = "lblQuantityOfBank";
            this.lblQuantityOfBank.Size = new System.Drawing.Size(13, 15);
            this.lblQuantityOfBank.TabIndex = 24;
            this.lblQuantityOfBank.Text = "0";
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(195, 458);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(33, 15);
            this.lblBank.TabIndex = 23;
            this.lblBank.Text = "Bank";
            // 
            // btnBuyBank
            // 
            this.btnBuyBank.Location = new System.Drawing.Point(366, 439);
            this.btnBuyBank.Name = "btnBuyBank";
            this.btnBuyBank.Size = new System.Drawing.Size(121, 58);
            this.btnBuyBank.TabIndex = 22;
            this.btnBuyBank.Text = "Buy Bank 1000000$";
            this.btnBuyBank.UseVisualStyleBackColor = true;
            this.btnBuyBank.Click += new System.EventHandler(this.btnBuyBank_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.lblQuantityOfBank);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.btnBuyBank);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblQuantityOfSkyScraper);
            this.Controls.Add(this.lblSkyScraper);
            this.Controls.Add(this.btnSkyScraper);
            this.Controls.Add(this.lblCorporation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuyCorporation);
            this.Controls.Add(this.lblQuantityOfHouse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuyHouse);
            this.Controls.Add(this.lblQuantityOfHotel);
            this.Controls.Add(this.lblHotel);
            this.Controls.Add(this.btnBuyHotel);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblMoney;
        private System.Windows.Forms.Timer timer1;
        private Button btnBuyHotel;
        private Label lblHotel;
        private Label lblQuantityOfHotel;
        private Button btnBuyHouse;
        private Label label2;
        private Label lblQuantityOfHouse;
        private Label lblCorporation;
        private Label label4;
        private Button btnBuyCorporation;
        private Label lblQuantityOfSkyScraper;
        private Label lblSkyScraper;
        private Button btnSkyScraper;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label lblQuantityOfBank;
        private Label lblBank;
        private Button btnBuyBank;
    }
}