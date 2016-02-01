using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Org.Nexage.Sourcekit.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='XmlTools']"
	[global::Android.Runtime.Register ("org/nexage/sourcekit/util/XmlTools", DoNotGenerateAcw=true)]
	public partial class XmlTools : global::Java.Lang.Object {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("org/nexage/sourcekit/util/XmlTools", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (XmlTools); }
		}

		protected XmlTools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='XmlTools']/constructor[@name='XmlTools' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XmlTools ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (XmlTools)) {
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

		static IntPtr id_getElementValue_Lorg_w3c_dom_Node_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='XmlTools']/method[@name='getElementValue' and count(parameter)=1 and parameter[1][@type='org.w3c.dom.Node']]"
		[Register ("getElementValue", "(Lorg/w3c/dom/Node;)Ljava/lang/String;", "")]
		public static unsafe string GetElementValue (global::Org.W3c.Dom.INode p0)
		{
			if (id_getElementValue_Lorg_w3c_dom_Node_ == IntPtr.Zero)
				id_getElementValue_Lorg_w3c_dom_Node_ = JNIEnv.GetStaticMethodID (class_ref, "getElementValue", "(Lorg/w3c/dom/Node;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getElementValue_Lorg_w3c_dom_Node_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_logXmlDocument_Lorg_w3c_dom_Document_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='XmlTools']/method[@name='logXmlDocument' and count(parameter)=1 and parameter[1][@type='org.w3c.dom.Document']]"
		[Register ("logXmlDocument", "(Lorg/w3c/dom/Document;)V", "")]
		public static unsafe void LogXmlDocument (global::Org.W3c.Dom.IDocument p0)
		{
			if (id_logXmlDocument_Lorg_w3c_dom_Document_ == IntPtr.Zero)
				id_logXmlDocument_Lorg_w3c_dom_Document_ = JNIEnv.GetStaticMethodID (class_ref, "logXmlDocument", "(Lorg/w3c/dom/Document;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_logXmlDocument_Lorg_w3c_dom_Document_, __args);
			} finally {
			}
		}

		static IntPtr id_stringFromStream_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='XmlTools']/method[@name='stringFromStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("stringFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string StringFromStream (global::System.IO.Stream p0)
		{
			if (id_stringFromStream_Ljava_io_InputStream_ == IntPtr.Zero)
				id_stringFromStream_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "stringFromStream", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_stringFromStream_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_stringToDocument_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='XmlTools']/method[@name='stringToDocument' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("stringToDocument", "(Ljava/lang/String;)Lorg/w3c/dom/Document;", "")]
		public static unsafe global::Org.W3c.Dom.IDocument StringToDocument (string p0)
		{
			if (id_stringToDocument_Ljava_lang_String_ == IntPtr.Zero)
				id_stringToDocument_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "stringToDocument", "(Ljava/lang/String;)Lorg/w3c/dom/Document;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Org.W3c.Dom.IDocument __ret = global::Java.Lang.Object.GetObject<global::Org.W3c.Dom.IDocument> (JNIEnv.CallStaticObjectMethod  (class_ref, id_stringToDocument_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_xmlDocumentToString_Lorg_w3c_dom_Document_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='XmlTools']/method[@name='xmlDocumentToString' and count(parameter)=1 and parameter[1][@type='org.w3c.dom.Document']]"
		[Register ("xmlDocumentToString", "(Lorg/w3c/dom/Document;)Ljava/lang/String;", "")]
		public static unsafe string XmlDocumentToString (global::Org.W3c.Dom.IDocument p0)
		{
			if (id_xmlDocumentToString_Lorg_w3c_dom_Document_ == IntPtr.Zero)
				id_xmlDocumentToString_Lorg_w3c_dom_Document_ = JNIEnv.GetStaticMethodID (class_ref, "xmlDocumentToString", "(Lorg/w3c/dom/Document;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_xmlDocumentToString_Lorg_w3c_dom_Document_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_xmlDocumentToString_Lorg_w3c_dom_Node_;
		// Metadata.xml XPath method reference: path="/api/package[@name='org.nexage.sourcekit.util']/class[@name='XmlTools']/method[@name='xmlDocumentToString' and count(parameter)=1 and parameter[1][@type='org.w3c.dom.Node']]"
		[Register ("xmlDocumentToString", "(Lorg/w3c/dom/Node;)Ljava/lang/String;", "")]
		public static unsafe string XmlDocumentToString (global::Org.W3c.Dom.INode p0)
		{
			if (id_xmlDocumentToString_Lorg_w3c_dom_Node_ == IntPtr.Zero)
				id_xmlDocumentToString_Lorg_w3c_dom_Node_ = JNIEnv.GetStaticMethodID (class_ref, "xmlDocumentToString", "(Lorg/w3c/dom/Node;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_xmlDocumentToString_Lorg_w3c_dom_Node_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
