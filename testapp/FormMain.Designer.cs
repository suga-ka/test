namespace testapp
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Latitude = new System.Windows.Forms.Label();
            this.Lbl_Longitude = new System.Windows.Forms.Label();
            this.Tbx_In = new System.Windows.Forms.TextBox();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Tbx_out = new System.Windows.Forms.TextBox();
            this.Btn_Sort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "緯度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "経度";
            // 
            // Lbl_Latitude
            // 
            this.Lbl_Latitude.AutoSize = true;
            this.Lbl_Latitude.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Latitude.Location = new System.Drawing.Point(82, 31);
            this.Lbl_Latitude.Name = "Lbl_Latitude";
            this.Lbl_Latitude.Size = new System.Drawing.Size(72, 20);
            this.Lbl_Latitude.TabIndex = 2;
            this.Lbl_Latitude.Text = "Latitude";
            // 
            // Lbl_Longitude
            // 
            this.Lbl_Longitude.AutoSize = true;
            this.Lbl_Longitude.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Lbl_Longitude.Location = new System.Drawing.Point(82, 82);
            this.Lbl_Longitude.Name = "Lbl_Longitude";
            this.Lbl_Longitude.Size = new System.Drawing.Size(87, 20);
            this.Lbl_Longitude.TabIndex = 3;
            this.Lbl_Longitude.Text = "Longitude";
            // 
            // Tbx_In
            // 
            this.Tbx_In.Location = new System.Drawing.Point(449, 100);
            this.Tbx_In.Multiline = true;
            this.Tbx_In.Name = "Tbx_In";
            this.Tbx_In.Size = new System.Drawing.Size(100, 281);
            this.Tbx_In.TabIndex = 4;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(208, 61);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(75, 23);
            this.Btn_Save.TabIndex = 5;
            this.Btn_Save.Text = "保存";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Tbx_out
            // 
            this.Tbx_out.Location = new System.Drawing.Point(735, 100);
            this.Tbx_out.Multiline = true;
            this.Tbx_out.Name = "Tbx_out";
            this.Tbx_out.Size = new System.Drawing.Size(100, 281);
            this.Tbx_out.TabIndex = 6;
            // 
            // Btn_Sort
            // 
            this.Btn_Sort.Location = new System.Drawing.Point(604, 221);
            this.Btn_Sort.Name = "Btn_Sort";
            this.Btn_Sort.Size = new System.Drawing.Size(75, 23);
            this.Btn_Sort.TabIndex = 7;
            this.Btn_Sort.Text = "並べ替え";
            this.Btn_Sort.UseVisualStyleBackColor = true;
            this.Btn_Sort.Click += new System.EventHandler(this.Btn_Sort_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 590);
            this.Controls.Add(this.Btn_Sort);
            this.Controls.Add(this.Tbx_out);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Tbx_In);
            this.Controls.Add(this.Lbl_Longitude);
            this.Controls.Add(this.Lbl_Latitude);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Latitude;
        private System.Windows.Forms.Label Lbl_Longitude;
        private System.Windows.Forms.TextBox Tbx_In;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox Tbx_out;
        private System.Windows.Forms.Button Btn_Sort;
    }
}

