﻿using System;
using System.Globalization;


namespace CauladoraMembrosInstancia {
    internal class Calculadora {
        
            public static double Pi = 3.14;
            public static double Circunferencia(double r) {
                return 2.0 * Pi * r;
            }
            public static double Volume(double r) {
                return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
            }
        }
    }
