﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WarzoneConnect.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Link_TextResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Link_TextResource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WarzoneConnect.Properties.Link_TextResource", typeof(Link_TextResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 connect [ip地址] 连接指定ip地址的主机 的本地化字符串。
        /// </summary>
        internal static string Connect_Help {
            get {
                return ResourceManager.GetString("Connect_Help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} - 无法连接至{1} 的本地化字符串。
        /// </summary>
        internal static string ConnectionFailed {
            get {
                return ResourceManager.GetString("ConnectionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 dc 断开连接 的本地化字符串。
        /// </summary>
        internal static string Dc_Help {
            get {
                return ResourceManager.GetString("Dc_Help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} - 正在断开连接... 的本地化字符串。
        /// </summary>
        internal static string Disconnect {
            get {
                return ResourceManager.GetString("Disconnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 请输入{0}的密码: 的本地化字符串。
        /// </summary>
        internal static string InputPassword {
            get {
                return ResourceManager.GetString("InputPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This action shouldn`t be invoked 的本地化字符串。
        /// </summary>
        internal static string InvokeError {
            get {
                return ResourceManager.GetString("InvokeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 RemoteShell - 成功连接至{0}！ 的本地化字符串。
        /// </summary>
        internal static string RemoteShell_Connected {
            get {
                return ResourceManager.GetString("RemoteShell_Connected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 额外的远程桌面指令： 的本地化字符串。
        /// </summary>
        internal static string RemoteTerminal_ExtraExec {
            get {
                return ResourceManager.GetString("RemoteTerminal_ExtraExec", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 tf [旧文件] (可选)[新文件] 将指定文件传输回本机，若没有指定新文件目录，可执行文件将会放置于/bin，其他文件会放在/doc 的本地化字符串。
        /// </summary>
        internal static string Tf_Help {
            get {
                return ResourceManager.GetString("Tf_Help", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 远程连接密码错误！ 的本地化字符串。
        /// </summary>
        internal static string WrongPassword {
            get {
                return ResourceManager.GetString("WrongPassword", resourceCulture);
            }
        }
    }
}
