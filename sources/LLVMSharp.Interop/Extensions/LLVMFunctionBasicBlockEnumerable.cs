// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Collections;
using System.Collections.Generic;

namespace LLVMSharp.Interop;

public readonly record struct LLVMFunctionBasicBlockEnumerable(LLVMValueRef Function) : IEnumerable<LLVMBasicBlockRef>
{
    public Enumerator GetEnumerator() => new(Function);
    IEnumerator<LLVMBasicBlockRef> IEnumerable<LLVMBasicBlockRef>.GetEnumerator() => GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public struct Enumerator(LLVMValueRef function) : IEnumerator<LLVMBasicBlockRef>
    {
        public LLVMBasicBlockRef Current { get; private set; }
        readonly object IEnumerator.Current => Current;
        readonly void IDisposable.Dispose() { }

        public bool MoveNext()
        {
            if (Current.Handle == IntPtr.Zero)
            {
                Current = function.FirstBasicBlock;
            }
            else
            {
                Current = Current.Next;
            }
            return Current.Handle != IntPtr.Zero;
        }
        public void Reset() => Current = default;
    }
}
