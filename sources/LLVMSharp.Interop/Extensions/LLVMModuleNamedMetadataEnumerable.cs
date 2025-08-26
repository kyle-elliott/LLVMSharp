// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace LLVMSharp.Interop;

public readonly record struct LLVMModuleNamedMetadataEnumerable(LLVMModuleRef Module) : IEnumerable<LLVMNamedMDNodeRef>
{
    public Enumerator GetEnumerator() => new(Module);
    IEnumerator<LLVMNamedMDNodeRef> IEnumerable<LLVMNamedMDNodeRef>.GetEnumerator() => GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public struct Enumerator(LLVMModuleRef module) : IEnumerator<LLVMNamedMDNodeRef>
    {
        public LLVMNamedMDNodeRef Current { get; private set; }
        readonly object IEnumerator.Current => Current;
        readonly void IDisposable.Dispose() { }

        public bool MoveNext()
        {
            if (Current.Handle == IntPtr.Zero)
            {
                Current = module.FirstNamedMetadata;
            }
            else
            {
                Current = Current.NextNamedMetadata;
            }
            return Current.Handle != IntPtr.Zero;
        }
        public void Reset() => Current = default;
    }
}
