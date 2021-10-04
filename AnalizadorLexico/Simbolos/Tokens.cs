using System;
using System.Collections.Generic;
using System.Text;

namespace Simbolos
{
    public class Tokens
    {
        public List<Constructor_Tokens> tokens = new List<Constructor_Tokens>();
        public List<Caracteristicas> datos = new List<Caracteristicas>();
        public Tokens() { }
        public List<Constructor_Tokens> TSimbolos { get => tokens; set => tokens = value; }

        public void Token()
        {
            //(int iD_Token, string token, string tipo, string descripcion_Tipo)
            Constructor_Tokens tk = new Constructor_Tokens(0, "<<", "Comentario", " Inicio de una linea de comentario ");
            tokens.Add(tk);
            Constructor_Tokens tk1 = new Constructor_Tokens(1, ">>", "Comentario", " Fin de una linea de comentario ");
            tokens.Add(tk1);
            Constructor_Tokens tk2 = new Constructor_Tokens(2, "<¿", "Comentario", " Inicio de mas de una linea de comentario ");
            tokens.Add(tk2);
            Constructor_Tokens tk3 = new Constructor_Tokens(3, "<?", "Comentario", " Fin de mas de una linea de comentario ");
            tokens.Add(tk3);
            Constructor_Tokens tk4 = new Constructor_Tokens(4, "{", "Bloque", " Inicio de un bloque ");
            tokens.Add(tk4);
            Constructor_Tokens tk5 = new Constructor_Tokens(5, "}", "Bloque", " Fin de un bloque ");
            tokens.Add(tk5);
            Constructor_Tokens tk6 = new Constructor_Tokens(6, ">int", "Palabra reservada", " Numero entero ");
            tokens.Add(tk6);
            Constructor_Tokens tk7 = new Constructor_Tokens(7, ">double", "Palabra reservada", " Numero con decimales ");
            tokens.Add(tk7);
            Constructor_Tokens tk8 = new Constructor_Tokens(8, ">string", "Palabra reservada", " Cadena de caracteres ");
            tokens.Add(tk8);
            Constructor_Tokens tk9 = new Constructor_Tokens(9, ">bool", "Palabra reservada", " Booleano tru or false ");
            tokens.Add(tk9);
            Constructor_Tokens tk10 = new Constructor_Tokens(10, "-", "Operador", " Representa una resta ");
            tokens.Add(tk10);
            Constructor_Tokens tk11 = new Constructor_Tokens(11, "+", "Operador", " Representa una suma ");
            tokens.Add(tk11);
            Constructor_Tokens tk12 = new Constructor_Tokens(12, "*", "Operador", " Representa una multiplicacion ");
            tokens.Add(tk12);
            Constructor_Tokens tk13 = new Constructor_Tokens(13, "/", "Operador", " Representa una division ");
            tokens.Add(tk13);
            Constructor_Tokens tk14 = new Constructor_Tokens(14, ":", "Operador", " Simbolo de asignacion ");
            tokens.Add(tk14);
            Constructor_Tokens tk15 = new Constructor_Tokens(15, ">", "Operador", " Mayor que ");
            tokens.Add(tk15);
            Constructor_Tokens tk16 = new Constructor_Tokens(16, "<", "Operador", " Menor que ");
            tokens.Add(tk16);
            Constructor_Tokens tk17 = new Constructor_Tokens(17, ">:", "Operador", " Mayor o igual que ");
            tokens.Add(tk17);
            Constructor_Tokens tk18 = new Constructor_Tokens(18, "<:", "Operador", " Menor o igual que ");
            tokens.Add(tk18);
            Constructor_Tokens tk19 = new Constructor_Tokens(19, "&&", "Operador logico", " Condicion esto y esto ");
            tokens.Add(tk19);
            Constructor_Tokens tk20 = new Constructor_Tokens(20, "||", "Operador logico", " Condicion esto o esto ");
            tokens.Add(tk20);
            Constructor_Tokens tk21 = new Constructor_Tokens(21, "::", "Operador logico", " Condicion esto es igual a esto ");
            tokens.Add(tk21);
            Constructor_Tokens tk22 = new Constructor_Tokens(22, "!:", "Operador logico", " Condicion diferente a ");
            tokens.Add(tk22);
            Constructor_Tokens tk23 = new Constructor_Tokens(23, "!", "Operador logico", " Condicion de negacion ");
            tokens.Add(tk23);
            Constructor_Tokens tk24 = new Constructor_Tokens(24, ">print", "Palabra reservada", " Muestra en consola ");
            tokens.Add(tk24);
            Constructor_Tokens tk25 = new Constructor_Tokens(25, ">read", "Palabra reservada", " captura un valor desde consola ");
            tokens.Add(tk25);
            Constructor_Tokens tk26 = new Constructor_Tokens(26, ">func", "Palabra reservada", " Define una funcion ");
            tokens.Add(tk26);
            Constructor_Tokens tk27 = new Constructor_Tokens(27, ">class", "Palabra reservada", " define una clase ");
            tokens.Add(tk27);
            Constructor_Tokens tk28 = new Constructor_Tokens(28, ">si", "Palabra reservada", " si tal condicion se cumple ");
            tokens.Add(tk28);
            Constructor_Tokens tk29 = new Constructor_Tokens(29, ">sino", "Palabra reservada", " si tal condicion no se cumple ");
            tokens.Add(tk29);
            Constructor_Tokens tk30 = new Constructor_Tokens(30, "(", "Parametro", " Inicia peticion de parametro ");
            tokens.Add(tk30);
            Constructor_Tokens tk31 = new Constructor_Tokens(31, ")", "Parametro", " Finaliza peticion de parametro ");
            tokens.Add(tk31);
            Constructor_Tokens tk32 = new Constructor_Tokens(32, "~", "Concatenacion", " Permite concatenar variables ");
            tokens.Add(tk32);
            Constructor_Tokens tk33 = new Constructor_Tokens(33, "'", "Indicador de texto", " Indica donde comienza y termina un string ");
            tokens.Add(tk33);
        }

        public List<Constructor_Tokens> ObtenerTokens()
        {
            return tokens;
        }

        public List<Caracteristicas> BuscarToken(string argumento, int linea, string regla)
        {
            foreach (var word in tokens)
            {
                if (word.Token1 == argumento)
                {
                    if (Verificar((linea + 1).ToString()) == true)
                    {
                        return datos;
                    }
                    else
                    {
                        datos.Add(new Caracteristicas(word.Token1, word.Tipo1, (linea + 1).ToString(), word.ID_Token1.ToString(), regla, word.Descripcion_Tipo1));
                        return datos;
                    }
                }
            }
            return null;
        }

        private bool Verificar(string linea)
        {
            foreach (var x in datos)
            {
                if (x.Linea == linea)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
