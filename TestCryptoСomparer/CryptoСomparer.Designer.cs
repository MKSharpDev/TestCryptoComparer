using TestCryptoComparerClassLibrary.Abstractions;
using TestCryptoComparerClassLibrary.Implementation;
using TestCryptoСomparer.Implementation.Messendger;

namespace TestCryptoСomparer
{
    partial class CryptoСomparer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        string ticker = "BTCUSDT";

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
            CryptoTypeComboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            SelectedView = new Label();
            SuspendLayout();
            // 
            // binanceTextBox
            // 
            binanceTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            binanceTextBox.Location = new Point(271, 62);
            binanceTextBox.Name = "binanceTextBox";
            binanceTextBox.Size = new Size(171, 29);
            binanceTextBox.TabIndex = 0;
            binanceTextBox.TextChanged += textBox1_TextChanged;
            // 
            // kucoinTextBox
            // 
            kucoinTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kucoinTextBox.Location = new Point(271, 97);
            kucoinTextBox.Name = "kucoinTextBox";
            kucoinTextBox.Size = new Size(171, 29);
            kucoinTextBox.TabIndex = 1;
            // 
            // bitgetTextBox
            // 
            bitgetTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bitgetTextBox.Location = new Point(271, 131);
            bitgetTextBox.Name = "bitgetTextBox";
            bitgetTextBox.Size = new Size(171, 29);
            bitgetTextBox.TabIndex = 2;
            // 
            // bybitTextBox
            // 
            bybitTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bybitTextBox.Location = new Point(271, 169);
            bybitTextBox.Name = "bybitTextBox";
            bybitTextBox.Size = new Size(171, 29);
            bybitTextBox.TabIndex = 3;
            bybitTextBox.TextChanged += textBox4_TextChanged;
            // 
            // GetByRestButton
            // 
            GetByRestButton.Location = new Point(54, 288);
            GetByRestButton.Name = "GetByRestButton";
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
            // StopBotton
            // 
            StopBotton.Location = new Point(424, 288);
            StopBotton.Name = "StopBotton";
            StopBotton.Size = new Size(148, 50);
            StopBotton.TabIndex = 9;
            StopBotton.Text = "Stop";
            StopBotton.UseVisualStyleBackColor = true;
            StopBotton.Click += StopBottonClick;
            // 
            // CryptoTypeComboBox
            // 
            CryptoTypeComboBox.DisplayMember = "BTC";
            CryptoTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CryptoTypeComboBox.FlatStyle = FlatStyle.System;
            CryptoTypeComboBox.FormattingEnabled = true;
            CryptoTypeComboBox.Items.AddRange(new object[] { "BTCUSDT", "ETHUSDT" });
            CryptoTypeComboBox.Location = new Point(487, 68);
            CryptoTypeComboBox.Name = "CryptoTypeComboBox";
            CryptoTypeComboBox.Size = new Size(118, 23);
            CryptoTypeComboBox.TabIndex = 11;
            CryptoTypeComboBox.ValueMember = "BTCUSDT";
            CryptoTypeComboBox.SelectedIndexChanged += CryptoTypeComboBox_SelectedIndexChanged;
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
            // SelectedView
            // 
            SelectedView.AutoSize = true;
            SelectedView.Location = new Point(544, 111);
            SelectedView.Name = "SelectedView";
            SelectedView.Size = new Size(0, 15);
            SelectedView.TabIndex = 15;
            SelectedView.Click += label8_Click;
            SelectedView.Text = ticker;
            // 
            // CryptoСomparer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 411);
            Controls.Add(SelectedView);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(CryptoTypeComboBox);
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

            for (int index = 0; index < clientsList.Count; index++)
            {
                int client = index;
                tasks.Add(Task.Run(async () =>
                    {

                        while (!token.IsCancellationRequested)
                        {
                            var result = await clientsList[client].GetTicketByRestAsync(ticker, token);
                            if (!token.IsCancellationRequested)
                            {
                                messengerList[client].SendMessege(result);
                            }
                            Thread.Sleep(5000);
                        }
                    }
                ));
            }

            //Parallel.For(0, clientsList.Count,
            //index =>
            //{
            //    Task.Factory.StartNew(async () =>
            //    {
            //        while (!token.IsCancellationRequested)
            //        {
            //            var result = await clientsList[index].GetTicketByRestAsync(ticker, token);
            //            if (!token.IsCancellationRequested)
            //            {
            //                messengerList[index].SendMessege(result);
            //            }
            //            Thread.Sleep(5000);
            //        }
            //    });
            //});
        }

        

        private async void StopBottonClick(object sender, EventArgs e)
        {
            Stop();
        }
        void Stop()
        {
            ts.Cancel();
            binanceTextBox.Text = string.Empty;
            kucoinTextBox.Text = string.Empty;
            bitgetTextBox.Text = string.Empty;
            bybitTextBox.Text = string.Empty;
            ts = new CancellationTokenSource();
        }

        private void CryptoTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            binanceTextBox.Text = string.Empty;
            kucoinTextBox.Text = string.Empty;
            bitgetTextBox.Text = string.Empty;
            bybitTextBox.Text = string.Empty;

            ticker = CryptoTypeComboBox.SelectedItem.ToString();
            SelectedView.Text = ticker;

        }

        private ComboBox CryptoTypeComboBox;
        private Label label5;
        private Label label6;
        private Label SelectedView;
    }
}
