// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace LLVMSharp.Interop;

public unsafe partial struct LLVMAAResultsRef(IntPtr handle) : IEquatable<LLVMAAResultsRef>
{
    public IntPtr Handle = handle;

    public readonly LLVMAliasResultRef Alias(LLVMMemoryLocationRef locA, LLVMMemoryLocationRef locB) =>
        LLVM.AAResultsAlias(this, locA, locB);

    public readonly LLVMAliasResultRef Alias(LLVMValueRef v1, LLVMLocationSize v1Size, LLVMValueRef v2,
        LLVMLocationSize v2Size) =>
        Alias(LLVMMemoryLocationRef.Get(v1, v1Size), LLVMMemoryLocationRef.Get(v2, v2Size));

    public readonly LLVMAliasResultRef Alias(LLVMValueRef v1, LLVMValueRef v2) =>
        Alias(LLVMMemoryLocationRef.GetBeforeOrAfter(v1), LLVMMemoryLocationRef.GetBeforeOrAfter(v2));

    public readonly bool IsNoAlias(LLVMMemoryLocationRef locA, LLVMMemoryLocationRef locB) =>
        Alias(locA, locB) == LLVMAliasResultKind.LLVMAAResultNoAlias;

    public readonly bool IsNoAlias(LLVMValueRef v1, LLVMLocationSize v1Size, LLVMValueRef v2,
        LLVMLocationSize v2Size) =>
        IsNoAlias(LLVMMemoryLocationRef.Get(v1, v1Size), LLVMMemoryLocationRef.Get(v2, v2Size));

    public readonly bool IsNoAlias(LLVMValueRef v1, LLVMValueRef v2) =>
        IsNoAlias(LLVMMemoryLocationRef.GetBeforeOrAfter(v1), LLVMMemoryLocationRef.GetBeforeOrAfter(v2));

    public readonly bool IsMustAlias(LLVMMemoryLocationRef locA, LLVMMemoryLocationRef locB) =>
        Alias(locA, locB) == LLVMAliasResultKind.LLVMAAResultMustAlias;

    public readonly bool IsMustAlias(LLVMValueRef v1, LLVMValueRef v2) =>
        Alias(v1, LLVMLocationSize.Precise(1), v2, LLVMLocationSize.Precise(1)) ==
        LLVMAliasResultKind.LLVMAAResultMustAlias;

    public static implicit operator LLVMAAResultsRef(LLVMOpaqueAAResults* value) => new LLVMAAResultsRef((IntPtr)value);

    public static implicit operator LLVMOpaqueAAResults*(LLVMAAResultsRef value) => (LLVMOpaqueAAResults*)value.Handle;

    public static bool operator ==(LLVMAAResultsRef left, LLVMAAResultsRef right) => left.Handle == right.Handle;

    public static bool operator !=(LLVMAAResultsRef left, LLVMAAResultsRef right) => !(left == right);

    public override readonly bool Equals(object? obj) => (obj is LLVMAAResultsRef other) && Equals(other);

    public readonly bool Equals(LLVMAAResultsRef other) => this == other;

    public override readonly int GetHashCode() => Handle.GetHashCode();
}
