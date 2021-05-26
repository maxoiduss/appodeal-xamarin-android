using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Smaato.Sdk.Rewarded {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.smaato.sdk.rewarded']/interface[@name='EventListener']"
	[Register ("com/smaato/sdk/rewarded/EventListener", "", "Com.Smaato.Sdk.Rewarded.IEventListenerInvoker")]
	public partial interface IEventListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/interface[@name='EventListener']/method[@name='onAdClicked' and count(parameter)=1 and parameter[1][@type='com.smaato.sdk.rewarded.RewardedInterstitialAd']]"
		[Register ("onAdClicked", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;)V", "GetOnAdClicked_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Handler:Com.Smaato.Sdk.Rewarded.IEventListenerInvoker, AppodealXamarinAndroid")]
		void OnAdClicked (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/interface[@name='EventListener']/method[@name='onAdClosed' and count(parameter)=1 and parameter[1][@type='com.smaato.sdk.rewarded.RewardedInterstitialAd']]"
		[Register ("onAdClosed", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;)V", "GetOnAdClosed_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Handler:Com.Smaato.Sdk.Rewarded.IEventListenerInvoker, AppodealXamarinAndroid")]
		void OnAdClosed (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/interface[@name='EventListener']/method[@name='onAdError' and count(parameter)=2 and parameter[1][@type='com.smaato.sdk.rewarded.RewardedInterstitialAd'] and parameter[2][@type='com.smaato.sdk.rewarded.RewardedError']]"
		[Register ("onAdError", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;Lcom/smaato/sdk/rewarded/RewardedError;)V", "GetOnAdError_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Lcom_smaato_sdk_rewarded_RewardedError_Handler:Com.Smaato.Sdk.Rewarded.IEventListenerInvoker, AppodealXamarinAndroid")]
		void OnAdError (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0, global::Com.Smaato.Sdk.Rewarded.RewardedError p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/interface[@name='EventListener']/method[@name='onAdFailedToLoad' and count(parameter)=1 and parameter[1][@type='com.smaato.sdk.rewarded.RewardedRequestError']]"
		[Register ("onAdFailedToLoad", "(Lcom/smaato/sdk/rewarded/RewardedRequestError;)V", "GetOnAdFailedToLoad_Lcom_smaato_sdk_rewarded_RewardedRequestError_Handler:Com.Smaato.Sdk.Rewarded.IEventListenerInvoker, AppodealXamarinAndroid")]
		void OnAdFailedToLoad (global::Com.Smaato.Sdk.Rewarded.RewardedRequestError p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/interface[@name='EventListener']/method[@name='onAdLoaded' and count(parameter)=1 and parameter[1][@type='com.smaato.sdk.rewarded.RewardedInterstitialAd']]"
		[Register ("onAdLoaded", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;)V", "GetOnAdLoaded_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Handler:Com.Smaato.Sdk.Rewarded.IEventListenerInvoker, AppodealXamarinAndroid")]
		void OnAdLoaded (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/interface[@name='EventListener']/method[@name='onAdReward' and count(parameter)=1 and parameter[1][@type='com.smaato.sdk.rewarded.RewardedInterstitialAd']]"
		[Register ("onAdReward", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;)V", "GetOnAdReward_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Handler:Com.Smaato.Sdk.Rewarded.IEventListenerInvoker, AppodealXamarinAndroid")]
		void OnAdReward (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/interface[@name='EventListener']/method[@name='onAdStarted' and count(parameter)=1 and parameter[1][@type='com.smaato.sdk.rewarded.RewardedInterstitialAd']]"
		[Register ("onAdStarted", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;)V", "GetOnAdStarted_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Handler:Com.Smaato.Sdk.Rewarded.IEventListenerInvoker, AppodealXamarinAndroid")]
		void OnAdStarted (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/interface[@name='EventListener']/method[@name='onAdTTLExpired' and count(parameter)=1 and parameter[1][@type='com.smaato.sdk.rewarded.RewardedInterstitialAd']]"
		[Register ("onAdTTLExpired", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;)V", "GetOnAdTTLExpired_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Handler:Com.Smaato.Sdk.Rewarded.IEventListenerInvoker, AppodealXamarinAndroid")]
		void OnAdTTLExpired (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0);

	}

	[global::Android.Runtime.Register ("com/smaato/sdk/rewarded/EventListener", DoNotGenerateAcw=true)]
	internal partial class IEventListenerInvoker : global::Java.Lang.Object, IEventListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/smaato/sdk/rewarded/EventListener", typeof (IEventListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IEventListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEventListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.smaato.sdk.rewarded.EventListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEventListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onAdClicked_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
#pragma warning disable 0169
		static Delegate GetOnAdClicked_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Handler ()
		{
			if (cb_onAdClicked_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ == null)
				cb_onAdClicked_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnAdClicked_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_);
			return cb_onAdClicked_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
		}

		static void n_OnAdClicked_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClicked (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdClicked_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
		public unsafe void OnAdClicked (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			if (id_onAdClicked_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ == IntPtr.Zero)
				id_onAdClicked_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ = JNIEnv.GetMethodID (class_ref, "onAdClicked", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClicked_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_, __args);
		}

		static Delegate cb_onAdClosed_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
#pragma warning disable 0169
		static Delegate GetOnAdClosed_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Handler ()
		{
			if (cb_onAdClosed_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ == null)
				cb_onAdClosed_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnAdClosed_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_);
			return cb_onAdClosed_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
		}

		static void n_OnAdClosed_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdClosed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdClosed_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
		public unsafe void OnAdClosed (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			if (id_onAdClosed_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ == IntPtr.Zero)
				id_onAdClosed_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ = JNIEnv.GetMethodID (class_ref, "onAdClosed", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdClosed_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_, __args);
		}

		static Delegate cb_onAdError_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Lcom_smaato_sdk_rewarded_RewardedError_;
#pragma warning disable 0169
		static Delegate GetOnAdError_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Lcom_smaato_sdk_rewarded_RewardedError_Handler ()
		{
			if (cb_onAdError_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Lcom_smaato_sdk_rewarded_RewardedError_ == null)
				cb_onAdError_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Lcom_smaato_sdk_rewarded_RewardedError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnAdError_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Lcom_smaato_sdk_rewarded_RewardedError_);
			return cb_onAdError_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Lcom_smaato_sdk_rewarded_RewardedError_;
		}

		static void n_OnAdError_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Lcom_smaato_sdk_rewarded_RewardedError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedError> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnAdError (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onAdError_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Lcom_smaato_sdk_rewarded_RewardedError_;
		public unsafe void OnAdError (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0, global::Com.Smaato.Sdk.Rewarded.RewardedError p1)
		{
			if (id_onAdError_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Lcom_smaato_sdk_rewarded_RewardedError_ == IntPtr.Zero)
				id_onAdError_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Lcom_smaato_sdk_rewarded_RewardedError_ = JNIEnv.GetMethodID (class_ref, "onAdError", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;Lcom/smaato/sdk/rewarded/RewardedError;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdError_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Lcom_smaato_sdk_rewarded_RewardedError_, __args);
		}

		static Delegate cb_onAdFailedToLoad_Lcom_smaato_sdk_rewarded_RewardedRequestError_;
#pragma warning disable 0169
		static Delegate GetOnAdFailedToLoad_Lcom_smaato_sdk_rewarded_RewardedRequestError_Handler ()
		{
			if (cb_onAdFailedToLoad_Lcom_smaato_sdk_rewarded_RewardedRequestError_ == null)
				cb_onAdFailedToLoad_Lcom_smaato_sdk_rewarded_RewardedRequestError_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnAdFailedToLoad_Lcom_smaato_sdk_rewarded_RewardedRequestError_);
			return cb_onAdFailedToLoad_Lcom_smaato_sdk_rewarded_RewardedRequestError_;
		}

		static void n_OnAdFailedToLoad_Lcom_smaato_sdk_rewarded_RewardedRequestError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedRequestError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdFailedToLoad (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdFailedToLoad_Lcom_smaato_sdk_rewarded_RewardedRequestError_;
		public unsafe void OnAdFailedToLoad (global::Com.Smaato.Sdk.Rewarded.RewardedRequestError p0)
		{
			if (id_onAdFailedToLoad_Lcom_smaato_sdk_rewarded_RewardedRequestError_ == IntPtr.Zero)
				id_onAdFailedToLoad_Lcom_smaato_sdk_rewarded_RewardedRequestError_ = JNIEnv.GetMethodID (class_ref, "onAdFailedToLoad", "(Lcom/smaato/sdk/rewarded/RewardedRequestError;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdFailedToLoad_Lcom_smaato_sdk_rewarded_RewardedRequestError_, __args);
		}

		static Delegate cb_onAdLoaded_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
#pragma warning disable 0169
		static Delegate GetOnAdLoaded_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Handler ()
		{
			if (cb_onAdLoaded_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ == null)
				cb_onAdLoaded_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnAdLoaded_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_);
			return cb_onAdLoaded_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
		}

		static void n_OnAdLoaded_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdLoaded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdLoaded_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
		public unsafe void OnAdLoaded (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			if (id_onAdLoaded_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ == IntPtr.Zero)
				id_onAdLoaded_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ = JNIEnv.GetMethodID (class_ref, "onAdLoaded", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdLoaded_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_, __args);
		}

		static Delegate cb_onAdReward_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
#pragma warning disable 0169
		static Delegate GetOnAdReward_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Handler ()
		{
			if (cb_onAdReward_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ == null)
				cb_onAdReward_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnAdReward_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_);
			return cb_onAdReward_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
		}

		static void n_OnAdReward_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdReward (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdReward_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
		public unsafe void OnAdReward (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			if (id_onAdReward_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ == IntPtr.Zero)
				id_onAdReward_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ = JNIEnv.GetMethodID (class_ref, "onAdReward", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdReward_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_, __args);
		}

		static Delegate cb_onAdStarted_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
#pragma warning disable 0169
		static Delegate GetOnAdStarted_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Handler ()
		{
			if (cb_onAdStarted_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ == null)
				cb_onAdStarted_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnAdStarted_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_);
			return cb_onAdStarted_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
		}

		static void n_OnAdStarted_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdStarted (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdStarted_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
		public unsafe void OnAdStarted (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			if (id_onAdStarted_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ == IntPtr.Zero)
				id_onAdStarted_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ = JNIEnv.GetMethodID (class_ref, "onAdStarted", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdStarted_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_, __args);
		}

		static Delegate cb_onAdTTLExpired_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
#pragma warning disable 0169
		static Delegate GetOnAdTTLExpired_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_Handler ()
		{
			if (cb_onAdTTLExpired_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ == null)
				cb_onAdTTLExpired_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnAdTTLExpired_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_);
			return cb_onAdTTLExpired_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
		}

		static void n_OnAdTTLExpired_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.IEventListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnAdTTLExpired (p0);
		}
#pragma warning restore 0169

		IntPtr id_onAdTTLExpired_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_;
		public unsafe void OnAdTTLExpired (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			if (id_onAdTTLExpired_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ == IntPtr.Zero)
				id_onAdTTLExpired_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_ = JNIEnv.GetMethodID (class_ref, "onAdTTLExpired", "(Lcom/smaato/sdk/rewarded/RewardedInterstitialAd;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onAdTTLExpired_Lcom_smaato_sdk_rewarded_RewardedInterstitialAd_, __args);
		}

	}

	// event args for com.smaato.sdk.rewarded.EventListener.onAdClicked
	public partial class AdClickedEventArgs : global::System.EventArgs {
		public AdClickedEventArgs (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			this.p0 = p0;
		}

		global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0;

		public global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd P0 {
			get { return p0; }
		}

	}

	// event args for com.smaato.sdk.rewarded.EventListener.onAdClosed
	public partial class AdClosedEventArgs : global::System.EventArgs {
		public AdClosedEventArgs (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			this.p0 = p0;
		}

		global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0;

		public global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd P0 {
			get { return p0; }
		}

	}

	// event args for com.smaato.sdk.rewarded.EventListener.onAdError
	public partial class AdErrorEventArgs : global::System.EventArgs {
		public AdErrorEventArgs (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0, global::Com.Smaato.Sdk.Rewarded.RewardedError p1)
		{
			this.p0 = p0;
			this.p1 = p1;
		}

		global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0;

		public global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd P0 {
			get { return p0; }
		}

		global::Com.Smaato.Sdk.Rewarded.RewardedError p1;

		public global::Com.Smaato.Sdk.Rewarded.RewardedError P1 {
			get { return p1; }
		}

	}

	// event args for com.smaato.sdk.rewarded.EventListener.onAdFailedToLoad
	public partial class AdFailedToLoadEventArgs : global::System.EventArgs {
		public AdFailedToLoadEventArgs (global::Com.Smaato.Sdk.Rewarded.RewardedRequestError p0)
		{
			this.p0 = p0;
		}

		global::Com.Smaato.Sdk.Rewarded.RewardedRequestError p0;

		public global::Com.Smaato.Sdk.Rewarded.RewardedRequestError P0 {
			get { return p0; }
		}

	}

	// event args for com.smaato.sdk.rewarded.EventListener.onAdLoaded
	public partial class AdLoadedEventArgs : global::System.EventArgs {
		public AdLoadedEventArgs (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			this.p0 = p0;
		}

		global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0;

		public global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd P0 {
			get { return p0; }
		}

	}

	// event args for com.smaato.sdk.rewarded.EventListener.onAdReward
	public partial class AdRewardEventArgs : global::System.EventArgs {
		public AdRewardEventArgs (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			this.p0 = p0;
		}

		global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0;

		public global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd P0 {
			get { return p0; }
		}

	}

	// event args for com.smaato.sdk.rewarded.EventListener.onAdStarted
	public partial class AdStartedEventArgs : global::System.EventArgs {
		public AdStartedEventArgs (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			this.p0 = p0;
		}

		global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0;

		public global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd P0 {
			get { return p0; }
		}

	}

	// event args for com.smaato.sdk.rewarded.EventListener.onAdTTLExpired
	public partial class AdTTLExpiredEventArgs : global::System.EventArgs {
		public AdTTLExpiredEventArgs (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			this.p0 = p0;
		}

		global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0;

		public global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd P0 {
			get { return p0; }
		}

	}

	[global::Android.Runtime.Register ("mono/com/smaato/sdk/rewarded/EventListenerImplementor")]
	internal sealed partial class IEventListenerImplementor : global::Java.Lang.Object, IEventListener {

		object sender;

		public IEventListenerImplementor (object sender) : base (global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/smaato/sdk/rewarded/EventListenerImplementor", "()V"), JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler<AdClickedEventArgs> OnAdClickedHandler;
		#pragma warning restore 0649

		public void OnAdClicked (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			var __h = OnAdClickedHandler;
			if (__h != null)
				__h (sender, new AdClickedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<AdClosedEventArgs> OnAdClosedHandler;
		#pragma warning restore 0649

		public void OnAdClosed (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			var __h = OnAdClosedHandler;
			if (__h != null)
				__h (sender, new AdClosedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<AdErrorEventArgs> OnAdErrorHandler;
		#pragma warning restore 0649

		public void OnAdError (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0, global::Com.Smaato.Sdk.Rewarded.RewardedError p1)
		{
			var __h = OnAdErrorHandler;
			if (__h != null)
				__h (sender, new AdErrorEventArgs (p0, p1));
		}

		#pragma warning disable 0649
		public EventHandler<AdFailedToLoadEventArgs> OnAdFailedToLoadHandler;
		#pragma warning restore 0649

		public void OnAdFailedToLoad (global::Com.Smaato.Sdk.Rewarded.RewardedRequestError p0)
		{
			var __h = OnAdFailedToLoadHandler;
			if (__h != null)
				__h (sender, new AdFailedToLoadEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<AdLoadedEventArgs> OnAdLoadedHandler;
		#pragma warning restore 0649

		public void OnAdLoaded (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			var __h = OnAdLoadedHandler;
			if (__h != null)
				__h (sender, new AdLoadedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<AdRewardEventArgs> OnAdRewardHandler;
		#pragma warning restore 0649

		public void OnAdReward (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			var __h = OnAdRewardHandler;
			if (__h != null)
				__h (sender, new AdRewardEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<AdStartedEventArgs> OnAdStartedHandler;
		#pragma warning restore 0649

		public void OnAdStarted (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			var __h = OnAdStartedHandler;
			if (__h != null)
				__h (sender, new AdStartedEventArgs (p0));
		}

		#pragma warning disable 0649
		public EventHandler<AdTTLExpiredEventArgs> OnAdTTLExpiredHandler;
		#pragma warning restore 0649

		public void OnAdTTLExpired (global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd p0)
		{
			var __h = OnAdTTLExpiredHandler;
			if (__h != null)
				__h (sender, new AdTTLExpiredEventArgs (p0));
		}

		internal static bool __IsEmpty (IEventListenerImplementor value)
		{
			return value.OnAdClickedHandler == null && value.OnAdClosedHandler == null && value.OnAdErrorHandler == null && value.OnAdFailedToLoadHandler == null && value.OnAdLoadedHandler == null && value.OnAdRewardHandler == null && value.OnAdStartedHandler == null && value.OnAdTTLExpiredHandler == null;
		}

	}
}
