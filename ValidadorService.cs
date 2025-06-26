using System.Collections.Generic;
using ValidadorExpresiones.Models;

namespace ValidadorExpresiones.Services
{
    public class ValidadorService
    {
        private readonly Dictionary<char, char> _parejas = new()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        public ResultadoValidacion Validar(string expresion)
        {
            var pila = new Stack<char>();

            for (int i = 0; i < expresion.Length; i++)
            {
                char actual = expresion[i];

                if (_parejas.ContainsValue(actual))
                {
                    pila.Push(actual);
                }
                else if (_parejas.ContainsKey(actual))
                {
                    if (pila.Count == 0 || pila.Pop() != _parejas[actual])
                    {
                        return new ResultadoValidacion(false, $"❌ Error: símbolo inesperado '{actual}' en posición {i}");
                    }
                }
            }

            if (pila.Count > 0)
            {
                return new ResultadoValidacion(false, "❌ Error: hay símbolos sin cerrar");
            }

            return new ResultadoValidacion(true, "✅ Expresión válida: todos los símbolos están balanceados");
        }
    }
}
