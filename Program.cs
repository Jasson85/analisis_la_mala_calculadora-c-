using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text;
using System.Threading;

using BadCalc_VeryBad;
namespace BadCalcVeryBad
{
    // Clase Program marcada como estática ya que solo contendrá el punto de entrada principal.
    static class Program
    {
        // El punto de entrada principal main ahora delega la lógica del flujo de la aplicación.
        // Esto reduce la complejidad ciclomatica del método main y sigue el principio de mantenibilidad.
        static void Main(string[] args)
        {
            // Se elimina todo el código de la función main y se llama a la función init de logicapp
            // Esto es una buena práctica para mover la lógica de negocio fuera del punto de entrada,
            // lo que mejora la legibilidad y la testabilidad, y es un code Smell común en sonarqube.
            LogicApp.init();
        }   
    }
}
