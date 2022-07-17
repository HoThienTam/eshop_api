namespace SharedKernel.GuardClauses
{
    public static partial class Assert
    {
        private static void NotNegative<T>(T input, string parameterName) where T : struct, IComparable
        {
            if (input.CompareTo(default(T)) < 0)
            {
                throw new ArgumentException($"Required input {parameterName} cannot be negative.", parameterName);
            }
        }

        public static void NotNegative(int input, string parameterName)
        {
            NotNegative<int>(input, parameterName);
        }

        public static void NotNegative(long input, string parameterName)
        {
            NotNegative<long>(input, parameterName);
        }

        public static void NotNegative(decimal input, string parameterName)
        {
            NotNegative<decimal>(input, parameterName);
        }

        public static void NotNegative(double input, string parameterName)
        {
            NotNegative<double>(input, parameterName);
        }

        public static void NotNegative(float input, string parameterName)
        {
            NotNegative<float>(input, parameterName);
        }

        private static void NotNegativeOrZero<T>(T input, string parameterName) where T : struct, IComparable
        {
            if (input.CompareTo(default(T)) <= 0)
            {
                throw new ArgumentException($"Required input {parameterName} cannot be zero or negative.", parameterName);
            }
        }

        public static void NotNegativeOrZero(int input, string parameterName)
        {
            NotNegativeOrZero(input, parameterName);
        }

        public static void NotNegativeOrZero(long input, string parameterName)
        {
            NotNegativeOrZero(input, parameterName);
        }

        public static void NotNegativeOrZero(double input, string parameterName)
        {
            NotNegativeOrZero(input, parameterName);
        }

        public static void NotNegativeOrZero(decimal input, string parameterName)
        {
            NotNegativeOrZero(input, parameterName);
        }

        public static void NotNegativeOrZero(float input, string parameterName)
        {
            NotNegativeOrZero(input, parameterName);
        }
    }
}
