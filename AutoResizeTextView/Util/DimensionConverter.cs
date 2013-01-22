using System;
using System.Collections.Generic;
using Java.Lang;
using System.Text.RegularExpressions;
using Android.Util;

namespace AutoResizeTextView.Util
{
    /// <summary>
    /// Converter that converts dimension strings to real dimension
    /// </summary>
    /// <remarks>From: http://stackoverflow.com/a/12713624/1998370</remarks>
    /*public class DimensionConverter
    {
        // -- Initialize dimension string to constant lookup.     

        public static readonly Dictionary<string, Integer> _dimensionConstantLookup = InitDimensionConstantLookup();

        private static Dictionary<string, Integer> InitDimensionConstantLookup()
        {
            Dictionary<string, Integer> m = new Dictionary<string, Integer>();
            
            m.Add("px", (Integer)((int)ComplexUnitType.Px));
            m.Add("dip", (Integer)((int)ComplexUnitType.Dip));
            m.Add("dp", (Integer)((int)ComplexUnitType.Dip));
            m.Add("sp", (Integer)((int)ComplexUnitType.Sp));
            m.Add("pt", (Integer)((int)ComplexUnitType.Pt));
            m.Add("in", (Integer)((int)ComplexUnitType.In));
            m.Add("mm", (Integer)((int)ComplexUnitType.Mm));
            
            return m;
        }
        
        // -- Initialize pattern for dimension string.     
        
        private static Regex DimensionPattern = new Regex("^\\s*(\\d+(\\.\\d+)*)\\s*([a-zA-Z]+)\\s*$");
        
        public static int StringToDimensionPixelSize(string dimension, DisplayMetrics metrics)
        {
            // -- Mimics TypedValue.complexToDimensionPixelSize(int data, DisplayMetrics metrics).         
            
            InternalDimension internalDimension = StringToInternalDimension(dimension);
            
            float value = internalDimension.value;
            //float f = TypedValue.ApplyDimension((ComplexUnitType)internalDimension.unit, value, metrics);
            float f = TypedValue.ApplyDimension((ComplexUnitType)(int)internalDimension.unit, value, metrics);
            int res = (int)(f + 0.5f);
            
            if (res != 0) return res;
            if (value == 0) return 0;
            if (value > 0) return 1;
            
            return -1;
        }
        
        public static float StringToDimension(string dimension, DisplayMetrics metrics)
        {
            // -- Mimics TypedValue.complexToDimension(int data, DisplayMetrics metrics).         

            var internalDimension = StringToInternalDimension(dimension);
            
            //return TypedValue.ApplyDimension((ComplexUnitType)internalDimension.unit, internalDimension.value, metrics);
            return TypedValue.ApplyDimension((ComplexUnitType)(int)internalDimension.unit, internalDimension.value, metrics);
        }
        
        private static InternalDimension StringToInternalDimension(string dimension)
        {
            // -- Match target against pattern.         
            
            var matches = DimensionPattern.Matches(dimension);
            
            if (matches.Count > 0)
            {
                Match matcher = matches[0];
                
                // -- Match found.             
                // -- Extract value.             
                float value = Float.ValueOf(matcher.Groups[1].Value).FloatValue();
                
                // -- Extract dimension units.             
                string unit = matcher.Groups[3].ToString().ToLower();
                
                // -- Get Android dimension constant.             
                //int dimensionUnit;
                
                Integer dimensionUnit;
                _dimensionConstantLookup.TryGetValue(unit, out dimensionUnit);
                
                //if (dimensionUnit == ????)
                if (dimensionUnit == null)
                {
                    // -- Invalid format.                 
                    throw new NumberFormatException();
                }
                else
                {
                    // -- Return valid dimension.                 
                    return new InternalDimension(value, dimensionUnit);
                }
            }
            else
            {
                // -- Invalid format.             
                throw new NumberFormatException();
            }
        }
        
        private class InternalDimension
        {
            public float value;
            //public int unit;
            public Integer unit;
            
            //public InternalDimension(float value, int unit)
            public InternalDimension(float value, Integer unit)
            {
                this.value = value;
                this.unit = unit;
            }
        }
    }*/
}

