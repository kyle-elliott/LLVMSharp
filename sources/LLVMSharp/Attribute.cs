// Copyright (c) .NET Foundation and Contributors. All Rights Reserved. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using LLVMSharp.Interop;

namespace LLVMSharp;

public sealed class Attribute : IEquatable<Attribute>
{
    public LLVMAttributeRef Handle { get; }

    public static bool operator ==(Attribute? left, Attribute? right) =>
        ReferenceEquals(left, right) || left?.Handle == right?.Handle;

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
    CoroElideSafe = 8,
    DeadOnUnwind = 9,
    DisableSanitizerInstrumentation = 10,
    FnRetThunkExtern = 11,
    Hot = 12,
    HybridPatchable = 13,
    ImmArg = 14,
    InReg = 15,
    InlineHint = 16,
    JumpTable = 17,
    MinSize = 18,
    MustProgress = 19,
    Naked = 20,
    Nest = 21,
    NoAlias = 22,
    NoBuiltin = 23,
    NoCallback = 24,
    NoCapture = 25,
    NoCfCheck = 26,
    NoDivergenceSource = 27,
    NoDuplicate = 28,
    NoExt = 29,
    NoFree = 30,
    NoImplicitFloat = 31,
    NoInline = 32,
    NoMerge = 33,
    NoProfile = 34,
    NoRecurse = 35,
    NoRedZone = 36,
    NoReturn = 37,
    NoSanitizeBounds = 38,
    NoSanitizeCoverage = 39,
    NoSync = 40,
    NoUndef = 41,
    NoUnwind = 42,
    NonLazyBind = 43,
    NonNull = 44,
    NullPointerIsValid = 45,
    OptForFuzzing = 46,
    OptimizeForDebugging = 47,
    OptimizeForSize = 48,
    OptimizeNone = 49,
    PresplitCoroutine = 50,
    ReadNone = 51,
    ReadOnly = 52,
    Returned = 53,
    ReturnsTwice = 54,
    SExt = 55,
    SafeStack = 56,
    SanitizeAddress = 57,
    SanitizeHWAddress = 58,
    SanitizeMemTag = 59,
    SanitizeMemory = 60,
    SanitizeNumericalStability = 61,
    SanitizeRealtime = 62,
    SanitizeRealtimeBlocking = 63,
    SanitizeThread = 64,
    SanitizeType = 65,
    ShadowCallStack = 66,
    SkipProfile = 67,
    Speculatable = 68,
    SpeculativeLoadHardening = 69,
    StackProtect = 70,
    StackProtectReq = 71,
    StackProtectStrong = 72,
    StrictFP = 73,
    SwiftAsync = 74,
    SwiftError = 75,
    SwiftSelf = 76,
    WillReturn = 77,
    Writable = 78,
    WriteOnly = 79,
    ZExt = 80,
    LastEnumAttr = 80,
    FirstTypeAttr = 81,
    ByRef = 81,
    ByVal = 82,
    ElementType = 83,
    InAlloca = 84,
    Preallocated = 85,
    StructRet = 86,
    LastTypeAttr = 86,
    FirstIntAttr = 87,
    Alignment = 87,
    AllocKind = 88,
    AllocSize = 89,
    Captures = 90,
    Dereferenceable = 91,
    DereferenceableOrNull = 92,
    Memory = 93,
    NoFPClass = 94,
    StackAlignment = 95,
    UWTable = 96,
    VScaleRange = 97,
    LastIntAttr = 97,
    FirstConstantRangeAttr = 98,
    Range = 98,
    LastConstantRangeAttr = 98,
    FirstConstantRangeListAttr = 99,
    Initializes = 99,
    LastConstantRangeListAttr = 99,
}
