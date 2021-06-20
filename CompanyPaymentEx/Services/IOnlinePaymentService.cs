namespace CompanyPaymentEx.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double Amount);
        double Interest(double Amount, int Months);
    }
}
