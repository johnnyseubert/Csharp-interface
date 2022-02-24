using System.Globalization;

namespace ProjetoSemInterface.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment{ get { return BasicPayment + Tax; } }
        
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public override string ToString()
        {
            return $"Basic Payment: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                   $"Tax: {Tax.ToString("F2", CultureInfo.InvariantCulture)}\n" +
                   $"TotalPayment: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}