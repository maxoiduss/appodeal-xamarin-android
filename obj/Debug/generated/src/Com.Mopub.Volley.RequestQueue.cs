using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='RequestQueue']"
	[global::Android.Runtime.Register ("com/mopub/volley/RequestQueue", DoNotGenerateAcw=true)]
	public partial class RequestQueue : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.volley']/interface[@name='RequestQueue.RequestFilter']"
		[Register ("com/mopub/volley/RequestQueue$RequestFilter", "", "Com.Mopub.Volley.RequestQueue/IRequestFilterInvoker")]
		public partial interface IRequestFilter : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='RequestQueue.RequestFilter']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.Request']]"
			[Register ("apply", "(Lcom/mopub/volley/Request;)Z", "GetApply_Lcom_mopub_volley_Request_Handler:Com.Mopub.Volley.RequestQueue/IRequestFilterInvoker, AppodealXamarinPlugin")]
			bool Apply (global::Com.Mopub.Volley.Request p0);

		}

		[global::Android.Runtime.Register ("com/mopub/volley/RequestQueue$RequestFilter", DoNotGenerateAcw=true)]
		internal class IRequestFilterInvoker : global::Java.Lang.Object, IRequestFilter {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/volley/RequestQueue$RequestFilter");
			IntPtr class_ref;

			public static IRequestFilter GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IRequestFilter> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.volley.RequestQueue.RequestFilter"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IRequestFilterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IRequestFilterInvoker); }
			}

			static Delegate cb_apply_Lcom_mopub_volley_Request_;
#pragma warning disable 0169
			static Delegate GetApply_Lcom_mopub_volley_Request_Handler ()
			{
				if (cb_apply_Lcom_mopub_volley_Request_ == null)
					cb_apply_Lcom_mopub_volley_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Apply_Lcom_mopub_volley_Request_);
				return cb_apply_Lcom_mopub_volley_Request_;
			}

			static bool n_Apply_Lcom_mopub_volley_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Volley.RequestQueue.IRequestFilter __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.RequestQueue.IRequestFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Apply (p0);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_apply_Lcom_mopub_volley_Request_;
			public unsafe bool Apply (global::Com.Mopub.Volley.Request p0)
			{
				if (id_apply_Lcom_mopub_volley_Request_ == IntPtr.Zero)
					id_apply_Lcom_mopub_volley_Request_ = JNIEnv.GetMethodID (class_ref, "apply", "(Lcom/mopub/volley/Request;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (Handle, id_apply_Lcom_mopub_volley_Request_, __args);
				return __ret;
			}

		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/RequestQueue", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestQueue); }
		}

		protected RequestQueue (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='RequestQueue']/constructor[@name='RequestQueue' and count(parameter)=2 and parameter[1][@type='com.mopub.volley.Cache'] and parameter[2][@type='com.mopub.volley.Network']]"
		[Register (".ctor", "(Lcom/mopub/volley/Cache;Lcom/mopub/volley/Network;)V", "")]
		public unsafe RequestQueue (global::Com.Mopub.Volley.ICache p0, global::Com.Mopub.Volley.INetwork p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (RequestQueue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/Cache;Lcom/mopub/volley/Network;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/Cache;Lcom/mopub/volley/Network;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/Cache;Lcom/mopub/volley/Network;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='RequestQueue']/constructor[@name='RequestQueue' and count(parameter)=3 and parameter[1][@type='com.mopub.volley.Cache'] and parameter[2][@type='com.mopub.volley.Network'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lcom/mopub/volley/Cache;Lcom/mopub/volley/Network;I)V", "")]
		public unsafe RequestQueue (global::Com.Mopub.Volley.ICache p0, global::Com.Mopub.Volley.INetwork p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (RequestQueue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/Cache;Lcom/mopub/volley/Network;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/Cache;Lcom/mopub/volley/Network;I)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_I == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/Cache;Lcom/mopub/volley/Network;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_ILcom_mopub_volley_ResponseDelivery_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='RequestQueue']/constructor[@name='RequestQueue' and count(parameter)=4 and parameter[1][@type='com.mopub.volley.Cache'] and parameter[2][@type='com.mopub.volley.Network'] and parameter[3][@type='int'] and parameter[4][@type='com.mopub.volley.ResponseDelivery']]"
		[Register (".ctor", "(Lcom/mopub/volley/Cache;Lcom/mopub/volley/Network;ILcom/mopub/volley/ResponseDelivery;)V", "")]
		public unsafe RequestQueue (global::Com.Mopub.Volley.ICache p0, global::Com.Mopub.Volley.INetwork p1, int p2, global::Com.Mopub.Volley.IResponseDelivery p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (RequestQueue)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Lcom/mopub/volley/Cache;Lcom/mopub/volley/Network;ILcom/mopub/volley/ResponseDelivery;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Lcom/mopub/volley/Cache;Lcom/mopub/volley/Network;ILcom/mopub/volley/ResponseDelivery;)V", __args);
					return;
				}

				if (id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_ILcom_mopub_volley_ResponseDelivery_ == IntPtr.Zero)
					id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_ILcom_mopub_volley_ResponseDelivery_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/mopub/volley/Cache;Lcom/mopub/volley/Network;ILcom/mopub/volley/ResponseDelivery;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_ILcom_mopub_volley_ResponseDelivery_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Lcom_mopub_volley_Cache_Lcom_mopub_volley_Network_ILcom_mopub_volley_ResponseDelivery_, __args);
			} finally {
			}
		}

		static Delegate cb_getCache;
