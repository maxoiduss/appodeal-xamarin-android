using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Mopub.Volley {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkResponse']"
	[global::Android.Runtime.Register ("com/mopub/volley/NetworkResponse", DoNotGenerateAcw=true)]
	public partial class NetworkResponse : global::Java.Lang.Object {


		static IntPtr data_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkResponse']/field[@name='data']"
		[Register ("data")]
		public IList<byte> Data {
			get {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, data_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (data_jfieldId == IntPtr.Zero)
					data_jfieldId = JNIEnv.GetFieldID (class_ref, "data", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, data_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr headers_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkResponse']/field[@name='headers']"
		[Register ("headers")]
		public global::System.Collections.IDictionary Headers {
			get {
				if (headers_jfieldId == IntPtr.Zero)
					headers_jfieldId = JNIEnv.GetFieldID (class_ref, "headers", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, headers_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (headers_jfieldId == IntPtr.Zero)
					headers_jfieldId = JNIEnv.GetFieldID (class_ref, "headers", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (Handle, headers_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr networkTimeMs_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkResponse']/field[@name='networkTimeMs']"
		[Register ("networkTimeMs")]
		public long NetworkTimeMs {
			get {
				if (networkTimeMs_jfieldId == IntPtr.Zero)
					networkTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "networkTimeMs", "J");
				return JNIEnv.GetLongField (Handle, networkTimeMs_jfieldId);
			}
			set {
				if (networkTimeMs_jfieldId == IntPtr.Zero)
					networkTimeMs_jfieldId = JNIEnv.GetFieldID (class_ref, "networkTimeMs", "J");
				try {
					JNIEnv.SetField (Handle, networkTimeMs_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr notModified_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkResponse']/field[@name='notModified']"
		[Register ("notModified")]
		public bool NotModified {
			get {
				if (notModified_jfieldId == IntPtr.Zero)
					notModified_jfieldId = JNIEnv.GetFieldID (class_ref, "notModified", "Z");
				return JNIEnv.GetBooleanField (Handle, notModified_jfieldId);
			}
			set {
				if (notModified_jfieldId == IntPtr.Zero)
					notModified_jfieldId = JNIEnv.GetFieldID (class_ref, "notModified", "Z");
				try {
					JNIEnv.SetField (Handle, notModified_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr statusCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkResponse']/field[@name='statusCode']"
		[Register ("statusCode")]
		public int StatusCode {
			get {
				if (statusCode_jfieldId == IntPtr.Zero)
					statusCode_jfieldId = JNIEnv.GetFieldID (class_ref, "statusCode", "I");
				return JNIEnv.GetIntField (Handle, statusCode_jfieldId);
			}
			set {
				if (statusCode_jfieldId == IntPtr.Zero)
					statusCode_jfieldId = JNIEnv.GetFieldID (class_ref, "statusCode", "I");
				try {
					JNIEnv.SetField (Handle, statusCode_jfieldId, value);
				} finally {
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/mopub/volley/NetworkResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NetworkResponse); }
		}

		protected NetworkResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_arrayBLjava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkResponse']/constructor[@name='NetworkResponse' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.Map']]"
		[Register (".ctor", "([BLjava/util/Map;)V", "")]
		public unsafe NetworkResponse (byte[] p0, global::System.Collections.IDictionary p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (GetType () != typeof (NetworkResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([BLjava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([BLjava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_arrayBLjava_util_Map_ == IntPtr.Zero)
					id_ctor_arrayBLjava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "([BLjava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBLjava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayBLjava_util_Map_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_arrayB;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkResponse']/constructor[@name='NetworkResponse' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register (".ctor", "([B)V", "")]
		public unsafe NetworkResponse (byte[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (NetworkResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "([B)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "([B)V", __args);
					return;
				}

				if (id_ctor_arrayB == IntPtr.Zero)
					id_ctor_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([B)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayB, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_arrayB, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_ctor_IarrayBLjava_util_Map_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkResponse']/constructor[@name='NetworkResponse' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='boolean']]"
		[Register (".ctor", "(I[BLjava/util/Map;Z)V", "")]
		public unsafe NetworkResponse (int p0, byte[] p1, global::System.Collections.IDictionary p2, bool p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				if (GetType () != typeof (NetworkResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I[BLjava/util/Map;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I[BLjava/util/Map;Z)V", __args);
					return;
				}

				if (id_ctor_IarrayBLjava_util_Map_Z == IntPtr.Zero)
					id_ctor_IarrayBLjava_util_Map_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(I[BLjava/util/Map;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayBLjava_util_Map_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IarrayBLjava_util_Map_Z, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_ctor_IarrayBLjava_util_Map_ZJ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.mopub.volley']/class[@name='NetworkResponse']/constructor[@name='NetworkResponse' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.Map'] and parameter[4][@type='boolean'] and parameter[5][@type='long']]"
		[Register (".ctor", "(I[BLjava/util/Map;ZJ)V", "")]
		public unsafe NetworkResponse (int p0, byte[] p1, global::System.Collections.IDictionary p2, bool p3, long p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (GetType () != typeof (NetworkResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(I[BLjava/util/Map;ZJ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(I[BLjava/util/Map;ZJ)V", __args);
					return;
				}

				if (id_ctor_IarrayBLjava_util_Map_ZJ == IntPtr.Zero)
					id_ctor_IarrayBLjava_util_Map_ZJ = JNIEnv.GetMethodID (class_ref, "<init>", "(I[BLjava/util/Map;ZJ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_IarrayBLjava_util_Map_ZJ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_IarrayBLjava_util_Map_ZJ, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
