using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='Response']"
	[global::Android.Runtime.Register ("com/mopub/volley/Response", DoNotGenerateAcw=true)]
	public partial class Response : global::Java.Lang.Object {


		static IntPtr cacheEntry_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Response']/field[@name='cacheEntry']"
		[Register ("cacheEntry")]
		public global::Com.Mopub.Volley.CacheEntry CacheEntry {
			get {
				if (cacheEntry_jfieldId == IntPtr.Zero)
					cacheEntry_jfieldId = JNIEnv.GetFieldID (class_ref, "cacheEntry", "Lcom/mopub/volley/Cache$Entry;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, cacheEntry_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.CacheEntry> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (cacheEntry_jfieldId == IntPtr.Zero)
					cacheEntry_jfieldId = JNIEnv.GetFieldID (class_ref, "cacheEntry", "Lcom/mopub/volley/Cache$Entry;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, cacheEntry_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr intermediate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Response']/field[@name='intermediate']"
		[Register ("intermediate")]
		public bool Intermediate {
			get {
				if (intermediate_jfieldId == IntPtr.Zero)
					intermediate_jfieldId = JNIEnv.GetFieldID (class_ref, "intermediate", "Z");
				return JNIEnv.GetBooleanField (Handle, intermediate_jfieldId);
			}
			set {
				if (intermediate_jfieldId == IntPtr.Zero)
					intermediate_jfieldId = JNIEnv.GetFieldID (class_ref, "intermediate", "Z");
				try {
					JNIEnv.SetField (Handle, intermediate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr result_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Response']/field[@name='result']"
		[Register ("result")]
		public global::Java.Lang.Object Result {
			get {
				if (result_jfieldId == IntPtr.Zero)
					result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, result_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (result_jfieldId == IntPtr.Zero)
					result_jfieldId = JNIEnv.GetFieldID (class_ref, "result", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, result_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Response.ErrorListener']"
		[Register ("com/mopub/volley/Response$ErrorListener", "", "Com.Mopub.Volley.Response/IErrorListenerInvoker")]
		public partial interface IErrorListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Response.ErrorListener']/method[@name='onErrorResponse' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
			[Register ("onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V", "GetOnErrorResponse_Lcom_mopub_volley_VolleyError_Handler:Com.Mopub.Volley.Response/IErrorListenerInvoker, AppodealXamarinPlugin")]
			void OnErrorResponse (global::Com.Mopub.Volley.VolleyError p0);

		}

		[global::Android.Runtime.Register ("com/mopub/volley/Response$ErrorListener", DoNotGenerateAcw=true)]
		internal class IErrorListenerInvoker : global::Java.Lang.Object, IErrorListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/volley/Response$ErrorListener");
			IntPtr class_ref;

			public static IErrorListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IErrorListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.volley.Response.ErrorListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IErrorListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IErrorListenerInvoker); }
			}

			static Delegate cb_onErrorResponse_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
			static Delegate GetOnErrorResponse_Lcom_mopub_volley_VolleyError_Handler ()
			{
				if (cb_onErrorResponse_Lcom_mopub_volley_VolleyError_ == null)
					cb_onErrorResponse_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnErrorResponse_Lcom_mopub_volley_VolleyError_);
				return cb_onErrorResponse_Lcom_mopub_volley_VolleyError_;
			}

			static void n_OnErrorResponse_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Volley.Response.IErrorListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response.IErrorListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnErrorResponse (p0);
			}
#pragma warning restore 0169

			IntPtr id_onErrorResponse_Lcom_mopub_volley_VolleyError_;
			public unsafe void OnErrorResponse (global::Com.Mopub.Volley.VolleyError p0)
			{
				if (id_onErrorResponse_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
					id_onErrorResponse_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "onErrorResponse", "(Lcom/mopub/volley/VolleyError;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onErrorResponse_Lcom_mopub_volley_VolleyError_, __args);
			}

		}

		public partial class ErrorEventArgs : global::System.EventArgs {

			public ErrorEventArgs (global::Com.Mopub.Volley.VolleyError p0)
			{
				this.p0 = p0;
			}

			global::Com.Mopub.Volley.VolleyError p0;
			public global::Com.Mopub.Volley.VolleyError P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/volley/Response_ErrorListenerImplementor")]
		internal sealed partial class IErrorListenerImplementor : global::Java.Lang.Object, IErrorListener {

			object sender;

			public IErrorListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/volley/Response_ErrorListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ErrorEventArgs> Handler;
#pragma warning restore 0649

			public void OnErrorResponse (global::Com.Mopub.Volley.VolleyError p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ErrorEventArgs (p0));
			}

			internal static bool __IsEmpty (IErrorListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Response.Listener']"
		[Register ("com/mopub/volley/Response$Listener", "", "Com.Mopub.Volley.Response/IListenerInvoker")]
		public partial interface IListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Response.Listener']/method[@name='onResponse' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("onResponse", "(Ljava/lang/Object;)V", "GetOnResponse_Ljava_lang_Object_Handler:Com.Mopub.Volley.Response/IListenerInvoker, AppodealXamarinPlugin")]
			void OnResponse (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("com/mopub/volley/Response$Listener", DoNotGenerateAcw=true)]
		internal class IListenerInvoker : global::Java.Lang.Object, IListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/mopub/volley/Response$Listener");
			IntPtr class_ref;

			public static IListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.mopub.volley.Response.Listener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IListenerInvoker); }
			}

			static Delegate cb_onResponse_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetOnResponse_Ljava_lang_Object_Handler ()
			{
				if (cb_onResponse_Ljava_lang_Object_ == null)
					cb_onResponse_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnResponse_Ljava_lang_Object_);
				return cb_onResponse_Ljava_lang_Object_;
			}

			static void n_OnResponse_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Mopub.Volley.Response.IListener __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response.IListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnResponse (p0);
			}
#pragma warning restore 0169

			IntPtr id_onResponse_Ljava_lang_Object_;
			public unsafe void OnResponse (global::Java.Lang.Object p0)
			{
				if (id_onResponse_Ljava_lang_Object_ == IntPtr.Zero)
					id_onResponse_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onResponse", "(Ljava/lang/Object;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (Handle, id_onResponse_Ljava_lang_Object_, __args);
			}

		}

		public partial class EventArgs : global::System.EventArgs {

			public EventArgs (global::Java.Lang.Object p0)
			{
				this.p0 = p0;
			}

			global::Java.Lang.Object p0;
			public global::Java.Lang.Object P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/com/mopub/volley/Response_ListenerImplementor")]
		internal sealed partial class IListenerImplementor : global::Java.Lang.Object, IListener {

			object sender;

			public IListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/mopub/volley/Response_ListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<EventArgs> Handler;
#pragma warning restore 0649

			public void OnResponse (global::Java.Lang.Object p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs (p0));
			}

			internal static bool __IsEmpty (IListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/Response", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Response); }
		}

		protected Response (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isSuccess;
#pragma warning disable 0169
		static Delegate GetIsSuccessHandler ()
		{
			if (cb_isSuccess == null)
				cb_isSuccess = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSuccess);
			return cb_isSuccess;
		}

		static bool n_IsSuccess (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Response __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSuccess;
		}
#pragma warning restore 0169

		static IntPtr id_isSuccess;
		public virtual unsafe bool IsSuccess {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Response']/method[@name='isSuccess' and count(parameter)=0]"
			[Register ("isSuccess", "()Z", "GetIsSuccessHandler")]
			get {
				if (id_isSuccess == IntPtr.Zero)
					id_isSuccess = JNIEnv.GetMethodID (class_ref, "isSuccess", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isSuccess);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSuccess", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_error_Lcom_mopub_volley_VolleyError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Response']/method[@name='error' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
		[Register ("error", "(Lcom/mopub/volley/VolleyError;)Lcom/mopub/volley/Response;", "")]
		public static unsafe global::Com.Mopub.Volley.Response Error (global::Com.Mopub.Volley.VolleyError p0)
		{
			if (id_error_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
				id_error_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetStaticMethodID (class_ref, "error", "(Lcom/mopub/volley/VolleyError;)Lcom/mopub/volley/Response;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mopub.Volley.Response __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_error_Lcom_mopub_volley_VolleyError_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_success_Ljava_lang_Object_Lcom_mopub_volley_Cache_Entry_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Response']/method[@name='success' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='com.mopub.volley.Cache.Entry']]"
		[Register ("success", "(Ljava/lang/Object;Lcom/mopub/volley/Cache$Entry;)Lcom/mopub/volley/Response;", "")]
		public static unsafe global::Com.Mopub.Volley.Response Success (global::Java.Lang.Object p0, global::Com.Mopub.Volley.CacheEntry p1)
		{
			if (id_success_Ljava_lang_Object_Lcom_mopub_volley_Cache_Entry_ == IntPtr.Zero)
				id_success_Ljava_lang_Object_Lcom_mopub_volley_Cache_Entry_ = JNIEnv.GetStaticMethodID (class_ref, "success", "(Ljava/lang/Object;Lcom/mopub/volley/Cache$Entry;)Lcom/mopub/volley/Response;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Mopub.Volley.Response __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response> (JNIEnv.CallStaticObjectMethod  (class_ref, id_success_Ljava_lang_Object_Lcom_mopub_volley_Cache_Entry_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
