﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoNota
{
    public class Avaliacao
    {

        public static string Avalia(double nota1, double nota2, double faltas, double cargaHoraria)
        {
            string result;
            double percentualFaltas = (faltas / cargaHoraria);
            double media = (nota1 + nota2) / 2;
            if ((nota1 < 0.0 || nota1 > 10) ||
                    (nota2 < 0.0 || nota2 > 10) ||
                    (faltas < 0.0 || faltas > cargaHoraria) ||
                    cargaHoraria < 0.0)
            {
                throw new Exception("Valores Inválidos.");
            }
            else if (percentualFaltas > 0.25)
            {
                result = "Reprovado por Falta.";
            }
            else if (media < 3.0)
            {
                result = "Reprovado por Média.";
            }
            else if (media >= 3.0 && media < 6.0)
            {
                result = "Prova Extra.";
            }
            else
            {
                result = "Aprovado.";
            }
            return result;
        }
    }
}
