namespace ReflectionPaymentMethod
{
    public partial class Form1 : Form
    {
        private IPaymentMethod _paymentMethod;
        public Form1()
        {
            InitializeComponent();
        }

        private IPaymentMethod CreatePaymentInstance(string paymentMethod)
        {
            var type = Type.GetType("ReflectionPaymentMethod.PaymentMethods." + paymentMethod);
            if (type != null)
                return (IPaymentMethod)Activator.CreateInstance(type);

            return null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string paymentMethod = comboBox1.SelectedItem.ToString();
            _paymentMethod = CreatePaymentInstance(paymentMethod);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_paymentMethod != null)
            {
                lblResult.Text = _paymentMethod.MakePayment(double.Parse(textBox1.Text));
            }
            else
            {
                MessageBox.Show("Ödeme yöntemi seçilmedi.");
            }
        }
    }
}
