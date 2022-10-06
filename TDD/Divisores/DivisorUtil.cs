namespace Divisores
{
    /// <summary>
    /// This class should be used to create new methods.
    /// </summary>
    public class DivisorUtil : IDivisorUtil
    {
        public bool IsDividedBy(int a, int b)
        {
            if (a < b)
            {
                throw new Exception("The A is Less than B");
            }

            if (b == 0)
            {
                throw new ArgumentException("B is Zero");
            }

            return a % b == 0;
        }
    }
}