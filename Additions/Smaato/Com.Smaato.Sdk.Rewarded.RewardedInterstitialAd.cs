using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Smaato.Sdk.Rewarded {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']"
	[global::Android.Runtime.Register ("com/smaato/sdk/rewarded/RewardedInterstitialAd", DoNotGenerateAcw=true)]
	public abstract partial class RewardedInterstitialAd : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/smaato/sdk/rewarded/RewardedInterstitialAd", typeof (RewardedInterstitialAd));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected RewardedInterstitialAd (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/constructor[@name='RewardedInterstitialAd' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RewardedInterstitialAd () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getAdSpaceId;
#pragma warning disable 0169
		static Delegate GetGetAdSpaceIdHandler ()
		{
			if (cb_getAdSpaceId == null)
				cb_getAdSpaceId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAdSpaceId);
			return cb_getAdSpaceId;
		}

		static IntPtr n_GetAdSpaceId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AdSpaceId);
		}
#pragma warning restore 0169

		public abstract string AdSpaceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='getAdSpaceId' and count(parameter)=0]"
			[Register ("getAdSpaceId", "()Ljava/lang/String;", "GetGetAdSpaceIdHandler")]
			get; 
		}

		static Delegate cb_getCreativeId;
#pragma warning disable 0169
		static Delegate GetGetCreativeIdHandler ()
		{
			if (cb_getCreativeId == null)
				cb_getCreativeId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCreativeId);
			return cb_getCreativeId;
		}

		static IntPtr n_GetCreativeId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CreativeId);
		}
#pragma warning restore 0169

		public abstract string CreativeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='getCreativeId' and count(parameter)=0]"
			[Register ("getCreativeId", "()Ljava/lang/String;", "GetGetCreativeIdHandler")]
			get; 
		}

		static Delegate cb_isAvailableForPresentation;
#pragma warning disable 0169
		static Delegate GetIsAvailableForPresentationHandler ()
		{
			if (cb_isAvailableForPresentation == null)
				cb_isAvailableForPresentation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAvailableForPresentation);
			return cb_isAvailableForPresentation;
		}

		static bool n_IsAvailableForPresentation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAvailableForPresentation;
		}
#pragma warning restore 0169

		public abstract bool IsAvailableForPresentation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='isAvailableForPresentation' and count(parameter)=0]"
			[Register ("isAvailableForPresentation", "()Z", "GetIsAvailableForPresentationHandler")]
			get; 
		}

		static Delegate cb_getSessionId;
#pragma warning disable 0169
		static Delegate GetGetSessionIdHandler ()
		{
			if (cb_getSessionId == null)
				cb_getSessionId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSessionId);
			return cb_getSessionId;
		}

		static IntPtr n_GetSessionId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionId);
		}
#pragma warning restore 0169

		public abstract string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get; 
		}

		static Delegate cb_setCloseButtonEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetCloseButtonEnabled_ZHandler ()
		{
			if (cb_setCloseButtonEnabled_Z == null)
				cb_setCloseButtonEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetCloseButtonEnabled_Z);
			return cb_setCloseButtonEnabled_Z;
		}

		static void n_SetCloseButtonEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCloseButtonEnabled (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='setCloseButtonEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCloseButtonEnabled", "(Z)V", "GetSetCloseButtonEnabled_ZHandler")]
		public abstract void SetCloseButtonEnabled (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='showAd' and count(parameter)=0]"
		[Register ("showAd", "()V", "")]
		public unsafe void ShowAd ()
		{
			const string __id = "showAd.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_showAdInternal;
#pragma warning disable 0169
		static Delegate GetShowAdInternalHandler ()
		{
			if (cb_showAdInternal == null)
				cb_showAdInternal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ShowAdInternal);
			return cb_showAdInternal;
		}

		static void n_ShowAdInternal (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedInterstitialAd> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowAdInternal ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='showAdInternal' and count(parameter)=0]"
		[Register ("showAdInternal", "()V", "GetShowAdInternalHandler")]
		protected abstract void ShowAdInternal ();

	}

	[global::Android.Runtime.Register ("com/smaato/sdk/rewarded/RewardedInterstitialAd", DoNotGenerateAcw=true)]
	internal partial class RewardedInterstitialAdInvoker : RewardedInterstitialAd {
		public RewardedInterstitialAdInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/smaato/sdk/rewarded/RewardedInterstitialAd", typeof (RewardedInterstitialAdInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe string AdSpaceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='getAdSpaceId' and count(parameter)=0]"
			[Register ("getAdSpaceId", "()Ljava/lang/String;", "GetGetAdSpaceIdHandler")]
			get {
				const string __id = "getAdSpaceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string CreativeId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='getCreativeId' and count(parameter)=0]"
			[Register ("getCreativeId", "()Ljava/lang/String;", "GetGetCreativeIdHandler")]
			get {
				const string __id = "getCreativeId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe bool IsAvailableForPresentation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='isAvailableForPresentation' and count(parameter)=0]"
			[Register ("isAvailableForPresentation", "()Z", "GetIsAvailableForPresentationHandler")]
			get {
				const string __id = "isAvailableForPresentation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get {
				const string __id = "getSessionId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='setCloseButtonEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCloseButtonEnabled", "(Z)V", "GetSetCloseButtonEnabled_ZHandler")]
		public override unsafe void SetCloseButtonEnabled (bool p0)
		{
			const string __id = "setCloseButtonEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedInterstitialAd']/method[@name='showAdInternal' and count(parameter)=0]"
		[Register ("showAdInternal", "()V", "GetShowAdInternalHandler")]
		protected override unsafe void ShowAdInternal ()
		{
			const string __id = "showAdInternal.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
