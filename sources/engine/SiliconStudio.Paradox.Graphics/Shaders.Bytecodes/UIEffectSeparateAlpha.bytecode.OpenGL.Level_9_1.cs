﻿#if SILICONSTUDIO_PARADOX_GRAPHICS_API_OPENGLCORE
//------------------------------------------------------------------------------
// <auto-generated>
//     Paradox Effect Compiler File Generated:
//     Effect [UIEffectSeparateAlpha]
//
//     Command Line: C:\Projects\Paradox\sources\engine\SiliconStudio.Paradox.Graphics\Shaders.Bytecodes\..\..\..\..\Bin\Windows-Direct3D11\SiliconStudio.Assets.CompilerApp.exe --platform=Windows --profile=Windows --output-path=C:\Projects\Paradox\sources\engine\SiliconStudio.Paradox.Graphics\Shaders.Bytecodes\obj\app_data --build-path=C:\Projects\Paradox\sources\engine\SiliconStudio.Paradox.Graphics\Shaders.Bytecodes\obj\build_app_data --package-file=Graphics.pdxpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Paradox.Graphics 
{
    internal partial class UIEffectSeparateAlpha
    {
        private static readonly byte[] binaryBytecode = new byte[] {
1, 192, 254, 239, 0, 3, 0, 0, 0, 21, 85, 73, 69, 102, 102, 101, 99, 116, 83, 101, 112, 97, 114, 97, 116, 101, 65, 108, 112, 104, 97, 1, 46, 206, 219, 94, 217, 53, 237, 231, 114, 68, 160, 176, 231, 40, 60, 119, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 38, 78, 99, 69, 57, 
166, 56, 80, 170, 135, 207, 17, 198, 242, 239, 219, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 81, 38, 111, 95, 215, 119, 15, 182, 65, 120, 243, 215, 80, 6, 228, 35, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 34, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 46, 80, 
97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 0, 0, 0, 0, 0, 23, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 
109, 112, 108, 101, 114, 0, 0, 0, 0, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 51, 55, 8, 0, 0, 0, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 49, 0, 
0, 0, 0, 0, 13, 84, 101, 120, 116, 117, 114, 101, 49, 95, 105, 100, 49, 53, 9, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 0, 0, 0, 0, 0, 13, 
84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 9, 0, 0, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 0, 0, 0, 0, 0, 11, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 10, 
0, 0, 0, 25, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 21, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 
0, 0, 0, 0, 0, 255, 255, 127, 255, 255, 255, 127, 127, 0, 17, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 0, 77, 5, 0, 0, 35, 118, 101, 114, 115, 105, 111, 
110, 32, 52, 50, 48, 13, 10, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 53, 56, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 
50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 53, 57, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 
95, 105, 100, 48, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 
32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 53, 57, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 73, 78, 80, 
85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 53, 56, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 59, 13, 10, 32, 32, 32, 32, 118, 101, 
99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 53, 57, 59, 13, 10, 125, 59, 13, 10, 115, 116, 100, 49, 52, 48, 32, 117, 110, 105, 102, 111, 114, 109, 32, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 32, 123, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 80, 97, 114, 97, 
100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 59, 13, 10, 125, 59, 13, 10, 111, 117, 116, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 111, 117, 116, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 
82, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 67, 79, 76, 79, 82, 
48, 59, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 73, 78, 80, 85, 84, 32, 95, 105, 110, 112, 117, 116, 95, 59, 13, 10, 32, 32, 32, 32, 95, 105, 110, 112, 117, 116, 95, 46, 67, 111, 108, 111, 114, 95, 105, 100, 53, 
57, 32, 61, 32, 97, 95, 67, 79, 76, 79, 82, 48, 59, 13, 10, 32, 32, 32, 32, 95, 105, 110, 112, 117, 116, 95, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 105, 110, 
112, 117, 116, 95, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 53, 56, 32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 
115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 53, 56, 32, 61, 32, 95, 105, 110, 112, 117, 116, 95, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 53, 56, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 
111, 111, 114, 100, 95, 105, 100, 53, 53, 32, 61, 32, 95, 105, 110, 112, 117, 116, 95, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 95, 105, 100, 53, 57, 32, 61, 32, 95, 105, 110, 
112, 117, 116, 95, 46, 67, 111, 108, 111, 114, 95, 105, 100, 53, 57, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 
116, 105, 111, 110, 95, 105, 100, 53, 56, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 111, 117, 116, 112, 117, 116, 95, 59, 13, 10, 32, 32, 32, 32, 95, 111, 117, 116, 112, 117, 116, 95, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 
110, 95, 105, 100, 48, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 95, 111, 117, 116, 112, 117, 116, 95, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 
32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 59, 13, 10, 32, 32, 32, 32, 95, 111, 117, 116, 112, 117, 116, 95, 46, 67, 111, 108, 111, 114, 95, 105, 100, 53, 57, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 
111, 114, 95, 105, 100, 53, 57, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 32, 61, 32, 95, 111, 117, 116, 112, 117, 116, 95, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 
95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 32, 61, 32, 95, 111, 117, 116, 112, 117, 116, 95, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 59, 13, 10, 32, 32, 32, 32, 118, 95, 67, 79, 76, 79, 82, 48, 32, 61, 32, 95, 111, 117, 116, 112, 117, 116, 95, 46, 67, 111, 
108, 111, 114, 95, 105, 100, 53, 57, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 42, 32, 50, 46, 48, 32, 45, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 
46, 119, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 80, 97, 114, 97, 100, 111, 120, 70, 108, 105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 32, 42, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 
59, 13, 10, 125, 13, 10, 1, 20, 73, 198, 238, 47, 115, 242, 27, 8, 165, 139, 46, 137, 250, 197, 230, 0, 5, 0, 0, 0, 0, 225, 4, 0, 0, 35, 118, 101, 114, 115, 105, 111, 110, 32, 52, 50, 48, 13, 10, 13, 10, 111, 117, 116, 32, 118, 101, 99, 52, 32, 103, 108, 95, 70, 114, 97, 
103, 68, 97, 116, 97, 91, 49, 93, 59, 13, 10, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 59, 13, 10, 32, 32, 32, 
32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 95, 105, 100, 53, 57, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 79, 85, 84, 80, 
85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 
32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 
108, 111, 114, 95, 105, 100, 53, 57, 59, 13, 10, 125, 59, 13, 10, 115, 116, 100, 49, 52, 48, 32, 117, 110, 105, 102, 111, 114, 109, 32, 79, 112, 101, 110, 103, 108, 70, 108, 97, 103, 115, 32, 123, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 80, 97, 114, 97, 100, 111, 120, 70, 108, 
105, 112, 82, 101, 110, 100, 101, 114, 116, 97, 114, 103, 101, 116, 59, 13, 10, 125, 59, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 51, 
55, 59, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 49, 95, 105, 100, 49, 53, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 51, 55, 59, 13, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 
67, 79, 79, 82, 68, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 13, 10, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 
114, 101, 97, 109, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 51, 32, 99, 111, 108, 111, 114, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 51, 55, 44, 32, 
115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 41, 46, 114, 103, 98, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 97, 108, 112, 104, 97, 32, 61, 32, 116, 101, 120, 116, 117, 114, 101, 40, 84, 101, 120, 116, 117, 114, 101, 49, 95, 
105, 100, 49, 53, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 51, 55, 44, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 41, 46, 114, 59, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 118, 101, 99, 52, 40, 99, 111, 
108, 111, 114, 44, 32, 97, 108, 112, 104, 97, 41, 32, 42, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 95, 105, 100, 53, 57, 59, 13, 10, 125, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 
80, 85, 84, 32, 95, 105, 110, 112, 117, 116, 95, 59, 13, 10, 32, 32, 32, 32, 95, 105, 110, 112, 117, 116, 95, 46, 67, 111, 108, 111, 114, 95, 105, 100, 53, 57, 32, 61, 32, 118, 95, 67, 79, 76, 79, 82, 48, 59, 13, 10, 32, 32, 32, 32, 95, 105, 110, 112, 117, 116, 95, 46, 84, 101, 
120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 105, 110, 112, 117, 116, 95, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 103, 108, 
95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 32, 
61, 32, 95, 105, 110, 112, 117, 116, 95, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 53, 53, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 95, 105, 100, 53, 57, 32, 61, 32, 95, 105, 110, 112, 117, 116, 95, 46, 67, 111, 108, 111, 114, 
95, 105, 100, 53, 57, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 115, 116, 114, 101, 97, 109, 115, 41, 59, 13, 10, 32, 32, 32, 
32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 111, 117, 116, 112, 117, 116, 95, 59, 13, 10, 32, 32, 32, 32, 95, 111, 117, 116, 112, 117, 116, 95, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 
111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 70, 114, 97, 103, 68, 97, 116, 97, 91, 48, 93, 32, 61, 32, 95, 111, 117, 116, 112, 117, 116, 95, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 
13, 10, 1, 218, 209, 126, 244, 172, 58, 246, 166, 64, 21, 155, 176, 90, 50, 127, 153, 
        };
    }
}
#endif
