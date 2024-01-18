Pour information sur linux j'ai eu une erreur avec l'import de la librairie sous ubuntu :
J'ai donc mocké mais laissé ma fonction de base afin que vous puissiez l'évaluer

```
System.TypeInitializationException: The type initializer for 'OpenCvSharp.Internal.NativeMethods' threw an exception.

System.TypeInitializationException
The type initializer for 'OpenCvSharp.Internal.NativeMethods' threw an exception.
at OpenCvSharp.Internal.NativeMethods.imgcodecs_imdecode_vector(Byte* buf, Int32 bufLength, Int32 flags, IntPtr& returnValue)
at OpenCvSharp.Cv2.ImDecode(ReadOnlySpan`1 span, ImreadModes flags)
--- End of stack trace from previous location ---
at System.Threading.ExecutionContext.RunFromThreadPoolDispatchLoop(Thread threadPoolThread, ExecutionContext executionContext, ContextCallback callback, Object state)
at OpenCvSharp.Cv2.ImDecode(Byte[] buf, ImreadModes flags)
at System.Threading.Tasks.Task.ExecuteWithThreadLocal(Task& currentTaskSlot, Thread threadPoolThread)
at OpenCvSharp.Mat.ImDecode(Byte[] imageBytes, ImreadModes mode)
at OpenCvSharp.Mat.FromImageData(Byte[] imageBytes, ImreadModes mode)
at Louis.Martin.FeatureMatching.ObjectDetection.DetectObjectInScene(Byte[] imageObjectData, Byte[] imageSceneData) in /home/louis/RiderProjects/Louis.Martin.FeatureMatching/Louis.Martin.FeatureMatching/ObjectDetection.cs:line 21
at Louis.Martin.FeatureMatching.ObjectDetection.<>c__DisplayClass0_1.<DetectObjectInScenesAsync>b__1() in /home/louis/RiderProjects/Louis.Martin.FeatureMatching/Louis.Martin.FeatureMatching/ObjectDetection.cs:line 10
at System.Threading.Tasks.Task`1.InnerInvoke()
at System.Threading.ExecutionContext.RunFromThreadPoolDispatchLoop(Thread threadPoolThread, ExecutionContext executionContext, ContextCallback callback, Object state)
--- End of stack trace from previous location ---
at System.Threading.ExecutionContext.RunFromThreadPoolDispatchLoop(Thread threadPoolThread, ExecutionContext executionContext, ContextCallback callback, Object state)
at System.Threading.Tasks.Task.ExecuteWithThreadLocal(Task& currentTaskSlot, Thread threadPoolThread)
--- End of stack trace from previous location ---
at Louis.Martin.FeatureMatching.ObjectDetection.DetectObjectInScenesAsync(Byte[] objectImageData, IList`1 imagesSceneData) in /home/louis/RiderProjects/Louis.Martin.FeatureMatching/Louis.Martin.FeatureMatching/ObjectDetection.cs:line 12
at Louis.Martin.FeatureMatching.Tests.FeatureMatchingUnitTest.ObjectShouldBeDetectedCorrectly() in /home/louis/RiderProjects/Louis.Martin.FeatureMatching/Louis.Martin.FeatureMatching.Tests/FeatureMatchingUnitTest.cs:line 24
at Xunit.Sdk.TestInvoker`1.<>c__DisplayClass48_0.<<InvokeTestMethodAsync>b__1>d.MoveNext() in /_/src/xunit.execution/Sdk/Frameworks/Runners/TestInvoker.cs:line 264
--- End of stack trace from previous location ---
at Xunit.Sdk.ExecutionTimer.AggregateAsync(Func`1 asyncAction) in /_/src/xunit.execution/Sdk/Frameworks/ExecutionTimer.cs:line 48
at Xunit.Sdk.ExceptionAggregator.RunAsync(Func`1 code) in /_/src/xunit.core/Sdk/ExceptionAggregator.cs:line 90

System.DllNotFoundException
Unable to load shared library 'OpenCvSharpExtern' or one of its dependencies. In order to help diagnose loading problems, consider using a tool like strace. If you're using glibc, consider setting the LD_DEBUG environment variable:
/usr/share/dotnet/shared/Microsoft.NETCore.App/8.0.1/OpenCvSharpExtern.so: cannot open shared object file: No such file or directory
/usr/share/dotnet/shared/Microsoft.NETCore.App/8.0.1/libOpenCvSharpExtern.so: cannot open shared object file: No such file or directory
/usr/share/dotnet/shared/Microsoft.NETCore.App/8.0.1/OpenCvSharpExtern: cannot open shared object file: No such file or directory
/usr/share/dotnet/shared/Microsoft.NETCore.App/8.0.1/libOpenCvSharpExtern: cannot open shared object file: No such file or directory

at OpenCvSharp.Internal.NativeMethods.redirectError(CvErrorCallback errCallback, IntPtr userdata, IntPtr& prevUserdata)
at OpenCvSharp.Internal.ExceptionHandler.RegisterExceptionCallback()
at OpenCvSharp.Internal.NativeMethods.LoadLibraries(IEnumerable`1 additionalPaths)
at OpenCvSharp.Internal.NativeMethods..cctor()
```