// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace LLVMSharp.Interop;

public enum LLVMSCEVType
{
    LLVMSCEVTypeConstant,
    LLVMSCEVTypeVScale,
    LLVMSCEVTypeTruncate,
    LLVMSCEVTypeZeroExtend,
    LLVMSCEVTypeSignExtend,
    LLVMSCEVTypeAddExpr,
    LLVMSCEVTypeMulExpr,
    LLVMSCEVTypeUDivExpr,
    LLVMSCEVTypeAddRecExpr,
    LLVMSCEVTypeUMaxExpr,
    LLVMSCEVTypeSMaxExpr,
    LLVMSCEVTypeUMinExpr,
    LLVMSCEVTypeSMinExpr,
    LLVMSCEVTypeSequentialUMinExpr,
    LLVMSCEVTypePtrToInt,
    LLVMSCEVTypeUnknown,
    LLVMSCEVTypeCouldNotCompute
}
