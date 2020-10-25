//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        /*

            Para cumplir con el principio de SRP eliminamos la responsabilidad en la clase Recipe de imprimir 
            por consola los costos de cada paso y la receta correspondiente, por lo que esta tarea será derivada
            a la clase ConsolePrinter, la cual mediante un método estático (para que de esta manera no se creen instancias
            innecesarias) imprimirá por pantalla la información birndadá por cada clase. 

        */

        public void PrintRecipe()
        {
            ConsolePrinter.Print($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                ConsolePrinter.Print($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}