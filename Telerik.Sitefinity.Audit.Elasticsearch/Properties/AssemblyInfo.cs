using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Telerik.Sitefinity.Audit.Elasticsearch")]
[assembly: AssemblyDescription("ElasticSearchAuditModule is a Sitefinity module used in conjunction with the Audit Trail module(http://www.sitefinity.com/documentation/documentationarticles/audit-trail). When you activate both modules, the site administrator can monitor the actions performed by the users and also the system processes by using Kibana (http://www.elasticsearch.org/overview/kibana/). Actions are logged by Type, Name, TimeStamp, user performing the actions, user affected by the action, and others.")]
[assembly: AssemblyConfiguration("")]
[assembly: CLSCompliant(true)]

// Suppresses the CA1020:AvoidNamespacesWithFewTypes in the solution
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Telerik.Sitefinity.Audit.Elasticsearch", Justification = "Current implementation holds namespaces that contain fewer than five types.")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("0bf35578-c4de-4606-815e-8094c2c73703")]
