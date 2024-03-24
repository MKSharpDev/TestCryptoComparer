namespace TestCryptoСomparer.Implementation.Messendger
{
    public class TextBoxMessendger : Messendger
    {
        private TextBox textBox;
        public TextBoxMessendger(TextBox textBox)
        {
            this.textBox = textBox;
        }
        
        public override void SendMessege(string messege) 
        {
            textBox.Invoke(() => {
                textBox.Clear();
                textBox.AppendText(messege);
            });
        }
    }
}
