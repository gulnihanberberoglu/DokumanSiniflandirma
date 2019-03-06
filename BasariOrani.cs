namespace DokumanSiniflandirma
{
    public class BasariOrani
    {
        public Kategori Kategori { get; set; }

        public double TruePositiveCount { get; set; }

        public double FalsePositiveCount { get; set; }

        public double FalseNegativeCount { get; set; }

        public double TrueNegativeCount { get; set; }

        public double Precision => TruePositiveCount / (TruePositiveCount + FalsePositiveCount);

        public double Recall => TruePositiveCount / (TruePositiveCount + FalseNegativeCount);

        public double Fmeasure => 2 * ((Precision * Recall) / (Precision + Recall));
    }
}
