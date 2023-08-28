namespace ProcesoTramasRecaudo.Aplication
{
    public class ApplicationException : Exception
    {
        public ApplicationException(string businessMessage)
                       : base(businessMessage)
        {
        }
    }
}
