// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Collections.Generic;

namespace LLVMSharp.Interop;

public unsafe partial struct LLVMMemoryAccessRef(IntPtr handle) : IEquatable<LLVMMemoryAccessRef>
{
    public IntPtr Handle = handle;

    public readonly LLVMBasicBlockRef Block => (Handle != IntPtr.Zero) ? LLVM.GetMemoryAccessBlock(this) : null;

    public readonly bool IsUseOrDef => (Handle != IntPtr.Zero) && LLVM.IsMemoryAccessUseOrDef(this);

    public readonly bool IsUse => (Handle != IntPtr.Zero) && LLVM.IsMemoryAccessUse(this);

    public readonly bool IsDef => (Handle != IntPtr.Zero) && LLVM.IsMemoryAccessDef(this);

    public readonly bool IsMemoryPhi => (Handle != IntPtr.Zero) && LLVM.IsMemoryAccessPhi(this);

    public readonly LLVMValueRef MemoryInstruction => (Handle != IntPtr.Zero && IsUseOrDef) ? LLVM.GetMemoryAccessMemoryInst(this) : null;

    public readonly LLVMMemoryAccessRef DefiningAccess => (Handle != IntPtr.Zero && IsUseOrDef) ? LLVM.GetMemoryAccessDefiningAccess(this) : null;

    public static implicit operator LLVMMemoryAccessRef(LLVMOpaqueMemoryAccess* value) => new LLVMMemoryAccessRef((IntPtr)value);

    public static implicit operator LLVMOpaqueMemoryAccess*(LLVMMemoryAccessRef value) => (LLVMOpaqueMemoryAccess*)value.Handle;

    public static bool operator ==(LLVMMemoryAccessRef left, LLVMMemoryAccessRef right) => left.Handle == right.Handle;

    public static bool operator !=(LLVMMemoryAccessRef left, LLVMMemoryAccessRef right) => !(left == right);

    public override readonly bool Equals(object? obj) => (obj is LLVMMemoryAccessRef other) && Equals(other);

    public readonly bool Equals(LLVMMemoryAccessRef other) => this == other;

    public override readonly int GetHashCode() => Handle.GetHashCode();

    public readonly string PrintToString()
    {
        var pStr = LLVM.PrintMemoryAccessToString(this);

        if (pStr == null)
        {
            return string.Empty;
        }

        var result = SpanExtensions.AsString(pStr);
        LLVM.DisposeMessage(pStr);
        return result;
    }

    public override readonly string ToString() => (Handle != IntPtr.Zero) ? PrintToString() : string.Empty;
}
