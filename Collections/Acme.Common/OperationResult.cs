namespace Acme.Common
{
    /// <summary>
    /// Provides a success flag and message 
    /// useful as a method return type.
    /// </summary>
    public class OperationResult<T>
    {
        public OperationResult()
        {
        }

        public OperationResult(T sucess, string message) : this()
        {
            this.Ressult = sucess;
            this.Message = message;
        }

        public T Ressult { get; set; }
        public string Message { get; set; }
    }

}
