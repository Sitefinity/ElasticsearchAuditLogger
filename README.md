# ElasticSearchAuditModule #
----------



**ElasticSearchAuditModule** is a Sitefinity module used in conjunction with the [Audit Trail module](http://www.sitefinity.com/documentation/documentationarticles/audit-trail). When you activate both modules, the site administrator can monitor the actions performed by the users and also the system processes by using [Kibana](http://www.elasticsearch.org/overview/kibana/ "Kibana"). Actions are logged by *Type*, *Name*, *TimeStamp*, user performing the actions, user affected by the action, and others.

#### The Audit Trail Elasticsearch module is included in Sitefinity CMS version 7.2 or later.

Predefined dashboards
----------

Sitefinity has some predefined dashboards to help you start with the monitoring process. There are predefined dashboards for user permissions, content changes, and backend access. You can find the predefined dashboards in the *Dashboards* folder.

Requirements
----------

- Sitefinity 10 or later with valid license
- .NET Framework 4.8
- Visual Studio 2017 or later.
- Microsoft SQL Server 2012 or later.
- The following tested combinations of versions of **ElasticSearch** and **Kibana**:
	- ***ElasticSearch 7.5.1*** and ***Kibana 7.5.1***

### Installation instructions

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

### ElasticSearch and Kibana installation and configuration  ###
- [ElasticSearch 7.5.1 and Kibana 7.5.1](ElasticSearch7.5.1AndKibana7.5.1.md)

Contributing
------

We'd love to get contributions from you! Take a look at the
[Contribution Documents](CONTRIBUTING.md) to see how to get your changes merged
in.
