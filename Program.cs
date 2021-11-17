using System;

namespace HustGotReal_Tech
{
    class Program
    {
        public static String loginUrl = "https://app.hustlegotreal.com/Account/Login";
        public static String scrapUrl = "https://app.hustlegotreal.com";
        public static String email = "testing@hustlegotreal.com";
        public static String pass = "HGR2021";
        
        static void Main(string[] args)
        {
            Authentication.Login(); //EJECUTAMOS EL METODO AUTHENTICATION, QUE LLEVA IMPLICITO EL METODO DE IMPRESIÓN.
        }
    }
}
// ME GUSTA QUE LAS FUNCIONES TENGAN UN UNICO PROPÓSITO CADA UNO, ASÍ PARA DEJAR MÁS LIMPIO EL MAIN() HE DECIDIDO SEPARAR EN 2 EL EJERCICIO
// EN EL ARCHIVO Authentication.cs, ESTÁ LA LÓGICA PARA ACCEDER A LA PÁGINA DE LOGIN. 
// LOCALIZAMOS LOS TEXTOS QUE SE NOS PIEDEN MOSTRAR EN CONSOLA
// EN EL ARCHIVO TakeText.cs, TENEMOS LA LÓGICA PARA PRINTAR ESOS TEXTOS. LA UTILIDAD DE TENERLO POR SEPARADO, ES QUE EN EL CASO DE UN FRONT-END 
//EN EL CASO DE QUERER CAMBIAR DE ESTILOS, ES MÁS COMODO TENER EN UNA FUNCIÓN A PARTE LA IMPRESIÓN. COMO SI DE COMPONENTES SE TRATARA.

//HE AÑADIDO LA PRIMERA FRASE DE TEXTO "Subscription allowance" PARA DAR VISIBILIDAD A LA HORA DEL CONSOLE.WRITELINE.
