﻿// ------------------------------------------ Librerias E Imports ---------------------------------------------------
using System;
using Proyecto1.Misc;

// ------------------------------------------------ Namespace -------------------------------------------------------
namespace Proyecto1.TranslatorAndInterpreter
{
    
    // Clase Principal 
    class ObjectReturn
    {
        
        // Valor Expression 
        public object Value;

        // Tipo Expression
        public object Type;

        // Opcional
        public String Option;

        // End
        public String End;

        // Constructor 
        public ObjectReturn(object Value, object Type) {

            // Inicializar Valroes 
            this.Value = Value;
            this.Type = Type;
            this.Option = "";
            this.End = "";

        }
        
    }

}