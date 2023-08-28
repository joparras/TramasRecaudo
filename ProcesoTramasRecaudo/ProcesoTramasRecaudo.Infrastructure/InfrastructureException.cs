﻿namespace ProcesoTramasRecaudo.Infrastructure
{
    public class InfrastructureException : Exception
    {
        public InfrastructureException(string businessMessage)
            : base(businessMessage)
        {
        }
    }
}
