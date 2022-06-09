
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly lesson7
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 6C 65 73 73 6F 6E 37 00 00 )             // ...lesson7..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 6C 65 73 73 6F 6E 37 00 00 )             // ...lesson7..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 32 00 00 )                            //  2022..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 30 32 63 64 35 30 34 37 2D 65 34 64 37   // ..$02cd5047-e4d7
                                                                                                  2D 34 61 33 32 2D 62 38 39 34 2D 31 33 35 30 33   // -4a32-b894-13503
                                                                                                  33 65 36 64 63 32 38 00 00 )                      // 3e6dc28..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module lesson7.exe
// MVID: {78DDA84C-7AB1-4292-A3FB-5E388776B9FB}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x0B640000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit lesson7.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Test1() cil managed
  {
    // Размер кода:       185 (0xb9)
    .maxstack  3
    .locals init ([0] int32 m,
             [1] int32 n,
             [2] int32 i,
             [3] int32 V_3)
    IL_0000:  ldstr      bytearray (21 04 3A 04 3E 04 3B 04 4C 04 3A 04 3E 04 20 00   // !.:.>.;.L.:.>. .
                                    47 04 38 04 41 04 35 04 3B 04 20 00 3D 04 35 04   // G.8.A.5.;. .=.5.
                                    3E 04 31 04 45 04 3E 04 34 04 38 04 3C 04 3E 04   // >.1.E.>.4.8.<.>.
                                    20 00 32 04 4B 04 32 04 35 04 41 04 42 04 38 04   //  .2.K.2.5.A.B.8.
                                    3F 00 )                                           // ?.
    IL_0005:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000a:  call       string [mscorlib]System.Console::ReadLine()
    IL_000f:  call       int32 [mscorlib]System.Int32::Parse(string)
    IL_0014:  stloc.0
    IL_0015:  ldc.i4.0
    IL_0016:  stloc.2
    IL_0017:  br.s       IL_0033

    IL_0019:  ldloca.s   i
    IL_001b:  call       instance string [mscorlib]System.Int32::ToString()
    IL_0020:  ldstr      " "
    IL_0025:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_002a:  call       void [mscorlib]System.Console::Write(string)
    IL_002f:  ldloc.2
    IL_0030:  ldc.i4.1
    IL_0031:  add
    IL_0032:  stloc.2
    IL_0033:  ldloc.2
    IL_0034:  ldloc.0
    IL_0035:  blt.s      IL_0019

    IL_0037:  call       void [mscorlib]System.Console::WriteLine()
    IL_003c:  ldstr      bytearray (21 04 3A 04 3E 04 3B 04 4C 04 3A 04 3E 04 20 00   // !.:.>.;.L.:.>. .
                                    47 04 38 04 41 04 35 04 3B 04 20 00 3D 04 35 04   // G.8.A.5.;. .=.5.
                                    3E 04 31 04 45 04 3E 04 34 04 38 04 3C 04 3E 04   // >.1.E.>.4.8.<.>.
                                    20 00 32 04 4B 04 32 04 35 04 41 04 42 04 38 04   //  .2.K.2.5.A.B.8.
                                    3F 00 )                                           // ?.
    IL_0041:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0046:  call       string [mscorlib]System.Console::ReadLine()
    IL_004b:  call       int32 [mscorlib]System.Int32::Parse(string)
    IL_0050:  stloc.1
    IL_0051:  ldc.i4.0
    IL_0052:  stloc.3
    IL_0053:  br.s       IL_006f

    IL_0055:  ldloca.s   V_3
    IL_0057:  call       instance string [mscorlib]System.Int32::ToString()
    IL_005c:  ldstr      " "
    IL_0061:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_0066:  call       void [mscorlib]System.Console::Write(string)
    IL_006b:  ldloc.3
    IL_006c:  ldc.i4.1
    IL_006d:  add
    IL_006e:  stloc.3
    IL_006f:  ldloc.3
    IL_0070:  ldloc.1
    IL_0071:  blt.s      IL_0055

    IL_0073:  call       void [mscorlib]System.Console::WriteLine()
    IL_0078:  ldstr      bytearray (12 04 4B 04 32 04 35 04 34 04 35 04 3D 04 3E 04   // ..K.2.5.4.5.=.>.
                                    20 00 7B 00 30 00 7D 00 20 00 47 04 38 04 41 04   //  .{.0.}. .G.8.A.
                                    35 04 3B 04 )                                     // 5.;.
    IL_007d:  ldloc.1
    IL_007e:  box        [mscorlib]System.Int32
    IL_0083:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_0088:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_008d:  ldstr      bytearray (12 04 4B 04 32 04 35 04 34 04 35 04 3D 04 3E 04   // ..K.2.5.4.5.=.>.
                                    20 00 )                                           //  .
    IL_0092:  ldloca.s   n
    IL_0094:  call       instance string [mscorlib]System.Int32::ToString()
    IL_0099:  ldstr      bytearray (20 00 47 04 38 04 41 04 35 04 3B 04 )             //  .G.8.A.5.;.
    IL_009e:  call       string [mscorlib]System.String::Concat(string,
                                                                string,
                                                                string)
    IL_00a3:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00a8:  ldstr      bytearray (12 04 4B 04 32 04 35 04 34 04 35 04 3D 04 3E 04   // ..K.2.5.4.5.=.>.
                                    20 00 7B 00 30 00 7D 00 20 00 47 04 38 04 41 04   //  .{.0.}. .G.8.A.
                                    35 04 3B 04 )                                     // 5.;.
    IL_00ad:  ldloc.1
    IL_00ae:  box        [mscorlib]System.Int32
    IL_00b3:  call       void [mscorlib]System.Console::WriteLine(string,
                                                                  object)
    IL_00b8:  ret
  } // end of method Program::Test1

  .method private hidebysig static string 
          Test2() cil managed
  {
    // Размер кода:       6 (0x6)
    .maxstack  8
    IL_0000:  call       string [mscorlib]System.Console::ReadLine()
    IL_0005:  ret
  } // end of method Program::Test2

  .method private hidebysig static int32 
          Fi(int32 n) cil managed
  {
    // Размер кода:       57 (0x39)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  brtrue.s   IL_0005

    IL_0003:  ldc.i4.0
    IL_0004:  ret

    IL_0005:  ldarg.0
    IL_0006:  ldc.i4.1
    IL_0007:  bne.un.s   IL_000b

    IL_0009:  ldc.i4.1
    IL_000a:  ret

    IL_000b:  ldarg.0
    IL_000c:  ldc.i4.m1
    IL_000d:  bne.un.s   IL_0011

    IL_000f:  ldc.i4.1
    IL_0010:  ret

    IL_0011:  ldarg.0
    IL_0012:  ldc.i4.0
    IL_0013:  ble.s      IL_0027

    IL_0015:  ldarg.0
    IL_0016:  ldc.i4.1
    IL_0017:  sub
    IL_0018:  call       int32 lesson7.Program::Fi(int32)
    IL_001d:  ldarg.0
    IL_001e:  ldc.i4.2
    IL_001f:  sub
    IL_0020:  call       int32 lesson7.Program::Fi(int32)
    IL_0025:  add
    IL_0026:  ret

    IL_0027:  ldarg.0
    IL_0028:  ldc.i4.2
    IL_0029:  add
    IL_002a:  call       int32 lesson7.Program::Fi(int32)
    IL_002f:  ldarg.0
    IL_0030:  ldc.i4.1
    IL_0031:  add
    IL_0032:  call       int32 lesson7.Program::Fi(int32)
    IL_0037:  sub
    IL_0038:  ret
  } // end of method Program::Fi

  .method private hidebysig static void  Test3() cil managed
  {
    // Размер кода:       126 (0x7e)
    .maxstack  2
    .locals init ([0] int32 n,
             [1] int32 i,
             [2] int32 V_2,
             [3] int32 V_3)
    IL_0000:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    46 04 35 04 3B 04 3E 04 35 04 20 00 47 04 38 04   // F.5.;.>.5. .G.8.
                                    41 04 3B 04 3E 04 20 00 6E 00 2C 00 20 00 34 04   // A.;.>. .n.,. .4.
                                    3B 04 4F 04 20 00 3A 04 3E 04 42 04 3E 04 40 04   // ;.O. .:.>.B.>.@.
                                    3E 04 33 04 3E 04 20 00 31 04 43 04 34 04 35 04   // >.3.>. .1.C.4.5.
                                    42 04 20 00 32 04 4B 04 47 04 38 04 41 04 3B 04   // B. .2.K.G.8.A.;.
                                    35 04 3D 04 30 04 20 00 3F 04 3E 04 41 04 3B 04   // 5.=.0. .?.>.A.;.
                                    35 04 34 04 3E 04 32 04 30 04 42 04 35 04 3B 04   // 5.4.>.2.0.B.5.;.
                                    4C 04 3D 04 3E 04 41 04 42 04 4C 04 20 00 47 04   // L.=.>.A.B.L. .G.
                                    38 04 41 04 35 04 3B 04 20 00 24 04 38 04 31 04   // 8.A.5.;. .$.8.1.
                                    3E 04 3D 04 30 04 47 04 47 04 38 04 3A 00 20 00 ) // >.=.0.G.G.8.:. .
    IL_0005:  call       void [mscorlib]System.Console::Write(string)
    IL_000a:  ldc.i4.0
    IL_000b:  stloc.0
    IL_000c:  br.s       IL_0018

    IL_000e:  ldstr      bytearray (21 04 42 04 40 04 3E 04 3A 04 30 04 20 00 32 04   // !.B.@.>.:.0. .2.
                                    32 04 35 04 34 04 35 04 3D 04 30 04 20 00 3D 04   // 2.5.4.5.=.0. .=.
                                    35 04 32 04 35 04 40 04 3D 04 3E 04 2C 00 20 00   // 5.2.5.@.=.>.,. .
                                    3F 04 3E 04 32 04 42 04 3E 04 40 04 38 04 42 04   // ?.>.2.B.>.@.8.B.
                                    35 04 20 00 41 04 3D 04 3E 04 32 04 30 04 2E 00 ) // 5. .A.=.>.2.0...
    IL_0013:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0018:  call       string [mscorlib]System.Console::ReadLine()
    IL_001d:  ldloca.s   n
    IL_001f:  call       bool [mscorlib]System.Int32::TryParse(string,
                                                               int32&)
    IL_0024:  brfalse.s  IL_000e

    IL_0026:  ldloc.0
    IL_0027:  ldc.i4.0
    IL_0028:  ble.s      IL_0054

    IL_002a:  ldc.i4.0
    IL_002b:  stloc.1
    IL_002c:  br.s       IL_004f

    IL_002e:  ldloc.1
    IL_002f:  call       int32 lesson7.Program::Fi(int32)
    IL_0034:  stloc.2
    IL_0035:  ldloca.s   V_2
    IL_0037:  call       instance string [mscorlib]System.Int32::ToString()
    IL_003c:  ldstr      " "
    IL_0041:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_0046:  call       void [mscorlib]System.Console::Write(string)
    IL_004b:  ldloc.1
    IL_004c:  ldc.i4.1
    IL_004d:  add
    IL_004e:  stloc.1
    IL_004f:  ldloc.1
    IL_0050:  ldloc.0
    IL_0051:  ble.s      IL_002e

    IL_0053:  ret

    IL_0054:  ldc.i4.0
    IL_0055:  stloc.3
    IL_0056:  br.s       IL_0079

    IL_0058:  ldloc.3
    IL_0059:  call       int32 lesson7.Program::Fi(int32)
    IL_005e:  stloc.2
    IL_005f:  ldloca.s   V_2
    IL_0061:  call       instance string [mscorlib]System.Int32::ToString()
    IL_0066:  ldstr      " "
    IL_006b:  call       string [mscorlib]System.String::Concat(string,
                                                                string)
    IL_0070:  call       void [mscorlib]System.Console::Write(string)
    IL_0075:  ldloc.3
    IL_0076:  ldc.i4.1
    IL_0077:  sub
    IL_0078:  stloc.3
    IL_0079:  ldloc.3
    IL_007a:  ldloc.0
    IL_007b:  bge.s      IL_0058

    IL_007d:  ret
  } // end of method Program::Test3

  .method private hidebysig static void  Test4() cil managed
  {
    // Размер кода:       1 (0x1)
    .maxstack  8
    IL_0000:  ret
  } // end of method Program::Test4

  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       256 (0x100)
    .maxstack  1
    .locals init ([0] bool repeat,
             [1] int32 choice)
    IL_0000:  ldc.i4.1
    IL_0001:  stloc.0
    IL_0002:  br         IL_00f2

    IL_0007:  call       void [mscorlib]System.Console::Clear()
    IL_000c:  ldc.i4.0
    IL_000d:  stloc.1
    IL_000e:  ldc.i4.s   10
    IL_0010:  call       void [mscorlib]System.Console::set_ForegroundColor(valuetype [mscorlib]System.ConsoleColor)
    IL_0015:  ldstr      "[1-3]"
    IL_001a:  call       void [mscorlib]System.Console::Write(string)
    IL_001f:  call       void [mscorlib]System.Console::ResetColor()
    IL_0024:  ldstr      bytearray (20 00 12 04 32 04 35 04 34 04 38 04 42 04 35 04   //  ...2.5.4.8.B.5.
                                    20 00 3D 04 3E 04 3C 04 35 04 40 04 20 00 37 04   //  .=.>.<.5.@. .7.
                                    30 04 34 04 30 04 47 04 38 04 2C 00 20 00 3A 04   // 0.4.0.G.8.,. .:.
                                    3E 04 42 04 3E 04 40 04 43 04 4E 04 20 00 45 04   // >.B.>.@.C.N. .E.
                                    3E 04 42 04 38 04 42 04 35 04 20 00 3F 04 40 04   // >.B.8.B.5. .?.@.
                                    3E 04 41 04 3C 04 3E 04 42 04 40 04 35 04 42 04   // >.A.<.>.B.@.5.B.
                                    4C 04 3A 00 )                                     // L.:.
    IL_0029:  call       void [mscorlib]System.Console::WriteLine(string)
    .try
    {
      .try
      {
        IL_002e:  call       string [mscorlib]System.Console::ReadLine()
        IL_0033:  call       int32 [mscorlib]System.Int32::Parse(string)
        IL_0038:  stloc.1
        IL_0039:  leave.s    IL_0059

      }  // end .try
      catch [mscorlib]System.Exception 
      {
        IL_003b:  callvirt   instance string [mscorlib]System.Exception::get_Message()
        IL_0040:  call       void [mscorlib]System.Console::WriteLine(string)
        IL_0045:  ldstr      bytearray (1D 04 35 04 3E 04 31 04 45 04 3E 04 34 04 38 04   // ..5.>.1.E.>.4.8.
                                        3C 04 3E 04 20 00 32 04 32 04 35 04 41 04 42 04   // <.>. .2.2.5.A.B.
                                        38 04 20 00 47 04 38 04 41 04 3B 04 3E 04 2C 00   // 8. .G.8.A.;.>.,.
                                        20 00 30 04 20 00 32 04 4B 04 20 00 32 04 32 04   //  .0. .2.K. .2.2.
                                        35 04 3B 04 38 04 20 00 41 04 42 04 40 04 3E 04   // 5.;.8. .A.B.@.>.
                                        3A 04 43 04 )                                     // :.C.
        IL_004a:  call       void [mscorlib]System.Console::WriteLine(string)
        IL_004f:  ldc.i4.m1
        IL_0050:  stloc.1
        IL_0051:  leave.s    IL_0059

      }  // end handler
    }  // end .try
    finally
    {
      IL_0053:  call       void [mscorlib]System.Console::WriteLine()
      IL_0058:  endfinally
    }  // end handler
    IL_0059:  ldloc.1
    IL_005a:  switch     ( 
                          IL_00d3,
                          IL_0079,
                          IL_008c,
                          IL_00a4,
                          IL_00b7,
                          IL_00c5)
    IL_0077:  br.s       IL_00e1

    IL_0079:  call       void lesson7.Program::Test1()
    IL_007e:  call       void [mscorlib]System.Console::WriteLine()
    IL_0083:  ldc.i4.1
    IL_0084:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey(bool)
    IL_0089:  pop
    IL_008a:  br.s       IL_00f2

    IL_008c:  call       string lesson7.Program::Test2()
    IL_0091:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0096:  call       void [mscorlib]System.Console::WriteLine()
    IL_009b:  ldc.i4.1
    IL_009c:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey(bool)
    IL_00a1:  pop
    IL_00a2:  br.s       IL_00f2

    IL_00a4:  call       void lesson7.Program::Test3()
    IL_00a9:  call       void [mscorlib]System.Console::WriteLine()
    IL_00ae:  ldc.i4.1
    IL_00af:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey(bool)
    IL_00b4:  pop
    IL_00b5:  br.s       IL_00f2

    IL_00b7:  call       void [mscorlib]System.Console::WriteLine()
    IL_00bc:  ldc.i4.1
    IL_00bd:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey(bool)
    IL_00c2:  pop
    IL_00c3:  br.s       IL_00f2

    IL_00c5:  call       void [mscorlib]System.Console::WriteLine()
    IL_00ca:  ldc.i4.1
    IL_00cb:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey(bool)
    IL_00d0:  pop
    IL_00d1:  br.s       IL_00f2

    IL_00d3:  ldstr      bytearray (12 04 4B 04 45 04 3E 04 34 04 20 00 38 04 37 04   // ..K.E.>.4. .8.7.
                                    20 00 3F 04 40 04 3E 04 33 04 40 04 30 04 3C 04   //  .?.@.>.3.@.0.<.
                                    3C 04 4B 04 20 00 2E 00 2E 00 2E 00 )             // <.K. .......
    IL_00d8:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00dd:  ldc.i4.0
    IL_00de:  stloc.0
    IL_00df:  br.s       IL_00f2

    IL_00e1:  ldstr      bytearray (1F 04 3E 04 3B 04 43 04 47 04 35 04 3D 04 3E 04   // ..>.;.C.G.5.=.>.
                                    20 00 3D 04 35 04 3A 04 3E 04 40 04 40 04 35 04   //  .=.5.:.>.@.@.5.
                                    3A 04 42 04 3D 04 3E 04 35 04 20 00 37 04 3D 04   // :.B.=.>.5. .7.=.
                                    30 04 47 04 35 04 3D 04 38 04 35 04 2E 00 20 00   // 0.G.5.=.8.5... .
                                    1F 04 3E 04 32 04 42 04 3E 04 40 04 38 04 42 04   // ..>.2.B.>.@.8.B.
                                    35 04 20 00 32 04 32 04 3E 04 34 04 20 00 41 04   // 5. .2.2.>.4. .A.
                                    3D 04 3E 04 32 04 30 04 2E 00 )                   // =.>.2.0...
    IL_00e6:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00eb:  ldc.i4.1
    IL_00ec:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey(bool)
    IL_00f1:  pop
    IL_00f2:  ldloc.0
    IL_00f3:  brtrue     IL_0007

    IL_00f8:  ldc.i4.1
    IL_00f9:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey(bool)
    IL_00fe:  pop
    IL_00ff:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class lesson7.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 D:\MyPr\c#\geekbrains\introduction\lesson7\bin\Release\ildasmLesson7.res
