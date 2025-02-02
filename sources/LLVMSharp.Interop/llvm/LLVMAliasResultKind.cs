// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace LLVMSharp.Interop;

public enum LLVMAliasResultKind
{
    /// Error value indicating that the alias analysis is not available.
    LLVMAAResultInvalid = -1,
    /// The two locations do not alias at all.
    ///
    /// This value is arranged to convert to false, while all other values
    /// convert to true. This allows a boolean context to convert the result to
    /// a binary flag indicating whether there is the possibility of aliasing.
    LLVMAAResultNoAlias = 0,
    /// The two locations may or may not alias. This is the least precise
    /// result.
    LLVMAAResultMayAlias,
    /// The two locations alias, but only due to a partial overlap.
    LLVMAAResultPartialAlias,
    /// The two locations precisely alias each other.
    LLVMAAResultMustAlias,
}
