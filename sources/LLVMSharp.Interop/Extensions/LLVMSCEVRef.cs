// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace LLVMSharp.Interop;

public unsafe partial struct LLVMSCEVRef(IntPtr handle) : IEquatable<LLVMSCEVRef>
{
    public IntPtr Handle = handle;

    public readonly LLVMSCEVType Type => (Handle != IntPtr.Zero) ? LLVM.GetSCEVType(this) : default;

    public readonly LLVMSCEVRef IsAConstant => (Handle != IntPtr.Zero) ? LLVM.IsSCEVConstant(this) : null;

    public readonly LLVMSCEVRef IsAVScale => (Handle != IntPtr.Zero) ? LLVM.IsSCEVVScale(this) : null;

    public readonly LLVMSCEVRef IsATruncate => (Handle != IntPtr.Zero) ? LLVM.IsSCEVTruncateExpr(this) : null;

    public readonly LLVMSCEVRef IsAZeroExtend => (Handle != IntPtr.Zero) ? LLVM.IsSCEVZeroExtendExpr(this) : null;

    public readonly LLVMSCEVRef IsASignExtend => (Handle != IntPtr.Zero) ? LLVM.IsSCEVSignExtendExpr(this) : null;

    public readonly LLVMSCEVRef IsAAddExpr => (Handle != IntPtr.Zero) ? LLVM.IsSCEVAddExpr(this) : null;

    public readonly LLVMSCEVRef IsAMulExpr => (Handle != IntPtr.Zero) ? LLVM.IsSCEVMulExpr(this) : null;

    public readonly LLVMSCEVRef IsAUDivExpr => (Handle != IntPtr.Zero) ? LLVM.IsSCEVUDivExpr(this) : null;

    public readonly LLVMSCEVRef IsAAddRecExpr => (Handle != IntPtr.Zero) ? LLVM.IsSCEVAddRecExpr(this) : null;

    public readonly LLVMSCEVRef IsAUMaxExpr => (Handle != IntPtr.Zero) ? LLVM.IsSCEVUMaxExpr(this) : null;

    public readonly LLVMSCEVRef IsASMaxExpr => (Handle != IntPtr.Zero) ? LLVM.IsSCEVSMaxExpr(this) : null;

    public readonly LLVMSCEVRef IsAUMinExpr => (Handle != IntPtr.Zero) ? LLVM.IsSCEVUMinExpr(this) : null;

    public readonly LLVMSCEVRef IsASMinExpr => (Handle != IntPtr.Zero) ? LLVM.IsSCEVSMinExpr(this) : null;

    public readonly LLVMSCEVRef IsASequentialUMinExpr => (Handle != IntPtr.Zero) ? LLVM.IsSCEVSequentialUMinExpr(this) : null;

    public readonly LLVMSCEVRef IsAPtrToIntExpr => (Handle != IntPtr.Zero) ? LLVM.IsSCEVPtrToIntExpr(this) : null;

    public readonly LLVMSCEVRef IsAUnknown => (Handle != IntPtr.Zero) ? LLVM.IsSCEVUnknown(this) : null;

    public readonly LLVMSCEVRef IsACouldNotCompute => (Handle != IntPtr.Zero) ? LLVM.IsSCEVCouldNotCompute(this) : null;

    public readonly LLVMSCEVRef IsANAryExpr => (Handle != IntPtr.Zero) ? LLVM.IsSCEVNAryExpr(this) : null;

    public readonly LLVMSCEVRef IsACommutativeExpr => (Handle != IntPtr.Zero) ? LLVM.IsSCEVCommutativeExpr(this) : null;

    public readonly ulong NumOperands => (IsANAryExpr != null) ? LLVM.GetNumSCEVOperands(this) : 0;

    public readonly LLVMSCEVRef GetOperand(ulong i) => (IsANAryExpr != null) ? LLVM.GetSCEVOperand(this, i) : null;

    public readonly LLVMValueRef ConstValue => (IsAConstant != null) ? LLVM.SCEVConstGetValue(this) : null;

    public static implicit operator LLVMSCEVRef(LLVMOpaqueSCEV* value) => new((IntPtr)value);

    public static implicit operator LLVMOpaqueSCEV*(LLVMSCEVRef value) => (LLVMOpaqueSCEV*)value.Handle;

    public static bool operator ==(LLVMSCEVRef left, LLVMSCEVRef right) => left.Handle == right.Handle;

    public static bool operator !=(LLVMSCEVRef left, LLVMSCEVRef right) => !(left == right);

    public override readonly bool Equals(object? obj) => (obj is LLVMSCEVRef other) && Equals(other);

    public readonly bool Equals(LLVMSCEVRef other) => this == other;

    public override readonly int GetHashCode() => Handle.GetHashCode();
}
