// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Text;

namespace LLVMSharp.Interop;

public struct LLVMLocationSize : IEquatable<LLVMLocationSize>
{
    private enum Map : ulong
    {
        BeforeOrAfterPointer = ~0uL,
        ScalableBit = 1uL << 62,
        AfterPointer = (BeforeOrAfterPointer - 1uL) & ~ScalableBit,
        MapEmpty = BeforeOrAfterPointer - 2uL,
        MapTombstone = BeforeOrAfterPointer - 3uL,
        ImpreciseBit = 1uL << 63,

        // // The maximum value we can represent without falling back to 'unknown'.
        MaxValue = (MapTombstone - 1uL) & ~(ImpreciseBit | ScalableBit),
    }

    private readonly ulong _value;

    // Hack to support implicit construction. This should disappear when the
    // public LocationSize ctor goes away.
    private enum DirectConstruction { Direct }

    private LLVMLocationSize(ulong raw, DirectConstruction _)
    {
        _value = raw;
    }

    private LLVMLocationSize(ulong raw, bool scalable)
    {
        _value = raw > (ulong)Map.MaxValue ? (ulong)Map.AfterPointer : raw | (ulong)(scalable ? Map.ScalableBit : 0);
    }

    public LLVMLocationSize(ulong raw)
    {
        _value = raw > (ulong)Map.MaxValue ? (ulong)Map.AfterPointer : raw;
    }

    public static LLVMLocationSize Raw(ulong raw) => new(raw, DirectConstruction.Direct);

    public static LLVMLocationSize Precise(ulong value) => new(value, false);

    public static LLVMLocationSize UpperBound(ulong value)
    {
        return value switch {
            0 => Precise(0),
            > (ulong)Map.MaxValue => AfterPointer(),
            _ => new LLVMLocationSize(value | (ulong)Map.ImpreciseBit, DirectConstruction.Direct)
        };
    }

    public static LLVMLocationSize AfterPointer() => new((ulong)Map.AfterPointer, DirectConstruction.Direct);
    public static LLVMLocationSize BeforeOrAfterPointer() => new((ulong)Map.BeforeOrAfterPointer, DirectConstruction.Direct);
    public static LLVMLocationSize MapTombstone() => new((ulong)Map.MapTombstone, DirectConstruction.Direct);
    public static LLVMLocationSize MapEmpty() => new((ulong)Map.MapEmpty, DirectConstruction.Direct);

    // Returns a LocationSize that can correctly represent either `this` or `Other`.
    public readonly LLVMLocationSize UnionWith(LLVMLocationSize other)
    {
        if (other == this)
        {
            return this;
        }

        if (_value == (ulong)Map.BeforeOrAfterPointer || other._value == (ulong)Map.BeforeOrAfterPointer)
        {
            return BeforeOrAfterPointer();
        }

        if (_value == (ulong)Map.AfterPointer || other._value == (ulong)Map.AfterPointer)
        {
            return AfterPointer();
        }

        if (IsScalable() || other.IsScalable())
        {
            return AfterPointer();
        }

        return UpperBound(ulong.Max(TypeSizeValue(), other.TypeSizeValue()));
    }

    public readonly bool HasValue() => _value != (ulong)Map.BeforeOrAfterPointer && _value != (ulong)Map.AfterPointer;
    public readonly bool IsScalable() => (_value & (ulong)Map.ScalableBit) != 0;
    public readonly ulong TypeSizeValue() => _value & ~((ulong)Map.ScalableBit | (ulong)Map.ImpreciseBit);
    public readonly bool IsPrecise() => (_value & (ulong)Map.ImpreciseBit) == 0;
    public readonly bool IsZero() => HasValue()  && TypeSizeValue() == 0;
    public readonly bool MayBeBeforePointer() => _value == (ulong)Map.BeforeOrAfterPointer;

    public readonly ulong ToRaw() => _value;

    public static bool operator ==(LLVMLocationSize left, LLVMLocationSize right) => left._value == right._value;

    public static bool operator !=(LLVMLocationSize left, LLVMLocationSize right) => !(left == right);

    public override readonly bool Equals(object? obj) => (obj is LLVMLocationSize other) && Equals(other);

    public readonly bool Equals(LLVMLocationSize other) => this == other;

    public override readonly int GetHashCode() => _value.GetHashCode();

    public override readonly string ToString()
    {
        StringBuilder sb = new();
        _ = sb.Append("LLVMLocationSize::");
        if (this == BeforeOrAfterPointer())
        {
            _ = sb.Append("BeforeOrAfterPointer");
        }
        else if (this == AfterPointer())
        {
            _ = sb.Append("AfterPointer");
        }
        else if (this == MapTombstone())
        {
            _ = sb.Append("MapTombstone");
        }
        else if (this == MapEmpty())
        {
            _ = sb.Append("MapEmpty");
        }
        else if (IsPrecise())
        {
            _ = sb.Append("Precise(");
            _ = sb.Append(TypeSizeValue());
            _ = sb.Append(')');
        }
        else
        {
            _ = sb.Append("UpperBound(");
            _ = sb.Append(TypeSizeValue());
            _ = sb.Append(')');
        }

        return sb.ToString();
    }
}
