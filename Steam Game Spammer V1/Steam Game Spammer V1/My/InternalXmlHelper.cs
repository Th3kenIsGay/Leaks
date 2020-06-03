using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Steam_Game_Spammer_0._1.My
{
	// Token: 0x02000008 RID: 8
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal sealed class InternalXmlHelper
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000020D5 File Offset: 0x000002D5
		[EditorBrowsable(EditorBrowsableState.Never)]
		private InternalXmlHelper()
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000027B8 File Offset: 0x000009B8
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000280C File Offset: 0x00000A0C
		public static string Value
		{
			get
			{
				try
				{
					IEnumerator<XElement> enumerator = source.GetEnumerator();
					if (enumerator.MoveNext())
					{
						XElement xelement = enumerator.Current;
						return xelement.Value;
					}
				}
				finally
				{
					IEnumerator<XElement> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				return null;
			}
			set
			{
				try
				{
					IEnumerator<XElement> enumerator = source.GetEnumerator();
					if (enumerator.MoveNext())
					{
						XElement xelement = enumerator.Current;
						xelement.Value = value;
					}
				}
				finally
				{
					IEnumerator<XElement> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000285C File Offset: 0x00000A5C
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000028B4 File Offset: 0x00000AB4
		public static string AttributeValue
		{
			get
			{
				try
				{
					IEnumerator<XElement> enumerator = source.GetEnumerator();
					if (enumerator.MoveNext())
					{
						XElement xelement = enumerator.Current;
						return (string)xelement.Attribute(name);
					}
				}
				finally
				{
					IEnumerator<XElement> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
				return null;
			}
			set
			{
				try
				{
					IEnumerator<XElement> enumerator = source.GetEnumerator();
					if (enumerator.MoveNext())
					{
						XElement xelement = enumerator.Current;
						xelement.SetAttributeValue(name, value);
					}
				}
				finally
				{
					IEnumerator<XElement> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002904 File Offset: 0x00000B04
		// (set) Token: 0x06000027 RID: 39 RVA: 0x000020DD File Offset: 0x000002DD
		public static string AttributeValue
		{
			get
			{
				return (string)source.Attribute(name);
			}
			set
			{
				source.SetAttributeValue(name, value);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002920 File Offset: 0x00000B20
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XAttribute CreateAttribute(XName name, object value)
		{
			XAttribute result;
			if (value == null)
			{
				result = null;
			}
			else
			{
				result = new XAttribute(name, RuntimeHelpers.GetObjectValue(value));
			}
			return result;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002948 File Offset: 0x00000B48
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XAttribute CreateNamespaceAttribute(XName name, XNamespace ns)
		{
			XAttribute xattribute = new XAttribute(name, ns.NamespaceName);
			xattribute.AddAnnotation(ns);
			return xattribute;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000296C File Offset: 0x00000B6C
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static object RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, object obj)
		{
			if (obj != null)
			{
				XElement xelement = obj as XElement;
				if (xelement != null)
				{
					return InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, xelement);
				}
				IEnumerable enumerable = obj as IEnumerable;
				if (enumerable != null)
				{
					return InternalXmlHelper.RemoveNamespaceAttributes(inScopePrefixes, inScopeNs, attributes, enumerable);
				}
			}
			return obj;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000029C0 File Offset: 0x00000BC0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IEnumerable RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, IEnumerable obj)
		{
			IEnumerable result;
			if (obj != null)
			{
				IEnumerable<XElement> enumerable = obj as IEnumerable<XElement>;
				if (enumerable != null)
				{
					result = enumerable.Select(new Func<XElement, XElement>(new InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessXElement));
				}
				else
				{
					result = obj.Cast<object>().Select(new Func<object, object>(new InternalXmlHelper.RemoveNamespaceAttributesClosure(inScopePrefixes, inScopeNs, attributes).ProcessObject));
				}
			}
			else
			{
				result = obj;
			}
			return result;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002A28 File Offset: 0x00000C28
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static XElement RemoveNamespaceAttributes(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes, XElement e)
		{
			checked
			{
				if (e != null)
				{
					XAttribute nextAttribute;
					for (XAttribute xattribute = e.FirstAttribute; xattribute != null; xattribute = nextAttribute)
					{
						nextAttribute = xattribute.NextAttribute;
						if (xattribute.IsNamespaceDeclaration)
						{
							XNamespace xnamespace = xattribute.Annotation<XNamespace>();
							string localName = xattribute.Name.LocalName;
							if (xnamespace != null)
							{
								if (inScopePrefixes != null && inScopeNs != null)
								{
									int num = inScopePrefixes.Length - 1;
									int num2 = 0;
									int num3 = num;
									int num4 = num2;
									XNamespace right;
									for (;;)
									{
										int num5 = num4;
										int num6 = num3;
										if (num5 > num6)
										{
											goto Block_8;
										}
										string value = inScopePrefixes[num4];
										right = inScopeNs[num4];
										if (localName.Equals(value))
										{
											break;
										}
										num4++;
									}
									if (xnamespace == right)
									{
										xattribute.Remove();
									}
									xattribute = null;
									Block_8:;
								}
								if (xattribute != null)
								{
									if (attributes != null)
									{
										int num7 = attributes.Count - 1;
										int num8 = 0;
										int num9 = num7;
										int num10 = num8;
										XNamespace xnamespace2;
										for (;;)
										{
											int num11 = num10;
											int num6 = num9;
											if (num11 > num6)
											{
												goto Block_13;
											}
											XAttribute xattribute2 = attributes[num10];
											string localName2 = xattribute2.Name.LocalName;
											xnamespace2 = xattribute2.Annotation<XNamespace>();
											if (xnamespace2 != null && localName.Equals(localName2))
											{
												break;
											}
											num10++;
										}
										if (xnamespace == xnamespace2)
										{
											xattribute.Remove();
										}
										xattribute = null;
										Block_13:;
									}
									if (xattribute != null)
									{
										xattribute.Remove();
										attributes.Add(xattribute);
									}
								}
							}
						}
					}
				}
				return e;
			}
		}

		// Token: 0x02000009 RID: 9
		[CompilerGenerated]
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		private sealed class RemoveNamespaceAttributesClosure
		{
			// Token: 0x0600002D RID: 45 RVA: 0x000020E7 File Offset: 0x000002E7
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal RemoveNamespaceAttributesClosure(string[] inScopePrefixes, XNamespace[] inScopeNs, List<XAttribute> attributes)
			{
				this.m_inScopePrefixes = inScopePrefixes;
				this.m_inScopeNs = inScopeNs;
				this.m_attributes = attributes;
			}

			// Token: 0x0600002E RID: 46 RVA: 0x00002B80 File Offset: 0x00000D80
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal XElement ProcessXElement(XElement elem)
			{
				return InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, elem);
			}

			// Token: 0x0600002F RID: 47 RVA: 0x00002BA8 File Offset: 0x00000DA8
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal object ProcessObject(object obj)
			{
				XElement xelement = obj as XElement;
				object result;
				if (xelement != null)
				{
					result = InternalXmlHelper.RemoveNamespaceAttributes(this.m_inScopePrefixes, this.m_inScopeNs, this.m_attributes, xelement);
				}
				else
				{
					result = obj;
				}
				return result;
			}

			// Token: 0x0400000B RID: 11
			private readonly string[] m_inScopePrefixes;

			// Token: 0x0400000C RID: 12
			private readonly XNamespace[] m_inScopeNs;

			// Token: 0x0400000D RID: 13
			private readonly List<XAttribute> m_attributes;
		}
	}
}
