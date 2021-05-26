using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Smaato.Sdk.Rewarded {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedError']"
	[global::Android.Runtime.Register ("com/smaato/sdk/rewarded/RewardedError", DoNotGenerateAcw=true)]
	public sealed partial class RewardedError : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedError']/field[@name='CACHE_LIMIT_REACHED']"
		[Register ("CACHE_LIMIT_REACHED")]
		public static global::Com.Smaato.Sdk.Rewarded.RewardedError CacheLimitReached {
			get {
				const string __id = "CACHE_LIMIT_REACHED.Lcom/smaato/sdk/rewarded/RewardedError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedError']/field[@name='CREATIVE_RESOURCE_EXPIRED']"
		[Register ("CREATIVE_RESOURCE_EXPIRED")]
		public static global::Com.Smaato.Sdk.Rewarded.RewardedError CreativeResourceExpired {
			get {
				const string __id = "CREATIVE_RESOURCE_EXPIRED.Lcom/smaato/sdk/rewarded/RewardedError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedError']/field[@name='INTERNAL_ERROR']"
		[Register ("INTERNAL_ERROR")]
		public static global::Com.Smaato.Sdk.Rewarded.RewardedError InternalError {
			get {
				const string __id = "INTERNAL_ERROR.Lcom/smaato/sdk/rewarded/RewardedError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedError']/field[@name='INVALID_REQUEST']"
		[Register ("INVALID_REQUEST")]
		public static global::Com.Smaato.Sdk.Rewarded.RewardedError InvalidRequest {
			get {
				const string __id = "INVALID_REQUEST.Lcom/smaato/sdk/rewarded/RewardedError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedError']/field[@name='NETWORK_ERROR']"
		[Register ("NETWORK_ERROR")]
		public static global::Com.Smaato.Sdk.Rewarded.RewardedError NetworkError {
			get {
				const string __id = "NETWORK_ERROR.Lcom/smaato/sdk/rewarded/RewardedError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedError']/field[@name='NO_AD_AVAILABLE']"
		[Register ("NO_AD_AVAILABLE")]
		public static global::Com.Smaato.Sdk.Rewarded.RewardedError NoAdAvailable {
			get {
				const string __id = "NO_AD_AVAILABLE.Lcom/smaato/sdk/rewarded/RewardedError;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedError> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/smaato/sdk/rewarded/RewardedError", typeof (RewardedError));

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

		internal RewardedError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedError']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			const string __id = "toString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedError']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/smaato/sdk/rewarded/RewardedError;", "")]
		public static unsafe global::Com.Smaato.Sdk.Rewarded.RewardedError ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/smaato/sdk/rewarded/RewardedError;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedError']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/smaato/sdk/rewarded/RewardedError;", "")]
		public static unsafe global::Com.Smaato.Sdk.Rewarded.RewardedError[] Values ()
		{
			const string __id = "values.()[Lcom/smaato/sdk/rewarded/RewardedError;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Smaato.Sdk.Rewarded.RewardedError[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Smaato.Sdk.Rewarded.RewardedError));
			} finally {
			}
		}

	}
}
