using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubRewardedVideoListener']"
	[Register ("com/mopub/mobileads/MoPubRewardedVideoListener", "", "Com.Mopub.Mobileads.IMoPubRewardedVideoListenerInvoker")]
	public partial interface IMoPubRewardedVideoListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubRewardedVideoListener']/method[@name='onRewardedVideoClosed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRewardedVideoClosed", "(Ljava/lang/String;)V", "GetOnRewardedVideoClosed_Ljava_lang_String_Handler:Com.Mopub.Mobileads.IMoPubRewardedVideoListenerInvoker, AppodealXamarinPlugin")]
		void OnRewardedVideoClosed (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubRewardedVideoListener']/method[@name='onRewardedVideoCompleted' and count(parameter)=2 and parameter[1][@type='java.util.Set'] and parameter[2][@type='com.mopub.common.MoPubReward']]"
		[Register ("onRewardedVideoCompleted", "(Ljava/util/Set;Lcom/mopub/common/MoPubReward;)V", "GetOnRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_Handler:Com.Mopub.Mobileads.IMoPubRewardedVideoListenerInvoker, AppodealXamarinPlugin")]
		void OnRewardedVideoCompleted (global::System.Collections.ICollection p0, global::Com.Mopub.Common.MoPubReward p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubRewardedVideoListener']/method[@name='onRewardedVideoLoadFailure' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("onRewardedVideoLoadFailure", "(Ljava/lang/String;Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_Handler:Com.Mopub.Mobileads.IMoPubRewardedVideoListenerInvoker, AppodealXamarinPlugin")]
		void OnRewardedVideoLoadFailure (string p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubRewardedVideoListener']/method[@name='onRewardedVideoLoadSuccess' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRewardedVideoLoadSuccess", "(Ljava/lang/String;)V", "GetOnRewardedVideoLoadSuccess_Ljava_lang_String_Handler:Com.Mopub.Mobileads.IMoPubRewardedVideoListenerInvoker, AppodealXamarinPlugin")]
		void OnRewardedVideoLoadSuccess (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubRewardedVideoListener']/method[@name='onRewardedVideoPlaybackError' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.mobileads.MoPubErrorCode']]"
		[Register ("onRewardedVideoPlaybackError", "(Ljava/lang/String;Lcom/mopub/mobileads/MoPubErrorCode;)V", "GetOnRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_Handler:Com.Mopub.Mobileads.IMoPubRewardedVideoListenerInvoker, AppodealXamarinPlugin")]
		void OnRewardedVideoPlaybackError (string p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads']/interface[@name='MoPubRewardedVideoListener']/method[@name='onRewardedVideoStarted' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("onRewardedVideoStarted", "(Ljava/lang/String;)V", "GetOnRewardedVideoStarted_Ljava_lang_String_Handler:Com.Mopub.Mobileads.IMoPubRewardedVideoListenerInvoker, AppodealXamarinPlugin")]
		void OnRewardedVideoStarted (string p0);

	}

	[global::Android.Runtime.Register ("com/mopub/mobileads/MoPubRewardedVideoListener", DoNotGenerateAcw=true)]
	internal class IMoPubRewardedVideoListenerInvoker : global::Java.Lang.Object, IMoPubRewardedVideoListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/mobileads/MoPubRewardedVideoListener");
		IntPtr class_ref;

		public static IMoPubRewardedVideoListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMoPubRewardedVideoListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mopub.mobileads.MoPubRewardedVideoListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMoPubRewardedVideoListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMoPubRewardedVideoListenerInvoker); }
		}

		static Delegate cb_onRewardedVideoClosed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoClosed_Ljava_lang_String_Handler ()
		{
			if (cb_onRewardedVideoClosed_Ljava_lang_String_ == null)
				cb_onRewardedVideoClosed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRewardedVideoClosed_Ljava_lang_String_);
			return cb_onRewardedVideoClosed_Ljava_lang_String_;
		}

		static void n_OnRewardedVideoClosed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoClosed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoClosed_Ljava_lang_String_;
		public unsafe void OnRewardedVideoClosed (string p0)
		{
			if (id_onRewardedVideoClosed_Ljava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoClosed_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoClosed", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onRewardedVideoClosed_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_Handler ()
		{
			if (cb_onRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_ == null)
				cb_onRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_);
			return cb_onRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_;
		}

		static void n_OnRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaSet.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Common.MoPubReward p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Common.MoPubReward> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoCompleted (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_;
		public unsafe void OnRewardedVideoCompleted (global::System.Collections.ICollection p0, global::Com.Mopub.Common.MoPubReward p1)
		{
			if (id_onRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_ == IntPtr.Zero)
				id_onRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoCompleted", "(Ljava/util/Set;Lcom/mopub/common/MoPubReward;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaSet.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onRewardedVideoCompleted_Ljava_util_Set_Lcom_mopub_common_MoPubReward_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
		{
			if (cb_onRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
				cb_onRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_);
			return cb_onRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_;
		}

		static void n_OnRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubErrorCode p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoLoadFailure (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_;
		public unsafe void OnRewardedVideoLoadFailure (string p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
		{
			if (id_onRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_onRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoLoadFailure", "(Ljava/lang/String;Lcom/mopub/mobileads/MoPubErrorCode;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onRewardedVideoLoadFailure_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onRewardedVideoLoadSuccess_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoLoadSuccess_Ljava_lang_String_Handler ()
		{
			if (cb_onRewardedVideoLoadSuccess_Ljava_lang_String_ == null)
				cb_onRewardedVideoLoadSuccess_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRewardedVideoLoadSuccess_Ljava_lang_String_);
			return cb_onRewardedVideoLoadSuccess_Ljava_lang_String_;
		}

		static void n_OnRewardedVideoLoadSuccess_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoLoadSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoLoadSuccess_Ljava_lang_String_;
		public unsafe void OnRewardedVideoLoadSuccess (string p0)
		{
			if (id_onRewardedVideoLoadSuccess_Ljava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoLoadSuccess_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoLoadSuccess", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onRewardedVideoLoadSuccess_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_Handler ()
		{
			if (cb_onRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ == null)
				cb_onRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_);
			return cb_onRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_;
		}

		static void n_OnRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Mobileads.MoPubErrorCode p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.MoPubErrorCode> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoPlaybackError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_;
		public unsafe void OnRewardedVideoPlaybackError (string p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
		{
			if (id_onRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ == IntPtr.Zero)
				id_onRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoPlaybackError", "(Ljava/lang/String;Lcom/mopub/mobileads/MoPubErrorCode;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (Handle, id_onRewardedVideoPlaybackError_Ljava_lang_String_Lcom_mopub_mobileads_MoPubErrorCode_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_onRewardedVideoStarted_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOnRewardedVideoStarted_Ljava_lang_String_Handler ()
		{
			if (cb_onRewardedVideoStarted_Ljava_lang_String_ == null)
				cb_onRewardedVideoStarted_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRewardedVideoStarted_Ljava_lang_String_);
			return cb_onRewardedVideoStarted_Ljava_lang_String_;
		}

		static void n_OnRewardedVideoStarted_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.IMoPubRewardedVideoListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRewardedVideoStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onRewardedVideoStarted_Ljava_lang_String_;
		public unsafe void OnRewardedVideoStarted (string p0)
		{
			if (id_onRewardedVideoStarted_Ljava_lang_String_ == IntPtr.Zero)
				id_onRewardedVideoStarted_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "onRewardedVideoStarted", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (Handle, id_onRewardedVideoStarted_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

	public partial class RewardedVideoClosedEventArgs : global::System.EventArgs {

		public RewardedVideoClosedEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	public partial class RewardedVideoCompletedEventArgs : global::System.EventArgs {

		public RewardedVideoCompletedEventArgs (global::System.Collections.ICollection p0, global::Com.Mopub.Common.MoPubReward p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::System.Collections.ICollection p0;
		public global::System.Collections.ICollection P0 {
			get { return p0; }
		}

		global::Com.Mopub.Common.MoPubReward p1;
		public global::Com.Mopub.Common.MoPubReward P1 {
			get { return p1; }
		}
	}

	public partial class RewardedVideoLoadFailureEventArgs : global::System.EventArgs {

		public RewardedVideoLoadFailureEventArgs (string p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Com.Mopub.Mobileads.MoPubErrorCode p1;
		public global::Com.Mopub.Mobileads.MoPubErrorCode P1 {
			get { return p1; }
		}
	}

	public partial class RewardedVideoLoadSuccessEventArgs : global::System.EventArgs {

		public RewardedVideoLoadSuccessEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	public partial class RewardedVideoPlaybackErrorEventArgs : global::System.EventArgs {

		public RewardedVideoPlaybackErrorEventArgs (string p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}

		global::Com.Mopub.Mobileads.MoPubErrorCode p1;
		public global::Com.Mopub.Mobileads.MoPubErrorCode P1 {
			get { return p1; }
		}
	}

	public partial class RewardedVideoStartedEventArgs : global::System.EventArgs {

		public RewardedVideoStartedEventArgs (string p0)
		{
			this.p0 = p0;
		}

		string p0;
		public string P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/com/mopub/mobileads/MoPubRewardedVideoListenerImplementor")]
	internal sealed partial class IMoPubRewardedVideoListenerImplementor : global::Java.Lang.Object, IMoPubRewardedVideoListener {

		object sender;

		public IMoPubRewardedVideoListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/mobileads/MoPubRewardedVideoListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<RewardedVideoClosedEventArgs> OnRewardedVideoClosedHandler;
#pragma warning restore 0649

		public void OnRewardedVideoClosed (string p0)
		{
			var __h = OnRewardedVideoClosedHandler;
			if (__h != null)
				__h (sender, new RewardedVideoClosedEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<RewardedVideoCompletedEventArgs> OnRewardedVideoCompletedHandler;
#pragma warning restore 0649

		public void OnRewardedVideoCompleted (global::System.Collections.ICollection p0, global::Com.Mopub.Common.MoPubReward p1)
		{
			var __h = OnRewardedVideoCompletedHandler;
			if (__h != null)
				__h (sender, new RewardedVideoCompletedEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<RewardedVideoLoadFailureEventArgs> OnRewardedVideoLoadFailureHandler;
#pragma warning restore 0649

		public void OnRewardedVideoLoadFailure (string p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
		{
			var __h = OnRewardedVideoLoadFailureHandler;
			if (__h != null)
				__h (sender, new RewardedVideoLoadFailureEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<RewardedVideoLoadSuccessEventArgs> OnRewardedVideoLoadSuccessHandler;
#pragma warning restore 0649

		public void OnRewardedVideoLoadSuccess (string p0)
		{
			var __h = OnRewardedVideoLoadSuccessHandler;
			if (__h != null)
				__h (sender, new RewardedVideoLoadSuccessEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<RewardedVideoPlaybackErrorEventArgs> OnRewardedVideoPlaybackErrorHandler;
#pragma warning restore 0649

		public void OnRewardedVideoPlaybackError (string p0, global::Com.Mopub.Mobileads.MoPubErrorCode p1)
		{
			var __h = OnRewardedVideoPlaybackErrorHandler;
			if (__h != null)
				__h (sender, new RewardedVideoPlaybackErrorEventArgs (p0, p1));
		}
#pragma warning disable 0649
		public EventHandler<RewardedVideoStartedEventArgs> OnRewardedVideoStartedHandler;
#pragma warning restore 0649

		public void OnRewardedVideoStarted (string p0)
		{
			var __h = OnRewardedVideoStartedHandler;
			if (__h != null)
				__h (sender, new RewardedVideoStartedEventArgs (p0));
		}

		internal static bool __IsEmpty (IMoPubRewardedVideoListenerImplementor value)
		{
			return value.OnRewardedVideoClosedHandler == null && value.OnRewardedVideoCompletedHandler == null && value.OnRewardedVideoLoadFailureHandler == null && value.OnRewardedVideoLoadSuccessHandler == null && value.OnRewardedVideoPlaybackErrorHandler == null && value.OnRewardedVideoStartedHandler == null;
		}
	}

}
