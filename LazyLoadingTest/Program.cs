using LazyLoadingTest;
using LazyLoadingTest.AutoModel;
using System.Diagnostics;

var stopwatchLazyLoad = Stopwatch.StartNew();
var autoLazyLoad = new AutoLazyLoad();
autoLazyLoad.Init();
var valueLazyload = autoLazyLoad.CurrentSpeedLazyLoad.Value;
stopwatchLazyLoad.Stop();


var stopwatchLazyLoadNotUsed = Stopwatch.StartNew();
var autoLazyLoadNotUsed = new AutoLazyLoad();
autoLazyLoadNotUsed.Init();
stopwatchLazyLoadNotUsed.Stop();

var stopwatch = Stopwatch.StartNew();
var auto = new Auto();
auto.Init();
var autoValue = auto.CurrentSpeed;
stopwatch.Stop();

Console.WriteLine($"LazyLoadNotUsed:{stopwatchLazyLoadNotUsed.Elapsed}");
Console.WriteLine($"LazyLoad:       {stopwatchLazyLoad.Elapsed}");
Console.WriteLine($"Normal:         {stopwatch.Elapsed}");


