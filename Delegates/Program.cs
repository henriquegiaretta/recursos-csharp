using Delegates;

static void MakePayment(double value)
{
    //responsável por fazer a lógica do pagamento.
    Console.WriteLine($"O valor pago foi de {value}");
}

var payment = new Payment.Pay(MakePayment);
payment(35);