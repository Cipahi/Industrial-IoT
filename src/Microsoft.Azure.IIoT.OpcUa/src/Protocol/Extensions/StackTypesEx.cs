// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Protocol {
    using Microsoft.Azure.IIoT.OpcUa.Registry.Models;
    using Microsoft.Azure.IIoT.OpcUa.Twin.Models;
    using UaApplicationType = Opc.Ua.ApplicationType;
    using UaSecurityMode = Opc.Ua.MessageSecurityMode;
    using UaBrowseDirection = Opc.Ua.BrowseDirection;
    using UaTokenType = Opc.Ua.UserTokenType;
    using UaNodeClass = Opc.Ua.NodeClass;
    using UaDiagnosticsLevel = Opc.Ua.DiagnosticsMasks;

    /// <summary>
    /// Stack types conversions
    /// </summary>
    public static class StackTypesEx {

        /// <summary>
        /// Convert node class
        /// </summary>
        /// <param name="nodeClass"></param>
        /// <returns></returns>
        public static NodeClass? ToServiceType(this UaNodeClass nodeClass) {
            switch (nodeClass) {
                case UaNodeClass.Object:
                    return NodeClass.Object;
                case UaNodeClass.ObjectType:
                    return NodeClass.ObjectType;
                case UaNodeClass.Variable:
                    return NodeClass.Variable;
                case UaNodeClass.VariableType:
                    return NodeClass.VariableType;
                case UaNodeClass.Method:
                    return NodeClass.Method;
                case UaNodeClass.DataType:
                    return NodeClass.DataType;
                case UaNodeClass.ReferenceType:
                    return NodeClass.ReferenceType;
                case UaNodeClass.View:
                    return NodeClass.View;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert node class
        /// </summary>
        /// <param name="nodeClass"></param>
        /// <returns></returns>
        public static UaNodeClass ToStackType(this NodeClass nodeClass) {
            switch (nodeClass) {
                case NodeClass.Object:
                    return UaNodeClass.Object;
                case NodeClass.ObjectType:
                    return UaNodeClass.ObjectType;
                case NodeClass.Variable:
                    return UaNodeClass.Variable;
                case NodeClass.VariableType:
                    return UaNodeClass.VariableType;
                case NodeClass.Method:
                    return UaNodeClass.Method;
                case NodeClass.DataType:
                    return UaNodeClass.DataType;
                case NodeClass.ReferenceType:
                    return UaNodeClass.ReferenceType;
                case NodeClass.View:
                    return UaNodeClass.View;
                default:
                    return UaNodeClass.Unspecified;
            }
        }

        /// <summary>
        /// Convert browse direction
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static BrowseDirection? ToServiceType(this UaBrowseDirection mode) {
            switch (mode) {
                case UaBrowseDirection.Forward:
                    return BrowseDirection.Forward;
                case UaBrowseDirection.Inverse:
                    return BrowseDirection.Backward;
                case UaBrowseDirection.Both:
                    return BrowseDirection.Both;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert browse direction
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static UaBrowseDirection ToStackType(this BrowseDirection mode) {
            switch (mode) {
                case BrowseDirection.Forward:
                    return UaBrowseDirection.Forward;
                case BrowseDirection.Backward:
                    return UaBrowseDirection.Inverse;
                case BrowseDirection.Both:
                    return UaBrowseDirection.Both;
                default:
                    return UaBrowseDirection.Forward;
            }
        }

        /// <summary>
        /// Convert security mode
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static SecurityMode? ToServiceType(this UaSecurityMode mode) {
            switch(mode) {
                case UaSecurityMode.None:
                    return SecurityMode.None;
                case UaSecurityMode.Sign:
                    return SecurityMode.Sign;
                case UaSecurityMode.SignAndEncrypt:
                    return SecurityMode.SignAndEncrypt;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert security mode
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public static UaSecurityMode ToStackType(this SecurityMode mode) {
            switch (mode) {
                case SecurityMode.Sign:
                    return UaSecurityMode.Sign;
                case SecurityMode.SignAndEncrypt:
                    return UaSecurityMode.SignAndEncrypt;
                default:
                    return UaSecurityMode.None;
            }
        }

        /// <summary>
        /// Convert token type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static TokenType? ToServiceType(this UaTokenType type) {
            switch (type) {
                case UaTokenType.Anonymous:
                    return TokenType.None;
                case UaTokenType.Certificate:
                    return TokenType.X509Certificate;
                case UaTokenType.UserName:
                case UaTokenType.IssuedToken:
                    return TokenType.UserNamePassword;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert application type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ApplicationType? ToServiceType(this UaApplicationType type) {
            switch (type) {
                case UaApplicationType.Client:
                    return ApplicationType.Client;
                case UaApplicationType.DiscoveryServer:
                    return ApplicationType.Server;
                case UaApplicationType.Server:
                    return ApplicationType.Server;
                case UaApplicationType.ClientAndServer:
                    return ApplicationType.ClientAndServer;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert application type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static UaApplicationType ToStackType(this ApplicationType type) {
            switch (type) {
                case ApplicationType.Client:
                    return UaApplicationType.Client;
                case ApplicationType.ClientAndServer:
                    return UaApplicationType.ClientAndServer;
                default:
                    return UaApplicationType.Server;
            }
        }

        /// <summary>
        /// Convert to diagnostics level
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public static DiagnosticsLevel ToServiceType(this UaDiagnosticsLevel level) {
            switch (level) {
                case UaDiagnosticsLevel.SymbolicIdAndText | UaDiagnosticsLevel.InnerDiagnostics:
                    return DiagnosticsLevel.Diagnostics;
                case UaDiagnosticsLevel.All:
                    return DiagnosticsLevel.Verbose;
                default:
                    return DiagnosticsLevel.None;
            }
        }

        /// <summary>
        /// Convert to diagnostics mask
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public static UaDiagnosticsLevel ToStackType(this DiagnosticsLevel level) {
            switch (level) {
                case DiagnosticsLevel.Diagnostics:
                    return UaDiagnosticsLevel.SymbolicIdAndText | UaDiagnosticsLevel.InnerDiagnostics;
                case DiagnosticsLevel.Verbose:
                    return UaDiagnosticsLevel.All;
                default:
                    return UaDiagnosticsLevel.None;
            }
        }
    }
}
