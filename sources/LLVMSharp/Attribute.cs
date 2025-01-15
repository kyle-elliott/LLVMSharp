// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using LLVMSharp.Interop;

namespace LLVMSharp;

public sealed class Attribute : IEquatable<Attribute>
{
    public LLVMAttributeRef Handle { get; }

    public static bool operator ==(Attribute? left, Attribute? right) => ReferenceEquals(left, right) || left?.Handle == right?.Handle;

    public static bool operator !=(Attribute? left, Attribute? right) => !(left == right);

    public override bool Equals(object? obj) => obj is Attribute other && Equals(other);

    public bool Equals(Attribute? other) => this == other;

    public override int GetHashCode() => Handle.GetHashCode();

    public override string ToString() => Handle.ToString();
}

public enum AttributeKind
{
    None,

    FirstEnumAttr = 1,
    AllocAlign = 1,
    AllocatedPointer = 2,
    AlwaysInline = 3,
    Builtin = 4,
    Cold = 5,
    Convergent = 6,
    CoroDestroyOnlyWhenComplete = 7,
    DeadOnUnwind = 8,
    DisableSanitizerInstrumentation = 9,
    FnRetThunkExtern = 10,
    Hot = 11,
    HybridPatchable = 12,
    ImmArg = 13,
    InReg = 14,
    InlineHint = 15,
    JumpTable = 16,
    MinSize = 17,
    MustProgress = 18,
    Naked = 19,
    Nest = 20,
    NoAlias = 21,
    NoBuiltin = 22,
    NoCallback = 23,
    NoCapture = 24,
    NoCfCheck = 25,
    NoDuplicate = 26,
    NoFree = 27,
    NoImplicitFloat = 28,
    NoInline = 29,
    NoMerge = 30,
    NoProfile = 31,
    NoRecurse = 32,
    NoRedZone = 33,
    NoReturn = 34,
    NoSanitizeBounds = 35,
    NoSanitizeCoverage = 36,
    NoSync = 37,
    NoUndef = 38,
    NoUnwind = 39,
    NonLazyBind = 40,
    NonNull = 41,
    NullPointerIsValid = 42,
    OptForFuzzing = 43,
    OptimizeForDebugging = 44,
    OptimizeForSize = 45,
    OptimizeNone = 46,
    PresplitCoroutine = 47,
    ReadNone = 48,
    ReadOnly = 49,
    Returned = 50,
    ReturnsTwice = 51,
    SExt = 52,
    SafeStack = 53,
    SanitizeAddress = 54,
    SanitizeHWAddress = 55,
    SanitizeMemTag = 56,
    SanitizeMemory = 57,
    SanitizeNumericalStability = 58,
    SanitizeThread = 59,
    ShadowCallStack = 60,
    SkipProfile = 61,
    Speculatable = 62,
    SpeculativeLoadHardening = 63,
    StackProtect = 64,
    StackProtectReq = 65,
    StackProtectStrong = 66,
    StrictFP = 67,
    SwiftAsync = 68,
    SwiftError = 69,
    SwiftSelf = 70,
    WillReturn = 71,
    Writable = 72,
    WriteOnly = 73,
    ZExt = 74,
    LastEnumAttr = 74,
    FirstTypeAttr = 75,
    ByRef = 75,
    ByVal = 76,
    ElementType = 77,
    InAlloca = 78,
    Preallocated = 79,
    StructRet = 80,
    LastTypeAttr = 80,
    FirstIntAttr = 81,
    Alignment = 81,
    AllocKind = 82,
    AllocSize = 83,
    Dereferenceable = 84,
    DereferenceableOrNull = 85,
    Memory = 86,
    NoFPClass = 87,
    StackAlignment = 88,
    UWTable = 89,
    VScaleRange = 90,
    LastIntAttr = 90,
    FirstConstantRangeAttr = 91,
    Range = 91,
    LastConstantRangeAttr = 91,
    FirstConstantRangeListAttr = 92,
    Initializes = 92,
    LastConstantRangeListAttr = 92,
}
