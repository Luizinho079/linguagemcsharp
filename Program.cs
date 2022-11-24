using System;

namespace ListaByte
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] valores = { 4, "gota", 300, 500, 3 };
            byte[] vbyte = new byte[5];
            string[] vtextos = new string[5];
            string[] vforafaixa = new string[5];

            for (int i =0; i< valores.Length; i++)
            {
                try
                {
                    var v = Convert.ToByte(valores[i];
                    vbytes[i] = v;
                }
                catch (FormatException)
                {
                    vtextos[i] = valores[i].ToString();

                }
                catch (OverFlowException)
                {
                    vforafaixa[i] = Convert.ToInt32(valores[i]);
                }
        }
    }
}
