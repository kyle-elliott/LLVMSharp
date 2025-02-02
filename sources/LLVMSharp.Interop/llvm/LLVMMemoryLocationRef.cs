// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Reflection.Metadata;

namespace LLVMSharp.Interop;

public unsafe partial struct LLVMMemoryLocationRef(IntPtr handle) : IDisposable, IEquatable<LLVMMemoryLocationRef>
{
    public IntPtr Handle = handle;

    public readonly LLVMValueRef Pointer => (Handle != IntPtr.Zero) ? LLVM.GetMemoryLocationPointer(this) : null;

    public readonly ulong Size => (Handle != IntPtr.Zero) ? LLVM.GetMemoryLocationSize(this) : 0;

    public static LLVMMemoryLocationRef Get(LLVMValueRef inst)
    {
        return LLVM.MemoryLocationGet(inst);
    }

    public static LLVMMemoryLocationRef Get(LLVMValueRef inst, LLVMLocationSize size)
    {
        return LLVM.MemoryLocationGetInstSize(inst, size.ToRaw());
    }

    public static LLVMMemoryLocationRef GetAfter(LLVMValueRef ptr)
    {
        return Get(ptr, LLVMLocationSize.AfterPointer());
    }

    public static LLVMMemoryLocationRef GetBeforeOrAfter(LLVMValueRef ptr)
    {
        return Get(ptr, LLVMLocationSize.BeforeOrAfterPointer());
    }

    public static implicit operator LLVMMemoryLocationRef(LLVMOpaqueMemoryLocation* value) => new LLVMMemoryLocationRef((IntPtr)value);

    public static implicit operator LLVMOpaqueMemoryLocation*(LLVMMemoryLocationRef value) => (LLVMOpaqueMemoryLocation*)value.Handle;

    public static bool operator ==(LLVMMemoryLocationRef left, LLVMMemoryLocationRef right) => left.Handle == right.Handle;

    public static bool operator !=(LLVMMemoryLocationRef left, LLVMMemoryLocationRef right) => !(left == right);

    public override readonly bool Equals(object? obj) => (obj is LLVMMemoryLocationRef other) && Equals(other);

    public readonly bool Equals(LLVMMemoryLocationRef other) => this == other;

    public override readonly int GetHashCode() => Handle.GetHashCode();

    public readonly string PrintToString()
    {
        var pStr = LLVM.PrintMemoryLocationToString(this);

        if (pStr == null)
        {
            return string.Empty;
        }

        var result = SpanExtensions.AsString(pStr);
        LLVM.DisposeMessage(pStr);
        return result;
    }

    public override readonly string ToString() => (Handle != IntPtr.Zero) ? PrintToString() : string.Empty;

    public void Dispose()
    {
        if (Handle != IntPtr.Zero)
        {
            LLVM.DisposeMemoryLocation(this);
            Handle = IntPtr.Zero;
        }
    }
}
