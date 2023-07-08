
namespace Gameshop1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelCurrentGame = new System.Windows.Forms.Label();
            this.textBoxGame = new System.Windows.Forms.TextBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btdel = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCurrentGame
            // 
            this.labelCurrentGame.AutoSize = true;
            this.labelCurrentGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentGame.Location = new System.Drawing.Point(1138, 625);
            this.labelCurrentGame.Name = "labelCurrentGame";
            this.labelCurrentGame.Size = new System.Drawing.Size(54, 20);
            this.labelCurrentGame.TabIndex = 0;
            this.labelCurrentGame.Text = "PgNo";
            // 
            // textBoxGame
            // 
            this.textBoxGame.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGame.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxGame.Location = new System.Drawing.Point(127, 320);
            this.textBoxGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxGame.Multiline = true;
            this.textBoxGame.Name = "textBoxGame";
            this.textBoxGame.ReadOnly = true;
            this.textBoxGame.Size = new System.Drawing.Size(1010, 216);
            this.textBoxGame.TabIndex = 1;
            this.textBoxGame.TextChanged += new System.EventHandler(this.textBoxGame_TextChanged);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.Location = new System.Drawing.Point(127, 550);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(112, 42);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(1023, 540);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(114, 42);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Xbox Collections";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 13);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "PS Collections";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btdel
            // 
            this.btdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdel.Location = new System.Drawing.Point(524, 551);
            this.btdel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btdel.Name = "btdel";
            this.btdel.Size = new System.Drawing.Size(125, 32);
            this.btdel.TabIndex = 13;
            this.btdel.Text = "Delete";
            this.btdel.UseVisualStyleBackColor = true;
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Location = new System.Drawing.Point(393, 551);
            this.btadd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(125, 32);
            this.btadd.TabIndex = 12;
            this.btadd.Text = "Add";
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(655, 550);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 33);
            this.button3.TabIndex = 14;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "elderscrolls.jpg");
            this.imageList1.Images.SetKeyName(1, "fortnite.png");
            this.imageList1.Images.SetKeyName(2, "forzah5.jpg");
            this.imageList1.Images.SetKeyName(3, "gtav.jpg");
            this.imageList1.Images.SetKeyName(4, "halo.jpg");
            this.imageList1.Images.SetKeyName(5, "minecraft.png");
            this.imageList1.Images.SetKeyName(6, "pubg.jpg");
            this.imageList1.Images.SetKeyName(7, "r6s.jpg");
            this.imageList1.Images.SetKeyName(8, "roblox.png");
            this.imageList1.Images.SetKeyName(9, "warframe.jpg");
            this.imageList1.Images.SetKeyName(10, "hitman2.jpg");
            this.imageList1.Images.SetKeyName(11, "spiderman.jpg");
            this.imageList1.Images.SetKeyName(12, "rdr2.jpg");
            this.imageList1.Images.SetKeyName(13, "fifa.jpg");
            this.imageList1.Images.SetKeyName(14, "Apex Legends.jpg");
            this.imageList1.Images.SetKeyName(15, "NBA 2K22.jpg");
            this.imageList1.Images.SetKeyName(16, "Far Cry 6.jpg");
            this.imageList1.Images.SetKeyName(17, "Dying Light 2.jpg");
            this.imageList1.Images.SetKeyName(18, "Cyberpunk 2077.jpg");
            this.imageList1.Images.SetKeyName(19, "CallofDutyModernWarfare.jpg");
            this.imageList1.Images.SetKeyName(20, "Battlefield 2042.jpg");
            this.imageList1.Images.SetKeyName(21, "Rocket League.jpg");
            this.imageList1.Images.SetKeyName(22, "ARK Survival Evolved.jpg");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(127, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(381, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 223);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(635, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(248, 223);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "5.jpg");
            this.imageList2.Images.SetKeyName(1, "111.jpg");
            this.imageList2.Images.SetKeyName(2, "22222.jpg");
            this.imageList2.Images.SetKeyName(3, "33333.jpg");
            this.imageList2.Images.SetKeyName(4, "44444.jpg");
            this.imageList2.Images.SetKeyName(5, "1635168859_location.jpg");
            this.imageList2.Images.SetKeyName(6, "Apex-Legends-Season-8-–-Mayhem-Gameplay-Trailer-1-25-screenshot.png");
            this.imageList2.Images.SetKeyName(7, "ark-survival-evolved-ps4-review-you-didnt-say-the-magic-word-9.jpg");
            this.imageList2.Images.SetKeyName(8, "black-suit-spiderman-gameplay.jpg");
            this.imageList2.Images.SetKeyName(9, "call-of-duty-advanced-warfare_review_instinct.jpg");
            this.imageList2.Images.SetKeyName(10, "csm_Screenshot_2021_08_13_120805_0_99ef3ffa91.png");
            this.imageList2.Images.SetKeyName(11, "Cyberpunk-2077_20201119_01.png");
            this.imageList2.Images.SetKeyName(12, "DL2_ScreenE32019_7.jpg");
            this.imageList2.Images.SetKeyName(13, "en-r6s-epic-twe-ubi35-hero-banner-3840x2160-uk-3840x2160-a5747f0989bc.jpg");
            this.imageList2.Images.SetKeyName(14, "exportsequence_0000000437.jpg");
            this.imageList2.Images.SetKeyName(15, "Far-Cry-2-Modernized-screenshots-5.jpeg");
            this.imageList2.Images.SetKeyName(16, "fifa-22-referenced-buy-hero.png.adapt.crop16x9.320w.png");
            this.imageList2.Images.SetKeyName(17, "GettyImages-1234214852-scaled.jpg");
            this.imageList2.Images.SetKeyName(18, "HITMAN_2_Launch_WhittletonCreek2_1541530092.png");
            this.imageList2.Images.SetKeyName(19, "maxresdefault-1.jpg");
            this.imageList2.Images.SetKeyName(20, "Minecraft-2-Pams-Harvestcraft.jpg");
            this.imageList2.Images.SetKeyName(21, "rocketleague__14__1.jpg");
            this.imageList2.Images.SetKeyName(22, "Warframe-Spring-2021.jpg");
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(256, 256);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(889, 92);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(248, 223);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 672);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btdel);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.textBoxGame);
            this.Controls.Add(this.labelCurrentGame);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Game Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentGame;
        private System.Windows.Forms.TextBox textBoxGame;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btdel;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

