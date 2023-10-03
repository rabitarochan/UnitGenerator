﻿// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY UnitGenerator. DO NOT CHANGE IT.
// </auto-generated>
#pragma warning disable CS8669
#pragma warning disable CS8625
using System;
#if NET7_0_OR_GREATER
using System.Numerics;
#endif

namespace UnitGenerator
{
    [AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
    internal class UnitOfAttribute : Attribute
    {
        public Type Type { get; }
        public UnitGenerateOptions Options { get; }
        public UnitArithmeticOperators ArithmeticOperators { get; set; } = UnitArithmeticOperators.All;
        public string ToStringFormat { get; set; }

        public UnitOfAttribute(Type type, UnitGenerateOptions options = UnitGenerateOptions.None)
        {
            this.Type = type;
            this.Options = options;
        }
    }
    
    [Flags]
    internal enum UnitGenerateOptions
    {
        None = 0,
        ImplicitOperator = 1,
        ParseMethod = 1 << 1,
        MinMaxMethod = 1 << 2,
        ArithmeticOperator = 1 << 3,
        ValueArithmeticOperator = 1 << 4,
        Comparable = 1 << 5,
        Validate = 1 << 6,
        JsonConverter = 1 << 7,
        MessagePackFormatter = 1 << 8,
        DapperTypeHandler = 1 << 9,
        EntityFrameworkValueConverter = 1 << 10,
        WithoutComparisonOperator = 1 << 11,
        JsonConverterDictionaryKeySupport = 1 << 12,
        Normalize = 1 << 13,
        PrivateConstructor = 1 << 14,
    }

    [Flags]
    internal enum UnitArithmeticOperators
    {
        All = Addition | Subtraction | Multiply | Division | Increment | Decrement,
        Addition = 1,
        Subtraction = 1 << 1,
        Multiply = 1 << 2,
        Division = 1 << 3,
        Increment = 1 << 4,
        Decrement = 1 << 5,
    }
}
