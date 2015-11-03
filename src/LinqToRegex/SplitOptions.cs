﻿// Copyright (c) Josef Pihrt. All rights reserved. Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Pihrtsoft.Text.RegularExpressions.Linq
{
#if DEBUG
    [Flags]
    public enum SplitOptions
    {
        None = 0,
        OmitGroups = 1,
        OmitEmptyValues = 2
    }
#endif
}
