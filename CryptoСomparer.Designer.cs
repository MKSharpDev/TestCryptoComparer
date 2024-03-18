using Binance.Net.Clients;
using Bitget.Net.Clients;
using Bybit.Net.Clients;
using Kucoin.Net.Clients;
using TestCryptoСomparer.Abstractions;
using TestCryptoСomparer.Implementation;

namespace TestCryptoСomparer
{
    partial class CryptoСomparer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(271, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 29);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(271, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 29);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(271, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 29);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(271, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 29);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(54, 288);
            button1.Name = "button1";
            button1.Size = new Size(171, 50);
            button1.TabIndex = 4;
            button1.Text = "StartRest";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(145, 62);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 5;
            label1.Text = "Binance";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(145, 99);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 6;
            label2.Text = "Kucoin ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(145, 134);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 7;
            label3.Text = "Bitget";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(145, 169);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 8;
            label4.Text = "ByBit";
            // 
            // button2
            // 
            button2.Location = new Point(424, 288);
            button2.Name = "button2";
            button2.Size = new Size(148, 50);
            button2.TabIndex = 9;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(240, 288);
            button3.Name = "button3";
            button3.Size = new Size(160, 50);
            button3.TabIndex = 10;
            button3.Text = "StartSocket";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BTC", "ETH" });
            comboBox1.Location = new Point(487, 68);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(118, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(487, 50);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 12;
            label5.Text = "SelectCrypto";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(487, 111);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 13;
            label6.Text = "Selected";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(553, 111);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 14;
            label7.Text = "?";
            // 
            // CryptoСomparer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 411);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "CryptoСomparer";
            Text = "TestCryptoСomparer";
            Load += CryptoСomparer_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;


        private Button button1;
        private Button button2;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;


        //создаем лист клиентов для использования в разных кнопках
        private List<IGetTickerByRest> GetClientsList()
        {
            List<IGetTickerByRest> clientsList = new List<IGetTickerByRest>();
            clientsList.Add(new BinanceClient(textBox1));
            clientsList.Add(new KucoinClient(textBox2));
            clientsList.Add(new BitgetClient(textBox3));
            clientsList.Add(new BybitClient(textBox4));

            return clientsList;
        }

        private CancellationTokenSource ts = new CancellationTokenSource();


        private async void button1_Click(object sender, EventArgs e)
        {

            CancellationToken token = ts.Token;

            List<IGetTickerByRest> clientsList = GetClientsList();

            List<Task> tasks = new List<Task>();
            foreach (var client in clientsList)
            {
                tasks.Add(Task.Factory.StartNew(() => client.GetBTCByRestAsync(token) ));
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            ts.Cancel();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            ts = new CancellationTokenSource();
        }

        private Button button3;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
