﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models.Products.Resx {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Models.Products.Resx.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Product Name.
        /// </summary>
        public static string ProductModel_DisplayAttribute_Name {
            get {
                return ResourceManager.GetString("ProductModel_DisplayAttribute_Name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ProNum.
        /// </summary>
        public static string ProductModelCreateRequest_DisplayAttribute_ProductNumber {
            get {
                return ResourceManager.GetString("ProductModelCreateRequest_DisplayAttribute_ProductNumber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Standard Cost.
        /// </summary>
        public static string ProductModelCreateRequest_DisplayAttribute_StandardCost {
            get {
                return ResourceManager.GetString("ProductModelCreateRequest_DisplayAttribute_StandardCost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The standard cost - {0} - is too high for the product number - {1}. .
        /// </summary>
        public static string ProductModelCreateRequest_ValidationError_1 {
            get {
                return ResourceManager.GetString("ProductModelCreateRequest_ValidationError_1", resourceCulture);
            }
        }
    }
}
