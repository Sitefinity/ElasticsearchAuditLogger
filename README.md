# ElasticSearchAuditModule #
----------

[![Build Status](http://sdk-jenkins-ci.cloudapp.net/buildStatus/icon?job=Telerik.Sitefinity.ElasticSearchAuditLogger.CI)](http://sdk-jenkins-ci.cloudapp.net/job/Telerik.Sitefinity.ElasticSearchAuditLogger.CI/)

**ElasticSearchAuditModule** is a Sitefinity module used in conjunction with the [Audit Trail module](http://www.sitefinity.com/documentation/documentationarticles/audit-trail). When you activate both modules, the site administrator can monitor the actions performed by the users and also the system processes by using [Kibana](http://www.elasticsearch.org/overview/kibana/ "Kibana"). Actions are logged by *Type*, *Name*, *TimeStamp*, user performing the actions, user affected by the action, and others. 

Predefined dashboards
----------

Sitefinity has some predefined dashboards to help you start with the monitoring process. There are predefined dashboards for user permissions, content changes, and backend access. You can find the predefined dashboards in the *Dashboards* folder.

Requirements
----------

- Sitefinity 7.1 or later with valid license.
- .NET Framework 4.
- Visual Studio 2012 or later.
- Microsoft SQL Server 2008R2 or later.

### Prerequisites

Clear the NuGet cache files. To do this:

1. In Windows Explorer, open the **%localappdata%\NuGet\Cache** folder.
2. Select all files and delete them.


###Installation instructions

1. In GitHub, open the **ElasticsearchAuditLogger** repository.
Clone the repository on your desktop.

2. In Visual Studio, open the solution file you just downloaded and build the solution.

3. Open your project and copy the following .NET assemblies to the **bin** folder of your web application:
 * **Telerik.Sitefinity.Audit.Elasticsearch.dll**
 * **Nest.dll**
 * **Elasticsearch.Net.dll**


4. Build and run your Sitefinity application.

5. Navigate to *Administration* -> *Modules & Services*.

6. Browse to the **AuditTrail.ElasticSearch** module and install it.


Additional resources
------
The following YouTube video demonstrates the Audit Trail feature and its integration with Kibana and Elasticsearch:  
[![Sitefinity's Audit Trail module](https://raw.githubusercontent.com/Sitefinity/ElasticsearchAuditLogger/master/video.png?token=3206860__eyJzY29wZSI6IlJhd0Jsb2I6U2l0ZWZpbml0eS9FbGFzdGljc2VhcmNoQXVkaXRMb2dnZXIvbWFzdGVyL3ZpZGVvLnBuZyIsImV4cGlyZXMiOjE0MDU2OTAxNzZ9--b588ea9ea25b3f9e57c708d4409c2b6e6ecc9466)](https://www.youtube.com/watch?v=R6enydPS2tk)

