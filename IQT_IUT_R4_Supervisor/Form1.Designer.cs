
namespace IQT_IUT_R4_Supervisor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.com_num = new System.Windows.Forms.ComboBox();
            this.SR_button = new System.Windows.Forms.Button();
            this.SW_button = new System.Windows.Forms.Button();
            this.Parameter = new System.Windows.Forms.ComboBox();
            this.read_parameter_button = new System.Windows.Forms.Button();
            this.write_parameter_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.wordnum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.Hex_select = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.user_read_data = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.user_write_data = new System.Windows.Forms.TextBox();
            this.QU_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EW_button = new System.Windows.Forms.Button();
            this.ER_button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.paramete_inout = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EPC_read_data = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EPC_write_data = new System.Windows.Forms.TextBox();
            this.EPC_QU_button = new System.Windows.Forms.Button();
            this.ES_button = new System.Windows.Forms.Button();
            this.SP_button = new System.Windows.Forms.Button();
            this.SS_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.receive_data = new System.Windows.Forms.TextBox();
            this.send_data = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_num
            // 
            this.com_num.FormattingEnabled = true;
            this.com_num.Location = new System.Drawing.Point(24, 26);
            this.com_num.Name = "com_num";
            this.com_num.Size = new System.Drawing.Size(145, 24);
            this.com_num.TabIndex = 1;
            // 
            // SR_button
            // 
            this.SR_button.Enabled = false;
            this.SR_button.Location = new System.Drawing.Point(11, 180);
            this.SR_button.Name = "SR_button";
            this.SR_button.Size = new System.Drawing.Size(152, 29);
            this.SR_button.TabIndex = 3;
            this.SR_button.Text = "单次读SR";
            this.SR_button.UseVisualStyleBackColor = true;
            this.SR_button.Click += new System.EventHandler(this.SR_button_Click);
            // 
            // SW_button
            // 
            this.SW_button.Enabled = false;
            this.SW_button.Location = new System.Drawing.Point(172, 182);
            this.SW_button.Name = "SW_button";
            this.SW_button.Size = new System.Drawing.Size(152, 29);
            this.SW_button.TabIndex = 4;
            this.SW_button.Text = "单次写SW";
            this.SW_button.UseVisualStyleBackColor = true;
            this.SW_button.Click += new System.EventHandler(this.SW_button_Click);
            // 
            // Parameter
            // 
            this.Parameter.FormattingEnabled = true;
            this.Parameter.Location = new System.Drawing.Point(6, 26);
            this.Parameter.Name = "Parameter";
            this.Parameter.Size = new System.Drawing.Size(74, 24);
            this.Parameter.TabIndex = 5;
            // 
            // read_parameter_button
            // 
            this.read_parameter_button.Enabled = false;
            this.read_parameter_button.Location = new System.Drawing.Point(86, 21);
            this.read_parameter_button.Name = "read_parameter_button";
            this.read_parameter_button.Size = new System.Drawing.Size(81, 29);
            this.read_parameter_button.TabIndex = 6;
            this.read_parameter_button.Text = "读取";
            this.read_parameter_button.UseVisualStyleBackColor = true;
            this.read_parameter_button.Click += new System.EventHandler(this.read_parameter_button_Click);
            // 
            // write_parameter_button
            // 
            this.write_parameter_button.Enabled = false;
            this.write_parameter_button.Location = new System.Drawing.Point(172, 21);
            this.write_parameter_button.Name = "write_parameter_button";
            this.write_parameter_button.Size = new System.Drawing.Size(81, 29);
            this.write_parameter_button.TabIndex = 7;
            this.write_parameter_button.Text = "写入";
            this.write_parameter_button.UseVisualStyleBackColor = true;
            this.write_parameter_button.Click += new System.EventHandler(this.write_parameter_button_Click);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(183, 23);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(70, 29);
            this.connect_button.TabIndex = 9;
            this.connect_button.Text = "连接";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(81, 149);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(82, 22);
            this.address.TabIndex = 10;
            this.address.Text = "0000";
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wordnum
            // 
            this.wordnum.Location = new System.Drawing.Point(217, 149);
            this.wordnum.Name = "wordnum";
            this.wordnum.Size = new System.Drawing.Size(39, 22);
            this.wordnum.TabIndex = 11;
            this.wordnum.Text = "01";
            this.wordnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disconnect_button);
            this.groupBox1.Controls.Add(this.connect_button);
            this.groupBox1.Controls.Add(this.com_num);
            this.groupBox1.Location = new System.Drawing.Point(30, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 66);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口";
            // 
            // disconnect_button
            // 
            this.disconnect_button.Location = new System.Drawing.Point(254, 23);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(70, 29);
            this.disconnect_button.TabIndex = 10;
            this.disconnect_button.Text = "断开";
            this.disconnect_button.UseVisualStyleBackColor = true;
            this.disconnect_button.Click += new System.EventHandler(this.disconnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.user_read_data);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.user_write_data);
            this.groupBox2.Controls.Add(this.QU_button);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.EW_button);
            this.groupBox2.Controls.Add(this.ER_button);
            this.groupBox2.Controls.Add(this.wordnum);
            this.groupBox2.Controls.Add(this.address);
            this.groupBox2.Controls.Add(this.SW_button);
            this.groupBox2.Controls.Add(this.SR_button);
            this.groupBox2.Location = new System.Drawing.Point(30, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 287);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读写USER";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton2);
            this.groupBox6.Controls.Add(this.Hex_select);
            this.groupBox6.Location = new System.Drawing.Point(9, 119);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(160, 23);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(73, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 20);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.Text = "ASCII";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Hex_select
            // 
            this.Hex_select.AutoSize = true;
            this.Hex_select.Checked = true;
            this.Hex_select.Location = new System.Drawing.Point(15, 2);
            this.Hex_select.Name = "Hex_select";
            this.Hex_select.Size = new System.Drawing.Size(52, 20);
            this.Hex_select.TabIndex = 29;
            this.Hex_select.TabStop = true;
            this.Hex_select.Text = "Hex";
            this.Hex_select.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "读到数据";
            // 
            // user_read_data
            // 
            this.user_read_data.Location = new System.Drawing.Point(81, 26);
            this.user_read_data.Multiline = true;
            this.user_read_data.Name = "user_read_data";
            this.user_read_data.Size = new System.Drawing.Size(243, 39);
            this.user_read_data.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "写入数据";
            // 
            // user_write_data
            // 
            this.user_write_data.Location = new System.Drawing.Point(81, 71);
            this.user_write_data.Multiline = true;
            this.user_write_data.Name = "user_write_data";
            this.user_write_data.Size = new System.Drawing.Size(243, 39);
            this.user_write_data.TabIndex = 25;
            // 
            // QU_button
            // 
            this.QU_button.Enabled = false;
            this.QU_button.Location = new System.Drawing.Point(81, 251);
            this.QU_button.Name = "QU_button";
            this.QU_button.Size = new System.Drawing.Size(152, 29);
            this.QU_button.TabIndex = 17;
            this.QU_button.Text = "退出QU";
            this.QU_button.UseVisualStyleBackColor = true;
            this.QU_button.Click += new System.EventHandler(this.QU_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "×4bytes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "长度";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "起始地址";
            // 
            // EW_button
            // 
            this.EW_button.Enabled = false;
            this.EW_button.Location = new System.Drawing.Point(172, 215);
            this.EW_button.Name = "EW_button";
            this.EW_button.Size = new System.Drawing.Size(152, 29);
            this.EW_button.TabIndex = 13;
            this.EW_button.Text = "连续写EW";
            this.EW_button.UseVisualStyleBackColor = true;
            this.EW_button.Click += new System.EventHandler(this.EW_button_Click);
            // 
            // ER_button
            // 
            this.ER_button.Enabled = false;
            this.ER_button.Location = new System.Drawing.Point(11, 215);
            this.ER_button.Name = "ER_button";
            this.ER_button.Size = new System.Drawing.Size(152, 29);
            this.ER_button.TabIndex = 12;
            this.ER_button.Text = "连续读ER";
            this.ER_button.UseVisualStyleBackColor = true;
            this.ER_button.Click += new System.EventHandler(this.ER_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.paramete_inout);
            this.groupBox3.Controls.Add(this.write_parameter_button);
            this.groupBox3.Controls.Add(this.read_parameter_button);
            this.groupBox3.Controls.Add(this.Parameter);
            this.groupBox3.Location = new System.Drawing.Point(369, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(333, 66);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "参数";
            // 
            // paramete_inout
            // 
            this.paramete_inout.Location = new System.Drawing.Point(259, 21);
            this.paramete_inout.Multiline = true;
            this.paramete_inout.Name = "paramete_inout";
            this.paramete_inout.Size = new System.Drawing.Size(61, 29);
            this.paramete_inout.TabIndex = 32;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.EPC_read_data);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.EPC_write_data);
            this.groupBox4.Controls.Add(this.EPC_QU_button);
            this.groupBox4.Controls.Add(this.ES_button);
            this.groupBox4.Controls.Add(this.SP_button);
            this.groupBox4.Controls.Add(this.SS_button);
            this.groupBox4.Location = new System.Drawing.Point(369, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 271);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "读写EPC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "读到数据";
            // 
            // EPC_read_data
            // 
            this.EPC_read_data.Location = new System.Drawing.Point(86, 26);
            this.EPC_read_data.Multiline = true;
            this.EPC_read_data.Name = "EPC_read_data";
            this.EPC_read_data.Size = new System.Drawing.Size(241, 39);
            this.EPC_read_data.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "写入数据";
            // 
            // EPC_write_data
            // 
            this.EPC_write_data.Location = new System.Drawing.Point(86, 71);
            this.EPC_write_data.Multiline = true;
            this.EPC_write_data.Name = "EPC_write_data";
            this.EPC_write_data.Size = new System.Drawing.Size(241, 39);
            this.EPC_write_data.TabIndex = 26;
            // 
            // EPC_QU_button
            // 
            this.EPC_QU_button.Enabled = false;
            this.EPC_QU_button.Location = new System.Drawing.Point(77, 226);
            this.EPC_QU_button.Name = "EPC_QU_button";
            this.EPC_QU_button.Size = new System.Drawing.Size(152, 29);
            this.EPC_QU_button.TabIndex = 18;
            this.EPC_QU_button.Text = "退出QU";
            this.EPC_QU_button.UseVisualStyleBackColor = true;
            this.EPC_QU_button.Click += new System.EventHandler(this.EPC_QU_button_Click);
            // 
            // ES_button
            // 
            this.ES_button.Enabled = false;
            this.ES_button.Location = new System.Drawing.Point(6, 191);
            this.ES_button.Name = "ES_button";
            this.ES_button.Size = new System.Drawing.Size(152, 29);
            this.ES_button.TabIndex = 12;
            this.ES_button.Text = "连续读ES";
            this.ES_button.UseVisualStyleBackColor = true;
            this.ES_button.Click += new System.EventHandler(this.ES_button_Click);
            // 
            // SP_button
            // 
            this.SP_button.Enabled = false;
            this.SP_button.Location = new System.Drawing.Point(167, 158);
            this.SP_button.Name = "SP_button";
            this.SP_button.Size = new System.Drawing.Size(152, 29);
            this.SP_button.TabIndex = 4;
            this.SP_button.Text = "单次写SP";
            this.SP_button.UseVisualStyleBackColor = true;
            this.SP_button.Click += new System.EventHandler(this.SP_button_Click);
            // 
            // SS_button
            // 
            this.SS_button.Enabled = false;
            this.SS_button.Location = new System.Drawing.Point(6, 156);
            this.SS_button.Name = "SS_button";
            this.SS_button.Size = new System.Drawing.Size(152, 29);
            this.SS_button.TabIndex = 3;
            this.SS_button.Text = "单次读SS";
            this.SS_button.UseVisualStyleBackColor = true;
            this.SS_button.Click += new System.EventHandler(this.SS_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 32);
            this.label4.TabIndex = 24;
            this.label4.Text = "接收报文\r\n(Hex)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "发送报文\r\n(Hex)";
            // 
            // receive_data
            // 
            this.receive_data.Location = new System.Drawing.Point(81, 95);
            this.receive_data.Multiline = true;
            this.receive_data.Name = "receive_data";
            this.receive_data.Size = new System.Drawing.Size(585, 35);
            this.receive_data.TabIndex = 22;
            // 
            // send_data
            // 
            this.send_data.Location = new System.Drawing.Point(80, 33);
            this.send_data.Multiline = true;
            this.send_data.Name = "send_data";
            this.send_data.Size = new System.Drawing.Size(586, 39);
            this.send_data.TabIndex = 21;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.receive_data);
            this.groupBox5.Controls.Add(this.send_data);
            this.groupBox5.Location = new System.Drawing.Point(30, 397);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(672, 138);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "收发区";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 547);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "IUT_R4_Supervisor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox com_num;
        private System.Windows.Forms.Button SR_button;
        private System.Windows.Forms.Button SW_button;
        private System.Windows.Forms.ComboBox Parameter;
        private System.Windows.Forms.Button read_parameter_button;
        private System.Windows.Forms.Button write_parameter_button;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox wordnum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EW_button;
        private System.Windows.Forms.Button ER_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ES_button;
        private System.Windows.Forms.Button SP_button;
        private System.Windows.Forms.Button SS_button;
        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button QU_button;
        private System.Windows.Forms.Button EPC_QU_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox receive_data;
        private System.Windows.Forms.TextBox send_data;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox user_write_data;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EPC_write_data;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox user_read_data;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox EPC_read_data;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton Hex_select;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox paramete_inout;
    }
}

