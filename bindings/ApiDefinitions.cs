using Foundation;
using UIKit;

namespace Drastic.WatchdogInspector
{
	// @interface TWWatchdogInspector : NSObject
	[BaseType (typeof(NSObject))]
	interface TWWatchdogInspector
	{
		// +(void)start;
		[Static]
		[Export ("start")]
		void Start ();

		// +(void)stop;
		[Static]
		[Export ("stop")]
		void Stop ();

		// +(BOOL)isRunning;
		[Static]
		[Export ("isRunning")]
		[Verify (MethodToProperty)]
		bool IsRunning { get; }

		// +(void)setStallingThreshhold:(NSTimeInterval)time;
		[Static]
		[Export ("setStallingThreshhold:")]
		void SetStallingThreshhold (double time);

		// +(void)setEnableMainthreadStallingException:(BOOL)enable;
		[Static]
		[Export ("setEnableMainthreadStallingException:")]
		void SetEnableMainthreadStallingException (bool enable);

		// +(void)setUpdateWatchdogInterval:(NSTimeInterval)time;
		[Static]
		[Export ("setUpdateWatchdogInterval:")]
		void SetUpdateWatchdogInterval (double time);

		// +(void)setUseLogs:(BOOL)useLogs;
		[Static]
		[Export ("setUseLogs:")]
		void SetUseLogs (bool useLogs);
	}

	// @interface TWWatchdogInspectorViewController : UIViewController
	[BaseType (typeof(UIViewController))]
	interface TWWatchdogInspectorViewController
	{
		// -(void)updateFPS:(double)fps;
		[Export ("updateFPS:")]
		void UpdateFPS (double fps);

		// -(void)updateStallingTime:(NSTimeInterval)stallingTime;
		[Export ("updateStallingTime:")]
		void UpdateStallingTime (double stallingTime);
	}
}
