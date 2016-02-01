using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']"
	[global::Android.Runtime.Register ("com/mopub/volley/Request", DoNotGenerateAcw=true)]
	public abstract partial class Request : global::Java.Lang.Object, global::Java.Lang.IComparable {

		[Register ("com/mopub/volley/Request$Method")]
		public abstract class Method {

			internal Method ()
			{
			}

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Request.Method']/field[@name='DELETE']"
			[Register ("DELETE")]
			public const int Delete = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Request.Method']/field[@name='DEPRECATED_GET_OR_POST']"
			[Register ("DEPRECATED_GET_OR_POST")]
			public const int DeprecatedGetOrPost = (int) -1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Request.Method']/field[@name='GET']"
			[Register ("GET")]
			public const int Get = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Request.Method']/field[@name='HEAD']"
			[Register ("HEAD")]
			public const int Head = (int) 4;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Request.Method']/field[@name='OPTIONS']"
			[Register ("OPTIONS")]
			public const int Options = (int) 5;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Request.Method']/field[@name='PATCH']"
			[Register ("PATCH")]
			public const int Patch = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Request.Method']/field[@name='POST']"
			[Register ("POST")]
			public const int Post = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Request.Method']/field[@name='PUT']"
			[Register ("PUT")]
			public const int Put = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/interface[@name='Request.Method']/field[@name='TRACE']"
			[Register ("TRACE")]
			public const int Trace = (int) 6;
		}

		[global::System.Obsolete ("Use the 'Method' type. This type will be removed in a future release.")]
		public abstract class MethodConsts : Method {

			private MethodConsts ()
			{
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request.Priority']"
		[global::Android.Runtime.Register ("com/mopub/volley/Request$Priority", DoNotGenerateAcw=true)]
		public sealed partial class Priority : global::Java.Lang.Enum {


			static IntPtr HIGH_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request.Priority']/field[@name='HIGH']"
			[Register ("HIGH")]
			public static global::Com.Mopub.Volley.Request.Priority High {
				get {
					if (HIGH_jfieldId == IntPtr.Zero)
						HIGH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "HIGH", "Lcom/mopub/volley/Request$Priority;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, HIGH_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request.Priority> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IMMEDIATE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request.Priority']/field[@name='IMMEDIATE']"
			[Register ("IMMEDIATE")]
			public static global::Com.Mopub.Volley.Request.Priority Immediate {
				get {
					if (IMMEDIATE_jfieldId == IntPtr.Zero)
						IMMEDIATE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMMEDIATE", "Lcom/mopub/volley/Request$Priority;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMMEDIATE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request.Priority> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LOW_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request.Priority']/field[@name='LOW']"
			[Register ("LOW")]
			public static global::Com.Mopub.Volley.Request.Priority Low {
				get {
					if (LOW_jfieldId == IntPtr.Zero)
						LOW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOW", "Lcom/mopub/volley/Request$Priority;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOW_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request.Priority> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NORMAL_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request.Priority']/field[@name='NORMAL']"
			[Register ("NORMAL")]
			public static global::Com.Mopub.Volley.Request.Priority Normal {
				get {
					if (NORMAL_jfieldId == IntPtr.Zero)
						NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NORMAL", "Lcom/mopub/volley/Request$Priority;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NORMAL_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request.Priority> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/mopub/volley/Request$Priority", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Priority); }
			}

			internal Priority (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request.Priority']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/mopub/volley/Request$Priority;", "")]
			public static unsafe global::Com.Mopub.Volley.Request.Priority ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/mopub/volley/Request$Priority;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Mopub.Volley.Request.Priority __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request.Priority> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request.Priority']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/mopub/volley/Request$Priority;", "")]
			public static unsafe global::Com.Mopub.Volley.Request.Priority[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/mopub/volley/Request$Priority;");
				try {
					return (global::Com.Mopub.Volley.Request.Priority[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Mopub.Volley.Request.Priority));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/Request", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Request); }
		}

		protected Request (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Lcom_mopub_volley_Response_ErrorListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/constructor[@name='Request' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.mopub.volley.Response.ErrorListener']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/mopub/volley/Response$ErrorListener;)V", "")]
		public unsafe Request (string p0, global::Com.Mopub.Volley.Response.IErrorListener p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (GetType () != typeof (Request)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;Lcom/mopub/volley/Response$ErrorListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Ljava/lang/String;Lcom/mopub/volley/Response$ErrorListener;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lcom_mopub_volley_Response_ErrorListener_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lcom_mopub_volley_Response_ErrorListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lcom/mopub/volley/Response$ErrorListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_volley_Response_ErrorListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Ljava_lang_String_Lcom_mopub_volley_Response_ErrorListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_ILjava_lang_String_Lcom_mopub_volley_Response_ErrorListener_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/constructor[@name='Request' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.mopub.volley.Response.ErrorListener']]"
		[Register (".ctor", "(ILjava/lang/String;Lcom/mopub/volley/Response$ErrorListener;)V", "")]
		public unsafe Request (int p0, string p1, global::Com.Mopub.Volley.Response.IErrorListener p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (GetType () != typeof (Request)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(ILjava/lang/String;Lcom/mopub/volley/Response$ErrorListener;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(ILjava/lang/String;Lcom/mopub/volley/Response$ErrorListener;)V", __args);
					return;
				}

				if (id_ctor_ILjava_lang_String_Lcom_mopub_volley_Response_ErrorListener_ == IntPtr.Zero)
					id_ctor_ILjava_lang_String_Lcom_mopub_volley_Response_ErrorListener_ = JNIEnv.GetMethodID (class_ref, "<init>", "(ILjava/lang/String;Lcom/mopub/volley/Response$ErrorListener;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_ILjava_lang_String_Lcom_mopub_volley_Response_ErrorListener_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_ILjava_lang_String_Lcom_mopub_volley_Response_ErrorListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getBodyContentType;
#pragma warning disable 0169
		static Delegate GetGetBodyContentTypeHandler ()
		{
			if (cb_getBodyContentType == null)
				cb_getBodyContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBodyContentType);
			return cb_getBodyContentType;
		}

		static IntPtr n_GetBodyContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BodyContentType);
		}
#pragma warning restore 0169

		static IntPtr id_getBodyContentType;
		public virtual unsafe string BodyContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getBodyContentType' and count(parameter)=0]"
			[Register ("getBodyContentType", "()Ljava/lang/String;", "GetGetBodyContentTypeHandler")]
			get {
				if (id_getBodyContentType == IntPtr.Zero)
					id_getBodyContentType = JNIEnv.GetMethodID (class_ref, "getBodyContentType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getBodyContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBodyContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCacheEntry;
#pragma warning disable 0169
		static Delegate GetGetCacheEntryHandler ()
		{
			if (cb_getCacheEntry == null)
				cb_getCacheEntry = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheEntry);
			return cb_getCacheEntry;
		}

		static IntPtr n_GetCacheEntry (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CacheEntry);
		}
#pragma warning restore 0169

		static IntPtr id_getCacheEntry;
		public virtual unsafe global::Com.Mopub.Volley.CacheEntry CacheEntry {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getCacheEntry' and count(parameter)=0]"
			[Register ("getCacheEntry", "()Lcom/mopub/volley/Cache$Entry;", "GetGetCacheEntryHandler")]
			get {
				if (id_getCacheEntry == IntPtr.Zero)
					id_getCacheEntry = JNIEnv.GetMethodID (class_ref, "getCacheEntry", "()Lcom/mopub/volley/Cache$Entry;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.CacheEntry> (JNIEnv.CallObjectMethod  (Handle, id_getCacheEntry), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.CacheEntry> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCacheEntry", "()Lcom/mopub/volley/Cache$Entry;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCacheKey;
#pragma warning disable 0169
		static Delegate GetGetCacheKeyHandler ()
		{
			if (cb_getCacheKey == null)
				cb_getCacheKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheKey);
			return cb_getCacheKey;
		}

		static IntPtr n_GetCacheKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CacheKey);
		}
#pragma warning restore 0169

		static IntPtr id_getCacheKey;
		public virtual unsafe string CacheKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getCacheKey' and count(parameter)=0]"
			[Register ("getCacheKey", "()Ljava/lang/String;", "GetGetCacheKeyHandler")]
			get {
				if (id_getCacheKey == IntPtr.Zero)
					id_getCacheKey = JNIEnv.GetMethodID (class_ref, "getCacheKey", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getCacheKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCacheKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorListener;
#pragma warning disable 0169
		static Delegate GetGetErrorListenerHandler ()
		{
			if (cb_getErrorListener == null)
				cb_getErrorListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetErrorListener);
			return cb_getErrorListener;
		}

		static IntPtr n_GetErrorListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ErrorListener);
		}
#pragma warning restore 0169

		static IntPtr id_getErrorListener;
		public virtual unsafe global::Com.Mopub.Volley.Response.IErrorListener ErrorListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getErrorListener' and count(parameter)=0]"
			[Register ("getErrorListener", "()Lcom/mopub/volley/Response$ErrorListener;", "GetGetErrorListenerHandler")]
			get {
				if (id_getErrorListener == IntPtr.Zero)
					id_getErrorListener = JNIEnv.GetMethodID (class_ref, "getErrorListener", "()Lcom/mopub/volley/Response$ErrorListener;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response.IErrorListener> (JNIEnv.CallObjectMethod  (Handle, id_getErrorListener), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response.IErrorListener> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getErrorListener", "()Lcom/mopub/volley/Response$ErrorListener;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasHadResponseDelivered;
#pragma warning disable 0169
		static Delegate GetHasHadResponseDeliveredHandler ()
		{
			if (cb_hasHadResponseDelivered == null)
				cb_hasHadResponseDelivered = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasHadResponseDelivered);
			return cb_hasHadResponseDelivered;
		}

		static bool n_HasHadResponseDelivered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasHadResponseDelivered;
		}
#pragma warning restore 0169

		static IntPtr id_hasHadResponseDelivered;
		public virtual unsafe bool HasHadResponseDelivered {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='hasHadResponseDelivered' and count(parameter)=0]"
			[Register ("hasHadResponseDelivered", "()Z", "GetHasHadResponseDeliveredHandler")]
			get {
				if (id_hasHadResponseDelivered == IntPtr.Zero)
					id_hasHadResponseDelivered = JNIEnv.GetMethodID (class_ref, "hasHadResponseDelivered", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_hasHadResponseDelivered);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasHadResponseDelivered", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getHeaders;
#pragma warning disable 0169
		static Delegate GetGetHeadersHandler ()
		{
			if (cb_getHeaders == null)
				cb_getHeaders = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHeaders);
			return cb_getHeaders;
		}

		static IntPtr n_GetHeaders (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.Headers);
		}
#pragma warning restore 0169

		static IntPtr id_getHeaders;
		public virtual unsafe global::System.Collections.IDictionary Headers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getHeaders' and count(parameter)=0]"
			[Register ("getHeaders", "()Ljava/util/Map;", "GetGetHeadersHandler")]
			get {
				if (id_getHeaders == IntPtr.Zero)
					id_getHeaders = JNIEnv.GetMethodID (class_ref, "getHeaders", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getHeaders), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeaders", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isCanceled;
#pragma warning disable 0169
		static Delegate GetIsCanceledHandler ()
		{
			if (cb_isCanceled == null)
				cb_isCanceled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCanceled);
			return cb_isCanceled;
		}

		static bool n_IsCanceled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCanceled;
		}
#pragma warning restore 0169

		static IntPtr id_isCanceled;
		public virtual unsafe bool IsCanceled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='isCanceled' and count(parameter)=0]"
			[Register ("isCanceled", "()Z", "GetIsCanceledHandler")]
			get {
				if (id_isCanceled == IntPtr.Zero)
					id_isCanceled = JNIEnv.GetMethodID (class_ref, "isCanceled", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod  (Handle, id_isCanceled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isCanceled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMethod;
#pragma warning disable 0169
		static Delegate GetGetMethodHandler ()
		{
			if (cb_getMethod == null)
				cb_getMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMethod);
			return cb_getMethod;
		}

		static int n_GetMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Method;
		}
#pragma warning restore 0169

		static IntPtr id_getMethod;
		public virtual unsafe int Method {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getMethod' and count(parameter)=0]"
			[Register ("getMethod", "()I", "GetGetMethodHandler")]
			get {
				if (id_getMethod == IntPtr.Zero)
					id_getMethod = JNIEnv.GetMethodID (class_ref, "getMethod", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getMethod);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMethod", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getParams;
#pragma warning disable 0169
		static Delegate GetGetParamsHandler ()
		{
			if (cb_getParams == null)
				cb_getParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParams);
			return cb_getParams;
		}

		static IntPtr n_GetParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.Params);
		}
#pragma warning restore 0169

		static IntPtr id_getParams;
		protected virtual unsafe global::System.Collections.IDictionary Params {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getParams' and count(parameter)=0]"
			[Register ("getParams", "()Ljava/util/Map;", "GetGetParamsHandler")]
			get {
				if (id_getParams == IntPtr.Zero)
					id_getParams = JNIEnv.GetMethodID (class_ref, "getParams", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getParamsEncoding;
#pragma warning disable 0169
		static Delegate GetGetParamsEncodingHandler ()
		{
			if (cb_getParamsEncoding == null)
				cb_getParamsEncoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetParamsEncoding);
			return cb_getParamsEncoding;
		}

		static IntPtr n_GetParamsEncoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ParamsEncoding);
		}
#pragma warning restore 0169

		static IntPtr id_getParamsEncoding;
		protected virtual unsafe string ParamsEncoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getParamsEncoding' and count(parameter)=0]"
			[Register ("getParamsEncoding", "()Ljava/lang/String;", "GetGetParamsEncodingHandler")]
			get {
				if (id_getParamsEncoding == IntPtr.Zero)
					id_getParamsEncoding = JNIEnv.GetMethodID (class_ref, "getParamsEncoding", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getParamsEncoding), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getParamsEncoding", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPostBodyContentType;
#pragma warning disable 0169
		static Delegate GetGetPostBodyContentTypeHandler ()
		{
			if (cb_getPostBodyContentType == null)
				cb_getPostBodyContentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPostBodyContentType);
			return cb_getPostBodyContentType;
		}

		static IntPtr n_GetPostBodyContentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PostBodyContentType);
		}
#pragma warning restore 0169

		static IntPtr id_getPostBodyContentType;
		[Obsolete (@"deprecated")]
		public virtual unsafe string PostBodyContentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getPostBodyContentType' and count(parameter)=0]"
			[Register ("getPostBodyContentType", "()Ljava/lang/String;", "GetGetPostBodyContentTypeHandler")]
			get {
				if (id_getPostBodyContentType == IntPtr.Zero)
					id_getPostBodyContentType = JNIEnv.GetMethodID (class_ref, "getPostBodyContentType", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPostBodyContentType), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPostBodyContentType", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPostParams;
#pragma warning disable 0169
		static Delegate GetGetPostParamsHandler ()
		{
			if (cb_getPostParams == null)
				cb_getPostParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPostParams);
			return cb_getPostParams;
		}

		static IntPtr n_GetPostParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary.ToLocalJniHandle (__this.PostParams);
		}
#pragma warning restore 0169

		static IntPtr id_getPostParams;
		[Obsolete (@"deprecated")]
		protected virtual unsafe global::System.Collections.IDictionary PostParams {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getPostParams' and count(parameter)=0]"
			[Register ("getPostParams", "()Ljava/util/Map;", "GetGetPostParamsHandler")]
			get {
				if (id_getPostParams == IntPtr.Zero)
					id_getPostParams = JNIEnv.GetMethodID (class_ref, "getPostParams", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallObjectMethod  (Handle, id_getPostParams), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPostParams", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPostParamsEncoding;
#pragma warning disable 0169
		static Delegate GetGetPostParamsEncodingHandler ()
		{
			if (cb_getPostParamsEncoding == null)
				cb_getPostParamsEncoding = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPostParamsEncoding);
			return cb_getPostParamsEncoding;
		}

		static IntPtr n_GetPostParamsEncoding (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PostParamsEncoding);
		}
#pragma warning restore 0169

		static IntPtr id_getPostParamsEncoding;
		[Obsolete (@"deprecated")]
		protected virtual unsafe string PostParamsEncoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getPostParamsEncoding' and count(parameter)=0]"
			[Register ("getPostParamsEncoding", "()Ljava/lang/String;", "GetGetPostParamsEncodingHandler")]
			get {
				if (id_getPostParamsEncoding == IntPtr.Zero)
					id_getPostParamsEncoding = JNIEnv.GetMethodID (class_ref, "getPostParamsEncoding", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getPostParamsEncoding), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPostParamsEncoding", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRetryPolicy;
#pragma warning disable 0169
		static Delegate GetGetRetryPolicyHandler ()
		{
			if (cb_getRetryPolicy == null)
				cb_getRetryPolicy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRetryPolicy);
			return cb_getRetryPolicy;
		}

		static IntPtr n_GetRetryPolicy (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RetryPolicy);
		}
#pragma warning restore 0169

		static IntPtr id_getRetryPolicy;
		public virtual unsafe global::Com.Mopub.Volley.IRetryPolicy RetryPolicy {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getRetryPolicy' and count(parameter)=0]"
			[Register ("getRetryPolicy", "()Lcom/mopub/volley/RetryPolicy;", "GetGetRetryPolicyHandler")]
			get {
				if (id_getRetryPolicy == IntPtr.Zero)
					id_getRetryPolicy = JNIEnv.GetMethodID (class_ref, "getRetryPolicy", "()Lcom/mopub/volley/RetryPolicy;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.IRetryPolicy> (JNIEnv.CallObjectMethod  (Handle, id_getRetryPolicy), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.IRetryPolicy> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRetryPolicy", "()Lcom/mopub/volley/RetryPolicy;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSequence;
		public unsafe int Sequence {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getSequence' and count(parameter)=0]"
			[Register ("getSequence", "()I", "GetGetSequenceHandler")]
			get {
				if (id_getSequence == IntPtr.Zero)
					id_getSequence = JNIEnv.GetMethodID (class_ref, "getSequence", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getSequence);
				} finally {
				}
			}
		}

		static Delegate cb_getTag;
#pragma warning disable 0169
		static Delegate GetGetTagHandler ()
		{
			if (cb_getTag == null)
				cb_getTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTag);
			return cb_getTag;
		}

		static IntPtr n_GetTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Tag);
		}
#pragma warning restore 0169

		static IntPtr id_getTag;
		public virtual unsafe global::Java.Lang.Object Tag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getTag' and count(parameter)=0]"
			[Register ("getTag", "()Ljava/lang/Object;", "GetGetTagHandler")]
			get {
				if (id_getTag == IntPtr.Zero)
					id_getTag = JNIEnv.GetMethodID (class_ref, "getTag", "()Ljava/lang/Object;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod  (Handle, id_getTag), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTag", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getTimeoutMs;
		public unsafe int TimeoutMs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getTimeoutMs' and count(parameter)=0]"
			[Register ("getTimeoutMs", "()I", "GetGetTimeoutMsHandler")]
			get {
				if (id_getTimeoutMs == IntPtr.Zero)
					id_getTimeoutMs = JNIEnv.GetMethodID (class_ref, "getTimeoutMs", "()I");
				try {
					return JNIEnv.CallIntMethod  (Handle, id_getTimeoutMs);
				} finally {
				}
			}
		}

		static Delegate cb_getTrafficStatsTag;
#pragma warning disable 0169
		static Delegate GetGetTrafficStatsTagHandler ()
		{
			if (cb_getTrafficStatsTag == null)
				cb_getTrafficStatsTag = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTrafficStatsTag);
			return cb_getTrafficStatsTag;
		}

		static int n_GetTrafficStatsTag (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrafficStatsTag;
		}
#pragma warning restore 0169

		static IntPtr id_getTrafficStatsTag;
		public virtual unsafe int TrafficStatsTag {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getTrafficStatsTag' and count(parameter)=0]"
			[Register ("getTrafficStatsTag", "()I", "GetGetTrafficStatsTagHandler")]
			get {
				if (id_getTrafficStatsTag == IntPtr.Zero)
					id_getTrafficStatsTag = JNIEnv.GetMethodID (class_ref, "getTrafficStatsTag", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod  (Handle, id_getTrafficStatsTag);
					else
						return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrafficStatsTag", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod  (Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addMarker_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddMarker_Ljava_lang_String_Handler ()
		{
			if (cb_addMarker_Ljava_lang_String_ == null)
				cb_addMarker_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddMarker_Ljava_lang_String_);
			return cb_addMarker_Ljava_lang_String_;
		}

		static void n_AddMarker_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddMarker (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addMarker_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='addMarker' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("addMarker", "(Ljava/lang/String;)V", "GetAddMarker_Ljava_lang_String_Handler")]
		public virtual unsafe void AddMarker (string p0)
		{
			if (id_addMarker_Ljava_lang_String_ == IntPtr.Zero)
				id_addMarker_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addMarker", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_addMarker_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMarker", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_cancel;
#pragma warning disable 0169
		static Delegate GetCancelHandler ()
		{
			if (cb_cancel == null)
				cb_cancel = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Cancel);
			return cb_cancel;
		}

		static void n_Cancel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Cancel ();
		}
#pragma warning restore 0169

		static IntPtr id_cancel;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='cancel' and count(parameter)=0]"
		[Register ("cancel", "()V", "GetCancelHandler")]
		public virtual unsafe void Cancel ()
		{
			if (id_cancel == IntPtr.Zero)
				id_cancel = JNIEnv.GetMethodID (class_ref, "cancel", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_cancel);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancel", "()V"));
			} finally {
			}
		}

		static Delegate cb_compareTo_Lcom_mopub_volley_Request_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lcom_mopub_volley_Request_Handler ()
		{
			if (cb_compareTo_Lcom_mopub_volley_Request_ == null)
				cb_compareTo_Lcom_mopub_volley_Request_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lcom_mopub_volley_Request_);
			return cb_compareTo_Lcom_mopub_volley_Request_;
		}

		static int n_CompareTo_Lcom_mopub_volley_Request_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.Request p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lcom_mopub_volley_Request_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.Request']]"
		[Register ("compareTo", "(Lcom/mopub/volley/Request;)I", "GetCompareTo_Lcom_mopub_volley_Request_Handler")]
		public virtual unsafe int CompareTo (global::Com.Mopub.Volley.Request p0)
		{
			if (id_compareTo_Lcom_mopub_volley_Request_ == IntPtr.Zero)
				id_compareTo_Lcom_mopub_volley_Request_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lcom/mopub/volley/Request;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Lcom_mopub_volley_Request_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lcom/mopub/volley/Request;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_deliverError_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
		static Delegate GetDeliverError_Lcom_mopub_volley_VolleyError_Handler ()
		{
			if (cb_deliverError_Lcom_mopub_volley_VolleyError_ == null)
				cb_deliverError_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliverError_Lcom_mopub_volley_VolleyError_);
			return cb_deliverError_Lcom_mopub_volley_VolleyError_;
		}

		static void n_DeliverError_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeliverError (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deliverError_Lcom_mopub_volley_VolleyError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='deliverError' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
		[Register ("deliverError", "(Lcom/mopub/volley/VolleyError;)V", "GetDeliverError_Lcom_mopub_volley_VolleyError_Handler")]
		public virtual unsafe void DeliverError (global::Com.Mopub.Volley.VolleyError p0)
		{
			if (id_deliverError_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
				id_deliverError_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "deliverError", "(Lcom/mopub/volley/VolleyError;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_deliverError_Lcom_mopub_volley_VolleyError_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deliverError", "(Lcom/mopub/volley/VolleyError;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deliverResponse_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetDeliverResponse_Ljava_lang_Object_Handler ()
		{
			if (cb_deliverResponse_Ljava_lang_Object_ == null)
				cb_deliverResponse_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeliverResponse_Ljava_lang_Object_);
			return cb_deliverResponse_Ljava_lang_Object_;
		}

		static void n_DeliverResponse_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeliverResponse (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='deliverResponse' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("deliverResponse", "(Ljava/lang/Object;)V", "GetDeliverResponse_Ljava_lang_Object_Handler")]
		protected abstract void DeliverResponse (global::Java.Lang.Object p0);

		static Delegate cb_getBody;
#pragma warning disable 0169
		static Delegate GetGetBodyHandler ()
		{
			if (cb_getBody == null)
				cb_getBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBody);
			return cb_getBody;
		}

		static IntPtr n_GetBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBody ());
		}
#pragma warning restore 0169

		static IntPtr id_getBody;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getBody' and count(parameter)=0]"
		[Register ("getBody", "()[B", "GetGetBodyHandler")]
		public virtual unsafe byte[] GetBody ()
		{
			if (id_getBody == IntPtr.Zero)
				id_getBody = JNIEnv.GetMethodID (class_ref, "getBody", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getBody), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBody", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getPostBody;
#pragma warning disable 0169
		static Delegate GetGetPostBodyHandler ()
		{
			if (cb_getPostBody == null)
				cb_getPostBody = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPostBody);
			return cb_getPostBody;
		}

		static IntPtr n_GetPostBody (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPostBody ());
		}
#pragma warning restore 0169

		static IntPtr id_getPostBody;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getPostBody' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("getPostBody", "()[B", "GetGetPostBodyHandler")]
		public virtual unsafe byte[] GetPostBody ()
		{
			if (id_getPostBody == IntPtr.Zero)
				id_getPostBody = JNIEnv.GetMethodID (class_ref, "getPostBody", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_getPostBody), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPostBody", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getPriority;
#pragma warning disable 0169
		static Delegate GetGetPriorityHandler ()
		{
			if (cb_getPriority == null)
				cb_getPriority = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPriority);
			return cb_getPriority;
		}

		static IntPtr n_GetPriority (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPriority ());
		}
#pragma warning restore 0169

		static IntPtr id_getPriority;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='getPriority' and count(parameter)=0]"
		[Register ("getPriority", "()Lcom/mopub/volley/Request$Priority;", "GetGetPriorityHandler")]
		public virtual unsafe global::Com.Mopub.Volley.Request.Priority GetPriority ()
		{
			if (id_getPriority == IntPtr.Zero)
				id_getPriority = JNIEnv.GetMethodID (class_ref, "getPriority", "()Lcom/mopub/volley/Request$Priority;");
			try {

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request.Priority> (JNIEnv.CallObjectMethod  (Handle, id_getPriority), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request.Priority> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPriority", "()Lcom/mopub/volley/Request$Priority;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_markDelivered;
#pragma warning disable 0169
		static Delegate GetMarkDeliveredHandler ()
		{
			if (cb_markDelivered == null)
				cb_markDelivered = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_MarkDelivered);
			return cb_markDelivered;
		}

		static void n_MarkDelivered (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkDelivered ();
		}
#pragma warning restore 0169

		static IntPtr id_markDelivered;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='markDelivered' and count(parameter)=0]"
		[Register ("markDelivered", "()V", "GetMarkDeliveredHandler")]
		public virtual unsafe void MarkDelivered ()
		{
			if (id_markDelivered == IntPtr.Zero)
				id_markDelivered = JNIEnv.GetMethodID (class_ref, "markDelivered", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_markDelivered);
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "markDelivered", "()V"));
			} finally {
			}
		}

		static Delegate cb_parseNetworkError_Lcom_mopub_volley_VolleyError_;
#pragma warning disable 0169
		static Delegate GetParseNetworkError_Lcom_mopub_volley_VolleyError_Handler ()
		{
			if (cb_parseNetworkError_Lcom_mopub_volley_VolleyError_ == null)
				cb_parseNetworkError_Lcom_mopub_volley_VolleyError_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseNetworkError_Lcom_mopub_volley_VolleyError_);
			return cb_parseNetworkError_Lcom_mopub_volley_VolleyError_;
		}

		static IntPtr n_ParseNetworkError_Lcom_mopub_volley_VolleyError_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.VolleyError p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseNetworkError (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parseNetworkError_Lcom_mopub_volley_VolleyError_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='parseNetworkError' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.VolleyError']]"
		[Register ("parseNetworkError", "(Lcom/mopub/volley/VolleyError;)Lcom/mopub/volley/VolleyError;", "GetParseNetworkError_Lcom_mopub_volley_VolleyError_Handler")]
		protected virtual unsafe global::Com.Mopub.Volley.VolleyError ParseNetworkError (global::Com.Mopub.Volley.VolleyError p0)
		{
			if (id_parseNetworkError_Lcom_mopub_volley_VolleyError_ == IntPtr.Zero)
				id_parseNetworkError_Lcom_mopub_volley_VolleyError_ = JNIEnv.GetMethodID (class_ref, "parseNetworkError", "(Lcom/mopub/volley/VolleyError;)Lcom/mopub/volley/VolleyError;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Volley.VolleyError __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (JNIEnv.CallObjectMethod  (Handle, id_parseNetworkError_Lcom_mopub_volley_VolleyError_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.VolleyError> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parseNetworkError", "(Lcom/mopub/volley/VolleyError;)Lcom/mopub/volley/VolleyError;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_;
#pragma warning disable 0169
		static Delegate GetParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_Handler ()
		{
			if (cb_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ == null)
				cb_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_);
			return cb_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_;
		}

		static IntPtr n_ParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.NetworkResponse p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.NetworkResponse> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ParseNetworkResponse (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='parseNetworkResponse' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.NetworkResponse']]"
		[Register ("parseNetworkResponse", "(Lcom/mopub/volley/NetworkResponse;)Lcom/mopub/volley/Response;", "GetParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_Handler")]
		protected abstract global::Com.Mopub.Volley.Response ParseNetworkResponse (global::Com.Mopub.Volley.NetworkResponse p0);

		static Delegate cb_setCacheEntry_Lcom_mopub_volley_Cache_Entry_;
#pragma warning disable 0169
		static Delegate GetSetCacheEntry_Lcom_mopub_volley_Cache_Entry_Handler ()
		{
			if (cb_setCacheEntry_Lcom_mopub_volley_Cache_Entry_ == null)
				cb_setCacheEntry_Lcom_mopub_volley_Cache_Entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCacheEntry_Lcom_mopub_volley_Cache_Entry_);
			return cb_setCacheEntry_Lcom_mopub_volley_Cache_Entry_;
		}

		static IntPtr n_SetCacheEntry_Lcom_mopub_volley_Cache_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.CacheEntry p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.CacheEntry> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCacheEntry (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCacheEntry_Lcom_mopub_volley_Cache_Entry_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='setCacheEntry' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.Cache.Entry']]"
		[Register ("setCacheEntry", "(Lcom/mopub/volley/Cache$Entry;)Lcom/mopub/volley/Request;", "GetSetCacheEntry_Lcom_mopub_volley_Cache_Entry_Handler")]
		public virtual unsafe global::Com.Mopub.Volley.Request SetCacheEntry (global::Com.Mopub.Volley.CacheEntry p0)
		{
			if (id_setCacheEntry_Lcom_mopub_volley_Cache_Entry_ == IntPtr.Zero)
				id_setCacheEntry_Lcom_mopub_volley_Cache_Entry_ = JNIEnv.GetMethodID (class_ref, "setCacheEntry", "(Lcom/mopub/volley/Cache$Entry;)Lcom/mopub/volley/Request;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Volley.Request __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallObjectMethod  (Handle, id_setCacheEntry_Lcom_mopub_volley_Cache_Entry_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCacheEntry", "(Lcom/mopub/volley/Cache$Entry;)Lcom/mopub/volley/Request;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setRequestQueue_Lcom_mopub_volley_RequestQueue_;
#pragma warning disable 0169
		static Delegate GetSetRequestQueue_Lcom_mopub_volley_RequestQueue_Handler ()
		{
			if (cb_setRequestQueue_Lcom_mopub_volley_RequestQueue_ == null)
				cb_setRequestQueue_Lcom_mopub_volley_RequestQueue_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRequestQueue_Lcom_mopub_volley_RequestQueue_);
			return cb_setRequestQueue_Lcom_mopub_volley_RequestQueue_;
		}

		static IntPtr n_SetRequestQueue_Lcom_mopub_volley_RequestQueue_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.RequestQueue p0 = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.RequestQueue> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRequestQueue (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setRequestQueue_Lcom_mopub_volley_RequestQueue_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='setRequestQueue' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.RequestQueue']]"
		[Register ("setRequestQueue", "(Lcom/mopub/volley/RequestQueue;)Lcom/mopub/volley/Request;", "GetSetRequestQueue_Lcom_mopub_volley_RequestQueue_Handler")]
		public virtual unsafe global::Com.Mopub.Volley.Request SetRequestQueue (global::Com.Mopub.Volley.RequestQueue p0)
		{
			if (id_setRequestQueue_Lcom_mopub_volley_RequestQueue_ == IntPtr.Zero)
				id_setRequestQueue_Lcom_mopub_volley_RequestQueue_ = JNIEnv.GetMethodID (class_ref, "setRequestQueue", "(Lcom/mopub/volley/RequestQueue;)Lcom/mopub/volley/Request;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Volley.Request __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallObjectMethod  (Handle, id_setRequestQueue_Lcom_mopub_volley_RequestQueue_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRequestQueue", "(Lcom/mopub/volley/RequestQueue;)Lcom/mopub/volley/Request;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setRetryPolicy_Lcom_mopub_volley_RetryPolicy_;
#pragma warning disable 0169
		static Delegate GetSetRetryPolicy_Lcom_mopub_volley_RetryPolicy_Handler ()
		{
			if (cb_setRetryPolicy_Lcom_mopub_volley_RetryPolicy_ == null)
				cb_setRetryPolicy_Lcom_mopub_volley_RetryPolicy_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetRetryPolicy_Lcom_mopub_volley_RetryPolicy_);
			return cb_setRetryPolicy_Lcom_mopub_volley_RetryPolicy_;
		}

		static IntPtr n_SetRetryPolicy_Lcom_mopub_volley_RetryPolicy_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Mopub.Volley.IRetryPolicy p0 = (global::Com.Mopub.Volley.IRetryPolicy)global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.IRetryPolicy> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetRetryPolicy (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setRetryPolicy_Lcom_mopub_volley_RetryPolicy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='setRetryPolicy' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.RetryPolicy']]"
		[Register ("setRetryPolicy", "(Lcom/mopub/volley/RetryPolicy;)Lcom/mopub/volley/Request;", "GetSetRetryPolicy_Lcom_mopub_volley_RetryPolicy_Handler")]
		public virtual unsafe global::Com.Mopub.Volley.Request SetRetryPolicy (global::Com.Mopub.Volley.IRetryPolicy p0)
		{
			if (id_setRetryPolicy_Lcom_mopub_volley_RetryPolicy_ == IntPtr.Zero)
				id_setRetryPolicy_Lcom_mopub_volley_RetryPolicy_ = JNIEnv.GetMethodID (class_ref, "setRetryPolicy", "(Lcom/mopub/volley/RetryPolicy;)Lcom/mopub/volley/Request;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Volley.Request __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallObjectMethod  (Handle, id_setRetryPolicy_Lcom_mopub_volley_RetryPolicy_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRetryPolicy", "(Lcom/mopub/volley/RetryPolicy;)Lcom/mopub/volley/Request;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setSequence_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='setSequence' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSequence", "(I)Lcom/mopub/volley/Request;", "")]
		public unsafe global::Com.Mopub.Volley.Request SetSequence (int p0)
		{
			if (id_setSequence_I == IntPtr.Zero)
				id_setSequence_I = JNIEnv.GetMethodID (class_ref, "setSequence", "(I)Lcom/mopub/volley/Request;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallObjectMethod  (Handle, id_setSequence_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setShouldCache_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='setShouldCache' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setShouldCache", "(Z)Lcom/mopub/volley/Request;", "")]
		public unsafe global::Com.Mopub.Volley.Request SetShouldCache (bool p0)
		{
			if (id_setShouldCache_Z == IntPtr.Zero)
				id_setShouldCache_Z = JNIEnv.GetMethodID (class_ref, "setShouldCache", "(Z)Lcom/mopub/volley/Request;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallObjectMethod  (Handle, id_setShouldCache_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTag_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetTag_Ljava_lang_Object_Handler ()
		{
			if (cb_setTag_Ljava_lang_Object_ == null)
				cb_setTag_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetTag_Ljava_lang_Object_);
			return cb_setTag_Ljava_lang_Object_;
		}

		static IntPtr n_SetTag_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetTag (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setTag_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='setTag' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setTag", "(Ljava/lang/Object;)Lcom/mopub/volley/Request;", "GetSetTag_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Mopub.Volley.Request SetTag (global::Java.Lang.Object p0)
		{
			if (id_setTag_Ljava_lang_Object_ == IntPtr.Zero)
				id_setTag_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "setTag", "(Ljava/lang/Object;)Lcom/mopub/volley/Request;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Mopub.Volley.Request __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallObjectMethod  (Handle, id_setTag_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTag", "(Ljava/lang/Object;)Lcom/mopub/volley/Request;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_shouldCache;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='shouldCache' and count(parameter)=0]"
		[Register ("shouldCache", "()Z", "")]
		public unsafe bool ShouldCache ()
		{
			if (id_shouldCache == IntPtr.Zero)
				id_shouldCache = JNIEnv.GetMethodID (class_ref, "shouldCache", "()Z");
			try {
				return JNIEnv.CallBooleanMethod  (Handle, id_shouldCache);
			} finally {
			}
		}

		static Delegate cb_compareTo_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Ljava_lang_Object_Handler ()
		{
			if (cb_compareTo_Ljava_lang_Object_ == null)
				cb_compareTo_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Ljava_lang_Object_);
			return cb_compareTo_Ljava_lang_Object_;
		}

		static int n_CompareTo_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_another)
		{
			global::Com.Mopub.Volley.Request __this = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Request> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object another = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_another, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (another);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='Java.Lang.Object']]"
		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public abstract global::System.Int32 CompareTo (global::Java.Lang.Object another);

	}

	[global::Android.Runtime.Register ("com/mopub/volley/Request", DoNotGenerateAcw=true)]
	internal partial class RequestInvoker : Request {

		public RequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestInvoker); }
		}

		static IntPtr id_deliverResponse_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='deliverResponse' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("deliverResponse", "(Ljava/lang/Object;)V", "GetDeliverResponse_Ljava_lang_Object_Handler")]
		protected override unsafe void DeliverResponse (global::Java.Lang.Object p0)
		{
			if (id_deliverResponse_Ljava_lang_Object_ == IntPtr.Zero)
				id_deliverResponse_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "deliverResponse", "(Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod  (Handle, id_deliverResponse_Ljava_lang_Object_, __args);
			} finally {
			}
		}

		static IntPtr id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='parseNetworkResponse' and count(parameter)=1 and parameter[1][@type='com.mopub.volley.NetworkResponse']]"
		[Register ("parseNetworkResponse", "(Lcom/mopub/volley/NetworkResponse;)Lcom/mopub/volley/Response;", "GetParseNetworkResponse_Lcom_mopub_volley_NetworkResponse_Handler")]
		protected override unsafe global::Com.Mopub.Volley.Response ParseNetworkResponse (global::Com.Mopub.Volley.NetworkResponse p0)
		{
			if (id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ == IntPtr.Zero)
				id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_ = JNIEnv.GetMethodID (class_ref, "parseNetworkResponse", "(Lcom/mopub/volley/NetworkResponse;)Lcom/mopub/volley/Response;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Mopub.Volley.Response __ret = global::Java.Lang.Object.GetObject<global::Com.Mopub.Volley.Response> (JNIEnv.CallObjectMethod  (Handle, id_parseNetworkResponse_Lcom_mopub_volley_NetworkResponse_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_compareTo_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.mopub.volley']/class[@name='Request']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='Java.Lang.Object']]"
		[Register ("compareTo", "(Ljava/lang/Object;)I", "GetCompareTo_Ljava_lang_Object_Handler")]
		public override unsafe global::System.Int32 CompareTo (global::Java.Lang.Object another)
		{
			if (id_compareTo_Ljava_lang_Object_ == IntPtr.Zero)
				id_compareTo_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Ljava/lang/Object;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (another);
				global::System.Int32 __ret = JNIEnv.CallIntMethod  (Handle, id_compareTo_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

	}

}
