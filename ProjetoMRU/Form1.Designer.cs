
namespace ProjetoMRU
{
    partial class Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.MS = new System.Windows.Forms.RadioButton();
            this.kmH = new System.Windows.Forms.RadioButton();
            this.spaceIni = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.NumericUpDown();
            this.vel = new System.Windows.Forms.NumericUpDown();
            this.btnNewCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.resultTitle = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.showSpaceTipe = new System.Windows.Forms.Label();
            this.showTimeTipe = new System.Windows.Forms.Label();
            this.showVelTipe = new System.Windows.Forms.Label();
            this.btnAutoCalc = new System.Windows.Forms.CheckBox();
            this.showInfo = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.spaceIni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).BeginInit();
            this.SuspendLayout();
            // 
            // MS
            // 
            this.MS.AutoSize = true;
            this.MS.BackColor = System.Drawing.Color.Transparent;
            this.MS.Checked = true;
            this.MS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.MS.Location = new System.Drawing.Point(12, 12);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(54, 23);
            this.MS.TabIndex = 10;
            this.MS.TabStop = true;
            this.MS.Text = "m/s";
            this.MS.UseVisualStyleBackColor = false;
            this.MS.CheckedChanged += new System.EventHandler(this.MS_CheckedChanged);
            // 
            // kmH
            // 
            this.kmH.AutoSize = true;
            this.kmH.BackColor = System.Drawing.Color.Transparent;
            this.kmH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.kmH.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.kmH.Location = new System.Drawing.Point(72, 12);
            this.kmH.Name = "kmH";
            this.kmH.Size = new System.Drawing.Size(67, 23);
            this.kmH.TabIndex = 10;
            this.kmH.Text = "Km/h";
            this.kmH.UseVisualStyleBackColor = false;
            this.kmH.CheckedChanged += new System.EventHandler(this.kmH_CheckedChanged);
            // 
            // spaceIni
            // 
            this.spaceIni.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.spaceIni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spaceIni.Font = new System.Drawing.Font("Arial", 12F);
            this.spaceIni.Location = new System.Drawing.Point(141, 66);
            this.spaceIni.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.spaceIni.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.spaceIni.Name = "spaceIni";
            this.spaceIni.Size = new System.Drawing.Size(127, 26);
            this.spaceIni.TabIndex = 0;
            this.spaceIni.ValueChanged += new System.EventHandler(this.spaceIni_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Espaço Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tempo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Velocidade:";
            // 
            // time
            // 
            this.time.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.time.Font = new System.Drawing.Font("Arial", 12F);
            this.time.Location = new System.Drawing.Point(141, 158);
            this.time.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(127, 26);
            this.time.TabIndex = 3;
            this.time.ValueChanged += new System.EventHandler(this.time_ValueChanged);
            // 
            // vel
            // 
            this.vel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.vel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vel.Font = new System.Drawing.Font("Arial", 12F);
            this.vel.Location = new System.Drawing.Point(141, 111);
            this.vel.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.vel.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.vel.Name = "vel";
            this.vel.Size = new System.Drawing.Size(127, 26);
            this.vel.TabIndex = 1;
            this.vel.ValueChanged += new System.EventHandler(this.vel_ValueChanged);
            // 
            // btnNewCalc
            // 
            this.btnNewCalc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCalc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCalc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewCalc.Location = new System.Drawing.Point(12, 401);
            this.btnNewCalc.Name = "btnNewCalc";
            this.btnNewCalc.Size = new System.Drawing.Size(89, 37);
            this.btnNewCalc.TabIndex = 5;
            this.btnNewCalc.Text = "Novo";
            this.btnNewCalc.UseVisualStyleBackColor = false;
            this.btnNewCalc.Click += new System.EventHandler(this.newCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(699, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 37);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalc.Location = new System.Drawing.Point(18, 201);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(250, 43);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.calc_Click);
            // 
            // resultTitle
            // 
            this.resultTitle.AutoSize = true;
            this.resultTitle.BackColor = System.Drawing.Color.Transparent;
            this.resultTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTitle.Location = new System.Drawing.Point(423, 60);
            this.resultTitle.Name = "resultTitle";
            this.resultTitle.Size = new System.Drawing.Size(136, 29);
            this.resultTitle.TabIndex = 13;
            this.resultTitle.Text = "Resultado:";
            this.resultTitle.Visible = false;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.Azure;
            this.result.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.Color.Black;
            this.result.Location = new System.Drawing.Point(424, 98);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 22);
            this.result.TabIndex = 14;
            // 
            // showSpaceTipe
            // 
            this.showSpaceTipe.AutoSize = true;
            this.showSpaceTipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSpaceTipe.Location = new System.Drawing.Point(275, 71);
            this.showSpaceTipe.Name = "showSpaceTipe";
            this.showSpaceTipe.Size = new System.Drawing.Size(45, 13);
            this.showSpaceTipe.TabIndex = 15;
            this.showSpaceTipe.Text = "Metros";
            // 
            // showTimeTipe
            // 
            this.showTimeTipe.AutoSize = true;
            this.showTimeTipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTimeTipe.Location = new System.Drawing.Point(275, 163);
            this.showTimeTipe.Name = "showTimeTipe";
            this.showTimeTipe.Size = new System.Drawing.Size(63, 13);
            this.showTimeTipe.TabIndex = 16;
            this.showTimeTipe.Text = "Segundos";
            // 
            // showVelTipe
            // 
            this.showVelTipe.AutoSize = true;
            this.showVelTipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showVelTipe.Location = new System.Drawing.Point(275, 116);
            this.showVelTipe.Name = "showVelTipe";
            this.showVelTipe.Size = new System.Drawing.Size(121, 13);
            this.showVelTipe.TabIndex = 17;
            this.showVelTipe.Text = "Metros por Segundo";
            // 
            // btnAutoCalc
            // 
            this.btnAutoCalc.AutoSize = true;
            this.btnAutoCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutoCalc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoCalc.Location = new System.Drawing.Point(18, 250);
            this.btnAutoCalc.Name = "btnAutoCalc";
            this.btnAutoCalc.Size = new System.Drawing.Size(113, 20);
            this.btnAutoCalc.TabIndex = 12;
            this.btnAutoCalc.Text = "Auto Calcular";
            this.btnAutoCalc.UseVisualStyleBackColor = true;
            // 
            // showInfo
            // 
            this.showInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showInfo.BackgroundImage")));
            this.showInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showInfo.Location = new System.Drawing.Point(739, 12);
            this.showInfo.Name = "showInfo";
            this.showInfo.Size = new System.Drawing.Size(49, 49);
            this.showInfo.TabIndex = 19;
            this.showInfo.TabStop = false;
            this.showInfo.Click += new System.EventHandler(this.showInfo_Click);
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("info.BackgroundImage")));
            this.info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.Location = new System.Drawing.Point(425, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(363, 224);
            this.info.TabIndex = 20;
            this.info.TabStop = false;
            this.info.Visible = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.info);
            this.Controls.Add(this.showInfo);
            this.Controls.Add(this.btnAutoCalc);
            this.Controls.Add(this.showVelTipe);
            this.Controls.Add(this.showTimeTipe);
            this.Controls.Add(this.showSpaceTipe);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultTitle);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewCalc);
            this.Controls.Add(this.vel);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spaceIni);
            this.Controls.Add(this.kmH);
            this.Controls.Add(this.MS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo do MRU";
            this.TransparencyKey = System.Drawing.Color.DarkRed;
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spaceIni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.time)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton MS;
        private System.Windows.Forms.RadioButton kmH;
        public System.Windows.Forms.NumericUpDown spaceIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown time;
        public System.Windows.Forms.NumericUpDown vel;
        private System.Windows.Forms.Button btnNewCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label resultTitle;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label showSpaceTipe;
        private System.Windows.Forms.Label showTimeTipe;
        private System.Windows.Forms.Label showVelTipe;
        private System.Windows.Forms.CheckBox btnAutoCalc;
        private System.Windows.Forms.PictureBox showInfo;
        private System.Windows.Forms.PictureBox info;
    }
}

