﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BaseRogue {
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
    public class GameResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal GameResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BaseRogue.GameResource", typeof(GameResource).Assembly);
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
        ///   Looks up a localized string similar to Resources have been all used up -  ships been abandoned!!!!.
        /// </summary>
        public static string GameLooseText {
            get {
                return ResourceManager.GetString("GameLooseText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You earned enought to retire thats it, put your feet up and relax - hard life earning a buck in the galaxy is over - you have won!!!.
        /// </summary>
        public static string GameWinText {
            get {
                return ResourceManager.GetString("GameWinText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To move the spaceship used W,A,S,D for directions. Click on a planet for details. When you arrive at a planet you will auto dock and if you want to pickup a job use the numbers [0-9] to select your job. Then head to the planet for the jobs destination. You can refuel by the [R] key and you can buy food using the [F] key..
        /// </summary>
        public static string HelpText {
            get {
                return ResourceManager.GetString("HelpText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Welcome to the galaxy, You are the captain of the dart - a small rugged spaceship. It&apos;s a  tough Galaxy to survivve in but there are good jobs and bad jobs and if you can pick up the right one - who knows you might just succeed. Of course the real money comes on the Big Jobs and these are the ones that will get you the glory but sometimes they don&apos;t end up so well but then... &quot;.cause sometimes &quot;you get that on these big jobs!!!&quot;. Travel to different planets to pickup jobs and collect money for the job. If y [rest of string was truncated]&quot;;.
        /// </summary>
        public static string IntroGameText {
            get {
                return ResourceManager.GetString("IntroGameText", resourceCulture);
            }
        }
    }
}
