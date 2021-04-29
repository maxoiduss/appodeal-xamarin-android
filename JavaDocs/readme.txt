About javadocs.
With the latest version of Visual Studio - the point where some problems with javadocs start.
Looks like build engine cannot properly figure out several docs dependencies in the generated java documentation while using JavaDocJar property group.
It is the reason why a bunch of compile warnings is here.
Ignore it until you get a compile-time error.
And remember: you should include only that javadocs which are used for c# code generation, i.e InputJar or EmbeddedJar property group jars.
Other javadocs can be skipped with None property group in the proj file.