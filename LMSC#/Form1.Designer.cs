namespace LMSC_
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
            this.tbSqad = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.dataGridViewCycle = new System.Windows.Forms.DataGridView();
            this.tbBeanch = new System.Windows.Forms.TextBox();
            this.tbDeadlift = new System.Windows.Forms.TextBox();
            this.lblSquat = new System.Windows.Forms.Label();
            this.lblBeanch = new System.Windows.Forms.Label();
            this.lblDeadlift = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCycle)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSqad
            // 
            this.tbSqad.Location = new System.Drawing.Point(476, 66);
            this.tbSqad.Name = "tbSqad";
            this.tbSqad.Size = new System.Drawing.Size(111, 22);
            this.tbSqad.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(476, 249);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(111, 50);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Расчитать Цикл";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // dataGridViewCycle
            // 
            this.dataGridViewCycle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCycle.Location = new System.Drawing.Point(36, 66);
            this.dataGridViewCycle.Name = "dataGridViewCycle";
            this.dataGridViewCycle.RowHeadersWidth = 51;
            this.dataGridViewCycle.RowTemplate.Height = 24;
            this.dataGridViewCycle.Size = new System.Drawing.Size(402, 297);
            this.dataGridViewCycle.TabIndex = 3;
            // 
            // tbBeanch
            // 
            this.tbBeanch.Location = new System.Drawing.Point(476, 118);
            this.tbBeanch.Name = "tbBeanch";
            this.tbBeanch.Size = new System.Drawing.Size(111, 22);
            this.tbBeanch.TabIndex = 1;
            // 
            // tbDeadlift
            // 
            this.tbDeadlift.Location = new System.Drawing.Point(476, 161);
            this.tbDeadlift.Name = "tbDeadlift";
            this.tbDeadlift.Size = new System.Drawing.Size(111, 22);
            this.tbDeadlift.TabIndex = 1;
            // 
            // lblSquat
            // 
            this.lblSquat.AutoSize = true;
            this.lblSquat.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquat.Location = new System.Drawing.Point(620, 72);
            this.lblSquat.Name = "lblSquat";
            this.lblSquat.Size = new System.Drawing.Size(62, 16);
            this.lblSquat.TabIndex = 4;
            this.lblSquat.Text = "Присед";
            // 
            // lblBeanch
            // 
            this.lblBeanch.AutoSize = true;
            this.lblBeanch.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeanch.Location = new System.Drawing.Point(620, 124);
            this.lblBeanch.Name = "lblBeanch";
            this.lblBeanch.Size = new System.Drawing.Size(40, 16);
            this.lblBeanch.TabIndex = 4;
            this.lblBeanch.Text = "Жим";
            // 
            // lblDeadlift
            // 
            this.lblDeadlift.AutoSize = true;
            this.lblDeadlift.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadlift.Location = new System.Drawing.Point(620, 167);
            this.lblDeadlift.Name = "lblDeadlift";
            this.lblDeadlift.Size = new System.Drawing.Size(114, 16);
            this.lblDeadlift.TabIndex = 4;
            this.lblDeadlift.Text = "Становая тяга";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDeadlift);
            this.Controls.Add(this.lblBeanch);
            this.Controls.Add(this.lblSquat);
            this.Controls.Add(this.dataGridViewCycle);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbDeadlift);
            this.Controls.Add(this.tbBeanch);
            this.Controls.Add(this.tbSqad);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCycle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSqad;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataGridView dataGridViewCycle;
        private System.Windows.Forms.TextBox tbBeanch;
        private System.Windows.Forms.TextBox tbDeadlift;
        private System.Windows.Forms.Label lblSquat;
        private System.Windows.Forms.Label lblBeanch;
        private System.Windows.Forms.Label lblDeadlift;
    }
}

