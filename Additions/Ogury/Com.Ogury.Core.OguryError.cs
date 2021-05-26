using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Ogury.Core
{

	// Metadata.xml XPath class reference: path="/api/package[@name='com.ogury.core']/class[@name='OguryError']"
	[global::Android.Runtime.Register("com/ogury/core/OguryError", DoNotGenerateAcw = true)]
	public sealed partial class OguryError : global::Java.Lang.Exception
	{
		static readonly JniPeerMembers _members = new XAPeerMembers("com/ogury/core/OguryError", typeof(OguryError));

		internal static IntPtr class_ref
		{
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers
		{
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass
		{
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType
		{
			get { return _members.ManagedPeerType; }
		}

		internal OguryError(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ogury.core']/class[@name='OguryError']/constructor[@name='OguryError' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register(".ctor", "(I)V", "")]
		public unsafe OguryError(int errorCode) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Throwable)this).Handle != IntPtr.Zero)
				return;

			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[1];
				__args[0] = new JniArgumentValue(errorCode);
				var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
				SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
			}
			finally
			{
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.ogury.core']/class[@name='OguryError']/constructor[@name='OguryError' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register(".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe OguryError(int errorCode, string message) : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;)V";

			if (((global::Java.Lang.Throwable)this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString(message);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[2];
				__args[0] = new JniArgumentValue(errorCode);
				__args[1] = new JniArgumentValue(native_message);
				var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
				SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_message);
			}
		}

		public unsafe int ErrorCode
		{
			// Metadata.xml XPath method reference: path="/api/package[@name='com.ogury.core']/class[@name='OguryError']/method[@name='getErrorCode' and count(parameter)=0]"
			[Register("getErrorCode", "()I", "")]
			get
			{
				const string __id = "getErrorCode.()I";
				try
				{
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method(__id, this, null);
					return __rm;
				}
				finally
				{
				}
			}
		}

	}
}
