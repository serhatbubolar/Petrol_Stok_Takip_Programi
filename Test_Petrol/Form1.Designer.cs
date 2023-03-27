namespace Test_Petrol
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblkursunsuz95 = new System.Windows.Forms.Label();
            this.lblkursunsuz97 = new System.Windows.Forms.Label();
            this.lblEuroDizel = new System.Windows.Forms.Label();
            this.lblProDizel = new System.Windows.Forms.Label();
            this.lblGaz = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGazfiyat = new System.Windows.Forms.TextBox();
            this.txtyeniprodizelfiyat = new System.Windows.Forms.TextBox();
            this.txteurodizel10fiyat = new System.Windows.Forms.TextBox();
            this.txtkursunsuz97fiyat = new System.Windows.Forms.TextBox();
            this.txtkursunsuz95fiyat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.btntDepoDoldur = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pkursunsuz95 = new System.Windows.Forms.ProgressBar();
            this.pkursunsuz97 = new System.Windows.Forms.ProgressBar();
            this.pEuroDizel = new System.Windows.Forms.ProgressBar();
            this.pYeniProDizel = new System.Windows.Forms.ProgressBar();
            this.pGaz = new System.Windows.Forms.ProgressBar();
            this.lblPGaz = new System.Windows.Forms.Label();
            this.lblPYeniProDizel = new System.Windows.Forms.Label();
            this.lblPEuroDizel = new System.Windows.Forms.Label();
            this.lblPkursunsuz97 = new System.Windows.Forms.Label();
            this.lblPkursunsuz95 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.numerickursun95 = new System.Windows.Forms.NumericUpDown();
            this.numerickursun97 = new System.Windows.Forms.NumericUpDown();
            this.numericeurodizel = new System.Windows.Forms.NumericUpDown();
            this.numericprodizel = new System.Windows.Forms.NumericUpDown();
            this.numericgaz = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerickursun95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerickursun97)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericeurodizel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericprodizel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericgaz)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGaz);
            this.groupBox1.Controls.Add(this.lblProDizel);
            this.groupBox1.Controls.Add(this.lblEuroDizel);
            this.groupBox1.Controls.Add(this.lblkursunsuz97);
            this.groupBox1.Controls.Add(this.lblkursunsuz95);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yakıt Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(177, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Litre Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kurşunsuz 95:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kurşunsuz 97:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Euro Dizel10:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Yeni Pro Dizel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(96, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gaz:";
            // 
            // lblkursunsuz95
            // 
            this.lblkursunsuz95.AutoSize = true;
            this.lblkursunsuz95.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkursunsuz95.Location = new System.Drawing.Point(208, 103);
            this.lblkursunsuz95.Name = "lblkursunsuz95";
            this.lblkursunsuz95.Size = new System.Drawing.Size(30, 24);
            this.lblkursunsuz95.TabIndex = 7;
            this.lblkursunsuz95.Text = "00";
            // 
            // lblkursunsuz97
            // 
            this.lblkursunsuz97.AutoSize = true;
            this.lblkursunsuz97.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkursunsuz97.Location = new System.Drawing.Point(208, 145);
            this.lblkursunsuz97.Name = "lblkursunsuz97";
            this.lblkursunsuz97.Size = new System.Drawing.Size(30, 24);
            this.lblkursunsuz97.TabIndex = 8;
            this.lblkursunsuz97.Text = "00";
            // 
            // lblEuroDizel
            // 
            this.lblEuroDizel.AutoSize = true;
            this.lblEuroDizel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEuroDizel.Location = new System.Drawing.Point(208, 188);
            this.lblEuroDizel.Name = "lblEuroDizel";
            this.lblEuroDizel.Size = new System.Drawing.Size(30, 24);
            this.lblEuroDizel.TabIndex = 9;
            this.lblEuroDizel.Text = "00";
            // 
            // lblProDizel
            // 
            this.lblProDizel.AutoSize = true;
            this.lblProDizel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProDizel.Location = new System.Drawing.Point(208, 233);
            this.lblProDizel.Name = "lblProDizel";
            this.lblProDizel.Size = new System.Drawing.Size(30, 24);
            this.lblProDizel.TabIndex = 10;
            this.lblProDizel.Text = "00";
            // 
            // lblGaz
            // 
            this.lblGaz.AutoSize = true;
            this.lblGaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGaz.Location = new System.Drawing.Point(208, 276);
            this.lblGaz.Name = "lblGaz";
            this.lblGaz.Size = new System.Drawing.Size(30, 24);
            this.lblGaz.TabIndex = 11;
            this.lblGaz.Text = "00";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericgaz);
            this.groupBox2.Controls.Add(this.numericprodizel);
            this.groupBox2.Controls.Add(this.numericeurodizel);
            this.groupBox2.Controls.Add(this.numerickursun97);
            this.groupBox2.Controls.Add(this.numerickursun95);
            this.groupBox2.Controls.Add(this.btntDepoDoldur);
            this.groupBox2.Controls.Add(this.txtPlaka);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtGazfiyat);
            this.groupBox2.Controls.Add(this.txtyeniprodizelfiyat);
            this.groupBox2.Controls.Add(this.txteurodizel10fiyat);
            this.groupBox2.Controls.Add(this.txtkursunsuz97fiyat);
            this.groupBox2.Controls.Add(this.txtkursunsuz95fiyat);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(314, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 412);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(151, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fiyat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(24, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Litre";
            // 
            // txtGazfiyat
            // 
            this.txtGazfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGazfiyat.Location = new System.Drawing.Point(151, 269);
            this.txtGazfiyat.Name = "txtGazfiyat";
            this.txtGazfiyat.Size = new System.Drawing.Size(100, 29);
            this.txtGazfiyat.TabIndex = 23;
            // 
            // txtyeniprodizelfiyat
            // 
            this.txtyeniprodizelfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtyeniprodizelfiyat.Location = new System.Drawing.Point(151, 228);
            this.txtyeniprodizelfiyat.Name = "txtyeniprodizelfiyat";
            this.txtyeniprodizelfiyat.Size = new System.Drawing.Size(100, 29);
            this.txtyeniprodizelfiyat.TabIndex = 22;
            // 
            // txteurodizel10fiyat
            // 
            this.txteurodizel10fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txteurodizel10fiyat.Location = new System.Drawing.Point(151, 183);
            this.txteurodizel10fiyat.Name = "txteurodizel10fiyat";
            this.txteurodizel10fiyat.Size = new System.Drawing.Size(100, 29);
            this.txteurodizel10fiyat.TabIndex = 21;
            // 
            // txtkursunsuz97fiyat
            // 
            this.txtkursunsuz97fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkursunsuz97fiyat.Location = new System.Drawing.Point(151, 143);
            this.txtkursunsuz97fiyat.Name = "txtkursunsuz97fiyat";
            this.txtkursunsuz97fiyat.Size = new System.Drawing.Size(100, 29);
            this.txtkursunsuz97fiyat.TabIndex = 20;
            // 
            // txtkursunsuz95fiyat
            // 
            this.txtkursunsuz95fiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkursunsuz95fiyat.Location = new System.Drawing.Point(151, 98);
            this.txtkursunsuz95fiyat.Name = "txtkursunsuz95fiyat";
            this.txtkursunsuz95fiyat.Size = new System.Drawing.Size(100, 29);
            this.txtkursunsuz95fiyat.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(59, 321);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Plaka :";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPlaka.Location = new System.Drawing.Point(151, 316);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 29);
            this.txtPlaka.TabIndex = 24;
            // 
            // btntDepoDoldur
            // 
            this.btntDepoDoldur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntDepoDoldur.Location = new System.Drawing.Point(24, 367);
            this.btntDepoDoldur.Name = "btntDepoDoldur";
            this.btntDepoDoldur.Size = new System.Drawing.Size(227, 39);
            this.btntDepoDoldur.TabIndex = 25;
            this.btntDepoDoldur.Text = "Depoyu Doldur";
            this.btntDepoDoldur.UseVisualStyleBackColor = true;
            this.btntDepoDoldur.Click += new System.EventHandler(this.btntDepoDoldur_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblPGaz);
            this.groupBox3.Controls.Add(this.pGaz);
            this.groupBox3.Controls.Add(this.lblPYeniProDizel);
            this.groupBox3.Controls.Add(this.pYeniProDizel);
            this.groupBox3.Controls.Add(this.lblPEuroDizel);
            this.groupBox3.Controls.Add(this.lblPkursunsuz97);
            this.groupBox3.Controls.Add(this.pEuroDizel);
            this.groupBox3.Controls.Add(this.lblPkursunsuz95);
            this.groupBox3.Controls.Add(this.pkursunsuz97);
            this.groupBox3.Controls.Add(this.pkursunsuz95);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(631, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 317);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(25, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 24);
            this.label11.TabIndex = 26;
            this.label11.Text = "Depo Petrol Miktarı";
            // 
            // pkursunsuz95
            // 
            this.pkursunsuz95.Location = new System.Drawing.Point(29, 98);
            this.pkursunsuz95.Maximum = 10000;
            this.pkursunsuz95.Name = "pkursunsuz95";
            this.pkursunsuz95.Size = new System.Drawing.Size(248, 23);
            this.pkursunsuz95.TabIndex = 27;
            // 
            // pkursunsuz97
            // 
            this.pkursunsuz97.Location = new System.Drawing.Point(29, 145);
            this.pkursunsuz97.Maximum = 10000;
            this.pkursunsuz97.Name = "pkursunsuz97";
            this.pkursunsuz97.Size = new System.Drawing.Size(248, 23);
            this.pkursunsuz97.TabIndex = 28;
            // 
            // pEuroDizel
            // 
            this.pEuroDizel.Location = new System.Drawing.Point(29, 185);
            this.pEuroDizel.Maximum = 10000;
            this.pEuroDizel.Name = "pEuroDizel";
            this.pEuroDizel.Size = new System.Drawing.Size(248, 23);
            this.pEuroDizel.TabIndex = 29;
            // 
            // pYeniProDizel
            // 
            this.pYeniProDizel.Location = new System.Drawing.Point(29, 230);
            this.pYeniProDizel.Maximum = 10000;
            this.pYeniProDizel.Name = "pYeniProDizel";
            this.pYeniProDizel.Size = new System.Drawing.Size(248, 23);
            this.pYeniProDizel.TabIndex = 30;
            // 
            // pGaz
            // 
            this.pGaz.Location = new System.Drawing.Point(29, 271);
            this.pGaz.Maximum = 10000;
            this.pGaz.Name = "pGaz";
            this.pGaz.Size = new System.Drawing.Size(248, 23);
            this.pGaz.TabIndex = 31;
            // 
            // lblPGaz
            // 
            this.lblPGaz.AutoSize = true;
            this.lblPGaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPGaz.Location = new System.Drawing.Point(302, 271);
            this.lblPGaz.Name = "lblPGaz";
            this.lblPGaz.Size = new System.Drawing.Size(30, 24);
            this.lblPGaz.TabIndex = 16;
            this.lblPGaz.Text = "00";
            // 
            // lblPYeniProDizel
            // 
            this.lblPYeniProDizel.AutoSize = true;
            this.lblPYeniProDizel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPYeniProDizel.Location = new System.Drawing.Point(302, 228);
            this.lblPYeniProDizel.Name = "lblPYeniProDizel";
            this.lblPYeniProDizel.Size = new System.Drawing.Size(30, 24);
            this.lblPYeniProDizel.TabIndex = 15;
            this.lblPYeniProDizel.Text = "00";
            // 
            // lblPEuroDizel
            // 
            this.lblPEuroDizel.AutoSize = true;
            this.lblPEuroDizel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPEuroDizel.Location = new System.Drawing.Point(302, 183);
            this.lblPEuroDizel.Name = "lblPEuroDizel";
            this.lblPEuroDizel.Size = new System.Drawing.Size(30, 24);
            this.lblPEuroDizel.TabIndex = 14;
            this.lblPEuroDizel.Text = "00";
            // 
            // lblPkursunsuz97
            // 
            this.lblPkursunsuz97.AutoSize = true;
            this.lblPkursunsuz97.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPkursunsuz97.Location = new System.Drawing.Point(302, 140);
            this.lblPkursunsuz97.Name = "lblPkursunsuz97";
            this.lblPkursunsuz97.Size = new System.Drawing.Size(30, 24);
            this.lblPkursunsuz97.TabIndex = 13;
            this.lblPkursunsuz97.Text = "00";
            // 
            // lblPkursunsuz95
            // 
            this.lblPkursunsuz95.AutoSize = true;
            this.lblPkursunsuz95.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPkursunsuz95.Location = new System.Drawing.Point(302, 98);
            this.lblPkursunsuz95.Name = "lblPkursunsuz95";
            this.lblPkursunsuz95.Size = new System.Drawing.Size(30, 24);
            this.lblPkursunsuz95.TabIndex = 12;
            this.lblPkursunsuz95.Text = "00";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblKasa);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Location = new System.Drawing.Point(631, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(466, 86);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(25, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 24);
            this.label12.TabIndex = 32;
            this.label12.Text = "Kasa :";
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKasa.Location = new System.Drawing.Point(92, 41);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(30, 24);
            this.lblKasa.TabIndex = 33;
            this.lblKasa.Text = "00";
            // 
            // numerickursun95
            // 
            this.numerickursun95.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numerickursun95.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numerickursun95.Location = new System.Drawing.Point(6, 99);
            this.numerickursun95.Name = "numerickursun95";
            this.numerickursun95.Size = new System.Drawing.Size(120, 26);
            this.numerickursun95.TabIndex = 26;
            this.numerickursun95.ValueChanged += new System.EventHandler(this.numerickursun96_ValueChanged);
            // 
            // numerickursun97
            // 
            this.numerickursun97.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numerickursun97.Location = new System.Drawing.Point(4, 143);
            this.numerickursun97.Name = "numerickursun97";
            this.numerickursun97.Size = new System.Drawing.Size(120, 26);
            this.numerickursun97.TabIndex = 27;
            this.numerickursun97.ValueChanged += new System.EventHandler(this.numerickursun97_ValueChanged);
            // 
            // numericeurodizel
            // 
            this.numericeurodizel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericeurodizel.Location = new System.Drawing.Point(6, 187);
            this.numericeurodizel.Name = "numericeurodizel";
            this.numericeurodizel.Size = new System.Drawing.Size(120, 26);
            this.numericeurodizel.TabIndex = 28;
            this.numericeurodizel.ValueChanged += new System.EventHandler(this.numericeurodizel_ValueChanged);
            // 
            // numericprodizel
            // 
            this.numericprodizel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericprodizel.Location = new System.Drawing.Point(6, 230);
            this.numericprodizel.Name = "numericprodizel";
            this.numericprodizel.Size = new System.Drawing.Size(120, 26);
            this.numericprodizel.TabIndex = 29;
            this.numericprodizel.ValueChanged += new System.EventHandler(this.numericprodizel_ValueChanged);
            // 
            // numericgaz
            // 
            this.numericgaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericgaz.Location = new System.Drawing.Point(6, 269);
            this.numericgaz.Name = "numericgaz";
            this.numericgaz.Size = new System.Drawing.Size(120, 26);
            this.numericgaz.TabIndex = 30;
            this.numericgaz.ValueChanged += new System.EventHandler(this.numericgaz_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerickursun95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerickursun97)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericeurodizel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericprodizel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericgaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGaz;
        private System.Windows.Forms.Label lblProDizel;
        private System.Windows.Forms.Label lblEuroDizel;
        private System.Windows.Forms.Label lblkursunsuz97;
        private System.Windows.Forms.Label lblkursunsuz95;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntDepoDoldur;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGazfiyat;
        private System.Windows.Forms.TextBox txtyeniprodizelfiyat;
        private System.Windows.Forms.TextBox txteurodizel10fiyat;
        private System.Windows.Forms.TextBox txtkursunsuz97fiyat;
        private System.Windows.Forms.TextBox txtkursunsuz95fiyat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPGaz;
        private System.Windows.Forms.ProgressBar pGaz;
        private System.Windows.Forms.Label lblPYeniProDizel;
        private System.Windows.Forms.ProgressBar pYeniProDizel;
        private System.Windows.Forms.Label lblPEuroDizel;
        private System.Windows.Forms.Label lblPkursunsuz97;
        private System.Windows.Forms.ProgressBar pEuroDizel;
        private System.Windows.Forms.Label lblPkursunsuz95;
        private System.Windows.Forms.ProgressBar pkursunsuz97;
        private System.Windows.Forms.ProgressBar pkursunsuz95;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericgaz;
        private System.Windows.Forms.NumericUpDown numericprodizel;
        private System.Windows.Forms.NumericUpDown numericeurodizel;
        private System.Windows.Forms.NumericUpDown numerickursun97;
        private System.Windows.Forms.NumericUpDown numerickursun95;
    }
}

