namespace ChromaAPISync
{
    class Program
    {
        static void Main(string[] args)
        {
            const string headerStdafx = @"C:\Razer\CChromaEditor\CChromaEditorLibrary\stdafx.h";
            Converter.ConvertExportsToClass(headerStdafx, "ChromaAnimationAPI.h", "ChromaAnimationAPI.cpp", "ChromaAnimationAPI.md",
                "stdafx.h");
        }
    }
}
