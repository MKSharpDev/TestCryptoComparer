using Binance.Net.Clients;
using Bitget.Net.Clients;
using Bybit.Net.Clients;
using Kucoin.Net.Clients;
using System.Diagnostics;
using TestCryptoСomparer.Abstractions;
using TestCryptoСomparer.Implementation;
using TestCryptoСomparer.Implementation.Messendger;

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
            binanceTextBox = new TextBox();
            kucoinTextBox = new TextBox();
            bitgetTextBox = new TextBox();
            bybitTextBox = new TextBox();
            GetByRestButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            StopBotton = new Button();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            binanceTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            binanceTextBox.Location = new Point(271, 62);
            binanceTextBox.Name = "textBox1";
            binanceTextBox.Size = new Size(171, 29);
            binanceTextBox.TabIndex = 0;
            binanceTextBox.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            kucoinTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kucoinTextBox.Location = new Point(271, 97);
            kucoinTextBox.Name = "textBox2";
            kucoinTextBox.Size = new Size(171, 29);
            kucoinTextBox.TabIndex = 1;
            // 
            // textBox3
            // 
            bitgetTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bitgetTextBox.Location = new Point(271, 131);
            bitgetTextBox.Name = "textBox3";
            bitgetTextBox.Size = new Size(171, 29);
            bitgetTextBox.TabIndex = 2;
            // 
            // textBox4
            // 
            bybitTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bybitTextBox.Location = new Point(271, 169);
            bybitTextBox.Name = "textBox4";
            bybitTextBox.Size = new Size(171, 29);
            bybitTextBox.TabIndex = 3;
            bybitTextBox.TextChanged += textBox4_TextChanged;
            // 
            // button1
            // 
            GetByRestButton.Location = new Point(54, 288);
            GetByRestButton.Name = "button1";
            GetByRestButton.Size = new Size(171, 50);
            GetByRestButton.TabIndex = 4;
            GetByRestButton.Text = "StartRest";
            GetByRestButton.UseVisualStyleBackColor = true;
            GetByRestButton.Click += GetByRestButtonClick;
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
            StopBotton.Location = new Point(424, 288);
            StopBotton.Name = "button2";
            StopBotton.Size = new Size(148, 50);
            StopBotton.TabIndex = 9;
            StopBotton.Text = "Stop";
            StopBotton.UseVisualStyleBackColor = true;
            StopBotton.Click += StopBottonClick;
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
            Controls.Add(StopBotton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GetByRestButton);
            Controls.Add(bybitTextBox);
            Controls.Add(bitgetTextBox);
            Controls.Add(kucoinTextBox);
            Controls.Add(binanceTextBox);
            Name = "CryptoСomparer";
            Text = "TestCryptoСomparer";
            Load += CryptoСomparer_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private TextBox binanceTextBox;
        private TextBox kucoinTextBox;
        private TextBox bitgetTextBox;
        private TextBox bybitTextBox;


        private Button GetByRestButton;
        private Button StopBotton;

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;


        //создаем лист клиентов для использования в разных кнопках
        private List<IGetTickerByRest> GetClientsList()
        {
            List<IGetTickerByRest> clientsList = new List<IGetTickerByRest>();
            clientsList.Add(new BinanceClient());
            clientsList.Add(new KucoinClient());
            clientsList.Add(new BitgetClient());
            clientsList.Add(new BybitClient());

            return clientsList;
        }

        private List<TextBoxMessendger> GetTextBoxMessendgerList()
        {
            List<TextBoxMessendger> messengerList = new List<TextBoxMessendger>();
            messengerList.Add(new TextBoxMessendger(binanceTextBox));
            messengerList.Add(new TextBoxMessendger(kucoinTextBox));
            messengerList.Add(new TextBoxMessendger(bitgetTextBox));
            messengerList.Add(new TextBoxMessendger(bybitTextBox));

            return messengerList;
        }

        private CancellationTokenSource ts = new CancellationTokenSource();


        private async void GetByRestButtonClick(object sender, EventArgs e)
        {

            CancellationToken token = ts.Token;

            List<IGetTickerByRest> clientsList = GetClientsList();
            List<TextBoxMessendger> messengerList = GetTextBoxMessendgerList();


            List<Task> tasks = new List<Task>();
 

            Parallel.For(0, clientsList.Count,
             index => {
                 Task.Factory.StartNew(async () =>
                 {
                     while (!token.IsCancellationRequested)
                     {
                         var result = await clientsList[index].GetBTCByRestAsync();
                         if (!token.IsCancellationRequested)
                         {
                             messengerList[index].SendMessege(result);
                         }                       
                         Thread.Sleep(5000);
                     }
                 });
             });


        }

        private async void StopBottonClick(object sender, EventArgs e)
        {
            ts.Cancel();
            binanceTextBox.Text = string.Empty;
            kucoinTextBox.Text = string.Empty;
            bitgetTextBox.Text = string.Empty;
            bybitTextBox.Text = string.Empty;
            ts = new CancellationTokenSource();
        }

        private Button button3;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
