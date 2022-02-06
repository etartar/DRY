namespace DRY.ReplaceIFElseStatement
{
    public class ReplaceIFElseStatementBad : ReplaceIFElseStatementBase
    {
        public decimal CalculateTotalAfterDiscount()
        {
            if (TotalOrder >= 50 && TotalOrder < 100)
            {
                return TotalOrder - (TotalOrder * 2) / 100;
            }
            else if(TotalOrder >= 100 && TotalOrder < 500)
            {
                return TotalOrder - (TotalOrder * 5) / 100;
            }
            else if(TotalOrder >= 500)
            {
                return TotalOrder - (TotalOrder * 10) / 100;
            }
            else
            {
                return TotalOrder;
            }
        }
    }
}
