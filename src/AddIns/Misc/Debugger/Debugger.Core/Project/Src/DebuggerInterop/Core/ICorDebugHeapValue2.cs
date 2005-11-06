﻿// <file>
//     <copyright see="prj:///doc/copyright.txt">2002-2005 AlphaSierraPapa</copyright>
//     <license see="prj:///doc/license.txt">GNU General Public License</license>
//     <owner name="David Srbecký" email="dsrbecky@gmail.com"/>
//     <version>$Revision$</version>
// </file>

namespace DebuggerInterop.Core
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport, Guid("E3AC4D6C-9CB7-43E6-96CC-B21540E5083C"), InterfaceType((short) 1)]
    public interface ICorDebugHeapValue2
    {
        [MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
        void CreateHandle([In] CorDebugHandleType type, [MarshalAs(UnmanagedType.Interface)] out ICorDebugHandleValue ppHandle);
    }
}
