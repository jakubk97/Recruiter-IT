namespace Recruiter {
    using System;


    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class DBInfo {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DBInfo() {
        }

        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Quiz.Source.DataAccessLayer.DBInfo", typeof(DBInfo).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        internal static string database {
            get {
                return ResourceManager.GetString("database", resourceCulture);
            }
        }

        internal static string password {
            get {
                return ResourceManager.GetString("password", resourceCulture);
            }
        }

        internal static string port {
            get {
                return ResourceManager.GetString("port", resourceCulture);
            }
        }

        internal static string server {
            get {
                return ResourceManager.GetString("server", resourceCulture);
            }
        }
        internal static string user {
            get {
                return ResourceManager.GetString("user", resourceCulture);
            }
        }
    }
}
