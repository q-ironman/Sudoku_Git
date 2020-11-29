
namespace Sudoku_Git
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
            this.checkButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.beginnerLevel = new System.Windows.Forms.RadioButton();
            this.intermediateLevel = new System.Windows.Forms.RadioButton();
            this.advancedLevel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkButton.Location = new System.Drawing.Point(566, 68);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(141, 50);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Check Input";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clearButton.Location = new System.Drawing.Point(566, 133);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(141, 38);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear Input";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // beginnerLevel
            // 
            this.beginnerLevel.AutoSize = true;
            this.beginnerLevel.Location = new System.Drawing.Point(566, 238);
            this.beginnerLevel.Name = "beginnerLevel";
            this.beginnerLevel.Size = new System.Drawing.Size(67, 17);
            this.beginnerLevel.TabIndex = 2;
            this.beginnerLevel.TabStop = true;
            this.beginnerLevel.Text = "Beginner";
            this.beginnerLevel.UseVisualStyleBackColor = true;
            // 
            // intermediateLevel
            // 
            this.intermediateLevel.AutoSize = true;
            this.intermediateLevel.Location = new System.Drawing.Point(566, 261);
            this.intermediateLevel.Name = "intermediateLevel";
            this.intermediateLevel.Size = new System.Drawing.Size(83, 17);
            this.intermediateLevel.TabIndex = 3;
            this.intermediateLevel.TabStop = true;
            this.intermediateLevel.Text = "Intermediate";
            this.intermediateLevel.UseVisualStyleBackColor = true;
            // 
            // advancedLevel
            // 
            this.advancedLevel.AutoSize = true;
            this.advancedLevel.Location = new System.Drawing.Point(566, 284);
            this.advancedLevel.Name = "advancedLevel";
            this.advancedLevel.Size = new System.Drawing.Size(74, 17);
            this.advancedLevel.TabIndex = 4;
            this.advancedLevel.TabStop = true;
            this.advancedLevel.Text = "Advanced";
            this.advancedLevel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(563, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Level";
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newGameButton.Location = new System.Drawing.Point(566, 307);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(141, 39);
            this.newGameButton.TabIndex = 6;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 278);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.advancedLevel);
            this.Controls.Add(this.intermediateLevel);
            this.Controls.Add(this.beginnerLevel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkButton);
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton beginnerLevel;
        private System.Windows.Forms.RadioButton intermediateLevel;
        private System.Windows.Forms.RadioButton advancedLevel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Panel panel1;
    }
}

