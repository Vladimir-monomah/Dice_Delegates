namespace Делегаты_на_кубиках
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textDices = new System.Windows.Forms.TextBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.box1 = new System.Windows.Forms.PictureBox();
            this.box2 = new System.Windows.Forms.PictureBox();
            this.buttonGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).BeginInit();
            this.SuspendLayout();
            // 
            // textDices
            // 
            this.textDices.Location = new System.Drawing.Point(68, 62);
            this.textDices.Name = "textDices";
            this.textDices.ReadOnly = true;
            this.textDices.Size = new System.Drawing.Size(186, 22);
            this.textDices.TabIndex = 0;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(65, 112);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(46, 17);
            this.labelSum.TabIndex = 1;
            this.labelSum.Text = "label1";
            // 
            // box1
            // 
            this.box1.Location = new System.Drawing.Point(68, 158);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(90, 79);
            this.box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box1.TabIndex = 2;
            this.box1.TabStop = false;
            // 
            // box2
            // 
            this.box2.Location = new System.Drawing.Point(164, 158);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(90, 79);
            this.box2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box2.TabIndex = 3;
            this.box2.TabStop = false;
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGo.Location = new System.Drawing.Point(364, 62);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(145, 175);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Бросить кубики";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 363);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.textDices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Игральные кубики";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.box2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDices;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.PictureBox box1;
        private System.Windows.Forms.PictureBox box2;
        private System.Windows.Forms.Button buttonGo;
    }
}

