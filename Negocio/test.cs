namespace Negocio
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using Transversal;

    public class test
    {
        public string Registrar(Transversal.test oTexto)
        {
            try
            {
                string Valor = "";
                NumericServices Obj = new NumericServices();
                AlphaNumericService ObjALpha = new AlphaNumericService(); 
                int resultado = 0;
                bool esNumerico = Int32.TryParse(oTexto.input, out resultado);
                if (esNumerico)
                {
                    Valor = Obj.ProcessAsync(oTexto.input);
                }
                else
                {
                    Valor = ObjALpha.ProcessAsync(oTexto.input);
                }
                return Valor; 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}