#pragma warning disable 0169
		static Delegate GetGetCacheHandler ()
		{
			if (cb_getCache == null)
				cb_getCache = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCache);
			return cb_getCache;
		}

		static IntPtr n_GetCache (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.RequestQueue __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.RequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Cache);
		}
#pragma warning restore 0169

		static IntPtr id_getCache;
		public virtual unsafe global::Com.Mopub.Volley.ICache Cache {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='RequestQueue']/method[@name='getCache' and count(parameter)=0]"
			[Register ("getCache", "()Lcom/mopub/volley/Cache;", "GetGetCacheHandler")]
			get {
				if (id_getCache == IntPtr.Zero)
					id_getCache = JNIEnv.GetMethodID (class_ref, "getCache", "()Lcom/mopub/volley/Cache;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.ICache> (JNIEnv.CallObjectMethod  (Handle, id_getCache), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.ICache> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCache", "()Lcom/mopub/volley/Cache;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSequenceNumber;
#pragma warning disable 0169
		static Delegate GetGetSequenceNumberHandler ()
		{
			if (cb_getSequenceNumber == null)
				cb_getSequenceNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSequenceNumber);
			return cb_getSequenceNumber;
		}

		static int n_GetSequenceNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.RequestQueue __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.RequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SequenceNumber;
		}
#pragma warning restore 0169

		static IntPtr id_getSequenceNumber;
		public virtual unsafe int SequenceNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='RequestQueue']/method[@name='getSequenceNumber' and count(parameter)=0]"
			[Register ("getSequenceNumber", "()I", "GetGetSequenceNumberHandler")]
			get {
				if (id_getSequenceNumber == IntPtr.Zero)
					id_getSequenceNumber = JNIEnv.GetMethodID (class_ref, "getSequenceNumber", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getSequenceNumber);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSequenceNumber", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_add_Lcom_mopub_volley_Request_;
#pragma warning disable 0169
		static Delegate GetAdd_Lcom_mopub_volley_Request_Handler ()
		{
			if (cb_add_Lcom_mopub_volley_Request_ == null)
				cb_add_Lcom_mopub_volley_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_Lcom_mopub_volley_Request_);
			return cb_add_Lcom_mopub_volley_Request_;
		}

		static IntPtr n_Add_Lcom_mopub_volley_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.RequestQueue __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.RequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Add (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_add_Lcom_mopub_volley_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='RequestQueue']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.Request']]"
		[Register ("add", "(Lcom/mopub/volley/Request;)Lcom/mopub/volley/Request;", "GetAdd_Lcom_mopub_volley_Request_Handler")]
		public virtual unsafe global::Com.Mopub.Volley.Request Add (global::Com.Mopub.Volley.Request p0)
		{
			if (id_add_Lcom_mopub_volley_Request_ == IntPtr.Zero)
				id_add_Lcom_mopub_volley_Request_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/mopub/volley/Request;)Lcom/mopub/volley/Request;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Volley.Request __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallObjectMethod  (Handle, id_add_Lcom_mopub_volley_Request_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Lcom/mopub/volley/Request;)Lcom/mopub/volley/Request;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_cancelAll_Lcom_mopub_volley_RequestQueue_RequestFilter_;
