// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace LLVMSharp.Interop;

public unsafe partial struct LLVMMemorySSARef(IntPtr handle) : IEquatable<LLVMMemorySSARef>
{
    public IntPtr Handle = handle;

    public readonly LLVMMemorySSAWalkerRef GetWalker() => LLVM.GetMemorySSAWalker(this);

    public readonly LLVMMemorySSAWalkerRef GetSkipSelfWalker() => LLVM.GetMemorySSASkipSelfWalker(this);

    public readonly LLVMMemoryAccessRef GetMemoryAccess(LLVMValueRef instruction) => LLVM.GetInstructionMemoryAccess(this, instruction);

    public readonly LLVMMemoryAccessRef GetMemoryAccess(LLVMBasicBlockRef block) => LLVM.GetBlockMemoryAccess(this, block);

    public readonly bool IsLiveOnEntryDef(LLVMMemoryAccessRef accessRef) => LLVM.IsLiveOnEntryDef(this, accessRef);

    public readonly LLVMMemoryAccessRef LiveOnEntryDef => (Handle != IntPtr.Zero) ? LLVM.GetLiveOnEntryDef(this) : null;

    // Block accesses
    // Block defs

    public readonly bool LocallyDominates(LLVMMemoryAccessRef A, LLVMMemoryAccessRef B) => LLVM.MemoryAccessesAreLocallyDominated(this, A, B);

    public readonly bool Dominates(LLVMMemoryAccessRef A, LLVMMemoryAccessRef B) => LLVM.MemoryAccessesAreDominated(this, A, B);

    public static implicit operator LLVMMemorySSARef(LLVMOpaqueMemorySSA* value) => new LLVMMemorySSARef((IntPtr)value);

    public static implicit operator LLVMOpaqueMemorySSA*(LLVMMemorySSARef value) => (LLVMOpaqueMemorySSA*)value.Handle;

    public static bool operator ==(LLVMMemorySSARef left, LLVMMemorySSARef right) => left.Handle == right.Handle;

    public static bool operator !=(LLVMMemorySSARef left, LLVMMemorySSARef right) => !(left == right);

    public override readonly bool Equals(object? obj) => (obj is LLVMMemorySSARef other) && Equals(other);

    public readonly bool Equals(LLVMMemorySSARef other) => this == other;

    public override readonly int GetHashCode() => Handle.GetHashCode();
}
