using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Mobileads.Factories {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HttpClientFactory']"
	[global::Android.Runtime.Register ("com/mopub/mobileads/factories/HttpClientFactory", DoNotGenerateAcw=true)]
	public partial class HttpClientFactory : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HttpClientFactory']/field[@name='SOCKET_SIZE']"
		[Register ("SOCKET_SIZE")]
		public const int SocketSize = (int) 8192;
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/mobileads/factories/HttpClientFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (HttpClientFactory); }
		}

		protected HttpClientFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HttpClientFactory']/constructor[@name='HttpClientFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe HttpClientFactory ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (HttpClientFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HttpClientFactory']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lorg/apache/http/impl/client/DefaultHttpClient;", "")]
		public static unsafe global::Org.Apache.Http.Impl.Client.DefaultHttpClient Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lorg/apache/http/impl/client/DefaultHttpClient;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Impl.Client.DefaultHttpClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_create_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HttpClientFactory']/method[@name='create' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("create", "(I)Lorg/apache/http/impl/client/DefaultHttpClient;", "")]
		public static unsafe global::Org.Apache.Http.Impl.Client.DefaultHttpClient Create (int p0)
		{
			if (id_create_I == IntPtr.Zero)
				id_create_I = JNIEnv.GetStaticMethodID (class_ref, "create", "(I)Lorg/apache/http/impl/client/DefaultHttpClient;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Impl.Client.DefaultHttpClient> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_internalCreate_I;
#pragma warning disable 0169
		static Delegate GetInternalCreate_IHandler ()
		{
			if (cb_internalCreate_I == null)
				cb_internalCreate_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_InternalCreate_I);
			return cb_internalCreate_I;
		}

		static IntPtr n_InternalCreate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Mopub.Mobileads.Factories.HttpClientFactory __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Mobileads.Factories.HttpClientFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InternalCreate (p0));
		}
#pragma warning restore 0169

		static IntPtr id_internalCreate_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HttpClientFactory']/method[@name='internalCreate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("internalCreate", "(I)Lorg/apache/http/impl/client/DefaultHttpClient;", "GetInternalCreate_IHandler")]
		protected virtual unsafe global::Org.Apache.Http.Impl.Client.DefaultHttpClient InternalCreate (int p0)
		{
			if (id_internalCreate_I == IntPtr.Zero)
				id_internalCreate_I = JNIEnv.GetMethodID (class_ref, "internalCreate", "(I)Lorg/apache/http/impl/client/DefaultHttpClient;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Impl.Client.DefaultHttpClient> (JNIEnv.CallObjectMethod  (Handle, id_internalCreate_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Org.Apache.Http.Impl.Client.DefaultHttpClient> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "internalCreate", "(I)Lorg/apache/http/impl/client/DefaultHttpClient;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setInstance_Lcom_mopub_mobileads_factories_HttpClientFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.mobileads.factories']/class[@name='HttpClientFactory']/method[@name='setInstance' and count(parameter)=1 and parameter[1][@type='com.mopub.mobileads.factories.HttpClientFactory']]"
		[Obsolete (@"deprecated")]
		[Register ("setInstance", "(Lcom/mopub/mobileads/factories/HttpClientFactory;)V", "")]
		public static unsafe void SetInstance (global::Com.Mopub.Mobileads.Factories.HttpClientFactory p0)
		{
			if (id_setInstance_Lcom_mopub_mobileads_factories_HttpClientFactory_ == IntPtr.Zero)
				id_setInstance_Lcom_mopub_mobileads_factories_HttpClientFactory_ = JNIEnv.GetStaticMethodID (class_ref, "setInstance", "(Lcom/mopub/mobileads/factories/HttpClientFactory;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setInstance_Lcom_mopub_mobileads_factories_HttpClientFactory_, __args);
			} finally {
			}
		}

	}
}