#pragma warning disable 0169
		static Delegate GetCancelAll_Lcom_mopub_volley_RequestQueue_RequestFilter_Handler ()
		{
			if (cb_cancelAll_Lcom_mopub_volley_RequestQueue_RequestFilter_ == null)
				cb_cancelAll_Lcom_mopub_volley_RequestQueue_RequestFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CancelAll_Lcom_mopub_volley_RequestQueue_RequestFilter_);
			return cb_cancelAll_Lcom_mopub_volley_RequestQueue_RequestFilter_;
		}

		static void n_CancelAll_Lcom_mopub_volley_RequestQueue_RequestFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.RequestQueue __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.RequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.RequestQueue.IRequestFilter p0 = (global::Com.Mopub.Volley.RequestQueue.IRequestFilter)global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.RequestQueue.IRequestFilter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CancelAll (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancelAll_Lcom_mopub_volley_RequestQueue_RequestFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='RequestQueue']/method[@name='cancelAll' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.RequestQueue.RequestFilter']]"
		[Register ("cancelAll", "(Lcom/mopub/volley/RequestQueue$RequestFilter;)V", "GetCancelAll_Lcom_mopub_volley_RequestQueue_RequestFilter_Handler")]
		public virtual unsafe void CancelAll (global::Com.Mopub.Volley.RequestQueue.IRequestFilter p0)
		{
			if (id_cancelAll_Lcom_mopub_volley_RequestQueue_RequestFilter_ == IntPtr.Zero)
				id_cancelAll_Lcom_mopub_volley_RequestQueue_RequestFilter_ = JNIEnv.GetMethodID (class_ref, "cancelAll", "(Lcom/mopub/volley/RequestQueue$RequestFilter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancelAll_Lcom_mopub_volley_RequestQueue_RequestFilter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelAll", "(Lcom/mopub/volley/RequestQueue$RequestFilter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_cancelAll_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCancelAll_Ljava_lang_Object_Handler ()
		{
			if (cb_cancelAll_Ljava_lang_Object_ == null)
				cb_cancelAll_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CancelAll_Ljava_lang_Object_);
			return cb_cancelAll_Ljava_lang_Object_;
		}

		static void n_CancelAll_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.RequestQueue __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.RequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CancelAll (p0);
		}
#pragma warning restore 0169

		static IntPtr id_cancelAll_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='RequestQueue']/method[@name='cancelAll' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("cancelAll", "(Ljava/lang/Object;)V", "GetCancelAll_Ljava_lang_Object_Handler")]
		public virtual unsafe void CancelAll (global::Java.Lang.Object p0)
		{
			if (id_cancelAll_Ljava_lang_Object_ == IntPtr.Zero)
				id_cancelAll_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "cancelAll", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancelAll_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelAll", "(Ljava/lang/Object;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.RequestQueue __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.RequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		static IntPtr id_start;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='RequestQueue']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_start);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "start", "()V"));
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.RequestQueue __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.RequestQueue> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		static IntPtr id_stop;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='RequestQueue']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_stop);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stop", "()V"));
			} finally {
			}
		}

	}
}
