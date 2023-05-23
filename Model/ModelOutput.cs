using Microsoft.ML.Data;

namespace CreditRiskCustomerPrediction.Model
{
    public class ModelOutput
    {
        [ColumnName("PredictedLabel")]
        public string Prediction { get; set; }
    }
}
