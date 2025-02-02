// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace LLVMSharp.Interop;

public unsafe partial struct LLVMAliasResultRef(IntPtr handle) : IEquatable<LLVMAliasResultRef>
{
    public IntPtr Handle = handle;

    public readonly LLVMAliasResultKind Kind => (Handle != IntPtr.Zero) ? (LLVMAliasResultKind)LLVM.AAResultGetKind(this) : LLVMAliasResultKind.LLVMAAResultInvalid;

    public readonly bool HasOffset => (Handle != IntPtr.Zero) && LLVM.AAResultHasOffset(this);

    // Generate get/set for Offset
    public readonly int Offset
    {
        get
        {
            return (Handle != IntPtr.Zero && HasOffset) ? LLVM.AAResultGetOffset(this) : 0;
        }

        set
        {
            if (Handle != IntPtr.Zero)
            {
                LLVM.AAResultSetOffset(this, value);
            }
        }
    }

    public static implicit operator LLVMAliasResultRef(LLVMOpaqueAliasResult* value) => new((IntPtr)value);

    public static implicit operator LLVMOpaqueAliasResult*(LLVMAliasResultRef value) => (LLVMOpaqueAliasResult*)value.Handle;

    public static bool operator ==(LLVMAliasResultRef left, LLVMAliasResultKind right) => left.Kind == right;

    public static bool operator !=(LLVMAliasResultRef left, LLVMAliasResultKind right) => !(left == right);

    public static bool operator ==(LLVMAliasResultRef left, LLVMAliasResultRef right) => left.Kind == right.Kind && left.HasOffset == right.HasOffset && left.Offset == right.Offset;

    public static bool operator !=(LLVMAliasResultRef left, LLVMAliasResultRef right) => !(left == right);

    public override readonly bool Equals(object? obj) => (obj is LLVMAliasResultRef other) && Equals(other);

    public readonly bool Equals(LLVMAliasResultRef other) => this == other;

    public override readonly int GetHashCode() => Handle.GetHashCode();

    public readonly string PrintToString()
    {
        var pStr = LLVM.PrintAAResultToString(this);

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
