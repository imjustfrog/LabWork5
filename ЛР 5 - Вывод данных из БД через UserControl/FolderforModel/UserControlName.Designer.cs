namespace ЛР_5___Вывод_данных_из_БД_через_UserControl.FolderforModel
{
    partial class UserControlName
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMotorbike = new System.Windows.Forms.PictureBox();
            this.labelIDData = new System.Windows.Forms.Label();
            this.labelModelData = new System.Windows.Forms.Label();
            this.labelBrandData = new System.Windows.Forms.Label();
            this.labelPriceData = new System.Windows.Forms.Label();
            this.labelHorsepowerData = new System.Windows.Forms.Label();
            this.labelMileageData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorbike)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 143);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID\r\n\r\nМодель\r\n\r\nМарка \r\n\r\nЦена\r\n\r\nЛ/С\r\n\r\nПробег\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBoxMotorbike
            // 
            this.pictureBoxMotorbike.Location = new System.Drawing.Point(44, 15);
            this.pictureBoxMotorbike.Name = "pictureBoxMotorbike";
            this.pictureBoxMotorbike.Size = new System.Drawing.Size(199, 118);
            this.pictureBoxMotorbike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMotorbike.TabIndex = 1;
            this.pictureBoxMotorbike.TabStop = false;
            // 
            // labelIDData
            // 
            this.labelIDData.AutoSize = true;
            this.labelIDData.Location = new System.Drawing.Point(154, 154);
            this.labelIDData.Name = "labelIDData";
            this.labelIDData.Size = new System.Drawing.Size(63, 13);
            this.labelIDData.TabIndex = 2;
            this.labelIDData.Text = "labelIDData";
            // 
            // labelModelData
            // 
            this.labelModelData.AutoSize = true;
            this.labelModelData.Location = new System.Drawing.Point(154, 181);
            this.labelModelData.Name = "labelModelData";
            this.labelModelData.Size = new System.Drawing.Size(81, 13);
            this.labelModelData.TabIndex = 3;
            this.labelModelData.Text = "labelModelData";
            // 
            // labelBrandData
            // 
            this.labelBrandData.AutoSize = true;
            this.labelBrandData.Location = new System.Drawing.Point(154, 207);
            this.labelBrandData.Name = "labelBrandData";
            this.labelBrandData.Size = new System.Drawing.Size(80, 13);
            this.labelBrandData.TabIndex = 4;
            this.labelBrandData.Text = "labelBrandData";
            // 
            // labelPriceData
            // 
            this.labelPriceData.AutoSize = true;
            this.labelPriceData.Location = new System.Drawing.Point(154, 232);
            this.labelPriceData.Name = "labelPriceData";
            this.labelPriceData.Size = new System.Drawing.Size(76, 13);
            this.labelPriceData.TabIndex = 5;
            this.labelPriceData.Text = "labelPriceData";
            // 
            // labelHorsepowerData
            // 
            this.labelHorsepowerData.AutoSize = true;
            this.labelHorsepowerData.Location = new System.Drawing.Point(154, 258);
            this.labelHorsepowerData.Name = "labelHorsepowerData";
            this.labelHorsepowerData.Size = new System.Drawing.Size(109, 13);
            this.labelHorsepowerData.TabIndex = 6;
            this.labelHorsepowerData.Text = "labelHorsepowerData";
            // 
            // labelMileageData
            // 
            this.labelMileageData.AutoSize = true;
            this.labelMileageData.Location = new System.Drawing.Point(154, 284);
            this.labelMileageData.Name = "labelMileageData";
            this.labelMileageData.Size = new System.Drawing.Size(89, 13);
            this.labelMileageData.TabIndex = 7;
            this.labelMileageData.Text = "labelMileageData";
            // 
            // UserControlName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelMileageData);
            this.Controls.Add(this.labelHorsepowerData);
            this.Controls.Add(this.labelPriceData);
            this.Controls.Add(this.labelBrandData);
            this.Controls.Add(this.labelModelData);
            this.Controls.Add(this.labelIDData);
            this.Controls.Add(this.pictureBoxMotorbike);
            this.Controls.Add(this.label1);
            this.Name = "UserControlName";
            this.Size = new System.Drawing.Size(290, 396);
            this.Load += new System.EventHandler(this.UserControlName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorbike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxMotorbike;
        private System.Windows.Forms.Label labelIDData;
        private System.Windows.Forms.Label labelModelData;
        private System.Windows.Forms.Label labelBrandData;
        private System.Windows.Forms.Label labelPriceData;
        private System.Windows.Forms.Label labelHorsepowerData;
        private System.Windows.Forms.Label labelMileageData;
    }
}
