# 	Configure ElasticSearch v1.2.1 and Kibana v3.1.0 #

## ##

## Prerequisites ##



- Download and install *****Java Development Kit*** (JDK):**
[http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html](http://www.oracle.com/technetwork/java/javase/downloads/jdk8-downloads-2133151.html)
- Set the ***Path Environment variable:***
[http://docs.oracle.com/javase/8/docs/technotes/guides/install/windows_jdk_install.html#CHDHHBDD](http://docs.oracle.com/javase/8/docs/technotes/guides/install/windows_jdk_install.html#CHDHHBDD)
[https://www.youtube.com/watch?v=yrRmLOcB9fg](https://www.youtube.com/watch?v=yrRmLOcB9fg)

##	ElasticSearch Setup and Configuration ##

1.  Download and extract ***Elasticsearch***, version 1.2.1 from [https://www.elastic.co/downloads/past-releases/elasticsearch-1-2-1](https://www.elastic.co/downloads/past-releases/elasticsearch-1-2-1).
In the steps to follow, *%ElasticsearchPath%* refers to the path where your Elasticsearch files reside.
1. If you want the server to be started on specific port you have to edit the *elasticsearch.yml* file located in *%ElasticsearchPath%**/config* folder.Uncomment and change the port from section *Set a custom port to listen for HTTP traffic:* to the port that you want to use. **Default is 9200.**
1. Start the ***Elasticsearch*** server, either as executable, or as a service:
	- To start ***Elasticsearch*** as an executable, run *%ElasticsearchPath%\bin\elasticsearch.bat*.
	Ensure that *%ElasticsearchPath%\bin\elasticsearch.bat* (*%ElasticsearchPath%/bin/elasticsearch* on Unix) is called on system startup.
	- To start ***Elasticsearch*** as a service, in *%ElasticsearchPath%\bin*, in a command prompt, perform the following:
		- Install the service by typing: *service install*
		- Start the service by typing:  *service start*
1. In Sitefinity's backend, navigate to *Administration » Settings » Advanced Settings » ElasticsearchAudit.*
1. In *ElasticsearchUri* field, enter the root URL of your Elasticsearch site.**Default is 9200.**

## Kibana Setup and Configuration ##

1. Download and extract ***Kibana*** from [https://www.elastic.co/downloads/past-releases/kibana-3-1-0](https://www.elastic.co/downloads/past-releases/kibana-3-1-0).
In the steps to follow, *%KibanaPath%* refers to the path where your Kibana files reside
2. Host the extracted folder on a web server that is accessible by the users entitled access to the audit log.*Tips for hosting on a server* - [https://technet.microsoft.com/en-us/library/cc772350(v=ws.10).aspx](https://technet.microsoft.com/en-us/library/cc772350(v=ws.10).aspx)
3. Open the *%KibanaPath%\config.js* file for editing.
Locate the *elasticsearch:* setting and set it to the root URL of your ***Elasticsearch*** server.**Default is 9200.**
#### Dashboard configuration ####
Kibana comes with a built-in default Sample Dashboard for displaying information and records. You can also load additional dashboard files for custom views, either from local files, or Gist storage on GitHub.

1. Open your ***Kibana*** site and from the top right side of the screen click *Load button* then move to *Advanced* and choose how to import the dashboard from this repository or from the files shared as Gist snippets:
	-  [BackendAccess dashboard](https://gist.github.com/anonymous/6ea0d190e50771266829)
	
    Use this view to display user login/logout actions in Sitefinity.


	- [Content dashboard](https://gist.github.com/anonymous/98f30017728ba5060c1c)
    
	Use this view to display changes of content items in Sitefinity.

   	
	- [UserUpdates dashboard](https://gist.github.com/anonymous/469c373754a7e314ac53)

    Use this view to display changes of users in Sitefinity.
1. Click on the *Configure Dashboard* button in top right side of the screen and select *Index* tab.
2. In the *Default Index* field type ***index*** and click *Save*
3. You can save your dashboard and the configuration for future use by clicking *Save* button


##Additional Resources##


The following **YouTube** video demonstrates the ***Audit Trail*** feature and its integration with ***Kibana*** and ***Elasticsearch***:[![Sitefinity's Audit Trail module](https://raw.githubusercontent.com/Sitefinity/ElasticsearchAuditLogger/master/video.png?token=3206860__eyJzY29wZSI6IlJhd0Jsb2I6U2l0ZWZpbml0eS9FbGFzdGljc2VhcmNoQXVkaXRMb2dnZXIvbWFzdGVyL3ZpZGVvLnBuZyIsImV4cGlyZXMiOjE0MDU2OTAxNzZ9--b588ea9ea25b3f9e57c708d4409c2b6e6ecc9466)](https://www.youtube.com/watch?v=R6enydPS2tk)

