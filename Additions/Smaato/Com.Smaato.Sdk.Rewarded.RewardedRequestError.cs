using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Smaato.Sdk.Rewarded {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedRequestError']"
	[global::Android.Runtime.Register ("com/smaato/sdk/rewarded/RewardedRequestError", DoNotGenerateAcw=true)]
	public sealed partial class RewardedRequestError : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/smaato/sdk/rewarded/RewardedRequestError", typeof (RewardedRequestError));

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

		internal RewardedRequestError (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public unsafe string AdSpaceId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedRequestError']/method[@name='getAdSpaceId' and count(parameter)=0]"
			[Register ("getAdSpaceId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getAdSpaceId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string PublisherId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedRequestError']/method[@name='getPublisherId' and count(parameter)=0]"
			[Register ("getPublisherId", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getPublisherId.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Smaato.Sdk.Rewarded.RewardedError RewardedError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.smaato.sdk.rewarded']/class[@name='RewardedRequestError']/method[@name='getRewardedError' and count(parameter)=0]"
			[Register ("getRewardedError", "()Lcom/smaato/sdk/rewarded/RewardedError;", "")]
			get {
				const string __id = "getRewardedError.()Lcom/smaato/sdk/rewarded/RewardedError;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Smaato.Sdk.Rewarded.RewardedError> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
