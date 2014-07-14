# ElasticSearchAuditModule #
----------

ElasticSearchAuditModule is a module for Sitefinity CMS that is used in conjunction with Audit Trail module. When both modules are activated it allows an administrator to monitor the actions performed by the various users and processes of the system through [Kibana](http://www.elasticsearch.org/overview/kibana/ "Kibana"). Actions are logged by Type, Name, TimeStamp, user performing the actions, user affected by the action and others. 

Predefined dashboards
----------

There are some predefined dashboards to help you start with the monitoring process. There is a predefined dashboards for user permissions, content changes and backend access. You could find them in the Dashboards folder.

Requirements
----------

- Sitefinity 7.1 or later with valid license.
- .NET Framework 4
- Visual Studio 2012 or later.
- Microsoft SQL Server 2008R2 or later.

### Prerequisites

Clear the NuGet cache files. To do this:

1. In Windows Explorer, open the **%localappdata%\NuGet\Cache** folder.
2. Select all files and delete them.


###Installation instructions

1. Open the ElasticsearchAuditLogger repository from GitHub and clone the repository in your desktop.

2. Open your solution in Visual Studio and build the solution.

3. Open your project and copy the Telerik.Sitefinity.Audit.Elasticsearch.dll to the bin folder of your web application.

4. Build and run your Sitefinity application.

5. Go to Administration -> Modules & Services

6. Find the AuditTrail.ElasticSearch module and install it.


Additional resources
------
The following youtube video demonstrates the Audit Trail feature and its integration with Kibana and Elasticsearch.  
[![Sitefinity's Audit Trail module](https://raw.githubusercontent.com/Sitefinity/ElasticsearchAuditLogger/master/video.png?token=3206860__eyJzY29wZSI6IlJhd0Jsb2I6U2l0ZWZpbml0eS9FbGFzdGljc2VhcmNoQXVkaXRMb2dnZXIvbWFzdGVyL3ZpZGVvLnBuZyIsImV4cGlyZXMiOjE0MDU2OTAxNzZ9--b588ea9ea25b3f9e57c708d4409c2b6e6ecc9466)](https://www.youtube.com/watch?v=R6enydPS2tk)

Further questions
----------
If you have any other questions regarding this module you could contact our support team.
