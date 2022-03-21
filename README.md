# xf-ios-renderer-issue

Hello! 

There is an issue when you are referencing control with renderers from other assemblies, the control's iOS renderers do not work in the app at all. 
I didn't notice any issues in Android in the same approach. 

There is a chance that there is a problem in my environment or setup. 

### Description
- `AwesomeControl`, `AwesomeControl.Droid`, `AwesomeControl.iOS` are library projects that contains `AwesomeEntry` control with renderers for both platforms.
- `ios_renderer`, `ios_renderer.Android`, `ios_renderer.iOS` are xamarin application projects that contains `SunnyEntry` control with renderers for both platforms, and the page `AboutPage` to display `SunnyEntry` and `AwesomeEntry`.


### Expected Behavior
- Both Entries for both platforms should be of 'HotPink' color (see the screenshot from Android).
- Debug is also not working for`AwesomeControl.iOS\AwesomeEntryRenderer.cs`, neither `.ctor` or `OnElementChanged` are called. 


### Actual Behavior
- iOS renderer for `AwesomeEntry` from the `AwesomeControl.iOS` project is referenced by the `ios_renderer.iOS` project not working.

### Basic Information
- Microsoft Visual Studio Enterprise 2022
- Version 17.1.1
- VisualStudio.17.Release/17.1.1+32228.430
- Xamarin   17.1.0.309 (d17-1@3f96c58)
- Xamarin.iOS and Xamarin.Mac SDK   15.6.0.3 (caa899d24)
- Microsoft Visual Studio for Mac 8.10.20

### Screenshots
ANDROID OK:

![android ok](https://github.com/bondarenkod/xf-ios-renderer-issue/blob/master/android_ok.jpg)

iOS FAIL:

![ios not ok](https://github.com/bondarenkod/xf-ios-renderer-issue/blob/master/ios_notok.jpg)


