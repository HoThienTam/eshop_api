namespace SharedKernel.GuardClauses
{
    public static partial class Assert
    {
        private static void NotZero<T>(T input, string parameterName) where T : struct
        {
            if (EqualityComparer<T>.Default.Equals(input, default(T)))
            {
                throw new ArgumentException($"Required input {parameterName} cannot be zero.", parameterName);
            }
        }

        public static void NotZero(int input, string parameterName)
        {
            NotZero<int>(input, parameterName);
        }

        public static void NotZero(long input, string parameterName)
        {
            NotZero<long>(input, parameterName);
        }

        public static void NotZero(decimal input, string parameterName)
        {
            NotZero<decimal>(input, parameterName);
        }

        public static void NotZero(float input, string parameterName)
        {
            NotZero<float>(input, parameterName);
        }

        public static void NotZero(double input, string parameterName)
        {
            NotZero<double>(input, parameterName);
        }
    }
}
