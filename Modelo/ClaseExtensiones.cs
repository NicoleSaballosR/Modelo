﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
  
    //La clase donde se guardan las extensiones debe ser estatica
    public static class ClaseExtensiones
    {
        //El metodo que extiende debe ser estático
        //El primer parametro lleva this y representa el ipo que estamos extendiendo 
        public static bool EsPar(this int i)
        {
            if (i % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // metoodo que extiende a un double

        public static double Duplica(this double d)
        {
            return d * 2.0;
        }
    }
   
}
