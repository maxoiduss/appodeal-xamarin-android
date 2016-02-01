using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Network {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestManager']"
	[global::Android.Runtime.Register ("com/mopub/network/RequestManager", DoNotGenerateAcw=true)]
	public abstract partial class RequestManager : global::Java.Lang.Object {


		static IntPtr mBackoffPolicy_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestManager']/field[@name='mBackoffPolicy']"
		[Register ("mBackoffPolicy")]
		protected global::Com.Mopub.Network.BackoffPolicy MBackoffPolicy {
			get {
				if (mBackoffPolicy_jfieldId == IntPtr.Zero)
					mBackoffPolicy_jfieldId = JNIEnv.GetFieldID (class_ref, "mBackoffPolicy", "Lcom/mopub/network/BackoffPolicy;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mBackoffPolicy_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.BackoffPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBackoffPolicy_jfieldId == IntPtr.Zero)
					mBackoffPolicy_jfieldId = JNIEnv.GetFieldID (class_ref, "mBackoffPolicy", "Lcom/mopub/network/BackoffPolicy;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mBackoffPolicy_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mCurrentRequest_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestManager']/field[@name='mCurrentRequest']"
		[Register ("mCurrentRequest")]
		protected global::Com.Mopub.Volley.Request MCurrentRequest {
			get {
				if (mCurrentRequest_jfieldId == IntPtr.Zero)
					mCurrentRequest_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentRequest", "Lcom/mopub/volley/Request;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mCurrentRequest_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mCurrentRequest_jfieldId == IntPtr.Zero)
					mCurrentRequest_jfieldId = JNIEnv.GetFieldID (class_ref, "mCurrentRequest", "Lcom/mopub/volley/Request;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mCurrentRequest_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mHandler_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestManager']/field[@name='mHandler']"
		[Register ("mHandler")]
		protected global::Android.OS.Handler MHandler {
			get {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mHandler_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHandler_jfieldId == IntPtr.Zero)
					mHandler_jfieldId = JNIEnv.GetFieldID (class_ref, "mHandler", "Landroid/os/Handler;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mHandler_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mRequestFactory_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestManager']/field[@name='mRequestFactory']"
		[Register ("mRequestFactory")]
		protected global::Com.Mopub.Network.RequestManager.IRequestFactory MRequestFactory {
			get {
				if (mRequestFactory_jfieldId == IntPtr.Zero)
					mRequestFactory_jfieldId = JNIEnv.GetFieldID (class_ref, "mRequestFactory", "Lcom/mopub/network/RequestManager$RequestFactory;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mRequestFactory_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.RequestManager.IRequestFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mRequestFactory_jfieldId == IntPtr.Zero)
					mRequestFactory_jfieldId = JNIEnv.GetFieldID (class_ref, "mRequestFactory", "Lcom/mopub/network/RequestManager$RequestFactory;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, mRequestFactory_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.network']/interface[@name='RequestManager.RequestFactory']"
		[Register ("com/mopub/network/RequestManager$RequestFactory", "", "Com.Mopub.Network.RequestManager/IRequestFactoryInvoker")]
		public partial interface IRequestFactory : IJavaObject {

		}

		[global::Android.Runtime.Register ("com/mopub/network/RequestManager$RequestFactory", DoNotGenerateAcw=true)]
		internal class IRequestFactoryInvoker : global::Java.Lang.Object, IRequestFactory {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/network/RequestManager$RequestFactory");
			IntPtr class_ref;

			public static IRequestFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRequestFactory> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.network.RequestManager.RequestFactory"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRequestFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRequestFactoryInvoker); }
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/network/RequestManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestManager); }
		}

		protected RequestManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Looper_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestManager']/constructor[@name='RequestManager' and count(parameter)=1 and parameter[1][@type='android.os.Looper']]"
		[Register (".ctor", "(Landroid/os/Looper;)V", "")]
		public unsafe RequestManager (global::Android.OS.Looper p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (RequestManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/os/Looper;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/os/Looper;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Looper_ == IntPtr.Zero)
					id_ctor_Landroid_os_Looper_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Looper;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Looper_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_os_Looper_, __args);
			} finally {
			}
		}

		static Delegate cb_isAtCapacity;
#pragma warning disable 0169
		static Delegate GetIsAtCapacityHandler ()
		{
			if (cb_isAtCapacity == null)
				cb_isAtCapacity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAtCapacity);
			return cb_isAtCapacity;
		}

		static bool n_IsAtCapacity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAtCapacity;
		}
#pragma warning restore 0169

		static IntPtr id_isAtCapacity;
		public virtual unsafe bool IsAtCapacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestManager']/method[@name='isAtCapacity' and count(parameter)=0]"
			[Register ("isAtCapacity", "()Z", "GetIsAtCapacityHandler")]
			get {
				if (id_isAtCapacity == IntPtr.Zero)
					id_isAtCapacity = JNIEnv.GetMethodID (class_ref, "isAtCapacity", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isAtCapacity);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAtCapacity", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_cancelRequest;
#pragma warning disable 0169
		static Delegate GetCancelRequestHandler ()
		{
			if (cb_cancelRequest == null)
				cb_cancelRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelRequest);
			return cb_cancelRequest;
		}

		static void n_CancelRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Network.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CancelRequest ();
		}
#pragma warning restore 0169

		static IntPtr id_cancelRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestManager']/method[@name='cancelRequest' and count(parameter)=0]"
		[Register ("cancelRequest", "()V", "GetCancelRequestHandler")]
		public virtual unsafe void CancelRequest ()
		{
			if (id_cancelRequest == IntPtr.Zero)
				id_cancelRequest = JNIEnv.GetMethodID (class_ref, "cancelRequest", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancelRequest);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelRequest", "()V"));
			} finally {
			}
		}

		static Delegate cb_makeRequest_Lcom_mopub_network_RequestManager_RequestFactory_Lcom_mopub_network_BackoffPolicy_;
#pragma warning disable 0169
		static Delegate GetMakeRequest_Lcom_mopub_network_RequestManager_RequestFactory_Lcom_mopub_network_BackoffPolicy_Handler ()
		{
			if (cb_makeRequest_Lcom_mopub_network_RequestManager_RequestFactory_Lcom_mopub_network_BackoffPolicy_ == null)
				cb_makeRequest_Lcom_mopub_network_RequestManager_RequestFactory_Lcom_mopub_network_BackoffPolicy_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_MakeRequest_Lcom_mopub_network_RequestManager_RequestFactory_Lcom_mopub_network_BackoffPolicy_);
			return cb_makeRequest_Lcom_mopub_network_RequestManager_RequestFactory_Lcom_mopub_network_BackoffPolicy_;
		}

		static void n_MakeRequest_Lcom_mopub_network_RequestManager_RequestFactory_Lcom_mopub_network_BackoffPolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Mopub.Network.RequestManager __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.RequestManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Network.RequestManager.IRequestFactory p0 = (global::Com.Mopub.Network.RequestManager.IRequestFactory)global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.RequestManager.IRequestFactory> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Network.BackoffPolicy p1 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Network.BackoffPolicy> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.MakeRequest (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_makeRequest_Lcom_mopub_network_RequestManager_RequestFactory_Lcom_mopub_network_BackoffPolicy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.network']/class[@name='RequestManager']/method[@name='makeRequest' and count(parameter)=2 and parameter[1][@type='com.mopub.network.RequestManager.RequestFactory'] and parameter[2][@type='com.mopub.network.BackoffPolicy']]"
		[Register ("makeRequest", "(Lcom/mopub/network/RequestManager$RequestFactory;Lcom/mopub/network/BackoffPolicy;)V", "GetMakeRequest_Lcom_mopub_network_RequestManager_RequestFactory_Lcom_mopub_network_BackoffPolicy_Handler")]
		public virtual unsafe void MakeRequest (global::Com.Mopub.Network.RequestManager.IRequestFactory p0, global::Com.Mopub.Network.BackoffPolicy p1)
		{
			if (id_makeRequest_Lcom_mopub_network_RequestManager_RequestFactory_Lcom_mopub_network_BackoffPolicy_ == IntPtr.Zero)
				id_makeRequest_Lcom_mopub_network_RequestManager_RequestFactory_Lcom_mopub_network_BackoffPolicy_ = JNIEnv.GetMethodID (class_ref, "makeRequest", "(Lcom/mopub/network/RequestManager$RequestFactory;Lcom/mopub/network/BackoffPolicy;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_makeRequest_Lcom_mopub_network_RequestManager_RequestFactory_Lcom_mopub_network_BackoffPolicy_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "makeRequest", "(Lcom/mopub/network/RequestManager$RequestFactory;Lcom/mopub/network/BackoffPolicy;)V"), __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/mopub/network/RequestManager", DoNotGenerateAcw=true)]
	internal partial class RequestManagerInvoker : RequestManager {

		public RequestManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestManagerInvoker); }
		}

	}

}
