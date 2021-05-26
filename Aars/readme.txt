AAR file (Android ARchive, really zip) contains (* - is not optional):
-* Java classes in one Jar file
- res folder with all resources like images and xmls in it
- generated R file with resources indexes, is necessary for using resources
- assets folder with assets as html pages and images, videos, etc
- annotations.zip file with generated Java annotations
- proguard.txt file with proguard Android linking info
-* AndroidManifest file

# Keep in mind that there can be only one AAR file in the Java Binding project!

If you wanna use more than one you must merge all AARs in one. That could be done:
- using fat-aar gradle plugin in Android Studio (not recommended, cause is not stable)
- manually opening AARs and gathering all above described data and merging in one AAR
(you need to paste all data in several files with the same names like VALUES-XX
and create project in Android to generate AAR fie or do AAR creation manually)

# Keep in mind proguard.txt could contain duplicates inside (especially after the merge)

Here is proguard beautifier open source project: https://github.com/maxoiduss/ProguardBeautifier

For some reason AndroidManifest info is not exposed to resulting dll and you may have
to copy all that data to your main Android project where this dll will be used
(this issue needs to be investigated and fixed in the future)

You may add annotaitions.zip file (for example, after merge) in the resulting AAR
(I cannot find any solution to do it in another way)

Here is Android Studio resource project: https://github.com/maxoiduss/XX