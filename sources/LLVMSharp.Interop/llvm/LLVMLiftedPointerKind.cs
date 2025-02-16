// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace LLVMSharp.Interop;

public enum LLVMLiftedPointerKind
{
    LLVMUnknownPointer,
    LLVMStatePointer,
    LLVMIndirectPointer,
    LLVMStackPointer,
    LLVMMemoryPointer,
}
