namespace SharedKernel.GuardClauses
{
    public static partial class Assert
    {
        private static void NotNull<T>(T input, string parameterName) 
        {
            if (input is null)
            {
                throw new ArgumentNullException(parameterName);
            }
        }

        public static void NotNullOrEmpty(string? input, string parameterName)
        {
            NotNull(input, parameterName);

            if (input == string.Empty)
            {
                throw new ArgumentException($"Required input {parameterName} was empty.", parameterName);
            }
        }

        public static void NotNullOrEmpty(Guid? input, string parameterName)
        {
            NotNull(input, parameterName);

            if (input == Guid.Empty)
            {
                throw new ArgumentException($"Required input {parameterName} was empty.", parameterName);
            }
        }

        public static void NotNullOrEmpty<T>(IEnumerable<T>? input, string parameterName)
        {
            NotNull(input, parameterName);

            if (!input!.Any())
            {
                throw new ArgumentException($"Required input {parameterName} was empty.", parameterName);
            }
        }

        public static void NotNullOrWhiteSpace(string? input, string parameterName)
        {
            NotNullOrEmpty(input, parameterName);

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException($"Required input {parameterName} was empty.", parameterName);
            }
        }
    }
}
