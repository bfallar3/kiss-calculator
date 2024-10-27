namespace Kiss_Calculator;

public class ComplexCalculator
{
    private readonly Dictionary<string, Func<double, double, double>> _operations;
    private readonly List<string> _operationHistory;

    public ComplexCalculator()
    {
        _operations = new Dictionary<string, Func<double, double, double>>
        {
            { "add", (a, b) => a + b },
            { "subtract", (a, b) => a - b },
            { "multiply", (a, b) => a * b },
            { "divide", (a, b) => b != 0 ? a / b : throw new DivideByZeroException() }
        };
        _operationHistory = new List<string>();
    }

    public double Calculate(string operation, double a, double b)
    {
        try
        {
            if (!_operations.ContainsKey(operation.ToLower()))
            {
                throw new ArgumentException("Invalid operation");
            }

            var result = _operations[operation.ToLower()](a, b);
            _operationHistory.Add($"{DateTime.Now}: {a} {operation} {b} = {result}");

            // Unnecessary validation and processing
            if (double.IsInfinity(result) || double.IsNaN(result))
            {
                throw new ArithmeticException("Invalid result");
            }

            return Math.Round(result, 2);
        }
        catch (Exception ex)
        {
            _operationHistory.Add($"{DateTime.Now}: Error - {ex.Message}");
            throw;
        }
    }

    public List<string> GetOperationHistory()
    {
        return _operationHistory.ToList(); // Unnecessary copying
    }
}