
namespace LR_6
{
    partial class Supermarket
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.listBoxQueue = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCountServed = new System.Windows.Forms.Label();
            this.labelVisitorFirstCash = new System.Windows.Forms.Label();
            this.labelVisitorSecondCash = new System.Windows.Forms.Label();
            this.labelVisitorThirdCash = new System.Windows.Forms.Label();
            this.labelCountQueue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.labelWorkTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LR_6.Properties.Resources.kassir;
            this.pictureBox1.Location = new System.Drawing.Point(35, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LR_6.Properties.Resources.kassir;
            this.pictureBox2.Location = new System.Drawing.Point(316, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 108);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LR_6.Properties.Resources.kassir;
            this.pictureBox3.Location = new System.Drawing.Point(612, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 108);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // listBoxQueue
            // 
            this.listBoxQueue.FormattingEnabled = true;
            this.listBoxQueue.Location = new System.Drawing.Point(298, 200);
            this.listBoxQueue.Name = "listBoxQueue";
            this.listBoxQueue.Size = new System.Drawing.Size(186, 225);
            this.listBoxQueue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(294, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "В очереди: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(621, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Всего обслужено:";
            // 
            // labelCountServed
            // 
            this.labelCountServed.AutoSize = true;
            this.labelCountServed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountServed.Location = new System.Drawing.Point(754, 406);
            this.labelCountServed.Name = "labelCountServed";
            this.labelCountServed.Size = new System.Drawing.Size(17, 19);
            this.labelCountServed.TabIndex = 6;
            this.labelCountServed.Text = "0";
            // 
            // labelVisitorFirstCash
            // 
            this.labelVisitorFirstCash.AutoSize = true;
            this.labelVisitorFirstCash.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVisitorFirstCash.Location = new System.Drawing.Point(31, 143);
            this.labelVisitorFirstCash.Name = "labelVisitorFirstCash";
            this.labelVisitorFirstCash.Size = new System.Drawing.Size(104, 23);
            this.labelVisitorFirstCash.TabIndex = 7;
            this.labelVisitorFirstCash.Text = "Свободно ";
            this.labelVisitorFirstCash.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelVisitorSecondCash
            // 
            this.labelVisitorSecondCash.AutoSize = true;
            this.labelVisitorSecondCash.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVisitorSecondCash.Location = new System.Drawing.Point(312, 143);
            this.labelVisitorSecondCash.Name = "labelVisitorSecondCash";
            this.labelVisitorSecondCash.Size = new System.Drawing.Size(99, 23);
            this.labelVisitorSecondCash.TabIndex = 8;
            this.labelVisitorSecondCash.Text = "Свободно";
            this.labelVisitorSecondCash.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelVisitorThirdCash
            // 
            this.labelVisitorThirdCash.AutoSize = true;
            this.labelVisitorThirdCash.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVisitorThirdCash.Location = new System.Drawing.Point(608, 143);
            this.labelVisitorThirdCash.Name = "labelVisitorThirdCash";
            this.labelVisitorThirdCash.Size = new System.Drawing.Size(99, 23);
            this.labelVisitorThirdCash.TabIndex = 9;
            this.labelVisitorThirdCash.Text = "Свободно";
            // 
            // labelCountQueue
            // 
            this.labelCountQueue.AutoSize = true;
            this.labelCountQueue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountQueue.Location = new System.Drawing.Point(376, 178);
            this.labelCountQueue.Name = "labelCountQueue";
            this.labelCountQueue.Size = new System.Drawing.Size(17, 19);
            this.labelCountQueue.TabIndex = 10;
            this.labelCountQueue.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(621, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Время работы:";
            // 
            // labelWorkTime
            // 
            this.labelWorkTime.AutoSize = true;
            this.labelWorkTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWorkTime.Location = new System.Drawing.Point(754, 380);
            this.labelWorkTime.Name = "labelWorkTime";
            this.labelWorkTime.Size = new System.Drawing.Size(44, 19);
            this.labelWorkTime.TabIndex = 12;
            this.labelWorkTime.Text = "00:00";
            // 
            // Supermarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 437);
            this.Controls.Add(this.labelWorkTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCountQueue);
            this.Controls.Add(this.labelVisitorThirdCash);
            this.Controls.Add(this.labelVisitorSecondCash);
            this.Controls.Add(this.labelVisitorFirstCash);
            this.Controls.Add(this.labelCountServed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxQueue);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(827, 476);
            this.MinimumSize = new System.Drawing.Size(827, 476);
            this.Name = "Supermarket";
            this.Text = "Модель супермаркета";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Supermarket_FormClosed);
            this.Load += new System.EventHandler(this.Supermarket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListBox listBoxQueue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCountServed;
        private System.Windows.Forms.Label labelVisitorFirstCash;
        private System.Windows.Forms.Label labelVisitorSecondCash;
        private System.Windows.Forms.Label labelVisitorThirdCash;
        private System.Windows.Forms.Label labelCountQueue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWorkTime;
    }
}

