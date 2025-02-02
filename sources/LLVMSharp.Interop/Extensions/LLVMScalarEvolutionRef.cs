// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace LLVMSharp.Interop;

public unsafe partial struct LLVMScalarEvolutionRef(IntPtr handle) : IEquatable<LLVMScalarEvolutionRef>
{
    public IntPtr Handle = handle;

    public readonly LLVMSCEVRef GetSCEV(LLVMValueRef V) => LLVM.ScalarEvolutionGetSCEV(this, V);

    public static implicit operator LLVMScalarEvolutionRef(LLVMOpaqueScalarEvolution* value) => new((IntPtr)value);

    public static implicit operator LLVMOpaqueScalarEvolution*(LLVMScalarEvolutionRef value) => (LLVMOpaqueScalarEvolution*)value.Handle;

    public static bool operator ==(LLVMScalarEvolutionRef left, LLVMScalarEvolutionRef right) => left.Handle == right.Handle;

    public static bool operator !=(LLVMScalarEvolutionRef left, LLVMScalarEvolutionRef right) => !(left == right);

    public override readonly bool Equals(object? obj) => (obj is LLVMScalarEvolutionRef other) && Equals(other);

    public readonly bool Equals(LLVMScalarEvolutionRef other) => this == other;

    public override readonly int GetHashCode() => Handle.GetHashCode();
}

