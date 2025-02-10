// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace LLVMSharp.Interop;

public unsafe partial struct LLVMMemorySSAWalkerRef(IntPtr handle) : IEquatable<LLVMMemorySSAWalkerRef>
{
    public IntPtr Handle = handle;

    public readonly LLVMMemoryAccessRef GetClobberingMemoryAccess(LLVMMemoryAccessRef access) => LLVM.GetClobberingMemoryAccess(this, access);

    public readonly LLVMMemoryAccessRef GetClobberingMemoryAccess(LLVMMemoryAccessRef access,
        LLVMMemoryLocationRef location) => LLVM.GetClobberingMemoryAccessWithLocation(this, access, location);

    public static implicit operator LLVMMemorySSAWalkerRef(LLVMOpaqueMemorySSAWalker* value) => new LLVMMemorySSAWalkerRef((IntPtr)value);

    public static implicit operator LLVMOpaqueMemorySSAWalker*(LLVMMemorySSAWalkerRef value) => (LLVMOpaqueMemorySSAWalker*)value.Handle;

    public static bool operator ==(LLVMMemorySSAWalkerRef left, LLVMMemorySSAWalkerRef right) => left.Handle == right.Handle;

    public static bool operator !=(LLVMMemorySSAWalkerRef left, LLVMMemorySSAWalkerRef right) => !(left == right);

    public override readonly bool Equals(object? obj) => (obj is LLVMMemorySSAWalkerRef other) && Equals(other);

    public readonly bool Equals(LLVMMemorySSAWalkerRef other) => this == other;

    public override readonly int GetHashCode() => Handle.GetHashCode();
}
