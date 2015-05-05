namespace MyOTPGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox_keyuri = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_gen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label_code = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer_gen = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBox_keyuri
            // 
            this.textBox_keyuri.Location = new System.Drawing.Point(12, 27);
            this.textBox_keyuri.Name = "textBox_keyuri";
            this.textBox_keyuri.Size = new System.Drawing.Size(358, 21);
            this.textBox_keyuri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Key URI";
            // 
            // button_gen
            // 
            this.button_gen.Location = new System.Drawing.Point(12, 54);
            this.button_gen.Name = "button_gen";
            this.button_gen.Size = new System.Drawing.Size(358, 23);
            this.button_gen.TabIndex = 2;
            this.button_gen.Text = "生成";
            this.button_gen.UseVisualStyleBackColor = true;
            this.button_gen.Click += new System.EventHandler(this.button_gen_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 2);
            this.label2.TabIndex = 3;
            // 
            // label_code
            // 
            this.label_code.Font = new System.Drawing.Font("MS UI Gothic", 42.16216F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_code.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_code.Location = new System.Drawing.Point(12, 93);
            this.label_code.Name = "label_code";
            this.label_code.Size = new System.Drawing.Size(355, 84);
            this.label_code.TabIndex = 4;
            this.label_code.Text = "000 000";
            this.label_code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "次の生成まで";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Font = new System.Drawing.Font("MS UI Gothic", 16.21622F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_count.Location = new System.Drawing.Point(296, 204);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(40, 26);
            this.label_count.TabIndex = 6;
            this.label_count.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "秒";
            // 
            // timer_gen
            // 
            this.timer_gen.Interval = 1000;
            this.timer_gen.Tick += new System.EventHandler(this.timer_gen_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 237);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_gen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_keyuri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MyOTPGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_keyuri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_gen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer_gen;
    }
}

