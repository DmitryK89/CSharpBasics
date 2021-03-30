namespace Nutshell.Theory
{
    public class Runtime
    {
        //Runtime -  (also called a framework) is a deployable unit that you download and install
        //   Consist of: CLR (Common language runtime)
        //               BCL (Base class library)
        //               ApplicationLayer (optional, ASP.Net, Windows Desktop, Xamarin.Android and other)
        
        //CLR -  provides essential runtime services such as automatic memory management and exception handling
        // The CLR converts the IL into the native code of the machine, such as X64 or X86, usually just prior to execution.
        // Just-In-Time (JIT) compilation.
        
        //CLR has  garbage collector that executes as part of your program, reclaiming memory for objects that are no longer referenced
        
        //Assembly - container for managed code. Contain IL and type Information (metadata).The presence of metadata allows
        //assemblies to reference types in other assemblies without needing additional files. A program can query its own metadata (reflection)
        //and even generate new IL at runtime (reflection.emit).
        
        //BCL -  Base Class Library (BCL). Provides core functionality to programmers, such as collections, input/output, text processing,
        // XML/JSON handling, networking, encryption, interop, concurrency, and parallel programming. A BCL also implements types that the
        // C# language itself requires (for features such as enumeration, querying, and asynchrony) and lets you explicitly access features of
        // the CLR, such as Reflection and memory management.
    }
}